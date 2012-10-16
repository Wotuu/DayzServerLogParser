namespace DayzLogParser.UI {
    partial class DayzLogParserForm {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Online");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Offline");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Survivors", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Objects");
            this.blissHiveTree = new System.Windows.Forms.TreeView();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.fileMenuItem = new System.Windows.Forms.MenuItem();
            this.openBlissHiveMenuItem = new System.Windows.Forms.MenuItem();
            this.exitSeperator = new System.Windows.Forms.MenuItem();
            this.exitMenuItem = new System.Windows.Forms.MenuItem();
            this.optionsMenuItem = new System.Windows.Forms.MenuItem();
            this.blissHiveDownloadLogBtn = new System.Windows.Forms.Button();
            this.logfilesTabControl = new System.Windows.Forms.TabControl();
            this.blissHiveTab = new System.Windows.Forms.TabPage();
            this.blissHiveCardControl = new System.Windows.Forms.TabControl();
            this.blissHiveCardControlPlayerTab = new System.Windows.Forms.TabPage();
            this.blissHivePlayerDataPanel = new System.Windows.Forms.Panel();
            this.blissHivePlayerDataTabControl = new System.Windows.Forms.TabControl();
            this.blissHivePlayerDataTabFormattedData = new System.Windows.Forms.TabPage();
            this.blissHivePlayerDataFormattedLogDataListView = new System.Windows.Forms.ListView();
            this.blissHivePlayerDataFormattedDataTimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHivePlayerDataFormattedDataFunctionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHivePlayerDataFormattedDataParameterColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHivePlayerDataTabRawLogData = new System.Windows.Forms.TabPage();
            this.blissHivePlayerDataRawLogDataTextBox = new System.Windows.Forms.TextBox();
            this.blissHivePlayerDataTabInventoryHistory = new System.Windows.Forms.TabPage();
            this.blissHivePlayerDataInventoryHistoryComboBox = new System.Windows.Forms.ComboBox();
            this.blissHivePlayerDataInventoryHistorySelectLbl = new System.Windows.Forms.Label();
            this.blissHivePlayerDataInventoryHistoryBackpackGroupBox = new System.Windows.Forms.GroupBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.blissHivePlayerDataInventoryHistoryBackpackListView = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHivePlayerDataInventoryHistoryInventoryGroupBox = new System.Windows.Forms.GroupBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.blissHivePlayerDataInventoryHistoryInventoryListView = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHivePlayerDataTabDebugMonitorHistory = new System.Windows.Forms.TabPage();
            this.blissHivePlayerDataDebugMonitorHistoryComboBox = new System.Windows.Forms.ComboBox();
            this.blissHivePlayerDataDebugMonitorHistoryGroupBox = new System.Windows.Forms.GroupBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.blissHivePlayerDataDebugMonitorHistoryListView = new System.Windows.Forms.ListView();
            this.blissHivePlayerDataDebugMonitorListViewNameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHivePlayerDataDebugMonitorListViewValueColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHivePlayerDataDebugMonitorHistorySelectLbl = new System.Windows.Forms.Label();
            this.blissHivePlayerDataTabActivityLog = new System.Windows.Forms.TabPage();
            this.blissHiveActivityLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHiveCardControlObjectTab = new System.Windows.Forms.TabPage();
            this.blissHiveObjectDataTabControl = new System.Windows.Forms.TabControl();
            this.blissHiveObjectDataFormattedLogDataTab = new System.Windows.Forms.TabPage();
            this.blissHiveObjectDataFormattedLogDataListView = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHiveObjectDataRawLogDataTab = new System.Windows.Forms.TabPage();
            this.blissHiveObjectDataRawLogDataTextBox = new System.Windows.Forms.TextBox();
            this.blissHiveObjectDataInventoryTab = new System.Windows.Forms.TabPage();
            this.blissHiveObjectDataInventoryHistoryComboBox = new System.Windows.Forms.ComboBox();
            this.blissHiveObjectDataInventoryHistorySelectLbl = new System.Windows.Forms.Label();
            this.blissHiveObjectDataInventoryHistoryBackpackGroupBox = new System.Windows.Forms.GroupBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.blissHiveObjectDataInventoryHistoryBackpackListView = new System.Windows.Forms.ListView();
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHiveObjectDataInventoryHistoryInventoryGroupBox = new System.Windows.Forms.GroupBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.blissHiveObjectDataInventoryHistoryInventoryListView = new System.Windows.Forms.ListView();
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHiveObjectDataHealthTab = new System.Windows.Forms.TabPage();
            this.blissHiveObjectDataHealthGroupBox = new System.Windows.Forms.GroupBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.blissHiveObjectDataHealthListView = new System.Windows.Forms.ListView();
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHiveObjectDataActivityLogTab = new System.Windows.Forms.TabPage();
            this.blissHiveObjectDataActivityLogListView = new System.Windows.Forms.ListView();
            this.columnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHiveProgressTimeRemainingLbl = new System.Windows.Forms.Label();
            this.blissHiveFetchMinutesTF = new DayzLogParser.UI.IntTextBox();
            this.blissHivePlayerName = new System.Windows.Forms.Label();
            this.blissHiveDownloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.blissHiveLogFetchTimeDropdown = new System.Windows.Forms.ComboBox();
            this.blissHiveFetchLogLbl = new System.Windows.Forms.Label();
            this.warningPanel = new System.Windows.Forms.Panel();
            this.warningsLbl = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusText1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusText2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.blissHiveObjectDataHealthTypeEstimateLbl = new System.Windows.Forms.Label();
            this.blissHiveObjectDataHealthTypeEstimateTextBox = new System.Windows.Forms.TextBox();
            this.logfilesTabControl.SuspendLayout();
            this.blissHiveTab.SuspendLayout();
            this.blissHiveCardControl.SuspendLayout();
            this.blissHiveCardControlPlayerTab.SuspendLayout();
            this.blissHivePlayerDataPanel.SuspendLayout();
            this.blissHivePlayerDataTabControl.SuspendLayout();
            this.blissHivePlayerDataTabFormattedData.SuspendLayout();
            this.blissHivePlayerDataTabRawLogData.SuspendLayout();
            this.blissHivePlayerDataTabInventoryHistory.SuspendLayout();
            this.blissHivePlayerDataInventoryHistoryBackpackGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.blissHivePlayerDataInventoryHistoryInventoryGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.blissHivePlayerDataTabDebugMonitorHistory.SuspendLayout();
            this.blissHivePlayerDataDebugMonitorHistoryGroupBox.SuspendLayout();
            this.panel3.SuspendLayout();
            this.blissHivePlayerDataTabActivityLog.SuspendLayout();
            this.blissHiveCardControlObjectTab.SuspendLayout();
            this.blissHiveObjectDataTabControl.SuspendLayout();
            this.blissHiveObjectDataFormattedLogDataTab.SuspendLayout();
            this.blissHiveObjectDataRawLogDataTab.SuspendLayout();
            this.blissHiveObjectDataInventoryTab.SuspendLayout();
            this.blissHiveObjectDataInventoryHistoryBackpackGroupBox.SuspendLayout();
            this.panel4.SuspendLayout();
            this.blissHiveObjectDataInventoryHistoryInventoryGroupBox.SuspendLayout();
            this.panel5.SuspendLayout();
            this.blissHiveObjectDataHealthTab.SuspendLayout();
            this.blissHiveObjectDataHealthGroupBox.SuspendLayout();
            this.panel6.SuspendLayout();
            this.blissHiveObjectDataActivityLogTab.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // blissHiveTree
            // 
            this.blissHiveTree.Location = new System.Drawing.Point(6, 30);
            this.blissHiveTree.Name = "blissHiveTree";
            treeNode1.Name = "blisshiveTreeNodeOnline";
            treeNode1.Tag = "onlineSurvivors";
            treeNode1.Text = "Online";
            treeNode2.Name = "blisshiveTreeNodeOffline";
            treeNode2.Tag = "offlineSurvivors";
            treeNode2.Text = "Offline";
            treeNode3.ForeColor = System.Drawing.Color.Black;
            treeNode3.Name = "blisshiveTreeNodePlayers";
            treeNode3.Tag = "survivors";
            treeNode3.Text = "Survivors";
            treeNode4.Name = "blisshiveTreeNodeObjects";
            treeNode4.Tag = "objects";
            treeNode4.Text = "Objects";
            this.blissHiveTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.blissHiveTree.Size = new System.Drawing.Size(219, 396);
            this.blissHiveTree.TabIndex = 1;
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            // 
            // mainMenu
            // 
            this.mainMenu.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.fileMenuItem,
            this.optionsMenuItem});
            // 
            // fileMenuItem
            // 
            this.fileMenuItem.Index = 0;
            this.fileMenuItem.MenuItems.AddRange(new System.Windows.Forms.MenuItem[] {
            this.openBlissHiveMenuItem,
            this.exitSeperator,
            this.exitMenuItem});
            this.fileMenuItem.Text = "File";
            // 
            // openBlissHiveMenuItem
            // 
            this.openBlissHiveMenuItem.Index = 0;
            this.openBlissHiveMenuItem.Tag = "openFile";
            this.openBlissHiveMenuItem.Text = "Open blisshive.log";
            this.openBlissHiveMenuItem.Click += new System.EventHandler(this.openBlissHiveMenuItem_Click);
            // 
            // exitSeperator
            // 
            this.exitSeperator.Index = 1;
            this.exitSeperator.Text = "-";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Index = 2;
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.ExitMenuItem_Click);
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.Index = 1;
            this.optionsMenuItem.Text = "Options";
            this.optionsMenuItem.Click += new System.EventHandler(this.OptionsMenuItem_Click);
            // 
            // blissHiveDownloadLogBtn
            // 
            this.blissHiveDownloadLogBtn.Enabled = false;
            this.blissHiveDownloadLogBtn.Location = new System.Drawing.Point(231, 3);
            this.blissHiveDownloadLogBtn.Name = "blissHiveDownloadLogBtn";
            this.blissHiveDownloadLogBtn.Size = new System.Drawing.Size(75, 23);
            this.blissHiveDownloadLogBtn.TabIndex = 2;
            this.blissHiveDownloadLogBtn.Text = "Start";
            this.blissHiveDownloadLogBtn.UseVisualStyleBackColor = true;
            this.blissHiveDownloadLogBtn.Click += new System.EventHandler(this.BlisshiveDownloadLogBtn_Click);
            // 
            // logfilesTabControl
            // 
            this.logfilesTabControl.Controls.Add(this.blissHiveTab);
            this.logfilesTabControl.Location = new System.Drawing.Point(9, 7);
            this.logfilesTabControl.Name = "logfilesTabControl";
            this.logfilesTabControl.SelectedIndex = 0;
            this.logfilesTabControl.Size = new System.Drawing.Size(935, 458);
            this.logfilesTabControl.TabIndex = 3;
            // 
            // blissHiveTab
            // 
            this.blissHiveTab.Controls.Add(this.blissHiveCardControl);
            this.blissHiveTab.Controls.Add(this.blissHiveProgressTimeRemainingLbl);
            this.blissHiveTab.Controls.Add(this.blissHiveFetchMinutesTF);
            this.blissHiveTab.Controls.Add(this.blissHivePlayerName);
            this.blissHiveTab.Controls.Add(this.blissHiveDownloadProgressBar);
            this.blissHiveTab.Controls.Add(this.blissHiveLogFetchTimeDropdown);
            this.blissHiveTab.Controls.Add(this.blissHiveFetchLogLbl);
            this.blissHiveTab.Controls.Add(this.blissHiveTree);
            this.blissHiveTab.Controls.Add(this.blissHiveDownloadLogBtn);
            this.blissHiveTab.Location = new System.Drawing.Point(4, 22);
            this.blissHiveTab.Name = "blissHiveTab";
            this.blissHiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.blissHiveTab.Size = new System.Drawing.Size(927, 432);
            this.blissHiveTab.TabIndex = 0;
            this.blissHiveTab.Text = "blisshive.log";
            this.blissHiveTab.UseVisualStyleBackColor = true;
            // 
            // blissHiveCardControl
            // 
            this.blissHiveCardControl.Appearance = System.Windows.Forms.TabAppearance.Buttons;
            this.blissHiveCardControl.Controls.Add(this.blissHiveCardControlPlayerTab);
            this.blissHiveCardControl.Controls.Add(this.blissHiveCardControlObjectTab);
            this.blissHiveCardControl.ItemSize = new System.Drawing.Size(90, 4);
            this.blissHiveCardControl.Location = new System.Drawing.Point(231, 46);
            this.blissHiveCardControl.Name = "blissHiveCardControl";
            this.blissHiveCardControl.SelectedIndex = 0;
            this.blissHiveCardControl.Size = new System.Drawing.Size(700, 387);
            this.blissHiveCardControl.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.blissHiveCardControl.TabIndex = 10;
            // 
            // blissHiveCardControlPlayerTab
            // 
            this.blissHiveCardControlPlayerTab.BackColor = System.Drawing.Color.Transparent;
            this.blissHiveCardControlPlayerTab.Controls.Add(this.blissHivePlayerDataPanel);
            this.blissHiveCardControlPlayerTab.Location = new System.Drawing.Point(4, 8);
            this.blissHiveCardControlPlayerTab.Name = "blissHiveCardControlPlayerTab";
            this.blissHiveCardControlPlayerTab.Padding = new System.Windows.Forms.Padding(3);
            this.blissHiveCardControlPlayerTab.Size = new System.Drawing.Size(692, 375);
            this.blissHiveCardControlPlayerTab.TabIndex = 0;
            this.blissHiveCardControlPlayerTab.Text = "Player Controls";
            // 
            // blissHivePlayerDataPanel
            // 
            this.blissHivePlayerDataPanel.BackColor = System.Drawing.Color.Transparent;
            this.blissHivePlayerDataPanel.Controls.Add(this.blissHivePlayerDataTabControl);
            this.blissHivePlayerDataPanel.Location = new System.Drawing.Point(2, 0);
            this.blissHivePlayerDataPanel.Name = "blissHivePlayerDataPanel";
            this.blissHivePlayerDataPanel.Size = new System.Drawing.Size(689, 394);
            this.blissHivePlayerDataPanel.TabIndex = 7;
            // 
            // blissHivePlayerDataTabControl
            // 
            this.blissHivePlayerDataTabControl.Controls.Add(this.blissHivePlayerDataTabFormattedData);
            this.blissHivePlayerDataTabControl.Controls.Add(this.blissHivePlayerDataTabRawLogData);
            this.blissHivePlayerDataTabControl.Controls.Add(this.blissHivePlayerDataTabInventoryHistory);
            this.blissHivePlayerDataTabControl.Controls.Add(this.blissHivePlayerDataTabDebugMonitorHistory);
            this.blissHivePlayerDataTabControl.Controls.Add(this.blissHivePlayerDataTabActivityLog);
            this.blissHivePlayerDataTabControl.Location = new System.Drawing.Point(-1, 0);
            this.blissHivePlayerDataTabControl.Name = "blissHivePlayerDataTabControl";
            this.blissHivePlayerDataTabControl.SelectedIndex = 0;
            this.blissHivePlayerDataTabControl.Size = new System.Drawing.Size(691, 378);
            this.blissHivePlayerDataTabControl.TabIndex = 2;
            this.blissHivePlayerDataTabControl.Tag = "";
            // 
            // blissHivePlayerDataTabFormattedData
            // 
            this.blissHivePlayerDataTabFormattedData.Controls.Add(this.blissHivePlayerDataFormattedLogDataListView);
            this.blissHivePlayerDataTabFormattedData.Location = new System.Drawing.Point(4, 22);
            this.blissHivePlayerDataTabFormattedData.Name = "blissHivePlayerDataTabFormattedData";
            this.blissHivePlayerDataTabFormattedData.Padding = new System.Windows.Forms.Padding(3);
            this.blissHivePlayerDataTabFormattedData.Size = new System.Drawing.Size(683, 352);
            this.blissHivePlayerDataTabFormattedData.TabIndex = 0;
            this.blissHivePlayerDataTabFormattedData.Tag = "formattedLogData";
            this.blissHivePlayerDataTabFormattedData.Text = "Formatted Log Data";
            this.blissHivePlayerDataTabFormattedData.UseVisualStyleBackColor = true;
            // 
            // blissHivePlayerDataFormattedLogDataListView
            // 
            this.blissHivePlayerDataFormattedLogDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.blissHivePlayerDataFormattedDataTimeColumn,
            this.blissHivePlayerDataFormattedDataFunctionColumn,
            this.blissHivePlayerDataFormattedDataParameterColumn});
            this.blissHivePlayerDataFormattedLogDataListView.Location = new System.Drawing.Point(0, 0);
            this.blissHivePlayerDataFormattedLogDataListView.Name = "blissHivePlayerDataFormattedLogDataListView";
            this.blissHivePlayerDataFormattedLogDataListView.Size = new System.Drawing.Size(681, 351);
            this.blissHivePlayerDataFormattedLogDataListView.TabIndex = 0;
            this.blissHivePlayerDataFormattedLogDataListView.UseCompatibleStateImageBehavior = false;
            this.blissHivePlayerDataFormattedLogDataListView.View = System.Windows.Forms.View.Details;
            // 
            // blissHivePlayerDataFormattedDataTimeColumn
            // 
            this.blissHivePlayerDataFormattedDataTimeColumn.Text = "Timestamp";
            this.blissHivePlayerDataFormattedDataTimeColumn.Width = 120;
            // 
            // blissHivePlayerDataFormattedDataFunctionColumn
            // 
            this.blissHivePlayerDataFormattedDataFunctionColumn.Text = "Function Name";
            this.blissHivePlayerDataFormattedDataFunctionColumn.Width = 120;
            // 
            // blissHivePlayerDataFormattedDataParameterColumn
            // 
            this.blissHivePlayerDataFormattedDataParameterColumn.Text = "Parameters";
            this.blissHivePlayerDataFormattedDataParameterColumn.Width = 415;
            // 
            // blissHivePlayerDataTabRawLogData
            // 
            this.blissHivePlayerDataTabRawLogData.Controls.Add(this.blissHivePlayerDataRawLogDataTextBox);
            this.blissHivePlayerDataTabRawLogData.Location = new System.Drawing.Point(4, 22);
            this.blissHivePlayerDataTabRawLogData.Name = "blissHivePlayerDataTabRawLogData";
            this.blissHivePlayerDataTabRawLogData.Padding = new System.Windows.Forms.Padding(3);
            this.blissHivePlayerDataTabRawLogData.Size = new System.Drawing.Size(683, 352);
            this.blissHivePlayerDataTabRawLogData.TabIndex = 1;
            this.blissHivePlayerDataTabRawLogData.Tag = "rawLogData";
            this.blissHivePlayerDataTabRawLogData.Text = "Raw Log Data";
            this.blissHivePlayerDataTabRawLogData.UseVisualStyleBackColor = true;
            // 
            // blissHivePlayerDataRawLogDataTextBox
            // 
            this.blissHivePlayerDataRawLogDataTextBox.Location = new System.Drawing.Point(0, 0);
            this.blissHivePlayerDataRawLogDataTextBox.MaxLength = 2147483647;
            this.blissHivePlayerDataRawLogDataTextBox.Multiline = true;
            this.blissHivePlayerDataRawLogDataTextBox.Name = "blissHivePlayerDataRawLogDataTextBox";
            this.blissHivePlayerDataRawLogDataTextBox.ReadOnly = true;
            this.blissHivePlayerDataRawLogDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.blissHivePlayerDataRawLogDataTextBox.Size = new System.Drawing.Size(681, 351);
            this.blissHivePlayerDataRawLogDataTextBox.TabIndex = 0;
            this.blissHivePlayerDataRawLogDataTextBox.WordWrap = false;
            // 
            // blissHivePlayerDataTabInventoryHistory
            // 
            this.blissHivePlayerDataTabInventoryHistory.Controls.Add(this.blissHivePlayerDataInventoryHistoryComboBox);
            this.blissHivePlayerDataTabInventoryHistory.Controls.Add(this.blissHivePlayerDataInventoryHistorySelectLbl);
            this.blissHivePlayerDataTabInventoryHistory.Controls.Add(this.blissHivePlayerDataInventoryHistoryBackpackGroupBox);
            this.blissHivePlayerDataTabInventoryHistory.Controls.Add(this.blissHivePlayerDataInventoryHistoryInventoryGroupBox);
            this.blissHivePlayerDataTabInventoryHistory.Location = new System.Drawing.Point(4, 22);
            this.blissHivePlayerDataTabInventoryHistory.Name = "blissHivePlayerDataTabInventoryHistory";
            this.blissHivePlayerDataTabInventoryHistory.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.blissHivePlayerDataTabInventoryHistory.Size = new System.Drawing.Size(683, 352);
            this.blissHivePlayerDataTabInventoryHistory.TabIndex = 4;
            this.blissHivePlayerDataTabInventoryHistory.Text = "Inventory History";
            this.blissHivePlayerDataTabInventoryHistory.UseVisualStyleBackColor = true;
            // 
            // blissHivePlayerDataInventoryHistoryComboBox
            // 
            this.blissHivePlayerDataInventoryHistoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blissHivePlayerDataInventoryHistoryComboBox.FormattingEnabled = true;
            this.blissHivePlayerDataInventoryHistoryComboBox.Location = new System.Drawing.Point(119, 0);
            this.blissHivePlayerDataInventoryHistoryComboBox.Name = "blissHivePlayerDataInventoryHistoryComboBox";
            this.blissHivePlayerDataInventoryHistoryComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blissHivePlayerDataInventoryHistoryComboBox.Size = new System.Drawing.Size(152, 21);
            this.blissHivePlayerDataInventoryHistoryComboBox.TabIndex = 9;
            // 
            // blissHivePlayerDataInventoryHistorySelectLbl
            // 
            this.blissHivePlayerDataInventoryHistorySelectLbl.AutoSize = true;
            this.blissHivePlayerDataInventoryHistorySelectLbl.Location = new System.Drawing.Point(6, 4);
            this.blissHivePlayerDataInventoryHistorySelectLbl.Name = "blissHivePlayerDataInventoryHistorySelectLbl";
            this.blissHivePlayerDataInventoryHistorySelectLbl.Size = new System.Drawing.Size(83, 13);
            this.blissHivePlayerDataInventoryHistorySelectLbl.TabIndex = 8;
            this.blissHivePlayerDataInventoryHistorySelectLbl.Text = "Select inventory";
            // 
            // blissHivePlayerDataInventoryHistoryBackpackGroupBox
            // 
            this.blissHivePlayerDataInventoryHistoryBackpackGroupBox.Controls.Add(this.panel1);
            this.blissHivePlayerDataInventoryHistoryBackpackGroupBox.Location = new System.Drawing.Point(342, 20);
            this.blissHivePlayerDataInventoryHistoryBackpackGroupBox.Name = "blissHivePlayerDataInventoryHistoryBackpackGroupBox";
            this.blissHivePlayerDataInventoryHistoryBackpackGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blissHivePlayerDataInventoryHistoryBackpackGroupBox.Size = new System.Drawing.Size(338, 329);
            this.blissHivePlayerDataInventoryHistoryBackpackGroupBox.TabIndex = 7;
            this.blissHivePlayerDataInventoryHistoryBackpackGroupBox.TabStop = false;
            this.blissHivePlayerDataInventoryHistoryBackpackGroupBox.Text = "Backpack";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.blissHivePlayerDataInventoryHistoryBackpackListView);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(332, 310);
            this.panel1.TabIndex = 3;
            // 
            // blissHivePlayerDataInventoryHistoryBackpackListView
            // 
            this.blissHivePlayerDataInventoryHistoryBackpackListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3,
            this.columnHeader4});
            this.blissHivePlayerDataInventoryHistoryBackpackListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blissHivePlayerDataInventoryHistoryBackpackListView.Location = new System.Drawing.Point(0, 0);
            this.blissHivePlayerDataInventoryHistoryBackpackListView.Name = "blissHivePlayerDataInventoryHistoryBackpackListView";
            this.blissHivePlayerDataInventoryHistoryBackpackListView.Size = new System.Drawing.Size(332, 310);
            this.blissHivePlayerDataInventoryHistoryBackpackListView.TabIndex = 1;
            this.blissHivePlayerDataInventoryHistoryBackpackListView.UseCompatibleStateImageBehavior = false;
            this.blissHivePlayerDataInventoryHistoryBackpackListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Qnty";
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Item";
            this.columnHeader4.Width = 260;
            // 
            // blissHivePlayerDataInventoryHistoryInventoryGroupBox
            // 
            this.blissHivePlayerDataInventoryHistoryInventoryGroupBox.Controls.Add(this.panel2);
            this.blissHivePlayerDataInventoryHistoryInventoryGroupBox.Location = new System.Drawing.Point(3, 20);
            this.blissHivePlayerDataInventoryHistoryInventoryGroupBox.Name = "blissHivePlayerDataInventoryHistoryInventoryGroupBox";
            this.blissHivePlayerDataInventoryHistoryInventoryGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blissHivePlayerDataInventoryHistoryInventoryGroupBox.Size = new System.Drawing.Size(336, 329);
            this.blissHivePlayerDataInventoryHistoryInventoryGroupBox.TabIndex = 6;
            this.blissHivePlayerDataInventoryHistoryInventoryGroupBox.TabStop = false;
            this.blissHivePlayerDataInventoryHistoryInventoryGroupBox.Text = "Inventory";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.blissHivePlayerDataInventoryHistoryInventoryListView);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(3, 16);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(330, 310);
            this.panel2.TabIndex = 3;
            // 
            // blissHivePlayerDataInventoryHistoryInventoryListView
            // 
            this.blissHivePlayerDataInventoryHistoryInventoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6});
            this.blissHivePlayerDataInventoryHistoryInventoryListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blissHivePlayerDataInventoryHistoryInventoryListView.Location = new System.Drawing.Point(0, 0);
            this.blissHivePlayerDataInventoryHistoryInventoryListView.Name = "blissHivePlayerDataInventoryHistoryInventoryListView";
            this.blissHivePlayerDataInventoryHistoryInventoryListView.Size = new System.Drawing.Size(330, 310);
            this.blissHivePlayerDataInventoryHistoryInventoryListView.TabIndex = 0;
            this.blissHivePlayerDataInventoryHistoryInventoryListView.UseCompatibleStateImageBehavior = false;
            this.blissHivePlayerDataInventoryHistoryInventoryListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Qnty";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Item";
            this.columnHeader6.Width = 260;
            // 
            // blissHivePlayerDataTabDebugMonitorHistory
            // 
            this.blissHivePlayerDataTabDebugMonitorHistory.Controls.Add(this.blissHivePlayerDataDebugMonitorHistoryComboBox);
            this.blissHivePlayerDataTabDebugMonitorHistory.Controls.Add(this.blissHivePlayerDataDebugMonitorHistoryGroupBox);
            this.blissHivePlayerDataTabDebugMonitorHistory.Controls.Add(this.blissHivePlayerDataDebugMonitorHistorySelectLbl);
            this.blissHivePlayerDataTabDebugMonitorHistory.Location = new System.Drawing.Point(4, 22);
            this.blissHivePlayerDataTabDebugMonitorHistory.Name = "blissHivePlayerDataTabDebugMonitorHistory";
            this.blissHivePlayerDataTabDebugMonitorHistory.Size = new System.Drawing.Size(683, 352);
            this.blissHivePlayerDataTabDebugMonitorHistory.TabIndex = 5;
            this.blissHivePlayerDataTabDebugMonitorHistory.Text = "Debug Monitor History";
            this.blissHivePlayerDataTabDebugMonitorHistory.UseVisualStyleBackColor = true;
            // 
            // blissHivePlayerDataDebugMonitorHistoryComboBox
            // 
            this.blissHivePlayerDataDebugMonitorHistoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blissHivePlayerDataDebugMonitorHistoryComboBox.FormattingEnabled = true;
            this.blissHivePlayerDataDebugMonitorHistoryComboBox.Location = new System.Drawing.Point(119, 0);
            this.blissHivePlayerDataDebugMonitorHistoryComboBox.Name = "blissHivePlayerDataDebugMonitorHistoryComboBox";
            this.blissHivePlayerDataDebugMonitorHistoryComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blissHivePlayerDataDebugMonitorHistoryComboBox.Size = new System.Drawing.Size(152, 21);
            this.blissHivePlayerDataDebugMonitorHistoryComboBox.TabIndex = 11;
            // 
            // blissHivePlayerDataDebugMonitorHistoryGroupBox
            // 
            this.blissHivePlayerDataDebugMonitorHistoryGroupBox.Controls.Add(this.panel3);
            this.blissHivePlayerDataDebugMonitorHistoryGroupBox.Location = new System.Drawing.Point(3, 20);
            this.blissHivePlayerDataDebugMonitorHistoryGroupBox.Name = "blissHivePlayerDataDebugMonitorHistoryGroupBox";
            this.blissHivePlayerDataDebugMonitorHistoryGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blissHivePlayerDataDebugMonitorHistoryGroupBox.Size = new System.Drawing.Size(336, 329);
            this.blissHivePlayerDataDebugMonitorHistoryGroupBox.TabIndex = 12;
            this.blissHivePlayerDataDebugMonitorHistoryGroupBox.TabStop = false;
            this.blissHivePlayerDataDebugMonitorHistoryGroupBox.Text = "Debug Monitor";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.blissHivePlayerDataDebugMonitorHistoryListView);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(3, 16);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(330, 310);
            this.panel3.TabIndex = 3;
            // 
            // blissHivePlayerDataDebugMonitorHistoryListView
            // 
            this.blissHivePlayerDataDebugMonitorHistoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.blissHivePlayerDataDebugMonitorListViewNameColumn,
            this.blissHivePlayerDataDebugMonitorListViewValueColumn});
            this.blissHivePlayerDataDebugMonitorHistoryListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blissHivePlayerDataDebugMonitorHistoryListView.Location = new System.Drawing.Point(0, 0);
            this.blissHivePlayerDataDebugMonitorHistoryListView.Name = "blissHivePlayerDataDebugMonitorHistoryListView";
            this.blissHivePlayerDataDebugMonitorHistoryListView.Size = new System.Drawing.Size(330, 310);
            this.blissHivePlayerDataDebugMonitorHistoryListView.TabIndex = 0;
            this.blissHivePlayerDataDebugMonitorHistoryListView.UseCompatibleStateImageBehavior = false;
            this.blissHivePlayerDataDebugMonitorHistoryListView.View = System.Windows.Forms.View.Details;
            // 
            // blissHivePlayerDataDebugMonitorListViewNameColumn
            // 
            this.blissHivePlayerDataDebugMonitorListViewNameColumn.Text = "Name";
            this.blissHivePlayerDataDebugMonitorListViewNameColumn.Width = 158;
            // 
            // blissHivePlayerDataDebugMonitorListViewValueColumn
            // 
            this.blissHivePlayerDataDebugMonitorListViewValueColumn.Text = "Value";
            this.blissHivePlayerDataDebugMonitorListViewValueColumn.Width = 260;
            // 
            // blissHivePlayerDataDebugMonitorHistorySelectLbl
            // 
            this.blissHivePlayerDataDebugMonitorHistorySelectLbl.AutoSize = true;
            this.blissHivePlayerDataDebugMonitorHistorySelectLbl.Location = new System.Drawing.Point(6, 4);
            this.blissHivePlayerDataDebugMonitorHistorySelectLbl.Name = "blissHivePlayerDataDebugMonitorHistorySelectLbl";
            this.blissHivePlayerDataDebugMonitorHistorySelectLbl.Size = new System.Drawing.Size(107, 13);
            this.blissHivePlayerDataDebugMonitorHistorySelectLbl.TabIndex = 10;
            this.blissHivePlayerDataDebugMonitorHistorySelectLbl.Text = "Select debug monitor";
            // 
            // blissHivePlayerDataTabActivityLog
            // 
            this.blissHivePlayerDataTabActivityLog.Controls.Add(this.blissHiveActivityLog);
            this.blissHivePlayerDataTabActivityLog.Location = new System.Drawing.Point(4, 22);
            this.blissHivePlayerDataTabActivityLog.Name = "blissHivePlayerDataTabActivityLog";
            this.blissHivePlayerDataTabActivityLog.Size = new System.Drawing.Size(683, 352);
            this.blissHivePlayerDataTabActivityLog.TabIndex = 3;
            this.blissHivePlayerDataTabActivityLog.Tag = "activity";
            this.blissHivePlayerDataTabActivityLog.Text = "Activity Log";
            this.blissHivePlayerDataTabActivityLog.UseVisualStyleBackColor = true;
            // 
            // blissHiveActivityLog
            // 
            this.blissHiveActivityLog.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.blissHiveActivityLog.Location = new System.Drawing.Point(1, 1);
            this.blissHiveActivityLog.Name = "blissHiveActivityLog";
            this.blissHiveActivityLog.Size = new System.Drawing.Size(681, 351);
            this.blissHiveActivityLog.TabIndex = 1;
            this.blissHiveActivityLog.UseCompatibleStateImageBehavior = false;
            this.blissHiveActivityLog.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Timestamp";
            this.columnHeader1.Width = 120;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "What happened?";
            this.columnHeader2.Width = 620;
            // 
            // blissHiveCardControlObjectTab
            // 
            this.blissHiveCardControlObjectTab.BackColor = System.Drawing.Color.Transparent;
            this.blissHiveCardControlObjectTab.Controls.Add(this.blissHiveObjectDataTabControl);
            this.blissHiveCardControlObjectTab.Location = new System.Drawing.Point(4, 8);
            this.blissHiveCardControlObjectTab.Name = "blissHiveCardControlObjectTab";
            this.blissHiveCardControlObjectTab.Padding = new System.Windows.Forms.Padding(3);
            this.blissHiveCardControlObjectTab.Size = new System.Drawing.Size(692, 375);
            this.blissHiveCardControlObjectTab.TabIndex = 1;
            this.blissHiveCardControlObjectTab.Text = "Object Controls";
            // 
            // blissHiveObjectDataTabControl
            // 
            this.blissHiveObjectDataTabControl.Controls.Add(this.blissHiveObjectDataFormattedLogDataTab);
            this.blissHiveObjectDataTabControl.Controls.Add(this.blissHiveObjectDataRawLogDataTab);
            this.blissHiveObjectDataTabControl.Controls.Add(this.blissHiveObjectDataInventoryTab);
            this.blissHiveObjectDataTabControl.Controls.Add(this.blissHiveObjectDataHealthTab);
            this.blissHiveObjectDataTabControl.Controls.Add(this.blissHiveObjectDataActivityLogTab);
            this.blissHiveObjectDataTabControl.Location = new System.Drawing.Point(1, 0);
            this.blissHiveObjectDataTabControl.Name = "blissHiveObjectDataTabControl";
            this.blissHiveObjectDataTabControl.SelectedIndex = 0;
            this.blissHiveObjectDataTabControl.Size = new System.Drawing.Size(691, 378);
            this.blissHiveObjectDataTabControl.TabIndex = 3;
            this.blissHiveObjectDataTabControl.Tag = "";
            // 
            // blissHiveObjectDataFormattedLogDataTab
            // 
            this.blissHiveObjectDataFormattedLogDataTab.Controls.Add(this.blissHiveObjectDataFormattedLogDataListView);
            this.blissHiveObjectDataFormattedLogDataTab.Location = new System.Drawing.Point(4, 22);
            this.blissHiveObjectDataFormattedLogDataTab.Name = "blissHiveObjectDataFormattedLogDataTab";
            this.blissHiveObjectDataFormattedLogDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.blissHiveObjectDataFormattedLogDataTab.Size = new System.Drawing.Size(683, 352);
            this.blissHiveObjectDataFormattedLogDataTab.TabIndex = 0;
            this.blissHiveObjectDataFormattedLogDataTab.Tag = "formattedLogData";
            this.blissHiveObjectDataFormattedLogDataTab.Text = "Formatted Log Data";
            this.blissHiveObjectDataFormattedLogDataTab.UseVisualStyleBackColor = true;
            // 
            // blissHiveObjectDataFormattedLogDataListView
            // 
            this.blissHiveObjectDataFormattedLogDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader8,
            this.columnHeader9});
            this.blissHiveObjectDataFormattedLogDataListView.Location = new System.Drawing.Point(0, 0);
            this.blissHiveObjectDataFormattedLogDataListView.Name = "blissHiveObjectDataFormattedLogDataListView";
            this.blissHiveObjectDataFormattedLogDataListView.Size = new System.Drawing.Size(681, 351);
            this.blissHiveObjectDataFormattedLogDataListView.TabIndex = 0;
            this.blissHiveObjectDataFormattedLogDataListView.UseCompatibleStateImageBehavior = false;
            this.blissHiveObjectDataFormattedLogDataListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Timestamp";
            this.columnHeader7.Width = 120;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Function Name";
            this.columnHeader8.Width = 120;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Parameters";
            this.columnHeader9.Width = 415;
            // 
            // blissHiveObjectDataRawLogDataTab
            // 
            this.blissHiveObjectDataRawLogDataTab.Controls.Add(this.blissHiveObjectDataRawLogDataTextBox);
            this.blissHiveObjectDataRawLogDataTab.Location = new System.Drawing.Point(4, 22);
            this.blissHiveObjectDataRawLogDataTab.Name = "blissHiveObjectDataRawLogDataTab";
            this.blissHiveObjectDataRawLogDataTab.Padding = new System.Windows.Forms.Padding(3);
            this.blissHiveObjectDataRawLogDataTab.Size = new System.Drawing.Size(683, 352);
            this.blissHiveObjectDataRawLogDataTab.TabIndex = 1;
            this.blissHiveObjectDataRawLogDataTab.Tag = "rawLogData";
            this.blissHiveObjectDataRawLogDataTab.Text = "Raw Log Data";
            this.blissHiveObjectDataRawLogDataTab.UseVisualStyleBackColor = true;
            // 
            // blissHiveObjectDataRawLogDataTextBox
            // 
            this.blissHiveObjectDataRawLogDataTextBox.Location = new System.Drawing.Point(0, 0);
            this.blissHiveObjectDataRawLogDataTextBox.MaxLength = 2147483647;
            this.blissHiveObjectDataRawLogDataTextBox.Multiline = true;
            this.blissHiveObjectDataRawLogDataTextBox.Name = "blissHiveObjectDataRawLogDataTextBox";
            this.blissHiveObjectDataRawLogDataTextBox.ReadOnly = true;
            this.blissHiveObjectDataRawLogDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.blissHiveObjectDataRawLogDataTextBox.Size = new System.Drawing.Size(681, 351);
            this.blissHiveObjectDataRawLogDataTextBox.TabIndex = 0;
            this.blissHiveObjectDataRawLogDataTextBox.WordWrap = false;
            // 
            // blissHiveObjectDataInventoryTab
            // 
            this.blissHiveObjectDataInventoryTab.Controls.Add(this.blissHiveObjectDataInventoryHistoryComboBox);
            this.blissHiveObjectDataInventoryTab.Controls.Add(this.blissHiveObjectDataInventoryHistorySelectLbl);
            this.blissHiveObjectDataInventoryTab.Controls.Add(this.blissHiveObjectDataInventoryHistoryBackpackGroupBox);
            this.blissHiveObjectDataInventoryTab.Controls.Add(this.blissHiveObjectDataInventoryHistoryInventoryGroupBox);
            this.blissHiveObjectDataInventoryTab.Location = new System.Drawing.Point(4, 22);
            this.blissHiveObjectDataInventoryTab.Name = "blissHiveObjectDataInventoryTab";
            this.blissHiveObjectDataInventoryTab.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.blissHiveObjectDataInventoryTab.Size = new System.Drawing.Size(683, 352);
            this.blissHiveObjectDataInventoryTab.TabIndex = 4;
            this.blissHiveObjectDataInventoryTab.Text = "Inventory History";
            this.blissHiveObjectDataInventoryTab.UseVisualStyleBackColor = true;
            // 
            // blissHiveObjectDataInventoryHistorySelectBox
            // 
            this.blissHiveObjectDataInventoryHistoryComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blissHiveObjectDataInventoryHistoryComboBox.FormattingEnabled = true;
            this.blissHiveObjectDataInventoryHistoryComboBox.Location = new System.Drawing.Point(119, 0);
            this.blissHiveObjectDataInventoryHistoryComboBox.Name = "blissHiveObjectDataInventoryHistorySelectBox";
            this.blissHiveObjectDataInventoryHistoryComboBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blissHiveObjectDataInventoryHistoryComboBox.Size = new System.Drawing.Size(152, 21);
            this.blissHiveObjectDataInventoryHistoryComboBox.TabIndex = 9;
            // 
            // blissHiveObjectDataInventoryHistorySelectLbl
            // 
            this.blissHiveObjectDataInventoryHistorySelectLbl.AutoSize = true;
            this.blissHiveObjectDataInventoryHistorySelectLbl.Location = new System.Drawing.Point(6, 4);
            this.blissHiveObjectDataInventoryHistorySelectLbl.Name = "blissHiveObjectDataInventoryHistorySelectLbl";
            this.blissHiveObjectDataInventoryHistorySelectLbl.Size = new System.Drawing.Size(83, 13);
            this.blissHiveObjectDataInventoryHistorySelectLbl.TabIndex = 8;
            this.blissHiveObjectDataInventoryHistorySelectLbl.Text = "Select inventory";
            // 
            // blissHiveObjectDataInventoryHistoryBackpackGroupBox
            // 
            this.blissHiveObjectDataInventoryHistoryBackpackGroupBox.Controls.Add(this.panel4);
            this.blissHiveObjectDataInventoryHistoryBackpackGroupBox.Location = new System.Drawing.Point(342, 20);
            this.blissHiveObjectDataInventoryHistoryBackpackGroupBox.Name = "blissHiveObjectDataInventoryHistoryBackpackGroupBox";
            this.blissHiveObjectDataInventoryHistoryBackpackGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blissHiveObjectDataInventoryHistoryBackpackGroupBox.Size = new System.Drawing.Size(338, 329);
            this.blissHiveObjectDataInventoryHistoryBackpackGroupBox.TabIndex = 7;
            this.blissHiveObjectDataInventoryHistoryBackpackGroupBox.TabStop = false;
            this.blissHiveObjectDataInventoryHistoryBackpackGroupBox.Text = "Backpack";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.blissHiveObjectDataInventoryHistoryBackpackListView);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(3, 16);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(332, 310);
            this.panel4.TabIndex = 3;
            // 
            // blissHiveObjectDataInventoryHistoryBackpackListView
            // 
            this.blissHiveObjectDataInventoryHistoryBackpackListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader10,
            this.columnHeader11});
            this.blissHiveObjectDataInventoryHistoryBackpackListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blissHiveObjectDataInventoryHistoryBackpackListView.Location = new System.Drawing.Point(0, 0);
            this.blissHiveObjectDataInventoryHistoryBackpackListView.Name = "blissHiveObjectDataInventoryHistoryBackpackListView";
            this.blissHiveObjectDataInventoryHistoryBackpackListView.Size = new System.Drawing.Size(332, 310);
            this.blissHiveObjectDataInventoryHistoryBackpackListView.TabIndex = 1;
            this.blissHiveObjectDataInventoryHistoryBackpackListView.UseCompatibleStateImageBehavior = false;
            this.blissHiveObjectDataInventoryHistoryBackpackListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Qnty";
            // 
            // columnHeader11
            // 
            this.columnHeader11.Text = "Item";
            this.columnHeader11.Width = 260;
            // 
            // blissHiveObjectDataInventoryHistoryInventoryGroupBox
            // 
            this.blissHiveObjectDataInventoryHistoryInventoryGroupBox.Controls.Add(this.panel5);
            this.blissHiveObjectDataInventoryHistoryInventoryGroupBox.Location = new System.Drawing.Point(3, 20);
            this.blissHiveObjectDataInventoryHistoryInventoryGroupBox.Name = "blissHiveObjectDataInventoryHistoryInventoryGroupBox";
            this.blissHiveObjectDataInventoryHistoryInventoryGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blissHiveObjectDataInventoryHistoryInventoryGroupBox.Size = new System.Drawing.Size(336, 329);
            this.blissHiveObjectDataInventoryHistoryInventoryGroupBox.TabIndex = 6;
            this.blissHiveObjectDataInventoryHistoryInventoryGroupBox.TabStop = false;
            this.blissHiveObjectDataInventoryHistoryInventoryGroupBox.Text = "Inventory";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.blissHiveObjectDataInventoryHistoryInventoryListView);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(3, 16);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 310);
            this.panel5.TabIndex = 3;
            // 
            // blissHiveObjectDataInventoryHistoryInventoryListView
            // 
            this.blissHiveObjectDataInventoryHistoryInventoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader12,
            this.columnHeader13});
            this.blissHiveObjectDataInventoryHistoryInventoryListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blissHiveObjectDataInventoryHistoryInventoryListView.Location = new System.Drawing.Point(0, 0);
            this.blissHiveObjectDataInventoryHistoryInventoryListView.Name = "blissHiveObjectDataInventoryHistoryInventoryListView";
            this.blissHiveObjectDataInventoryHistoryInventoryListView.Size = new System.Drawing.Size(330, 310);
            this.blissHiveObjectDataInventoryHistoryInventoryListView.TabIndex = 0;
            this.blissHiveObjectDataInventoryHistoryInventoryListView.UseCompatibleStateImageBehavior = false;
            this.blissHiveObjectDataInventoryHistoryInventoryListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "Qnty";
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "Item";
            this.columnHeader13.Width = 260;
            // 
            // blissHiveObjectDataHealthTab
            // 
            this.blissHiveObjectDataHealthTab.Controls.Add(this.blissHiveObjectDataHealthTypeEstimateTextBox);
            this.blissHiveObjectDataHealthTab.Controls.Add(this.blissHiveObjectDataHealthTypeEstimateLbl);
            this.blissHiveObjectDataHealthTab.Controls.Add(this.blissHiveObjectDataHealthGroupBox);
            this.blissHiveObjectDataHealthTab.Location = new System.Drawing.Point(4, 22);
            this.blissHiveObjectDataHealthTab.Name = "blissHiveObjectDataHealthTab";
            this.blissHiveObjectDataHealthTab.Size = new System.Drawing.Size(683, 352);
            this.blissHiveObjectDataHealthTab.TabIndex = 5;
            this.blissHiveObjectDataHealthTab.Text = "Health";
            this.blissHiveObjectDataHealthTab.UseVisualStyleBackColor = true;
            // 
            // blissHiveObjectDataHealthGroupBox
            // 
            this.blissHiveObjectDataHealthGroupBox.Controls.Add(this.panel6);
            this.blissHiveObjectDataHealthGroupBox.Location = new System.Drawing.Point(3, 3);
            this.blissHiveObjectDataHealthGroupBox.Name = "blissHiveObjectDataHealthGroupBox";
            this.blissHiveObjectDataHealthGroupBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.blissHiveObjectDataHealthGroupBox.Size = new System.Drawing.Size(336, 346);
            this.blissHiveObjectDataHealthGroupBox.TabIndex = 12;
            this.blissHiveObjectDataHealthGroupBox.TabStop = false;
            this.blissHiveObjectDataHealthGroupBox.Text = "Health";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.blissHiveObjectDataHealthListView);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(3, 16);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(330, 327);
            this.panel6.TabIndex = 3;
            // 
            // blissHiveObjectDataHealthListView
            // 
            this.blissHiveObjectDataHealthListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader14,
            this.columnHeader15});
            this.blissHiveObjectDataHealthListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blissHiveObjectDataHealthListView.Location = new System.Drawing.Point(0, 0);
            this.blissHiveObjectDataHealthListView.Name = "blissHiveObjectDataHealthListView";
            this.blissHiveObjectDataHealthListView.Size = new System.Drawing.Size(330, 327);
            this.blissHiveObjectDataHealthListView.TabIndex = 0;
            this.blissHiveObjectDataHealthListView.UseCompatibleStateImageBehavior = false;
            this.blissHiveObjectDataHealthListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "Name";
            this.columnHeader14.Width = 158;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "Value";
            this.columnHeader15.Width = 260;
            // 
            // blissHiveObjectDataActivityLogTab
            // 
            this.blissHiveObjectDataActivityLogTab.Controls.Add(this.blissHiveObjectDataActivityLogListView);
            this.blissHiveObjectDataActivityLogTab.Location = new System.Drawing.Point(4, 22);
            this.blissHiveObjectDataActivityLogTab.Name = "blissHiveObjectDataActivityLogTab";
            this.blissHiveObjectDataActivityLogTab.Size = new System.Drawing.Size(683, 352);
            this.blissHiveObjectDataActivityLogTab.TabIndex = 3;
            this.blissHiveObjectDataActivityLogTab.Tag = "activity";
            this.blissHiveObjectDataActivityLogTab.Text = "Activity Log";
            this.blissHiveObjectDataActivityLogTab.UseVisualStyleBackColor = true;
            // 
            // blissHiveObjectDataActivityLogListView
            // 
            this.blissHiveObjectDataActivityLogListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader16,
            this.columnHeader17});
            this.blissHiveObjectDataActivityLogListView.Location = new System.Drawing.Point(1, 1);
            this.blissHiveObjectDataActivityLogListView.Name = "blissHiveObjectDataActivityLogListView";
            this.blissHiveObjectDataActivityLogListView.Size = new System.Drawing.Size(681, 351);
            this.blissHiveObjectDataActivityLogListView.TabIndex = 1;
            this.blissHiveObjectDataActivityLogListView.UseCompatibleStateImageBehavior = false;
            this.blissHiveObjectDataActivityLogListView.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader16
            // 
            this.columnHeader16.Text = "Timestamp";
            this.columnHeader16.Width = 120;
            // 
            // columnHeader17
            // 
            this.columnHeader17.Text = "What happened?";
            this.columnHeader17.Width = 620;
            // 
            // blissHiveProgressTimeRemainingLbl
            // 
            this.blissHiveProgressTimeRemainingLbl.AutoSize = true;
            this.blissHiveProgressTimeRemainingLbl.Location = new System.Drawing.Point(785, 30);
            this.blissHiveProgressTimeRemainingLbl.Name = "blissHiveProgressTimeRemainingLbl";
            this.blissHiveProgressTimeRemainingLbl.Size = new System.Drawing.Size(0, 13);
            this.blissHiveProgressTimeRemainingLbl.TabIndex = 9;
            // 
            // blissHiveFetchMinutesTF
            // 
            this.blissHiveFetchMinutesTF.Location = new System.Drawing.Point(93, 4);
            this.blissHiveFetchMinutesTF.Name = "blissHiveFetchMinutesTF";
            this.blissHiveFetchMinutesTF.Size = new System.Drawing.Size(42, 20);
            this.blissHiveFetchMinutesTF.TabIndex = 8;
            this.blissHiveFetchMinutesTF.TextChanged += new System.EventHandler(this.BlisshiveFetchMinutesTF_TextChanged);
            // 
            // blissHivePlayerName
            // 
            this.blissHivePlayerName.AutoSize = true;
            this.blissHivePlayerName.Location = new System.Drawing.Point(234, 30);
            this.blissHivePlayerName.Name = "blissHivePlayerName";
            this.blissHivePlayerName.Size = new System.Drawing.Size(231, 13);
            this.blissHivePlayerName.TabIndex = 1;
            this.blissHivePlayerName.Text = "Get stated by downloading or opening a log file.";
            // 
            // blissHiveDownloadProgressBar
            // 
            this.blissHiveDownloadProgressBar.Location = new System.Drawing.Point(313, 3);
            this.blissHiveDownloadProgressBar.Name = "blissHiveDownloadProgressBar";
            this.blissHiveDownloadProgressBar.Size = new System.Drawing.Size(608, 23);
            this.blissHiveDownloadProgressBar.TabIndex = 5;
            // 
            // blissHiveLogFetchTimeDropdown
            // 
            this.blissHiveLogFetchTimeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blissHiveLogFetchTimeDropdown.FormattingEnabled = true;
            this.blissHiveLogFetchTimeDropdown.Items.AddRange(new object[] {
            "Minutes",
            "Hours"});
            this.blissHiveLogFetchTimeDropdown.Location = new System.Drawing.Point(141, 3);
            this.blissHiveLogFetchTimeDropdown.Name = "blissHiveLogFetchTimeDropdown";
            this.blissHiveLogFetchTimeDropdown.Size = new System.Drawing.Size(84, 21);
            this.blissHiveLogFetchTimeDropdown.TabIndex = 6;
            // 
            // blissHiveFetchLogLbl
            // 
            this.blissHiveFetchLogLbl.AutoSize = true;
            this.blissHiveFetchLogLbl.Location = new System.Drawing.Point(6, 8);
            this.blissHiveFetchLogLbl.Name = "blissHiveFetchLogLbl";
            this.blissHiveFetchLogLbl.Size = new System.Drawing.Size(80, 13);
            this.blissHiveFetchLogLbl.TabIndex = 3;
            this.blissHiveFetchLogLbl.Text = "Fetch log every";
            // 
            // warningPanel
            // 
            this.warningPanel.Location = new System.Drawing.Point(950, 28);
            this.warningPanel.Name = "warningPanel";
            this.warningPanel.Size = new System.Drawing.Size(200, 434);
            this.warningPanel.TabIndex = 4;
            // 
            // warningsLbl
            // 
            this.warningsLbl.AutoSize = true;
            this.warningsLbl.Location = new System.Drawing.Point(950, 9);
            this.warningsLbl.Name = "warningsLbl";
            this.warningsLbl.Size = new System.Drawing.Size(52, 13);
            this.warningsLbl.TabIndex = 5;
            this.warningsLbl.Text = "Warnings";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusText1,
            this.toolStripStatusText2});
            this.statusStrip.Location = new System.Drawing.Point(0, 489);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1155, 22);
            this.statusStrip.TabIndex = 6;
            this.statusStrip.Text = "Just a test text";
            // 
            // toolStripStatusText1
            // 
            this.toolStripStatusText1.Name = "toolStripStatusText1";
            this.toolStripStatusText1.Size = new System.Drawing.Size(0, 17);
            // 
            // toolStripStatusText2
            // 
            this.toolStripStatusText2.Name = "toolStripStatusText2";
            this.toolStripStatusText2.Size = new System.Drawing.Size(0, 17);
            // 
            // blissHiveObjectDataHealthTypeEstimateLbl
            // 
            this.blissHiveObjectDataHealthTypeEstimateLbl.AutoSize = true;
            this.blissHiveObjectDataHealthTypeEstimateLbl.Location = new System.Drawing.Point(346, 4);
            this.blissHiveObjectDataHealthTypeEstimateLbl.Name = "blissHiveObjectDataHealthTypeEstimateLbl";
            this.blissHiveObjectDataHealthTypeEstimateLbl.Size = new System.Drawing.Size(229, 13);
            this.blissHiveObjectDataHealthTypeEstimateLbl.TabIndex = 13;
            this.blissHiveObjectDataHealthTypeEstimateLbl.Text = "This object is one of the following vehicle types";
            // 
            // blissHiveObjectDataHealthTypeEstimateTextBox
            // 
            this.blissHiveObjectDataHealthTypeEstimateTextBox.Location = new System.Drawing.Point(349, 21);
            this.blissHiveObjectDataHealthTypeEstimateTextBox.Multiline = true;
            this.blissHiveObjectDataHealthTypeEstimateTextBox.Name = "blissHiveObjectDataHealthTypeEstimateTextBox";
            this.blissHiveObjectDataHealthTypeEstimateTextBox.ReadOnly = true;
            this.blissHiveObjectDataHealthTypeEstimateTextBox.Size = new System.Drawing.Size(331, 325);
            this.blissHiveObjectDataHealthTypeEstimateTextBox.TabIndex = 14;
            // 
            // DayzLogParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 511);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.warningsLbl);
            this.Controls.Add(this.warningPanel);
            this.Controls.Add(this.logfilesTabControl);
            this.MaximumSize = new System.Drawing.Size(1171, 549);
            this.Menu = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(1171, 549);
            this.Name = "DayzLogParserForm";
            this.Text = "Dayz Log Parser";
            this.logfilesTabControl.ResumeLayout(false);
            this.blissHiveTab.ResumeLayout(false);
            this.blissHiveTab.PerformLayout();
            this.blissHiveCardControl.ResumeLayout(false);
            this.blissHiveCardControlPlayerTab.ResumeLayout(false);
            this.blissHivePlayerDataPanel.ResumeLayout(false);
            this.blissHivePlayerDataTabControl.ResumeLayout(false);
            this.blissHivePlayerDataTabFormattedData.ResumeLayout(false);
            this.blissHivePlayerDataTabRawLogData.ResumeLayout(false);
            this.blissHivePlayerDataTabRawLogData.PerformLayout();
            this.blissHivePlayerDataTabInventoryHistory.ResumeLayout(false);
            this.blissHivePlayerDataTabInventoryHistory.PerformLayout();
            this.blissHivePlayerDataInventoryHistoryBackpackGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.blissHivePlayerDataInventoryHistoryInventoryGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.blissHivePlayerDataTabDebugMonitorHistory.ResumeLayout(false);
            this.blissHivePlayerDataTabDebugMonitorHistory.PerformLayout();
            this.blissHivePlayerDataDebugMonitorHistoryGroupBox.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.blissHivePlayerDataTabActivityLog.ResumeLayout(false);
            this.blissHiveCardControlObjectTab.ResumeLayout(false);
            this.blissHiveObjectDataTabControl.ResumeLayout(false);
            this.blissHiveObjectDataFormattedLogDataTab.ResumeLayout(false);
            this.blissHiveObjectDataRawLogDataTab.ResumeLayout(false);
            this.blissHiveObjectDataRawLogDataTab.PerformLayout();
            this.blissHiveObjectDataInventoryTab.ResumeLayout(false);
            this.blissHiveObjectDataInventoryTab.PerformLayout();
            this.blissHiveObjectDataInventoryHistoryBackpackGroupBox.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.blissHiveObjectDataInventoryHistoryInventoryGroupBox.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.blissHiveObjectDataHealthTab.ResumeLayout(false);
            this.blissHiveObjectDataHealthTab.PerformLayout();
            this.blissHiveObjectDataHealthGroupBox.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.blissHiveObjectDataActivityLogTab.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TreeView blissHiveTree;
        public System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        public System.Windows.Forms.MainMenu mainMenu;
        public System.Windows.Forms.MenuItem fileMenuItem;
        public System.Windows.Forms.MenuItem exitMenuItem;
        public System.Windows.Forms.Button blissHiveDownloadLogBtn;
        public System.Windows.Forms.TabControl logfilesTabControl;
        public System.Windows.Forms.TabPage blissHiveTab;
        public System.Windows.Forms.ComboBox blissHiveLogFetchTimeDropdown;
        public System.Windows.Forms.ProgressBar blissHiveDownloadProgressBar;
        public System.Windows.Forms.Label blissHiveFetchLogLbl;
        public System.Windows.Forms.MenuItem optionsMenuItem;
        public System.Windows.Forms.Panel blissHivePlayerDataPanel;
        public System.Windows.Forms.Label blissHivePlayerName;
        public System.Windows.Forms.Panel warningPanel;
        public System.Windows.Forms.Label warningsLbl;
        // public IntTextBox blisshiveFetchMinutesTF;
        public System.Windows.Forms.StatusStrip statusStrip;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusText1;
        public System.Windows.Forms.ToolStripStatusLabel toolStripStatusText2;
        public IntTextBox blissHiveFetchMinutesTF;
        private System.Windows.Forms.TabPage blissHivePlayerDataTabFormattedData;
        private System.Windows.Forms.TabPage blissHivePlayerDataTabRawLogData;
        private System.Windows.Forms.ColumnHeader blissHivePlayerDataFormattedDataTimeColumn;
        private System.Windows.Forms.ColumnHeader blissHivePlayerDataFormattedDataFunctionColumn;
        private System.Windows.Forms.ColumnHeader blissHivePlayerDataFormattedDataParameterColumn;
        private System.Windows.Forms.MenuItem openBlissHiveMenuItem;
        private System.Windows.Forms.MenuItem exitSeperator;
        private System.Windows.Forms.TabPage blissHivePlayerDataTabActivityLog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        public System.Windows.Forms.TabControl blissHivePlayerDataTabControl;
        public System.Windows.Forms.ListView blissHivePlayerDataFormattedLogDataListView;
        public System.Windows.Forms.TextBox blissHivePlayerDataRawLogDataTextBox;
        private System.Windows.Forms.TabPage blissHivePlayerDataTabInventoryHistory;
        private System.Windows.Forms.GroupBox blissHivePlayerDataInventoryHistoryBackpackGroupBox;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ListView blissHivePlayerDataInventoryHistoryBackpackListView;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.GroupBox blissHivePlayerDataInventoryHistoryInventoryGroupBox;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.ListView blissHivePlayerDataInventoryHistoryInventoryListView;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.Label blissHivePlayerDataInventoryHistorySelectLbl;
        public System.Windows.Forms.ComboBox blissHivePlayerDataInventoryHistoryComboBox;
        public System.Windows.Forms.Label blissHiveProgressTimeRemainingLbl;
        public System.Windows.Forms.ListView blissHiveActivityLog;
        private System.Windows.Forms.TabPage blissHivePlayerDataTabDebugMonitorHistory;
        private System.Windows.Forms.GroupBox blissHivePlayerDataDebugMonitorHistoryGroupBox;
        private System.Windows.Forms.Panel panel3;
        public System.Windows.Forms.ListView blissHivePlayerDataDebugMonitorHistoryListView;
        private System.Windows.Forms.ColumnHeader blissHivePlayerDataDebugMonitorListViewNameColumn;
        private System.Windows.Forms.ColumnHeader blissHivePlayerDataDebugMonitorListViewValueColumn;
        public System.Windows.Forms.ComboBox blissHivePlayerDataDebugMonitorHistoryComboBox;
        private System.Windows.Forms.Label blissHivePlayerDataDebugMonitorHistorySelectLbl;
        private System.Windows.Forms.TabPage blissHiveCardControlPlayerTab;
        private System.Windows.Forms.TabPage blissHiveCardControlObjectTab;
        public System.Windows.Forms.TabControl blissHiveCardControl;
        public System.Windows.Forms.TabControl blissHiveObjectDataTabControl;
        private System.Windows.Forms.TabPage blissHiveObjectDataFormattedLogDataTab;
        public System.Windows.Forms.ListView blissHiveObjectDataFormattedLogDataListView;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.TabPage blissHiveObjectDataRawLogDataTab;
        public System.Windows.Forms.TextBox blissHiveObjectDataRawLogDataTextBox;
        private System.Windows.Forms.TabPage blissHiveObjectDataInventoryTab;
        public System.Windows.Forms.ComboBox blissHiveObjectDataInventoryHistoryComboBox;
        private System.Windows.Forms.Label blissHiveObjectDataInventoryHistorySelectLbl;
        private System.Windows.Forms.GroupBox blissHiveObjectDataInventoryHistoryBackpackGroupBox;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.ListView blissHiveObjectDataInventoryHistoryBackpackListView;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.ColumnHeader columnHeader11;
        private System.Windows.Forms.GroupBox blissHiveObjectDataInventoryHistoryInventoryGroupBox;
        private System.Windows.Forms.Panel panel5;
        public System.Windows.Forms.ListView blissHiveObjectDataInventoryHistoryInventoryListView;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.TabPage blissHiveObjectDataHealthTab;
        private System.Windows.Forms.GroupBox blissHiveObjectDataHealthGroupBox;
        private System.Windows.Forms.Panel panel6;
        public System.Windows.Forms.ListView blissHiveObjectDataHealthListView;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.TabPage blissHiveObjectDataActivityLogTab;
        public System.Windows.Forms.ListView blissHiveObjectDataActivityLogListView;
        private System.Windows.Forms.ColumnHeader columnHeader16;
        private System.Windows.Forms.ColumnHeader columnHeader17;
        public System.Windows.Forms.TextBox blissHiveObjectDataHealthTypeEstimateTextBox;
        private System.Windows.Forms.Label blissHiveObjectDataHealthTypeEstimateLbl;
    }
}

