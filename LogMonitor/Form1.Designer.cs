namespace LogMonitor
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbResponseNames = new System.Windows.Forms.ListBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectProjectstationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripComboBox_ProjectStationSelection = new System.Windows.Forms.ToolStripComboBox();
            this.ignoreTheFailResultsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportTestResultsWithLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mSAToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportItemsWithLimitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportLimitTableToCsvFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportResultTableForJMPAnalysisToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControl_Main = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tbResponseName = new System.Windows.Forms.TextBox();
            this.lbResponseName = new System.Windows.Forms.Label();
            this.lbCpk = new System.Windows.Forms.Label();
            this.tbMax = new System.Windows.Forms.TextBox();
            this.lbMin = new System.Windows.Forms.Label();
            this.lbRepeatability = new System.Windows.Forms.Label();
            this.lbMaxMin = new System.Windows.Forms.Label();
            this.tbRepeatability = new System.Windows.Forms.TextBox();
            this.tbLowerLimit = new System.Windows.Forms.TextBox();
            this.tbStandardDeviation = new System.Windows.Forms.TextBox();
            this.lbMax = new System.Windows.Forms.Label();
            this.tbCpk = new System.Windows.Forms.TextBox();
            this.lbAverage = new System.Windows.Forms.Label();
            this.tbAverage = new System.Windows.Forms.TextBox();
            this.tbTestCount = new System.Windows.Forms.TextBox();
            this.tbUpperLimit = new System.Windows.Forms.TextBox();
            this.lbPassRate = new System.Windows.Forms.Label();
            this.lbLimitMatch = new System.Windows.Forms.Label();
            this.tbFailureCount = new System.Windows.Forms.TextBox();
            this.lbStandardDeviation = new System.Windows.Forms.Label();
            this.tbUnit = new System.Windows.Forms.TextBox();
            this.tbMin = new System.Windows.Forms.TextBox();
            this.lbUnit = new System.Windows.Forms.Label();
            this.tbLimitMatch = new System.Windows.Forms.TextBox();
            this.lbUpperLimit = new System.Windows.Forms.Label();
            this.tbPassRate = new System.Windows.Forms.TextBox();
            this.lbTestCount = new System.Windows.Forms.Label();
            this.tbMaxMin = new System.Windows.Forms.TextBox();
            this.lbLowerLimit = new System.Windows.Forms.Label();
            this.lbFailureCount = new System.Windows.Forms.Label();
            this.dgvResponseValues = new System.Windows.Forms.DataGridView();
            this.tbUserFeedback = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControl_Main.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponseValues)).BeginInit();
            this.SuspendLayout();
            // 
            // lbResponseNames
            // 
            this.lbResponseNames.FormattingEnabled = true;
            this.lbResponseNames.ItemHeight = 25;
            this.lbResponseNames.Location = new System.Drawing.Point(8, 6);
            this.lbResponseNames.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.lbResponseNames.Name = "lbResponseNames";
            this.lbResponseNames.Size = new System.Drawing.Size(292, 929);
            this.lbResponseNames.Sorted = true;
            this.lbResponseNames.TabIndex = 0;
            this.lbResponseNames.SelectedIndexChanged += new System.EventHandler(this.lbResponseNames_SelectedIndexChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.AllowDrop = true;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.mSAToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1940, 40);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(64, 36);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectProjectstationToolStripMenuItem,
            this.ignoreTheFailResultsToolStripMenuItem,
            this.exportTestResultsWithLimitToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(111, 36);
            this.optionsToolStripMenuItem.Text = "Options";
            // 
            // selectProjectstationToolStripMenuItem
            // 
            this.selectProjectstationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripComboBox_ProjectStationSelection});
            this.selectProjectstationToolStripMenuItem.Name = "selectProjectstationToolStripMenuItem";
            this.selectProjectstationToolStripMenuItem.Size = new System.Drawing.Size(409, 38);
            this.selectProjectstationToolStripMenuItem.Text = "Select project/station";
            // 
            // toolStripComboBox_ProjectStationSelection
            // 
            this.toolStripComboBox_ProjectStationSelection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.toolStripComboBox_ProjectStationSelection.Name = "toolStripComboBox_ProjectStationSelection";
            this.toolStripComboBox_ProjectStationSelection.Size = new System.Drawing.Size(121, 40);
            this.toolStripComboBox_ProjectStationSelection.SelectedIndexChanged += new System.EventHandler(this.toolStripComboBox_ProjectStationSelection_SelectedIndexChanged);
            // 
            // ignoreTheFailResultsToolStripMenuItem
            // 
            this.ignoreTheFailResultsToolStripMenuItem.Checked = true;
            this.ignoreTheFailResultsToolStripMenuItem.CheckOnClick = true;
            this.ignoreTheFailResultsToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ignoreTheFailResultsToolStripMenuItem.Name = "ignoreTheFailResultsToolStripMenuItem";
            this.ignoreTheFailResultsToolStripMenuItem.Size = new System.Drawing.Size(409, 38);
            this.ignoreTheFailResultsToolStripMenuItem.Text = "Ignore the fail testing";
            // 
            // exportTestResultsWithLimitToolStripMenuItem
            // 
            this.exportTestResultsWithLimitToolStripMenuItem.Checked = true;
            this.exportTestResultsWithLimitToolStripMenuItem.CheckOnClick = true;
            this.exportTestResultsWithLimitToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.exportTestResultsWithLimitToolStripMenuItem.Name = "exportTestResultsWithLimitToolStripMenuItem";
            this.exportTestResultsWithLimitToolStripMenuItem.Size = new System.Drawing.Size(409, 38);
            this.exportTestResultsWithLimitToolStripMenuItem.Text = "Export test results with limit";
            // 
            // mSAToolStripMenuItem
            // 
            this.mSAToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exportItemsWithLimitToolStripMenuItem,
            this.exportLimitTableToCsvFileToolStripMenuItem,
            this.exportResultTableForJMPAnalysisToolStripMenuItem});
            this.mSAToolStripMenuItem.Name = "mSAToolStripMenuItem";
            this.mSAToolStripMenuItem.Size = new System.Drawing.Size(108, 36);
            this.mSAToolStripMenuItem.Text = "Statistic";
            // 
            // exportItemsWithLimitToolStripMenuItem
            // 
            this.exportItemsWithLimitToolStripMenuItem.Name = "exportItemsWithLimitToolStripMenuItem";
            this.exportItemsWithLimitToolStripMenuItem.Size = new System.Drawing.Size(484, 38);
            this.exportItemsWithLimitToolStripMenuItem.Text = "Export MSA table to csv file";
            this.exportItemsWithLimitToolStripMenuItem.Click += new System.EventHandler(this.exportMSATableToCsvFileToolStripMenuItem_Click);
            // 
            // exportLimitTableToCsvFileToolStripMenuItem
            // 
            this.exportLimitTableToCsvFileToolStripMenuItem.Name = "exportLimitTableToCsvFileToolStripMenuItem";
            this.exportLimitTableToCsvFileToolStripMenuItem.Size = new System.Drawing.Size(484, 38);
            this.exportLimitTableToCsvFileToolStripMenuItem.Text = "Export limit table to csv file";
            this.exportLimitTableToCsvFileToolStripMenuItem.Click += new System.EventHandler(this.exportLimitTableToCsvFileToolStripMenuItem_Click);
            // 
            // exportResultTableForJMPAnalysisToolStripMenuItem
            // 
            this.exportResultTableForJMPAnalysisToolStripMenuItem.Name = "exportResultTableForJMPAnalysisToolStripMenuItem";
            this.exportResultTableForJMPAnalysisToolStripMenuItem.Size = new System.Drawing.Size(484, 38);
            this.exportResultTableForJMPAnalysisToolStripMenuItem.Text = "Export result table for JMP analysis";
            this.exportResultTableForJMPAnalysisToolStripMenuItem.Click += new System.EventHandler(this.exportResultTableForJMPAnalysisToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(77, 36);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(179, 38);
            this.aboutToolStripMenuItem.Text = "About";
            // 
            // tabControl_Main
            // 
            this.tabControl_Main.Controls.Add(this.tabPage1);
            this.tabControl_Main.Controls.Add(this.tabPage2);
            this.tabControl_Main.Location = new System.Drawing.Point(22, 50);
            this.tabControl_Main.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabControl_Main.Name = "tabControl_Main";
            this.tabControl_Main.SelectedIndex = 0;
            this.tabControl_Main.Size = new System.Drawing.Size(1896, 996);
            this.tabControl_Main.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.SystemColors.Control;
            this.tabPage1.Controls.Add(this.tbResponseName);
            this.tabPage1.Controls.Add(this.lbResponseName);
            this.tabPage1.Controls.Add(this.lbCpk);
            this.tabPage1.Controls.Add(this.tbMax);
            this.tabPage1.Controls.Add(this.lbMin);
            this.tabPage1.Controls.Add(this.lbRepeatability);
            this.tabPage1.Controls.Add(this.lbMaxMin);
            this.tabPage1.Controls.Add(this.tbRepeatability);
            this.tabPage1.Controls.Add(this.tbLowerLimit);
            this.tabPage1.Controls.Add(this.tbStandardDeviation);
            this.tabPage1.Controls.Add(this.lbMax);
            this.tabPage1.Controls.Add(this.tbCpk);
            this.tabPage1.Controls.Add(this.lbAverage);
            this.tabPage1.Controls.Add(this.tbAverage);
            this.tabPage1.Controls.Add(this.tbTestCount);
            this.tabPage1.Controls.Add(this.tbUpperLimit);
            this.tabPage1.Controls.Add(this.lbPassRate);
            this.tabPage1.Controls.Add(this.lbLimitMatch);
            this.tabPage1.Controls.Add(this.tbFailureCount);
            this.tabPage1.Controls.Add(this.lbStandardDeviation);
            this.tabPage1.Controls.Add(this.tbUnit);
            this.tabPage1.Controls.Add(this.tbMin);
            this.tabPage1.Controls.Add(this.lbUnit);
            this.tabPage1.Controls.Add(this.tbLimitMatch);
            this.tabPage1.Controls.Add(this.lbUpperLimit);
            this.tabPage1.Controls.Add(this.tbPassRate);
            this.tabPage1.Controls.Add(this.lbTestCount);
            this.tabPage1.Controls.Add(this.tbMaxMin);
            this.tabPage1.Controls.Add(this.lbLowerLimit);
            this.tabPage1.Controls.Add(this.lbFailureCount);
            this.tabPage1.Controls.Add(this.dgvResponseValues);
            this.tabPage1.Controls.Add(this.tbUserFeedback);
            this.tabPage1.Controls.Add(this.lbResponseNames);
            this.tabPage1.Location = new System.Drawing.Point(8, 39);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage1.Size = new System.Drawing.Size(1880, 949);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "LogMonitor";
            // 
            // tbResponseName
            // 
            this.tbResponseName.BackColor = System.Drawing.Color.White;
            this.tbResponseName.Location = new System.Drawing.Point(1298, 175);
            this.tbResponseName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbResponseName.Name = "tbResponseName";
            this.tbResponseName.ReadOnly = true;
            this.tbResponseName.Size = new System.Drawing.Size(392, 31);
            this.tbResponseName.TabIndex = 100;
            this.tbResponseName.Tag = "1";
            this.tbResponseName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbResponseName
            // 
            this.lbResponseName.AutoSize = true;
            this.lbResponseName.Location = new System.Drawing.Point(1698, 179);
            this.lbResponseName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbResponseName.Name = "lbResponseName";
            this.lbResponseName.Size = new System.Drawing.Size(171, 25);
            this.lbResponseName.TabIndex = 101;
            this.lbResponseName.Tag = "1a";
            this.lbResponseName.Text = "Response Name";
            // 
            // lbCpk
            // 
            this.lbCpk.AutoSize = true;
            this.lbCpk.Location = new System.Drawing.Point(1560, 688);
            this.lbCpk.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbCpk.Name = "lbCpk";
            this.lbCpk.Size = new System.Drawing.Size(55, 25);
            this.lbCpk.TabIndex = 99;
            this.lbCpk.Tag = "13a";
            this.lbCpk.Text = "CPK";
            // 
            // tbMax
            // 
            this.tbMax.BackColor = System.Drawing.Color.White;
            this.tbMax.Location = new System.Drawing.Point(1298, 406);
            this.tbMax.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMax.Name = "tbMax";
            this.tbMax.ReadOnly = true;
            this.tbMax.Size = new System.Drawing.Size(250, 31);
            this.tbMax.TabIndex = 74;
            this.tbMax.Tag = "7";
            this.tbMax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbMin
            // 
            this.lbMin.AutoSize = true;
            this.lbMin.Location = new System.Drawing.Point(1560, 458);
            this.lbMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMin.Name = "lbMin";
            this.lbMin.Size = new System.Drawing.Size(47, 25);
            this.lbMin.TabIndex = 89;
            this.lbMin.Tag = "8a";
            this.lbMin.Text = "Min";
            // 
            // lbRepeatability
            // 
            this.lbRepeatability.AutoSize = true;
            this.lbRepeatability.Location = new System.Drawing.Point(1560, 642);
            this.lbRepeatability.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbRepeatability.Name = "lbRepeatability";
            this.lbRepeatability.Size = new System.Drawing.Size(137, 25);
            this.lbRepeatability.TabIndex = 98;
            this.lbRepeatability.Tag = "12a";
            this.lbRepeatability.Text = "Repeatability";
            // 
            // lbMaxMin
            // 
            this.lbMaxMin.AutoSize = true;
            this.lbMaxMin.Location = new System.Drawing.Point(1560, 504);
            this.lbMaxMin.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaxMin.Name = "lbMaxMin";
            this.lbMaxMin.Size = new System.Drawing.Size(107, 25);
            this.lbMaxMin.TabIndex = 90;
            this.lbMaxMin.Tag = "9a";
            this.lbMaxMin.Text = "Max - Min";
            // 
            // tbRepeatability
            // 
            this.tbRepeatability.BackColor = System.Drawing.Color.White;
            this.tbRepeatability.Location = new System.Drawing.Point(1298, 637);
            this.tbRepeatability.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbRepeatability.Name = "tbRepeatability";
            this.tbRepeatability.ReadOnly = true;
            this.tbRepeatability.Size = new System.Drawing.Size(250, 31);
            this.tbRepeatability.TabIndex = 96;
            this.tbRepeatability.Tag = "12";
            this.tbRepeatability.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbLowerLimit
            // 
            this.tbLowerLimit.BackColor = System.Drawing.Color.White;
            this.tbLowerLimit.Location = new System.Drawing.Point(1298, 360);
            this.tbLowerLimit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLowerLimit.Name = "tbLowerLimit";
            this.tbLowerLimit.Size = new System.Drawing.Size(250, 31);
            this.tbLowerLimit.TabIndex = 73;
            this.tbLowerLimit.Tag = "6";
            this.tbLowerLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbStandardDeviation
            // 
            this.tbStandardDeviation.BackColor = System.Drawing.Color.White;
            this.tbStandardDeviation.Location = new System.Drawing.Point(1298, 590);
            this.tbStandardDeviation.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbStandardDeviation.Name = "tbStandardDeviation";
            this.tbStandardDeviation.Size = new System.Drawing.Size(250, 31);
            this.tbStandardDeviation.TabIndex = 81;
            this.tbStandardDeviation.Tag = "11";
            this.tbStandardDeviation.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbMax
            // 
            this.lbMax.AutoSize = true;
            this.lbMax.Location = new System.Drawing.Point(1560, 412);
            this.lbMax.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMax.Name = "lbMax";
            this.lbMax.Size = new System.Drawing.Size(53, 25);
            this.lbMax.TabIndex = 88;
            this.lbMax.Tag = "7a";
            this.lbMax.Text = "Max";
            // 
            // tbCpk
            // 
            this.tbCpk.BackColor = System.Drawing.Color.White;
            this.tbCpk.Location = new System.Drawing.Point(1298, 683);
            this.tbCpk.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbCpk.Name = "tbCpk";
            this.tbCpk.ReadOnly = true;
            this.tbCpk.Size = new System.Drawing.Size(250, 31);
            this.tbCpk.TabIndex = 97;
            this.tbCpk.Tag = "13";
            this.tbCpk.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbAverage
            // 
            this.lbAverage.AutoSize = true;
            this.lbAverage.Location = new System.Drawing.Point(1560, 550);
            this.lbAverage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbAverage.Name = "lbAverage";
            this.lbAverage.Size = new System.Drawing.Size(92, 25);
            this.lbAverage.TabIndex = 91;
            this.lbAverage.Tag = "10a";
            this.lbAverage.Text = "Average";
            // 
            // tbAverage
            // 
            this.tbAverage.BackColor = System.Drawing.Color.White;
            this.tbAverage.Location = new System.Drawing.Point(1298, 544);
            this.tbAverage.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbAverage.Name = "tbAverage";
            this.tbAverage.Size = new System.Drawing.Size(250, 31);
            this.tbAverage.TabIndex = 75;
            this.tbAverage.Tag = "10";
            this.tbAverage.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbTestCount
            // 
            this.tbTestCount.BackColor = System.Drawing.Color.White;
            this.tbTestCount.Location = new System.Drawing.Point(1298, 729);
            this.tbTestCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbTestCount.Name = "tbTestCount";
            this.tbTestCount.ReadOnly = true;
            this.tbTestCount.Size = new System.Drawing.Size(250, 31);
            this.tbTestCount.TabIndex = 80;
            this.tbTestCount.Tag = "14";
            this.tbTestCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbUpperLimit
            // 
            this.tbUpperLimit.BackColor = System.Drawing.Color.White;
            this.tbUpperLimit.Location = new System.Drawing.Point(1298, 313);
            this.tbUpperLimit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUpperLimit.Name = "tbUpperLimit";
            this.tbUpperLimit.Size = new System.Drawing.Size(250, 31);
            this.tbUpperLimit.TabIndex = 72;
            this.tbUpperLimit.Tag = "5";
            this.tbUpperLimit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbPassRate
            // 
            this.lbPassRate.AutoSize = true;
            this.lbPassRate.Location = new System.Drawing.Point(1560, 827);
            this.lbPassRate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbPassRate.Name = "lbPassRate";
            this.lbPassRate.Size = new System.Drawing.Size(111, 25);
            this.lbPassRate.TabIndex = 95;
            this.lbPassRate.Tag = "17a";
            this.lbPassRate.Text = "Pass Rate";
            // 
            // lbLimitMatch
            // 
            this.lbLimitMatch.AutoSize = true;
            this.lbLimitMatch.Location = new System.Drawing.Point(1560, 273);
            this.lbLimitMatch.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLimitMatch.Name = "lbLimitMatch";
            this.lbLimitMatch.Size = new System.Drawing.Size(163, 25);
            this.lbLimitMatch.TabIndex = 87;
            this.lbLimitMatch.Tag = "4a";
            this.lbLimitMatch.Text = "All Limits Match";
            // 
            // tbFailureCount
            // 
            this.tbFailureCount.BackColor = System.Drawing.Color.White;
            this.tbFailureCount.Location = new System.Drawing.Point(1298, 775);
            this.tbFailureCount.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbFailureCount.Name = "tbFailureCount";
            this.tbFailureCount.ReadOnly = true;
            this.tbFailureCount.Size = new System.Drawing.Size(250, 31);
            this.tbFailureCount.TabIndex = 79;
            this.tbFailureCount.Tag = "15";
            this.tbFailureCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbStandardDeviation
            // 
            this.lbStandardDeviation.AutoSize = true;
            this.lbStandardDeviation.Location = new System.Drawing.Point(1560, 596);
            this.lbStandardDeviation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbStandardDeviation.Name = "lbStandardDeviation";
            this.lbStandardDeviation.Size = new System.Drawing.Size(195, 25);
            this.lbStandardDeviation.TabIndex = 92;
            this.lbStandardDeviation.Tag = "11a";
            this.lbStandardDeviation.Text = "Standard Deviation";
            // 
            // tbUnit
            // 
            this.tbUnit.BackColor = System.Drawing.Color.White;
            this.tbUnit.Location = new System.Drawing.Point(1298, 221);
            this.tbUnit.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUnit.Name = "tbUnit";
            this.tbUnit.ReadOnly = true;
            this.tbUnit.Size = new System.Drawing.Size(250, 31);
            this.tbUnit.TabIndex = 69;
            this.tbUnit.Tag = "3";
            this.tbUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbMin
            // 
            this.tbMin.BackColor = System.Drawing.Color.White;
            this.tbMin.Location = new System.Drawing.Point(1298, 452);
            this.tbMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMin.Name = "tbMin";
            this.tbMin.ReadOnly = true;
            this.tbMin.Size = new System.Drawing.Size(250, 31);
            this.tbMin.TabIndex = 76;
            this.tbMin.Tag = "8";
            this.tbMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbUnit
            // 
            this.lbUnit.AutoSize = true;
            this.lbUnit.Location = new System.Drawing.Point(1560, 227);
            this.lbUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUnit.Name = "lbUnit";
            this.lbUnit.Size = new System.Drawing.Size(50, 25);
            this.lbUnit.TabIndex = 84;
            this.lbUnit.Tag = "3a";
            this.lbUnit.Text = "Unit";
            // 
            // tbLimitMatch
            // 
            this.tbLimitMatch.BackColor = System.Drawing.Color.White;
            this.tbLimitMatch.Location = new System.Drawing.Point(1298, 267);
            this.tbLimitMatch.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbLimitMatch.Name = "tbLimitMatch";
            this.tbLimitMatch.ReadOnly = true;
            this.tbLimitMatch.Size = new System.Drawing.Size(250, 31);
            this.tbLimitMatch.TabIndex = 71;
            this.tbLimitMatch.Tag = "4";
            this.tbLimitMatch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbUpperLimit
            // 
            this.lbUpperLimit.AutoSize = true;
            this.lbUpperLimit.Location = new System.Drawing.Point(1560, 319);
            this.lbUpperLimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUpperLimit.Name = "lbUpperLimit";
            this.lbUpperLimit.Size = new System.Drawing.Size(121, 25);
            this.lbUpperLimit.TabIndex = 86;
            this.lbUpperLimit.Tag = "5a";
            this.lbUpperLimit.Text = "Upper Limit";
            // 
            // tbPassRate
            // 
            this.tbPassRate.BackColor = System.Drawing.Color.White;
            this.tbPassRate.Location = new System.Drawing.Point(1298, 821);
            this.tbPassRate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbPassRate.Name = "tbPassRate";
            this.tbPassRate.ReadOnly = true;
            this.tbPassRate.Size = new System.Drawing.Size(250, 31);
            this.tbPassRate.TabIndex = 78;
            this.tbPassRate.Tag = "17";
            this.tbPassRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbTestCount
            // 
            this.lbTestCount.AutoSize = true;
            this.lbTestCount.Location = new System.Drawing.Point(1560, 735);
            this.lbTestCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTestCount.Name = "lbTestCount";
            this.lbTestCount.Size = new System.Drawing.Size(117, 25);
            this.lbTestCount.TabIndex = 93;
            this.lbTestCount.Tag = "14a";
            this.lbTestCount.Text = "Test Count";
            // 
            // tbMaxMin
            // 
            this.tbMaxMin.BackColor = System.Drawing.Color.White;
            this.tbMaxMin.Location = new System.Drawing.Point(1298, 498);
            this.tbMaxMin.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbMaxMin.Name = "tbMaxMin";
            this.tbMaxMin.ReadOnly = true;
            this.tbMaxMin.Size = new System.Drawing.Size(250, 31);
            this.tbMaxMin.TabIndex = 77;
            this.tbMaxMin.Tag = "9";
            this.tbMaxMin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbLowerLimit
            // 
            this.lbLowerLimit.AutoSize = true;
            this.lbLowerLimit.Location = new System.Drawing.Point(1560, 365);
            this.lbLowerLimit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbLowerLimit.Name = "lbLowerLimit";
            this.lbLowerLimit.Size = new System.Drawing.Size(121, 25);
            this.lbLowerLimit.TabIndex = 85;
            this.lbLowerLimit.Tag = "6a";
            this.lbLowerLimit.Text = "Lower Limit";
            // 
            // lbFailureCount
            // 
            this.lbFailureCount.AutoSize = true;
            this.lbFailureCount.Location = new System.Drawing.Point(1560, 781);
            this.lbFailureCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbFailureCount.Name = "lbFailureCount";
            this.lbFailureCount.Size = new System.Drawing.Size(141, 25);
            this.lbFailureCount.TabIndex = 94;
            this.lbFailureCount.Tag = "15a";
            this.lbFailureCount.Text = "Failure Count";
            // 
            // dgvResponseValues
            // 
            this.dgvResponseValues.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dgvResponseValues.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvResponseValues.BackgroundColor = System.Drawing.SystemColors.Window;
            this.dgvResponseValues.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvResponseValues.Location = new System.Drawing.Point(312, 175);
            this.dgvResponseValues.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvResponseValues.Name = "dgvResponseValues";
            this.dgvResponseValues.RowTemplate.Height = 33;
            this.dgvResponseValues.Size = new System.Drawing.Size(978, 763);
            this.dgvResponseValues.TabIndex = 2;
            // 
            // tbUserFeedback
            // 
            this.tbUserFeedback.Location = new System.Drawing.Point(312, 6);
            this.tbUserFeedback.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbUserFeedback.Multiline = true;
            this.tbUserFeedback.Name = "tbUserFeedback";
            this.tbUserFeedback.Size = new System.Drawing.Size(1554, 158);
            this.tbUserFeedback.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(8, 39);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(1880, 949);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Visualization";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AllowDrop = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1940, 1067);
            this.Controls.Add(this.tabControl_Main);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Main";
            this.Text = "Log Monitor";
            this.DragDrop += new System.Windows.Forms.DragEventHandler(this.Main_DragDrop);
            this.DragEnter += new System.Windows.Forms.DragEventHandler(this.Main_DragEnter);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControl_Main.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResponseValues)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox lbResponseNames;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControl_Main;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tbUserFeedback;
        private System.Windows.Forms.DataGridView dgvResponseValues;
        private System.Windows.Forms.TextBox tbResponseName;
        private System.Windows.Forms.Label lbResponseName;
        private System.Windows.Forms.Label lbCpk;
        private System.Windows.Forms.TextBox tbMax;
        private System.Windows.Forms.Label lbMin;
        private System.Windows.Forms.Label lbRepeatability;
        private System.Windows.Forms.Label lbMaxMin;
        private System.Windows.Forms.TextBox tbRepeatability;
        private System.Windows.Forms.TextBox tbLowerLimit;
        private System.Windows.Forms.TextBox tbStandardDeviation;
        private System.Windows.Forms.Label lbMax;
        private System.Windows.Forms.TextBox tbCpk;
        private System.Windows.Forms.Label lbAverage;
        private System.Windows.Forms.TextBox tbAverage;
        private System.Windows.Forms.TextBox tbTestCount;
        private System.Windows.Forms.TextBox tbUpperLimit;
        private System.Windows.Forms.Label lbPassRate;
        private System.Windows.Forms.Label lbLimitMatch;
        private System.Windows.Forms.TextBox tbFailureCount;
        private System.Windows.Forms.Label lbStandardDeviation;
        private System.Windows.Forms.TextBox tbUnit;
        private System.Windows.Forms.TextBox tbMin;
        private System.Windows.Forms.Label lbUnit;
        private System.Windows.Forms.TextBox tbLimitMatch;
        private System.Windows.Forms.Label lbUpperLimit;
        private System.Windows.Forms.TextBox tbPassRate;
        private System.Windows.Forms.Label lbTestCount;
        private System.Windows.Forms.TextBox tbMaxMin;
        private System.Windows.Forms.Label lbLowerLimit;
        private System.Windows.Forms.Label lbFailureCount;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ignoreTheFailResultsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem mSAToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportItemsWithLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportTestResultsWithLimitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exportLimitTableToCsvFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectProjectstationToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBox_ProjectStationSelection;
        private System.Windows.Forms.ToolStripMenuItem exportResultTableForJMPAnalysisToolStripMenuItem;
    }
}

