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
            this.blissHivePlayerTree = new System.Windows.Forms.TreeView();
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
            this.blisshiveFetchMinutesTF = new DayzLogParser.UI.IntTextBox();
            this.blissHivePlayerName = new System.Windows.Forms.Label();
            this.blissHivePlayerDataPanel = new System.Windows.Forms.Panel();
            this.blissHivePlayerDataTabControl = new System.Windows.Forms.TabControl();
            this.blissHivePlayerDataTabFormattedData = new System.Windows.Forms.TabPage();
            this.blissHiveFormattedLogDataListView = new System.Windows.Forms.ListView();
            this.blissHivePlayerDataFormattedDataTimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHivePlayerDataFormattedDataFunctionColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHivePlayerDataFormattedDataParameterColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHivePlayerDataTabRawLogData = new System.Windows.Forms.TabPage();
            this.blissHiveRawLogDataTextBox = new System.Windows.Forms.TextBox();
            this.blissHivePlayerDataTabInventory = new System.Windows.Forms.TabPage();
            this.blissHiveInventoryBackpackGroupBox = new System.Windows.Forms.GroupBox();
            this.blissHiveInventoryBackpackPanel = new System.Windows.Forms.Panel();
            this.blissHivePlayerDataInventoryBackpackListView = new System.Windows.Forms.ListView();
            this.blissHiveInventoryBackpackQuantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHiveInventoryBackpackItemColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHiveInventoryInventoryGroupBox = new System.Windows.Forms.GroupBox();
            this.blissHiveInventoryInventoryPanel = new System.Windows.Forms.Panel();
            this.blissHivePlayerDataInventoryInventoryListView = new System.Windows.Forms.ListView();
            this.blissHiveInventoryInventoryQuantityColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHiveInventoryInventoryItem = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
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
            this.blissHivePlayerDataTabActivityLog = new System.Windows.Forms.TabPage();
            this.blissHiveActivityLog = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.blissHiveDownloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.blissHiveLogFetchTimeDropdown = new System.Windows.Forms.ComboBox();
            this.blissHiveFetchLogLbl = new System.Windows.Forms.Label();
            this.warningPanel = new System.Windows.Forms.Panel();
            this.warningsLbl = new System.Windows.Forms.Label();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusText1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusText2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.logfilesTabControl.SuspendLayout();
            this.blissHiveTab.SuspendLayout();
            this.blissHivePlayerDataPanel.SuspendLayout();
            this.blissHivePlayerDataTabControl.SuspendLayout();
            this.blissHivePlayerDataTabFormattedData.SuspendLayout();
            this.blissHivePlayerDataTabRawLogData.SuspendLayout();
            this.blissHivePlayerDataTabInventory.SuspendLayout();
            this.blissHiveInventoryBackpackGroupBox.SuspendLayout();
            this.blissHiveInventoryBackpackPanel.SuspendLayout();
            this.blissHiveInventoryInventoryGroupBox.SuspendLayout();
            this.blissHiveInventoryInventoryPanel.SuspendLayout();
            this.blissHivePlayerDataTabInventoryHistory.SuspendLayout();
            this.blissHivePlayerDataInventoryHistoryBackpackGroupBox.SuspendLayout();
            this.panel1.SuspendLayout();
            this.blissHivePlayerDataInventoryHistoryInventoryGroupBox.SuspendLayout();
            this.panel2.SuspendLayout();
            this.blissHivePlayerDataTabActivityLog.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // blissHivePlayerTree
            // 
            this.blissHivePlayerTree.Location = new System.Drawing.Point(6, 30);
            this.blissHivePlayerTree.Name = "blissHivePlayerTree";
            treeNode1.Name = "blisshiveTreeNodeOnline";
            treeNode1.Tag = "onlineSurvivors";
            treeNode1.Text = "Online";
            treeNode2.Name = "blisshiveTreeNodeOffline";
            treeNode2.Tag = "offlineSurvivors";
            treeNode2.Text = "Offline";
            treeNode3.ForeColor = System.Drawing.Color.Black;
            treeNode3.Name = "blisshiveTreeNodePlayers";
            treeNode3.Text = "Survivors";
            treeNode4.Name = "blisshiveTreeNodeObjects";
            treeNode4.Text = "Objects";
            this.blissHivePlayerTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3,
            treeNode4});
            this.blissHivePlayerTree.Size = new System.Drawing.Size(219, 396);
            this.blissHivePlayerTree.TabIndex = 1;
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
            this.blissHiveTab.Controls.Add(this.blisshiveFetchMinutesTF);
            this.blissHiveTab.Controls.Add(this.blissHivePlayerName);
            this.blissHiveTab.Controls.Add(this.blissHivePlayerDataPanel);
            this.blissHiveTab.Controls.Add(this.blissHiveDownloadProgressBar);
            this.blissHiveTab.Controls.Add(this.blissHiveLogFetchTimeDropdown);
            this.blissHiveTab.Controls.Add(this.blissHiveFetchLogLbl);
            this.blissHiveTab.Controls.Add(this.blissHivePlayerTree);
            this.blissHiveTab.Controls.Add(this.blissHiveDownloadLogBtn);
            this.blissHiveTab.Location = new System.Drawing.Point(4, 22);
            this.blissHiveTab.Name = "blissHiveTab";
            this.blissHiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.blissHiveTab.Size = new System.Drawing.Size(927, 432);
            this.blissHiveTab.TabIndex = 0;
            this.blissHiveTab.Text = "blisshive.log";
            this.blissHiveTab.UseVisualStyleBackColor = true;
            // 
            // blisshiveFetchMinutesTF
            // 
            this.blisshiveFetchMinutesTF.Location = new System.Drawing.Point(93, 4);
            this.blisshiveFetchMinutesTF.Name = "blisshiveFetchMinutesTF";
            this.blisshiveFetchMinutesTF.Size = new System.Drawing.Size(42, 20);
            this.blisshiveFetchMinutesTF.TabIndex = 8;
            this.blisshiveFetchMinutesTF.TextChanged += new System.EventHandler(this.BlisshiveFetchMinutesTF_TextChanged);
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
            // blissHivePlayerDataPanel
            // 
            this.blissHivePlayerDataPanel.BackColor = System.Drawing.Color.Transparent;
            this.blissHivePlayerDataPanel.Controls.Add(this.blissHivePlayerDataTabControl);
            this.blissHivePlayerDataPanel.Location = new System.Drawing.Point(231, 39);
            this.blissHivePlayerDataPanel.Name = "blissHivePlayerDataPanel";
            this.blissHivePlayerDataPanel.Size = new System.Drawing.Size(689, 394);
            this.blissHivePlayerDataPanel.TabIndex = 7;
            // 
            // blissHivePlayerDataTabControl
            // 
            this.blissHivePlayerDataTabControl.Controls.Add(this.blissHivePlayerDataTabFormattedData);
            this.blissHivePlayerDataTabControl.Controls.Add(this.blissHivePlayerDataTabRawLogData);
            this.blissHivePlayerDataTabControl.Controls.Add(this.blissHivePlayerDataTabInventory);
            this.blissHivePlayerDataTabControl.Controls.Add(this.blissHivePlayerDataTabInventoryHistory);
            this.blissHivePlayerDataTabControl.Controls.Add(this.blissHivePlayerDataTabActivityLog);
            this.blissHivePlayerDataTabControl.Location = new System.Drawing.Point(0, 17);
            this.blissHivePlayerDataTabControl.Name = "blissHivePlayerDataTabControl";
            this.blissHivePlayerDataTabControl.SelectedIndex = 0;
            this.blissHivePlayerDataTabControl.Size = new System.Drawing.Size(691, 378);
            this.blissHivePlayerDataTabControl.TabIndex = 2;
            this.blissHivePlayerDataTabControl.Tag = "";
            // 
            // blissHivePlayerDataTabFormattedData
            // 
            this.blissHivePlayerDataTabFormattedData.Controls.Add(this.blissHiveFormattedLogDataListView);
            this.blissHivePlayerDataTabFormattedData.Location = new System.Drawing.Point(4, 22);
            this.blissHivePlayerDataTabFormattedData.Name = "blissHivePlayerDataTabFormattedData";
            this.blissHivePlayerDataTabFormattedData.Padding = new System.Windows.Forms.Padding(3);
            this.blissHivePlayerDataTabFormattedData.Size = new System.Drawing.Size(683, 352);
            this.blissHivePlayerDataTabFormattedData.TabIndex = 0;
            this.blissHivePlayerDataTabFormattedData.Tag = "formattedLogData";
            this.blissHivePlayerDataTabFormattedData.Text = "Formatted Log Data";
            this.blissHivePlayerDataTabFormattedData.UseVisualStyleBackColor = true;
            // 
            // blissHiveFormattedLogDataListView
            // 
            this.blissHiveFormattedLogDataListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.blissHivePlayerDataFormattedDataTimeColumn,
            this.blissHivePlayerDataFormattedDataFunctionColumn,
            this.blissHivePlayerDataFormattedDataParameterColumn});
            this.blissHiveFormattedLogDataListView.Location = new System.Drawing.Point(0, 0);
            this.blissHiveFormattedLogDataListView.Name = "blissHiveFormattedLogDataListView";
            this.blissHiveFormattedLogDataListView.Size = new System.Drawing.Size(681, 351);
            this.blissHiveFormattedLogDataListView.TabIndex = 0;
            this.blissHiveFormattedLogDataListView.UseCompatibleStateImageBehavior = false;
            this.blissHiveFormattedLogDataListView.View = System.Windows.Forms.View.Details;
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
            this.blissHivePlayerDataTabRawLogData.Controls.Add(this.blissHiveRawLogDataTextBox);
            this.blissHivePlayerDataTabRawLogData.Location = new System.Drawing.Point(4, 22);
            this.blissHivePlayerDataTabRawLogData.Name = "blissHivePlayerDataTabRawLogData";
            this.blissHivePlayerDataTabRawLogData.Padding = new System.Windows.Forms.Padding(3);
            this.blissHivePlayerDataTabRawLogData.Size = new System.Drawing.Size(683, 352);
            this.blissHivePlayerDataTabRawLogData.TabIndex = 1;
            this.blissHivePlayerDataTabRawLogData.Tag = "rawLogData";
            this.blissHivePlayerDataTabRawLogData.Text = "Raw Log Data";
            this.blissHivePlayerDataTabRawLogData.UseVisualStyleBackColor = true;
            // 
            // blissHiveRawLogDataTextBox
            // 
            this.blissHiveRawLogDataTextBox.Location = new System.Drawing.Point(0, 0);
            this.blissHiveRawLogDataTextBox.MaxLength = 2147483647;
            this.blissHiveRawLogDataTextBox.Multiline = true;
            this.blissHiveRawLogDataTextBox.Name = "blissHiveRawLogDataTextBox";
            this.blissHiveRawLogDataTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.blissHiveRawLogDataTextBox.Size = new System.Drawing.Size(681, 351);
            this.blissHiveRawLogDataTextBox.TabIndex = 0;
            this.blissHiveRawLogDataTextBox.WordWrap = false;
            // 
            // blissHivePlayerDataTabInventory
            // 
            this.blissHivePlayerDataTabInventory.Controls.Add(this.blissHiveInventoryBackpackGroupBox);
            this.blissHivePlayerDataTabInventory.Controls.Add(this.blissHiveInventoryInventoryGroupBox);
            this.blissHivePlayerDataTabInventory.Location = new System.Drawing.Point(4, 22);
            this.blissHivePlayerDataTabInventory.Name = "blissHivePlayerDataTabInventory";
            this.blissHivePlayerDataTabInventory.Size = new System.Drawing.Size(683, 352);
            this.blissHivePlayerDataTabInventory.TabIndex = 2;
            this.blissHivePlayerDataTabInventory.Tag = "inventory";
            this.blissHivePlayerDataTabInventory.Text = "Inventory";
            this.blissHivePlayerDataTabInventory.UseVisualStyleBackColor = true;
            // 
            // blissHiveInventoryBackpackGroupBox
            // 
            this.blissHiveInventoryBackpackGroupBox.Controls.Add(this.blissHiveInventoryBackpackPanel);
            this.blissHiveInventoryBackpackGroupBox.Location = new System.Drawing.Point(343, 4);
            this.blissHiveInventoryBackpackGroupBox.Name = "blissHiveInventoryBackpackGroupBox";
            this.blissHiveInventoryBackpackGroupBox.Size = new System.Drawing.Size(338, 345);
            this.blissHiveInventoryBackpackGroupBox.TabIndex = 5;
            this.blissHiveInventoryBackpackGroupBox.TabStop = false;
            this.blissHiveInventoryBackpackGroupBox.Text = "Backpack";
            // 
            // blissHiveInventoryBackpackPanel
            // 
            this.blissHiveInventoryBackpackPanel.Controls.Add(this.blissHivePlayerDataInventoryBackpackListView);
            this.blissHiveInventoryBackpackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blissHiveInventoryBackpackPanel.Location = new System.Drawing.Point(3, 16);
            this.blissHiveInventoryBackpackPanel.Name = "blissHiveInventoryBackpackPanel";
            this.blissHiveInventoryBackpackPanel.Size = new System.Drawing.Size(332, 326);
            this.blissHiveInventoryBackpackPanel.TabIndex = 3;
            // 
            // blissHivePlayerDataInventoryBackpackListView
            // 
            this.blissHivePlayerDataInventoryBackpackListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.blissHiveInventoryBackpackQuantityColumn,
            this.blissHiveInventoryBackpackItemColumn});
            this.blissHivePlayerDataInventoryBackpackListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blissHivePlayerDataInventoryBackpackListView.Location = new System.Drawing.Point(0, 0);
            this.blissHivePlayerDataInventoryBackpackListView.Name = "blissHivePlayerDataInventoryBackpackListView";
            this.blissHivePlayerDataInventoryBackpackListView.Size = new System.Drawing.Size(332, 326);
            this.blissHivePlayerDataInventoryBackpackListView.TabIndex = 1;
            this.blissHivePlayerDataInventoryBackpackListView.UseCompatibleStateImageBehavior = false;
            this.blissHivePlayerDataInventoryBackpackListView.View = System.Windows.Forms.View.Details;
            // 
            // blissHiveInventoryBackpackQuantityColumn
            // 
            this.blissHiveInventoryBackpackQuantityColumn.Text = "Qnty";
            // 
            // blissHiveInventoryBackpackItemColumn
            // 
            this.blissHiveInventoryBackpackItemColumn.Text = "Item";
            this.blissHiveInventoryBackpackItemColumn.Width = 260;
            // 
            // blissHiveInventoryInventoryGroupBox
            // 
            this.blissHiveInventoryInventoryGroupBox.Controls.Add(this.blissHiveInventoryInventoryPanel);
            this.blissHiveInventoryInventoryGroupBox.Location = new System.Drawing.Point(4, 4);
            this.blissHiveInventoryInventoryGroupBox.Name = "blissHiveInventoryInventoryGroupBox";
            this.blissHiveInventoryInventoryGroupBox.Size = new System.Drawing.Size(336, 345);
            this.blissHiveInventoryInventoryGroupBox.TabIndex = 4;
            this.blissHiveInventoryInventoryGroupBox.TabStop = false;
            this.blissHiveInventoryInventoryGroupBox.Text = "Inventory";
            // 
            // blissHiveInventoryInventoryPanel
            // 
            this.blissHiveInventoryInventoryPanel.Controls.Add(this.blissHivePlayerDataInventoryInventoryListView);
            this.blissHiveInventoryInventoryPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blissHiveInventoryInventoryPanel.Location = new System.Drawing.Point(3, 16);
            this.blissHiveInventoryInventoryPanel.Name = "blissHiveInventoryInventoryPanel";
            this.blissHiveInventoryInventoryPanel.Size = new System.Drawing.Size(330, 326);
            this.blissHiveInventoryInventoryPanel.TabIndex = 3;
            // 
            // blissHivePlayerDataInventoryInventoryListView
            // 
            this.blissHivePlayerDataInventoryInventoryListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.blissHiveInventoryInventoryQuantityColumn,
            this.blissHiveInventoryInventoryItem});
            this.blissHivePlayerDataInventoryInventoryListView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.blissHivePlayerDataInventoryInventoryListView.Location = new System.Drawing.Point(0, 0);
            this.blissHivePlayerDataInventoryInventoryListView.Name = "blissHivePlayerDataInventoryInventoryListView";
            this.blissHivePlayerDataInventoryInventoryListView.Size = new System.Drawing.Size(330, 326);
            this.blissHivePlayerDataInventoryInventoryListView.TabIndex = 0;
            this.blissHivePlayerDataInventoryInventoryListView.UseCompatibleStateImageBehavior = false;
            this.blissHivePlayerDataInventoryInventoryListView.View = System.Windows.Forms.View.Details;
            // 
            // blissHiveInventoryInventoryQuantityColumn
            // 
            this.blissHiveInventoryInventoryQuantityColumn.Text = "Qnty";
            // 
            // blissHiveInventoryInventoryItem
            // 
            this.blissHiveInventoryInventoryItem.Text = "Item";
            this.blissHiveInventoryInventoryItem.Width = 260;
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
            this.blissHivePlayerDataInventoryHistoryComboBox.Location = new System.Drawing.Point(109, 1);
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
            this.blissHivePlayerDataPanel.ResumeLayout(false);
            this.blissHivePlayerDataTabControl.ResumeLayout(false);
            this.blissHivePlayerDataTabFormattedData.ResumeLayout(false);
            this.blissHivePlayerDataTabRawLogData.ResumeLayout(false);
            this.blissHivePlayerDataTabRawLogData.PerformLayout();
            this.blissHivePlayerDataTabInventory.ResumeLayout(false);
            this.blissHiveInventoryBackpackGroupBox.ResumeLayout(false);
            this.blissHiveInventoryBackpackPanel.ResumeLayout(false);
            this.blissHiveInventoryInventoryGroupBox.ResumeLayout(false);
            this.blissHiveInventoryInventoryPanel.ResumeLayout(false);
            this.blissHivePlayerDataTabInventoryHistory.ResumeLayout(false);
            this.blissHivePlayerDataTabInventoryHistory.PerformLayout();
            this.blissHivePlayerDataInventoryHistoryBackpackGroupBox.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.blissHivePlayerDataInventoryHistoryInventoryGroupBox.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.blissHivePlayerDataTabActivityLog.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TreeView blissHivePlayerTree;
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
        public IntTextBox blisshiveFetchMinutesTF;
        private System.Windows.Forms.TabPage blissHivePlayerDataTabFormattedData;
        private System.Windows.Forms.TabPage blissHivePlayerDataTabRawLogData;
        private System.Windows.Forms.ColumnHeader blissHivePlayerDataFormattedDataTimeColumn;
        private System.Windows.Forms.ColumnHeader blissHivePlayerDataFormattedDataFunctionColumn;
        private System.Windows.Forms.ColumnHeader blissHivePlayerDataFormattedDataParameterColumn;
        private System.Windows.Forms.MenuItem openBlissHiveMenuItem;
        private System.Windows.Forms.MenuItem exitSeperator;
        private System.Windows.Forms.TabPage blissHivePlayerDataTabInventory;
        private System.Windows.Forms.TabPage blissHivePlayerDataTabActivityLog;
        private System.Windows.Forms.ListView blissHiveActivityLog;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Panel blissHiveInventoryInventoryPanel;
        private System.Windows.Forms.GroupBox blissHiveInventoryInventoryGroupBox;
        private System.Windows.Forms.GroupBox blissHiveInventoryBackpackGroupBox;
        private System.Windows.Forms.Panel blissHiveInventoryBackpackPanel;
        public System.Windows.Forms.TabControl blissHivePlayerDataTabControl;
        private System.Windows.Forms.ColumnHeader blissHiveInventoryBackpackQuantityColumn;
        private System.Windows.Forms.ColumnHeader blissHiveInventoryBackpackItemColumn;
        private System.Windows.Forms.ColumnHeader blissHiveInventoryInventoryQuantityColumn;
        private System.Windows.Forms.ColumnHeader blissHiveInventoryInventoryItem;
        public System.Windows.Forms.ListView blissHiveFormattedLogDataListView;
        public System.Windows.Forms.TextBox blissHiveRawLogDataTextBox;
        public System.Windows.Forms.ListView blissHivePlayerDataInventoryInventoryListView;
        public System.Windows.Forms.ListView blissHivePlayerDataInventoryBackpackListView;
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
    }
}

