using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace LogMonitor
{
    public partial class Main : Form
    {

        DataTable dtMSATable = new DataTable();
        DataTable dtResponseValues = new DataTable();
        Dictionary<int, TestResult> Results = new Dictionary<int, TestResult>();
        string[] saResponseNames;
        string[] saLowerLimits;
        string[] saUpperLimits;
        string[] saUnits;

        string[] filePathsFromDrop;

        ProductStation productStation = new ProductStation();
        

        public Main()
        {
            InitializeComponent();

            toolStripComboBox_ProjectStationSelection.Items.AddRange(ProductStation.CollectSupportedStations());
            toolStripComboBox_ProjectStationSelection.SelectedIndex = 0;

            MakeDataTable();
        }

        private void Main_DragEnter(object sender, DragEventArgs e)
        {
            tbUserFeedback.Text = "Drag Event Detected. Drop Folder Anywhere";
            e.Effect = DragDropEffects.All;
            ResetAll();
        }

        private void Main_DragDrop(object sender, DragEventArgs e)
        {
            tbUserFeedback.Text = "Searching log files for test data..." + Environment.NewLine + "This may take a while...";
            filePathsFromDrop = (string[])e.Data.GetData("FileDrop");

            if (filePathsFromDrop[0].Contains(".csv"))//File Dropped instead of folder
            {
                GetValidationResults(filePathsFromDrop[0],false);
                tbUserFeedback.Text = string.Format("Find {0} measurements.", Results.Count);
            }
            else //Drop the folder.
            {
                ResetAll();
            }
        }

        private void ResetAll()
        {
            Results.Clear();

        }

        private void GetValidationResults(string spath,bool bIgnoreResponseNames)
        {
            string[] sRows = System.IO.File.ReadAllLines(spath);
            try
            {
                saResponseNames = sRows[0].Split(',');
                if (this.productStation.station.ToString().Contains("Bebop"))
                {
                    saUpperLimits = sRows[1].Split(',');
                    saLowerLimits = sRows[2].Split(',');
                }
                else
                {
                    saLowerLimits = sRows[1].Split(',');
                    saUpperLimits = sRows[2].Split(',');
                }
                saUnits = sRows[3].Split(',');

                int iFirstMeasurementIndex = 0;
                int iTSRIDIndex = 0;
                int iStationIDIndex = 0;
                int iPositionIndex = 0;
                int iSerialNumberIndex = 0;
                int iTestSuiteIndex = 0;
                int iTesterNameIndex = 0;
                int iOperatorIDIndex = 0;
                int iLineIDIndex = 0;

                // Dedicate for the logs don't have TSRID.
                int iEndDateIndex = 0;
                int iEndTimeIndex = 0;

                iSerialNumberIndex = Array.FindIndex(saResponseNames, res => res == this.productStation.sSerialNumberKeyword);
                iTesterNameIndex = Array.FindIndex(saResponseNames, res => res == this.productStation.sTesterNameKeyword);
                iStationIDIndex = Array.FindIndex(saResponseNames, res => res == this.productStation.sStationIDKeyword);
                iLineIDIndex = Array.FindIndex(saResponseNames, res => res == this.productStation.sLineIDKeyword);
                iPositionIndex = Array.FindIndex(saResponseNames, res => res == this.productStation.sPositionIDKeyword);
                iTestSuiteIndex = Array.FindIndex(saResponseNames, res => res == this.productStation.sTestSuiteVersionKeyword);
                iOperatorIDIndex = Array.FindIndex(saResponseNames, res => res == this.productStation.sOperatorIDKeyword);
                iFirstMeasurementIndex = Array.FindIndex(saResponseNames, res => res == this.productStation.sFirstMeasurementName);

                if (this.productStation.station.ToString().Contains("Bebop"))
                {
                    iTSRIDIndex = Array.FindIndex(saResponseNames, res => res == this.productStation.sTestSuiteRunIDKeyword);
                }
                else
                {
                    iEndDateIndex = Array.FindIndex(saResponseNames, res => res == "end_date");
                    iEndTimeIndex = Array.FindIndex(saResponseNames, res => res == "end_time");
                }

                for (int index = iFirstMeasurementIndex;index< saResponseNames.Length;index++)
                {
                    TestResult testResult = new TestResult();
                    testResult.VariationName = saResponseNames[index];

                    double dLow, dUp;
                    if(!double.TryParse(saUpperLimits[index],out dUp))
                    {
                        dUp = double.NaN;
                        testResult.UpperLimitInfinit = true;
                    }
                    else
                    {
                        testResult.UpperLimitInfinit = false;
                    }

                    if(!double.TryParse(saLowerLimits[index],out dLow))
                    {
                        dLow = double.NaN;
                        testResult.LowerLimitInfinit = true;
                    }
                    else
                    {
                        testResult.LowerLimitInfinit = false;
                    }

                    testResult.LowerLimit = dLow;
                    testResult.UpperLimit = dUp;

                    testResult.Unit = saUnits[index];
                    testResult.type = TestResult.ResultType.Null;

                    Results.Add(index, testResult);
                }

                for (int rownum = 4; rownum < sRows.Length; rownum++)
                {
                    string[] saResponseValues = sRows[rownum].Split(',');
                    TestResult.ResultType rt;
                    for (int resnum = iFirstMeasurementIndex; resnum < saResponseValues.Length; resnum++)
                    {
                        string sResult = saResponseValues[resnum];
                        if (sResult == "")
                        {
                            //continue;
                            Results[resnum].AddValue(double.NaN);
                            rt = TestResult.ResultType.Null;
                        }
                        else
                        {
                            if (sResult.StartsWith("0x"))
                            {
                                Results[resnum].AddValue(Convert.ToDouble(int.Parse(sResult.Remove(0, 2), System.Globalization.NumberStyles.HexNumber)));
                                rt = TestResult.ResultType.Hex;
                            }
                            else
                            {
                                double dTemp;
                                if (double.TryParse(sResult, out dTemp))
                                {
                                    Results[resnum].AddValue(dTemp);
                                    rt = TestResult.ResultType.Continous;
                                }
                                else
                                {
                                    Results[resnum].AddValue(double.NaN);
                                    rt = TestResult.ResultType.String;
                                }
                            }
                            Results[resnum].type = rt;
                        }
                        string sTSRID;
                        if(this.productStation.station.ToString().Contains("Bebop"))
                        {
                            sTSRID = saResponseValues[iTSRIDIndex];
                        }
                        else
                        {
                            sTSRID = saResponseValues[iEndDateIndex].Replace("//", "") + saResponseValues[iEndTimeIndex].Replace(":", "");
                        }

                        Results[resnum].AddValueWithDetails(sResult, saResponseValues[iSerialNumberIndex], saResponseValues[iTesterNameIndex],
                                    saResponseValues[iOperatorIDIndex], saResponseValues[iLineIDIndex],
                                    saResponseValues[iPositionIndex], sTSRID, saResponseValues[iTestSuiteIndex],rt);
                    }
                }

                foreach (var v in Results)
                {
                    if(v.Value.type==TestResult.ResultType.Continous)
                    {
                        Results[v.Key].CrunchStatData();
                    }
                }

                lbResponseNames.Items.Clear();
                foreach(var v in Results)
                {
                    lbResponseNames.Items.Add(v.Value.VariationName);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace);
            }
        }

        private void lbResponseNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayResponseInfo();
        }

        private void DisplayResponseInfo()
        {
            dgvResponseValues.Hide();
            dgvResponseValues.ClearSelection();
            ShowImmediateData();
            dgvResponseValues.FirstDisplayedScrollingRowIndex = 0;
            dgvResponseValues.Show();
        }

        /// <summary>
        /// Shows test result data
        /// </summary>
        private void ShowImmediateData()
        {
            try
            {
                ClearTextBoxes();
                if (lbResponseNames.Items.Count > 0)
                {
                    ShowSingleResult();
                }
            }
            catch
            {
            }
        }

        private void ClearTextBoxes()
        {
            this.tbResponseName.Text = "";
            this.tbUnit.Text = "";
            this.tbLimitMatch.Text = "";
            this.tbMax.Text = "";
            this.tbMin.Text = "";
            this.tbMaxMin.Text = "";
            this.tbUpperLimit.Text = "";
            this.tbLowerLimit.Text = "";
            this.tbAverage.Text = "";
            this.tbCpk.Text = "";
            this.tbStandardDeviation.Text = "";
            this.tbTestCount.Text = "";
            this.tbFailureCount.Text = "";
            this.tbPassRate.Text = "";
        }

        /// <summary>
        /// Displays result data of 1 test in data section
        /// </summary>
        private void ShowSingleResult()
        {
            try
            {
                if (lbResponseNames.SelectedItem != null)
                {
                    var rResponseName = lbResponseNames.SelectedItem.ToString();
                    int iResponseIndex = 0;
                    foreach (var v in Results)
                    {
                        if (v.Value.VariationName == rResponseName)
                        {
                            iResponseIndex = v.Key;
                        }
                        else
                        {
                            continue;
                        }
                    }
                    dgvResponseValues.Visible = false;
                    UpdateStatData(iResponseIndex);
                    dtResponseValues.Clear();

                    var qryRes = from p in Results[iResponseIndex].DiResponseDetails
                                 select new
                                 {
                                     Value = p.Value.value,
                                     Serial = p.Value.serialNumber,
                                     TesterName = p.Value.testerName,
                                     Position = p.Value.positionName,
                                     ID = p.Key,
                                     ResultType = p.Value.Type,
                                     };

                    //dgvResponseValues.Columns["Time"].DefaultCellStyle.Format = "MM/dd/yyyy HH:mm:ss";

                    foreach (var item in qryRes)
                    {
                        var row = dtResponseValues.NewRow();
                        if ((item.ResultType != TestResult.ResultType.Null)&&(item.ResultType != TestResult.ResultType.String))
                        {
                            if (item.ResultType == TestResult.ResultType.Continous)
                            {
                                row[0] = Convert.ToDouble(item.Value);
                            }
                            else
                            {
                                if (item.ResultType == TestResult.ResultType.Hex)
                                {
                                    row[0] =(double)(int.Parse(item.Value.Replace("0x", ""), System.Globalization.NumberStyles.HexNumber));
                                }
                            }

                            row[1] = item.Serial;
                            row[2] = item.TesterName;
                            row[3] = item.Position;
                            row[4] = item.ID;
                            dtResponseValues.Rows.Add(row);
                        }
                    }

                    dgvResponseValues.Visible = true;
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.StackTrace+Environment.NewLine+ex.Message);
            }
        }

        private void MakeDataTable()
        {
            dtResponseValues = new DataTable();
            dtResponseValues.Columns.Add("Value");
            dtResponseValues.Columns.Add("Serial");
            dtResponseValues.Columns.Add("TesterName");
            dtResponseValues.Columns.Add("Positions");
            dtResponseValues.Columns.Add("ID");
            dtResponseValues.Columns["Value"].DataType = typeof(double);
            dgvResponseValues.DataSource = dtResponseValues;
        }

        private void UpdateStatData(int rKey)
        {
            if (Results[rKey].type == TestResult.ResultType.Continous)
            {
                tbResponseName.Text = Results[rKey].VariationName;
                tbUnit.Text = Results[rKey].Unit;
                tbMin.BackColor = (Results[rKey].Min < Results[rKey].LowerLimit && Results[rKey].LowerLimit != double.MinValue) ? Color.IndianRed : Color.White;
                tbMax.BackColor = (Results[rKey].Max > Results[rKey].UpperLimit && Results[rKey].UpperLimit != double.MaxValue) ? Color.IndianRed : Color.White;
                tbAverage.BackColor = Results[rKey].avgModified ? Color.IndianRed : Color.White;
                tbStandardDeviation.BackColor = Results[rKey].stdDevModified ? Color.IndianRed : Color.White;
                tbLowerLimit.Text = (Results[rKey].LowerLimit == double.MinValue) ? "Infinity" : Results[rKey].LowerLimit.ToString();
                tbUpperLimit.Text = (Results[rKey].UpperLimit == double.MaxValue) ? "Infinity" : Results[rKey].UpperLimit.ToString();
                tbLimitMatch.Text = (!Results[rKey].limitsMixed).ToString();
                tbLimitMatch.BackColor = (Results[rKey].limitsMixed) ? Color.OrangeRed : Color.White;
                tbMax.Text = Results[rKey].Max.ToString("0.00");
                tbMin.Text = Results[rKey].Min.ToString("0.00");
                tbMaxMin.Text = Results[rKey].MaxMinusMin.ToString("0.00");
                tbAverage.Text = Results[rKey].Average.ToString("0.00");
                tbStandardDeviation.Text = Results[rKey].StandardDeviation.ToString("0.00");
                //tbRepeatability.Text = CalculateRepeatability().ToString("0.000");//
                tbCpk.Text = (Results[rKey].CPK == 0) ? "NA" : Results[rKey].CPK.ToString("0.00");
                tbTestCount.Text = (Results[rKey].DiResponseDetails.Count + Results[rKey].Exceptions.Count).ToString();
                tbFailureCount.Text = Results[rKey].FailCount.ToString();
                tbFailureCount.BackColor = (Results[rKey].FailCount > 0) ? Color.IndianRed : Color.White;
                tbPassRate.Text = Results[rKey].PassRate.ToString("0.0%");
            }
        }

        private void exportMSATableToCsvFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Results.Count>0)
            {
                ExportMSAData(true, true);
            }
        }

        private void ExportMSAData(bool bIgnoreFailures, bool bIgnoreItemsWithoutLimit)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save an csv File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                StringBuilder csv = new StringBuilder();
                string title = string.Format("{0},{1},{2},{3},{4},{5},{6}", "MeasurementName", "SerialNumber", "TesterName", "TSRID", "_LSL", "_USL", "Value");
                csv.AppendLine(title);

                foreach (var measurement in Results)
                {
                    if (measurement.Value.type != TestResult.ResultType.Continous)
                    {
                        continue;
                    }
                    else
                    {
                        if ((measurement.Value.UpperLimitInfinit == true) && (measurement.Value.LowerLimitInfinit == true) && (bIgnoreItemsWithoutLimit))
                        {
                            continue;
                        }
                        else
                        {
                            foreach (var v in measurement.Value.DiResponseDetails)
                            {
                                string line = string.Format("{0},{1},{2}-{3},{4},{5},{6},{7}", measurement.Value.VariationName, v.Value.serialNumber, v.Value.testerName, v.Value.positionName, v.Value.tsr, measurement.Value.LowerLimit, measurement.Value.UpperLimit, v.Value.value);
                                csv.AppendLine(line);
                            }
                        }
                    }
                }
                File.WriteAllText(saveFileDialog1.FileName, csv.ToString());

            }
            MessageBox.Show("Export the MSA table successfully.");
        }

        //private double CalculateRepeatability()
        //{
        //    try
        //    {

        //        if (lbResponseNames.SelectedItem != null)
        //        {
        //            string responseName = lbResponseNames.SelectedItem.ToString();
        //            var diValues = new Dictionary<string, Dictionary<string, List<double>>>();
        //            var diVariances = new Dictionary<string, Dictionary<string, double>>();
        //            var diAvgVariances = new Dictionary<string, double>();

        //            foreach (var apraiser in testers)
        //            {
        //                var tempDi = new Dictionary<string, List<double>>();
        //                var tempDi2 = new Dictionary<string, double>();

        //                foreach (var sn in serialNumbers)
        //                {
        //                    tempDi.Add(sn, new List<double>());
        //                    tempDi2.Add(sn, 0);
        //                }
        //                diValues.Add(apraiser, tempDi);
        //                diVariances.Add(apraiser, tempDi2);

        //            }

        //            foreach (var res in Results[responseName].DiResponseDetails)
        //            {
        //                diValues[res.Value.testerName][res.Value.serialNumber].Add(res.Value.value);
        //            }

        //            foreach (var tester in diValues)
        //            {
        //                foreach (var sn in tester.Value)
        //                {
        //                    diVariances[tester.Key][sn.Key] = Math.Pow(this.CalculateStdDev(sn.Value), 2);
        //                }
        //            }

        //            foreach (var tester in diVariances)
        //            {
        //                diAvgVariances.Add(tester.Key, tester.Value.Average(a => a.Value));
        //            }

        //            double variance = diAvgVariances.Average(a => a.Value);
        //            double sqrtVariance = Math.Sqrt(variance);
        //            double CI99Percent = sqrtVariance * 6;
        //            double sw = 0;
        //            if (Results[responseName].UpperLimit != double.MaxValue && Results[responseName].LowerLimit != double.MinValue)
        //            {
        //                sw = Results[responseName].UpperLimit - Results[responseName].LowerLimit;
        //            }
        //            else if (Results[responseName].UpperLimit == double.MaxValue)
        //            {
        //                sw = (Results[responseName].Average - Results[responseName].LowerLimit) * 2;
        //            }
        //            else if (Results[responseName].LowerLimit == double.MinValue)
        //            {
        //                sw = (Results[responseName].UpperLimit - Results[responseName].Average) * 2;
        //            }

        //            return CI99Percent / sw;//This is PTR
        //        }

        //        return 0;
        //    }
        //    catch (Exception)
        //    {
        //        return 0;
        //    }
        //}

        private void exportLimitTableToCsvFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Results.Count > 0)
            {
                ExportLimitTable(true);
            }
        }

        private void ExportLimitTable(bool bIgnoreItemsWithoutLimit)
        {
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveFileDialog1.Title = "Save an csv File";
            saveFileDialog1.ShowDialog();

            // If the file name is not an empty string open it for saving.  
            if (saveFileDialog1.FileName != "")
            {
                StringBuilder csv = new StringBuilder();
                string title = string.Format("{0},{1},{2}", "MeasurementName", "_LSL", "_USL");
                
                csv.AppendLine(title);

                foreach (var measurement in Results)
                {
                    if (measurement.Value.type != TestResult.ResultType.Continous)
                    {
                        continue;
                    }
                    else
                    {
                        if ((measurement.Value.UpperLimitInfinit == true) && (measurement.Value.LowerLimitInfinit == true) && (bIgnoreItemsWithoutLimit))
                        {
                            continue;
                        }
                        else
                        {
                            string line = string.Format("{0},{1},{2}", measurement.Value.VariationName, measurement.Value.LowerLimit, measurement.Value.UpperLimit);
                            csv.AppendLine(line);
                        }
                    }
                }
                File.WriteAllText(saveFileDialog1.FileName, csv.ToString());
                MessageBox.Show("Export the limit table successfully.");
            }

        }

        private void toolStripComboBox_ProjectStationSelection_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.productStation.station=(ProductStation.Station)toolStripComboBox_ProjectStationSelection.SelectedIndex;
        }

        private void exportResultTableForJMPAnalysisToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Results.Count!=0)
            {
                MakeMSATable(true);
            }
        }

        private void MakeMSATable(bool bIgnoreItemsWithoutLimit)
        {
            dtMSATable = new DataTable();
            dtMSATable.Columns.Add("TesterName");
            dtMSATable.Columns.Add("SerialNumber");
            foreach (var v in Results)
            {
                dtMSATable.Columns.Add(v.Value.VariationName);
                dtMSATable.Columns[v.Value.VariationName].DataType = typeof(double);
            }

            List<int> lDesiredColumns = new List<int>();
            foreach (var v in Results)
            {
                // Get the column numbers where the data is continous.
                if (v.Value.type == TestResult.ResultType.Continous)
                {
                    lDesiredColumns.Add(v.Key);
                }
            }
            
            



        }
    }

    public class ProductStation
    {
        public string sSerialNumberKeyword;
        public string sTestSuiteRunIDKeyword;
        public string sTesterNameKeyword;
        public string sStationIDKeyword;
        public string sLineIDKeyword;
        public string sPositionIDKeyword;
        public string sTestSuiteVersionKeyword;
        public string sOperatorIDKeyword;
        public string sFirstMeasurementName;

        private Station _station;
        public Station station
        {
            set
            {
                _station = value;
                switch (value)
                {
                    case Station.Bebop_FG:
                    case Station.Bebop_SFG:
                        this.sSerialNumberKeyword = "UUT_SN";
                        this.sTestSuiteRunIDKeyword = "TSRID";
                        this.sTesterNameKeyword = "PCName";
                        this.sStationIDKeyword = "StationID";
                        this.sLineIDKeyword = "LineID";
                        this.sPositionIDKeyword = "PositionID";
                        this.sTestSuiteVersionKeyword = "ScriptVersion";
                        this.sOperatorIDKeyword = "OPID";
                        this.sFirstMeasurementName = "Open_LoadBoard";
                        break;
                    case Station.Jagwar_SFG:
                    case Station.Jagwar_Plus_SFG:
                        this.sSerialNumberKeyword = "uut_sn";
                        this.sTestSuiteRunIDKeyword = "";
                        this.sTesterNameKeyword = "tester_id";
                        this.sStationIDKeyword = "phase_id";
                        this.sLineIDKeyword = "line_id";
                        this.sPositionIDKeyword = "position_id";
                        this.sTestSuiteVersionKeyword = "test_sw_version";
                        this.sOperatorIDKeyword = "operator_id";
                        this.sFirstMeasurementName = "charging_ch1_ch2_on_current";
                        break;
                    default:
                        break;
                }
            }
            get
            {
                return _station;
            }
        }

        public enum Station
        {
            Bebop_SFG = 0,
            Bebop_FG = 1,
            Jagwar_SFG = 2,
            Jagwar_FG = 3,
            Jagwar_Plus_SFG = 4,
            Jagwar_Plus_FG = 5,
        }

        public static string[] CollectSupportedStations()
        {
            return Enum.GetNames(typeof(Station));
        }

    }

}
