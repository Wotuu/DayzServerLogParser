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
            this.blisshivePlayerTimelinePanel = new System.Windows.Forms.Panel();
            this.blisshivePlayerTree = new System.Windows.Forms.TreeView();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.mainMenu = new System.Windows.Forms.MainMenu(this.components);
            this.fileMenuItem = new System.Windows.Forms.MenuItem();
            this.exitMenuItem = new System.Windows.Forms.MenuItem();
            this.optionsMenuItem = new System.Windows.Forms.MenuItem();
            this.blisshiveDownloadLogBtn = new System.Windows.Forms.Button();
            this.logfilesTabControl = new System.Windows.Forms.TabControl();
            this.blisshiveTab = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.blisshiveRawLogLbl = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.blisshiveLogFetchTimeDropdown = new System.Windows.Forms.ComboBox();
            this.blisshiveDownloadProgressBar = new System.Windows.Forms.ProgressBar();
            this.blisshiveFetchLogLbl = new System.Windows.Forms.Label();
            this.warningPanel = new System.Windows.Forms.Panel();
            this.warningsLbl = new System.Windows.Forms.Label();
            this.blisshiveFetchMinutesTF = new DayzLogParser.UI.IntTextBox();
            this.logfilesTabControl.SuspendLayout();
            this.blisshiveTab.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // blisshivePlayerTimelinePanel
            // 
            this.blisshivePlayerTimelinePanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.blisshivePlayerTimelinePanel.Location = new System.Drawing.Point(231, 30);
            this.blisshivePlayerTimelinePanel.Name = "blisshivePlayerTimelinePanel";
            this.blisshivePlayerTimelinePanel.Size = new System.Drawing.Size(690, 101);
            this.blisshivePlayerTimelinePanel.TabIndex = 0;
            // 
            // blisshivePlayerTree
            // 
            this.blisshivePlayerTree.Location = new System.Drawing.Point(6, 30);
            this.blisshivePlayerTree.Name = "blisshivePlayerTree";
            treeNode1.Name = "blisshiveTreeNodeOnline";
            treeNode1.Text = "Online";
            treeNode2.Name = "blisshiveTreeNodeOffline";
            treeNode2.Text = "Offline";
            this.blisshivePlayerTree.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.blisshivePlayerTree.Size = new System.Drawing.Size(219, 406);
            this.blisshivePlayerTree.TabIndex = 1;
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
            this.exitMenuItem});
            this.fileMenuItem.Text = "File";
            // 
            // exitMenuItem
            // 
            this.exitMenuItem.Index = 0;
            this.exitMenuItem.Text = "Exit";
            this.exitMenuItem.Click += new System.EventHandler(this.exitMenuItem_Click);
            // 
            // optionsMenuItem
            // 
            this.optionsMenuItem.Index = 1;
            this.optionsMenuItem.Text = "Options";
            this.optionsMenuItem.Click += new System.EventHandler(this.optionsMenuItem_Click);
            // 
            // blisshiveDownloadLogBtn
            // 
            this.blisshiveDownloadLogBtn.Enabled = false;
            this.blisshiveDownloadLogBtn.Location = new System.Drawing.Point(231, 3);
            this.blisshiveDownloadLogBtn.Name = "blisshiveDownloadLogBtn";
            this.blisshiveDownloadLogBtn.Size = new System.Drawing.Size(75, 23);
            this.blisshiveDownloadLogBtn.TabIndex = 2;
            this.blisshiveDownloadLogBtn.Text = "Start";
            this.blisshiveDownloadLogBtn.UseVisualStyleBackColor = true;
            this.blisshiveDownloadLogBtn.Click += new System.EventHandler(this.blisshiveDownloadLogBtn_Click);
            // 
            // logfilesTabControl
            // 
            this.logfilesTabControl.Controls.Add(this.blisshiveTab);
            this.logfilesTabControl.Location = new System.Drawing.Point(12, 12);
            this.logfilesTabControl.Name = "logfilesTabControl";
            this.logfilesTabControl.SelectedIndex = 0;
            this.logfilesTabControl.Size = new System.Drawing.Size(935, 468);
            this.logfilesTabControl.TabIndex = 3;
            // 
            // blisshiveTab
            // 
            this.blisshiveTab.Controls.Add(this.panel1);
            this.blisshiveTab.Controls.Add(this.blisshiveLogFetchTimeDropdown);
            this.blisshiveTab.Controls.Add(this.blisshiveDownloadProgressBar);
            this.blisshiveTab.Controls.Add(this.blisshiveFetchMinutesTF);
            this.blisshiveTab.Controls.Add(this.blisshiveFetchLogLbl);
            this.blisshiveTab.Controls.Add(this.blisshivePlayerTree);
            this.blisshiveTab.Controls.Add(this.blisshiveDownloadLogBtn);
            this.blisshiveTab.Controls.Add(this.blisshivePlayerTimelinePanel);
            this.blisshiveTab.Location = new System.Drawing.Point(4, 22);
            this.blisshiveTab.Name = "blisshiveTab";
            this.blisshiveTab.Padding = new System.Windows.Forms.Padding(3);
            this.blisshiveTab.Size = new System.Drawing.Size(927, 442);
            this.blisshiveTab.TabIndex = 0;
            this.blisshiveTab.Text = "blisshive.log";
            this.blisshiveTab.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.panel1.Controls.Add(this.blisshiveRawLogLbl);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Location = new System.Drawing.Point(232, 138);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 298);
            this.panel1.TabIndex = 7;
            // 
            // blisshiveRawLogLbl
            // 
            this.blisshiveRawLogLbl.AutoSize = true;
            this.blisshiveRawLogLbl.Location = new System.Drawing.Point(4, 10);
            this.blisshiveRawLogLbl.Name = "blisshiveRawLogLbl";
            this.blisshiveRawLogLbl.Size = new System.Drawing.Size(149, 13);
            this.blisshiveRawLogLbl.TabIndex = 1;
            this.blisshiveRawLogLbl.Text = "Raw log data associated with ";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(4, 29);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(682, 266);
            this.textBox1.TabIndex = 0;
            // 
            // blisshiveLogFetchTimeDropdown
            // 
            this.blisshiveLogFetchTimeDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.blisshiveLogFetchTimeDropdown.FormattingEnabled = true;
            this.blisshiveLogFetchTimeDropdown.Items.AddRange(new object[] {
            "Minutes",
            "Hours"});
            this.blisshiveLogFetchTimeDropdown.Location = new System.Drawing.Point(141, 3);
            this.blisshiveLogFetchTimeDropdown.Name = "blisshiveLogFetchTimeDropdown";
            this.blisshiveLogFetchTimeDropdown.Size = new System.Drawing.Size(84, 21);
            this.blisshiveLogFetchTimeDropdown.TabIndex = 6;
            // 
            // blisshiveDownloadProgressBar
            // 
            this.blisshiveDownloadProgressBar.Location = new System.Drawing.Point(313, 4);
            this.blisshiveDownloadProgressBar.Name = "blisshiveDownloadProgressBar";
            this.blisshiveDownloadProgressBar.Size = new System.Drawing.Size(608, 23);
            this.blisshiveDownloadProgressBar.TabIndex = 5;
            // 
            // blisshiveFetchLogLbl
            // 
            this.blisshiveFetchLogLbl.AutoSize = true;
            this.blisshiveFetchLogLbl.Location = new System.Drawing.Point(6, 8);
            this.blisshiveFetchLogLbl.Name = "blisshiveFetchLogLbl";
            this.blisshiveFetchLogLbl.Size = new System.Drawing.Size(80, 13);
            this.blisshiveFetchLogLbl.TabIndex = 3;
            this.blisshiveFetchLogLbl.Text = "Fetch log every";
            // 
            // warningPanel
            // 
            this.warningPanel.Location = new System.Drawing.Point(950, 34);
            this.warningPanel.Name = "warningPanel";
            this.warningPanel.Size = new System.Drawing.Size(200, 442);
            this.warningPanel.TabIndex = 4;
            // 
            // warningsLbl
            // 
            this.warningsLbl.AutoSize = true;
            this.warningsLbl.Location = new System.Drawing.Point(950, 12);
            this.warningsLbl.Name = "warningsLbl";
            this.warningsLbl.Size = new System.Drawing.Size(52, 13);
            this.warningsLbl.TabIndex = 5;
            this.warningsLbl.Text = "Warnings";
            // 
            // blisshiveFetchMinutesTF
            // 
            this.blisshiveFetchMinutesTF.Location = new System.Drawing.Point(93, 4);
            this.blisshiveFetchMinutesTF.Name = "blisshiveFetchMinutesTF";
            this.blisshiveFetchMinutesTF.Size = new System.Drawing.Size(41, 20);
            this.blisshiveFetchMinutesTF.TabIndex = 4;
            this.blisshiveFetchMinutesTF.TextChanged += new System.EventHandler(this.blisshiveFetchMinutesTF_TextChanged);
            // 
            // DayzLogParserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1155, 511);
            this.Controls.Add(this.warningsLbl);
            this.Controls.Add(this.warningPanel);
            this.Controls.Add(this.logfilesTabControl);
            this.MaximumSize = new System.Drawing.Size(1171, 549);
            this.Menu = this.mainMenu;
            this.MinimumSize = new System.Drawing.Size(1171, 549);
            this.Name = "DayzLogParserForm";
            this.Text = "Dayz Log Parser";
            this.logfilesTabControl.ResumeLayout(false);
            this.blisshiveTab.ResumeLayout(false);
            this.blisshiveTab.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel blisshivePlayerTimelinePanel;
        private System.Windows.Forms.TreeView blisshivePlayerTree;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.MainMenu mainMenu;
        private System.Windows.Forms.MenuItem fileMenuItem;
        private System.Windows.Forms.MenuItem exitMenuItem;
        private System.Windows.Forms.Button blisshiveDownloadLogBtn;
        private System.Windows.Forms.TabControl logfilesTabControl;
        private System.Windows.Forms.TabPage blisshiveTab;
        private System.Windows.Forms.ComboBox blisshiveLogFetchTimeDropdown;
        private System.Windows.Forms.ProgressBar blisshiveDownloadProgressBar;
        private System.Windows.Forms.Label blisshiveFetchLogLbl;
        private System.Windows.Forms.MenuItem optionsMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label blisshiveRawLogLbl;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel warningPanel;
        private System.Windows.Forms.Label warningsLbl;
        private IntTextBox blisshiveFetchMinutesTF;
    }
}

