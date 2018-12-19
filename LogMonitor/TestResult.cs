using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace LogMonitor
{
    public class TestResult
    {
        /// <summary>
        /// flag to show the result type, e.g. hex, string or double.
        /// </summary>
        public ResultType type;

        /// <summary>
        /// flag to show if result is a limit exception
        /// </summary>
        public bool isLimitException = false;

        /// <summary>
        /// flag to show if result is a limit exception
        /// </summary>
        public bool isGeneralException = false;

        /// <summary>
        /// flag to show if limits have been added
        /// </summary>
        public bool limitsAdded = false;

        /// <summary>
        /// Flag to show if any of the limits in the group have mixed values
        /// </summary>
        public bool limitsMixed = false;

        /// <summary>
        /// Flag to show if lower limit is infinite
        /// </summary>
        public bool LowerLimitInfinit { get; set; }

        /// <summary>
        /// Flag to show if upper limit is infinite
        /// </summary>
        public bool UpperLimitInfinit { get; set; }

        /// <summary>
        /// Average of all values
        /// </summary>
        public double Average { get; set; }

        /// <summary>
        /// Lower limit value
        /// </summary>
        public double LowerLimit { get; set; }

        /// <summary>
        /// Max of all values
        /// </summary>
        public double Max { get; set; }

        /// <summary>
        /// Max minus min of all values
        /// </summary>
        public double MaxMinusMin { get; set; }

        /// <summary>
        /// Min of all values
        /// </summary>
        public double Min { get; set; }

        /// <summary>
        /// Pass rate in percentage of all values
        /// </summary>
        public double PassRate { get; set; }

        /// <summary>
        /// Standard deviation of all values in list
        /// </summary>
        public double StandardDeviation { get; set; }

        /// <summary>
        /// Variance of all values in list
        /// </summary>
        public double Variance { get; set; }

        /// <summary>
        /// CP
        /// </summary>
        public double CP { get; set; }

        /// <summary>
        /// CPK
        /// </summary>
        public double CPK { get; set; }

        /// <summary>
        /// Upper limit of test
        /// </summary>
        public double UpperLimit { get; set; }

        /// <summary>
        /// All test result values
        /// </summary>
        public List<double> Values { get; set; }

        /// <summary>
        /// All test result values with serial numbers attached
        /// </summary>
        //public List<DetailedValue> DetailedValues { get; set; }

        public Dictionary<int, ResponseDetail> DiResponseDetails { get; set; }

        /// <summary>
        /// List of all exceptions related to test
        /// </summary>
        public List<string> Exceptions { get; set; }

        /// <summary>
        /// Name of test
        /// </summary>
        public string TestName { get; set; }

        /// <summary>
        /// Unit type of test. Such as millimeters or Amps
        /// </summary>
        public string Unit { get; set; }

        /// <summary>
        /// Test variant name
        /// </summary>
        public string VariationName { get; set; }

        ///// <summary>
        ///// Tester name
        ///// </summary>
        //public string TesterName { get; set; }

        ///// <summary>
        ///// Bay name
        ///// </summary>
        //public string BayName { get; set; }

        ///// <summary>
        ///// Operator name
        ///// </summary>
        //public string OperatorName { get; set; }

        ///// <summary>
        ///// Line name
        ///// </summary>
        //public string LineName { get; set; }

        /// <summary>
        /// Duration of the test
        /// </summary>
        public TimeSpan TestDuration { get; set; }

        public uint FailCount { get; set; }

        //public DataTable dataTable;

        public int RemovedResultCount { get; set; }

        public bool stdDevModified = false;
        public bool avgModified = false;

        public TestResult()
        {
            UpperLimit = double.MaxValue;//Assume infinite limits to start
            LowerLimit = double.MinValue;
            UpperLimitInfinit = true;
            LowerLimitInfinit = true;
            this.Values = new List<double>();
            this.Exceptions = new List<string>();
            //this.DetailedValues = new List<DetailedValue>();
            this.DiResponseDetails = new Dictionary<int, ResponseDetail>();
            this.RemovedResultCount = 0;
        }

        /// <summary>
        /// Class to store values with metadata
        /// </summary>
        public class ResponseDetail
        {
            public string value;
            public string serialNumber;
            public string testerName;
            public string operatorName;
            public string positionName;
            public string lineName;
            public string tsr;
            public string testSuite;
            public ResultType Type;

            public ResponseDetail(string value, string serialNumber, string testerName, string operatorName, string lineName, string positionName, string tsr, string testSuite,TestResult.ResultType resultType)
            {
                this.value = value;
                this.serialNumber = serialNumber;
                this.testerName = testerName;
                this.operatorName = operatorName;
                this.lineName = lineName;
                this.positionName = positionName;
                this.tsr = tsr;
                this.testSuite = testSuite;
                this.Type = resultType;
            }
        }

        /// <summary>
        /// Controls adding value to result list
        /// Calculates pass rate
        /// </summary>
        /// <param name="value"></param>
        public void AddValue(double value)
        {
            this.Values.Add(value);
            //CrunchStatData();
        }

        public void CrunchStatData()
        {
            Max = Values.Max();
            Min = Values.Min();
            MaxMinusMin = Max - Min;
            Average = Values.Average();
            StandardDeviation = this.CalculateStdDev(this.Values);
            //Variance = Math.Pow(StandardDeviation, 2);
            CP = 0;
            CPK = 0;
            double CPU = 0;
            double CPL = 0;
            if ((UpperLimit != double.MaxValue) && (LowerLimit != double.MinValue))//both upper and lower limit not infinite
            {
                CP = (UpperLimit - LowerLimit) / (6 * StandardDeviation);
                if (UpperLimit != double.MaxValue)
                {
                    CPU = (UpperLimit - Average) / (3 * StandardDeviation);
                }
                if (LowerLimit != double.MinValue)
                {
                    CPL = (Average - LowerLimit) / (3 * StandardDeviation);
                }
                CPK = CPL < CPU ? CPL : CPU;//use the smaller CPK
            }
            else// at least one limit infinite
            {
                if (UpperLimit == double.MaxValue && LowerLimit == double.MinValue)
                {
                    CPK = 0;
                }
                else if (UpperLimit == double.MaxValue)
                {
                    CPK = (Average - LowerLimit) / (3 * StandardDeviation);
                }
                else
                {
                    CPK = (UpperLimit - Average) / (3 * StandardDeviation);
                }
            }

            uint fails = 0;
            foreach (var value in this.Values)
            {
                if ((value > UpperLimit) || (value < LowerLimit))
                {
                    fails++;
                }
            }
            FailCount = fails;
            CalculatePassRate();
        }

        /// <summary>
        /// Adds data with serial number
        /// </summary>
        /// <param name="value"></param>
        /// <param name="serial"></param>
        public void AddValueWithDetails(string value, string serial, string testerName, string operatorName, string lineName, string positionName, string tsr, string testSuite,ResultType rt)
        {
            ResponseDetail dv = new ResponseDetail(value, serial, testerName, operatorName, lineName, positionName, tsr, testSuite,rt);
            //this.DetailedValues.Add(dv);
            this.DiResponseDetails.Add(this.DiResponseDetails.Count, dv);
        }

        /// <summary>
        /// Calculates pass rate of test
        /// </summary>
        private void CalculatePassRate()
        {
            PassRate = 1.0D - ((double)(FailCount + Exceptions.Count) / (double)(Values.Count + Exceptions.Count));
        }

        /// <summary>
        /// Adds exception to list
        /// </summary>
        /// <param name="exception"></param>
        public void AddException(string exception)
        {
            this.Exceptions.Add(exception);
            CalculatePassRate();
            //Form1.totalExceptions++;
        }

        /// <summary>
        /// Calculates Standard Deviation of doubles in list
        /// </summary>
        /// <param name="values"></param>
        /// <returns></returns>
        private double CalculateStdDev(IEnumerable<double> values)
        {
            double ret = 0;
            if (values.Count() > 1)
            {
                double avg = values.Average();//Compute the Average 
                double sum = values.Sum(d => Math.Pow(d - avg, 2));//Perform the Sum of (value-avg)_2_2   
                ret = Math.Sqrt((sum) / (values.Count() - 1));//Put it all together      
            }
            return ret;
        }

        public enum ResultType
        {
            Null = 0,

            String = 1,

            Hex = 2,

            Continous = 3,
        }
    }
}
