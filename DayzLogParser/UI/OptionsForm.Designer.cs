namespace DayzLogParser.UI {
    partial class OptionsForm {
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
            this.optionsFTPIPLbl = new System.Windows.Forms.Label();
            this.optionsFTPPortLbl = new System.Windows.Forms.Label();
            this.optionsFTPIPTF = new System.Windows.Forms.TextBox();
            this.optionsFTPPortTF = new System.Windows.Forms.TextBox();
            this.optionsFTPUsernameLbl = new System.Windows.Forms.Label();
            this.optionsFTPPasswordLbl = new System.Windows.Forms.Label();
            this.optionsFTPUsernameTF = new System.Windows.Forms.TextBox();
            this.optionsFTPPasswordTF = new System.Windows.Forms.TextBox();
            this.optionsSaveBtn = new System.Windows.Forms.Button();
            this.optionsCancelBtn = new System.Windows.Forms.Button();
            this.optionsFTPRootFolderTF = new System.Windows.Forms.TextBox();
            this.optionsFTPRootFolderLbl = new System.Windows.Forms.Label();
            this.optionsTabControl = new System.Windows.Forms.TabControl();
            this.optionsFTPTab = new System.Windows.Forms.TabPage();
            this.optionsBlisshiveTab = new System.Windows.Forms.TabPage();
            this.optionsBlisshiveBlacklistItemsLbl = new System.Windows.Forms.Label();
            this.optionsBlisshiveAllItemsLbl = new System.Windows.Forms.Label();
            this.optionsBlisshiveBlackListListView = new System.Windows.Forms.ListView();
            this.blackListNameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.optionsBlisshiveAllItemsListView = new System.Windows.Forms.ListView();
            this.nameHeader = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.optionsBlisshiveAddItemBtn = new System.Windows.Forms.Button();
            this.optionsBlisshiveAddItemTF = new System.Windows.Forms.TextBox();
            this.optionsTabControl.SuspendLayout();
            this.optionsFTPTab.SuspendLayout();
            this.optionsBlisshiveTab.SuspendLayout();
            this.SuspendLayout();
            // 
            // optionsFTPIPLbl
            // 
            this.optionsFTPIPLbl.AutoSize = true;
            this.optionsFTPIPLbl.Location = new System.Drawing.Point(7, 9);
            this.optionsFTPIPLbl.Name = "optionsFTPIPLbl";
            this.optionsFTPIPLbl.Size = new System.Drawing.Size(40, 13);
            this.optionsFTPIPLbl.TabIndex = 0;
            this.optionsFTPIPLbl.Text = "FTP IP";
            // 
            // optionsFTPPortLbl
            // 
            this.optionsFTPPortLbl.AutoSize = true;
            this.optionsFTPPortLbl.Location = new System.Drawing.Point(6, 38);
            this.optionsFTPPortLbl.Name = "optionsFTPPortLbl";
            this.optionsFTPPortLbl.Size = new System.Drawing.Size(49, 13);
            this.optionsFTPPortLbl.TabIndex = 1;
            this.optionsFTPPortLbl.Text = "FTP Port";
            // 
            // optionsFTPIPTF
            // 
            this.optionsFTPIPTF.Location = new System.Drawing.Point(161, 6);
            this.optionsFTPIPTF.Name = "optionsFTPIPTF";
            this.optionsFTPIPTF.Size = new System.Drawing.Size(139, 20);
            this.optionsFTPIPTF.TabIndex = 4;
            // 
            // optionsFTPPortTF
            // 
            this.optionsFTPPortTF.Location = new System.Drawing.Point(161, 35);
            this.optionsFTPPortTF.Name = "optionsFTPPortTF";
            this.optionsFTPPortTF.Size = new System.Drawing.Size(139, 20);
            this.optionsFTPPortTF.TabIndex = 5;
            // 
            // optionsFTPUsernameLbl
            // 
            this.optionsFTPUsernameLbl.AutoSize = true;
            this.optionsFTPUsernameLbl.Location = new System.Drawing.Point(7, 67);
            this.optionsFTPUsernameLbl.Name = "optionsFTPUsernameLbl";
            this.optionsFTPUsernameLbl.Size = new System.Drawing.Size(78, 13);
            this.optionsFTPUsernameLbl.TabIndex = 6;
            this.optionsFTPUsernameLbl.Text = "FTP Username";
            // 
            // optionsFTPPasswordLbl
            // 
            this.optionsFTPPasswordLbl.AutoSize = true;
            this.optionsFTPPasswordLbl.Location = new System.Drawing.Point(7, 96);
            this.optionsFTPPasswordLbl.Name = "optionsFTPPasswordLbl";
            this.optionsFTPPasswordLbl.Size = new System.Drawing.Size(76, 13);
            this.optionsFTPPasswordLbl.TabIndex = 7;
            this.optionsFTPPasswordLbl.Text = "FTP Password";
            // 
            // optionsFTPUsernameTF
            // 
            this.optionsFTPUsernameTF.Location = new System.Drawing.Point(161, 64);
            this.optionsFTPUsernameTF.Name = "optionsFTPUsernameTF";
            this.optionsFTPUsernameTF.Size = new System.Drawing.Size(139, 20);
            this.optionsFTPUsernameTF.TabIndex = 8;
            // 
            // optionsFTPPasswordTF
            // 
            this.optionsFTPPasswordTF.Location = new System.Drawing.Point(161, 93);
            this.optionsFTPPasswordTF.Name = "optionsFTPPasswordTF";
            this.optionsFTPPasswordTF.PasswordChar = '*';
            this.optionsFTPPasswordTF.Size = new System.Drawing.Size(139, 20);
            this.optionsFTPPasswordTF.TabIndex = 9;
            this.optionsFTPPasswordTF.UseSystemPasswordChar = true;
            // 
            // optionsSaveBtn
            // 
            this.optionsSaveBtn.Location = new System.Drawing.Point(16, 218);
            this.optionsSaveBtn.Name = "optionsSaveBtn";
            this.optionsSaveBtn.Size = new System.Drawing.Size(75, 23);
            this.optionsSaveBtn.TabIndex = 10;
            this.optionsSaveBtn.Text = "Save";
            this.optionsSaveBtn.UseVisualStyleBackColor = true;
            this.optionsSaveBtn.Click += new System.EventHandler(this.optionsSaveBtn_Click);
            // 
            // optionsCancelBtn
            // 
            this.optionsCancelBtn.Location = new System.Drawing.Point(231, 218);
            this.optionsCancelBtn.Name = "optionsCancelBtn";
            this.optionsCancelBtn.Size = new System.Drawing.Size(75, 23);
            this.optionsCancelBtn.TabIndex = 11;
            this.optionsCancelBtn.Text = "Cancel";
            this.optionsCancelBtn.UseVisualStyleBackColor = true;
            this.optionsCancelBtn.Click += new System.EventHandler(this.optionsCancelBtn_Click);
            // 
            // optionsFTPRootFolderTF
            // 
            this.optionsFTPRootFolderTF.Location = new System.Drawing.Point(161, 121);
            this.optionsFTPRootFolderTF.Name = "optionsFTPRootFolderTF";
            this.optionsFTPRootFolderTF.Size = new System.Drawing.Size(139, 20);
            this.optionsFTPRootFolderTF.TabIndex = 14;
            // 
            // optionsFTPRootFolderLbl
            // 
            this.optionsFTPRootFolderLbl.AutoSize = true;
            this.optionsFTPRootFolderLbl.Location = new System.Drawing.Point(7, 124);
            this.optionsFTPRootFolderLbl.Name = "optionsFTPRootFolderLbl";
            this.optionsFTPRootFolderLbl.Size = new System.Drawing.Size(85, 13);
            this.optionsFTPRootFolderLbl.TabIndex = 12;
            this.optionsFTPRootFolderLbl.Text = "FTP Root Folder";
            // 
            // optionsTabControl
            // 
            this.optionsTabControl.Controls.Add(this.optionsFTPTab);
            this.optionsTabControl.Controls.Add(this.optionsBlisshiveTab);
            this.optionsTabControl.Location = new System.Drawing.Point(1, 0);
            this.optionsTabControl.Name = "optionsTabControl";
            this.optionsTabControl.SelectedIndex = 0;
            this.optionsTabControl.Size = new System.Drawing.Size(314, 212);
            this.optionsTabControl.TabIndex = 15;
            // 
            // optionsFTPTab
            // 
            this.optionsFTPTab.Controls.Add(this.optionsFTPIPTF);
            this.optionsFTPTab.Controls.Add(this.optionsFTPRootFolderTF);
            this.optionsFTPTab.Controls.Add(this.optionsFTPIPLbl);
            this.optionsFTPTab.Controls.Add(this.optionsFTPRootFolderLbl);
            this.optionsFTPTab.Controls.Add(this.optionsFTPPortLbl);
            this.optionsFTPTab.Controls.Add(this.optionsFTPPortTF);
            this.optionsFTPTab.Controls.Add(this.optionsFTPUsernameLbl);
            this.optionsFTPTab.Controls.Add(this.optionsFTPPasswordTF);
            this.optionsFTPTab.Controls.Add(this.optionsFTPPasswordLbl);
            this.optionsFTPTab.Controls.Add(this.optionsFTPUsernameTF);
            this.optionsFTPTab.Location = new System.Drawing.Point(4, 22);
            this.optionsFTPTab.Name = "optionsFTPTab";
            this.optionsFTPTab.Padding = new System.Windows.Forms.Padding(3);
            this.optionsFTPTab.Size = new System.Drawing.Size(306, 186);
            this.optionsFTPTab.TabIndex = 0;
            this.optionsFTPTab.Text = "FTP";
            this.optionsFTPTab.UseVisualStyleBackColor = true;
            this.optionsFTPTab.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // optionsBlisshiveTab
            // 
            this.optionsBlisshiveTab.Controls.Add(this.optionsBlisshiveBlacklistItemsLbl);
            this.optionsBlisshiveTab.Controls.Add(this.optionsBlisshiveAllItemsLbl);
            this.optionsBlisshiveTab.Controls.Add(this.optionsBlisshiveBlackListListView);
            this.optionsBlisshiveTab.Controls.Add(this.optionsBlisshiveAllItemsListView);
            this.optionsBlisshiveTab.Controls.Add(this.optionsBlisshiveAddItemBtn);
            this.optionsBlisshiveTab.Controls.Add(this.optionsBlisshiveAddItemTF);
            this.optionsBlisshiveTab.Location = new System.Drawing.Point(4, 22);
            this.optionsBlisshiveTab.Name = "optionsBlisshiveTab";
            this.optionsBlisshiveTab.Size = new System.Drawing.Size(306, 186);
            this.optionsBlisshiveTab.TabIndex = 1;
            this.optionsBlisshiveTab.Text = "Blisshive";
            this.optionsBlisshiveTab.UseVisualStyleBackColor = true;
            // 
            // optionsBlisshiveBlacklistItemsLbl
            // 
            this.optionsBlisshiveBlacklistItemsLbl.AutoSize = true;
            this.optionsBlisshiveBlacklistItemsLbl.Location = new System.Drawing.Point(156, 31);
            this.optionsBlisshiveBlacklistItemsLbl.Name = "optionsBlisshiveBlacklistItemsLbl";
            this.optionsBlisshiveBlacklistItemsLbl.Size = new System.Drawing.Size(86, 13);
            this.optionsBlisshiveBlacklistItemsLbl.TabIndex = 6;
            this.optionsBlisshiveBlacklistItemsLbl.Text = "Blacklisted Items";
            // 
            // optionsBlisshiveAllItemsLbl
            // 
            this.optionsBlisshiveAllItemsLbl.AutoSize = true;
            this.optionsBlisshiveAllItemsLbl.Location = new System.Drawing.Point(11, 31);
            this.optionsBlisshiveAllItemsLbl.Name = "optionsBlisshiveAllItemsLbl";
            this.optionsBlisshiveAllItemsLbl.Size = new System.Drawing.Size(46, 13);
            this.optionsBlisshiveAllItemsLbl.TabIndex = 5;
            this.optionsBlisshiveAllItemsLbl.Text = "All Items";
            // 
            // optionsBlisshiveBlackListListView
            // 
            this.optionsBlisshiveBlackListListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.blackListNameHeader});
            this.optionsBlisshiveBlackListListView.Location = new System.Drawing.Point(155, 50);
            this.optionsBlisshiveBlackListListView.Name = "optionsBlisshiveBlackListListView";
            this.optionsBlisshiveBlackListListView.Size = new System.Drawing.Size(148, 133);
            this.optionsBlisshiveBlackListListView.TabIndex = 4;
            this.optionsBlisshiveBlackListListView.UseCompatibleStateImageBehavior = false;
            this.optionsBlisshiveBlackListListView.View = System.Windows.Forms.View.Details;
            // 
            // blackListNameHeader
            // 
            this.blackListNameHeader.Text = "Name";
            this.blackListNameHeader.Width = 143;
            // 
            // optionsBlisshiveAllItemsListView
            // 
            this.optionsBlisshiveAllItemsListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameHeader});
            this.optionsBlisshiveAllItemsListView.HideSelection = false;
            this.optionsBlisshiveAllItemsListView.Location = new System.Drawing.Point(8, 50);
            this.optionsBlisshiveAllItemsListView.Name = "optionsBlisshiveAllItemsListView";
            this.optionsBlisshiveAllItemsListView.Size = new System.Drawing.Size(141, 133);
            this.optionsBlisshiveAllItemsListView.TabIndex = 3;
            this.optionsBlisshiveAllItemsListView.UseCompatibleStateImageBehavior = false;
            this.optionsBlisshiveAllItemsListView.View = System.Windows.Forms.View.Details;
            // 
            // nameHeader
            // 
            this.nameHeader.Text = "Name";
            this.nameHeader.Width = 137;
            // 
            // optionsBlisshiveAddItemBtn
            // 
            this.optionsBlisshiveAddItemBtn.Location = new System.Drawing.Point(226, 2);
            this.optionsBlisshiveAddItemBtn.Name = "optionsBlisshiveAddItemBtn";
            this.optionsBlisshiveAddItemBtn.Size = new System.Drawing.Size(75, 23);
            this.optionsBlisshiveAddItemBtn.TabIndex = 2;
            this.optionsBlisshiveAddItemBtn.Text = "Add Item";
            this.optionsBlisshiveAddItemBtn.UseVisualStyleBackColor = true;
            this.optionsBlisshiveAddItemBtn.Click += new System.EventHandler(this.optionsBlisshiveAddItemBtn_Click);
            // 
            // optionsBlisshiveAddItemTF
            // 
            this.optionsBlisshiveAddItemTF.Location = new System.Drawing.Point(8, 4);
            this.optionsBlisshiveAddItemTF.Name = "optionsBlisshiveAddItemTF";
            this.optionsBlisshiveAddItemTF.Size = new System.Drawing.Size(212, 20);
            this.optionsBlisshiveAddItemTF.TabIndex = 1;
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.optionsSaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 252);
            this.Controls.Add(this.optionsTabControl);
            this.Controls.Add(this.optionsCancelBtn);
            this.Controls.Add(this.optionsSaveBtn);
            this.MaximumSize = new System.Drawing.Size(334, 290);
            this.MinimumSize = new System.Drawing.Size(334, 290);
            this.Name = "OptionsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Options";
            this.optionsTabControl.ResumeLayout(false);
            this.optionsFTPTab.ResumeLayout(false);
            this.optionsFTPTab.PerformLayout();
            this.optionsBlisshiveTab.ResumeLayout(false);
            this.optionsBlisshiveTab.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label optionsFTPIPLbl;
        private System.Windows.Forms.Label optionsFTPPortLbl;
        private System.Windows.Forms.TextBox optionsFTPIPTF;
        private System.Windows.Forms.TextBox optionsFTPPortTF;
        private System.Windows.Forms.Label optionsFTPUsernameLbl;
        private System.Windows.Forms.Label optionsFTPPasswordLbl;
        private System.Windows.Forms.TextBox optionsFTPUsernameTF;
        private System.Windows.Forms.TextBox optionsFTPPasswordTF;
        private System.Windows.Forms.Button optionsSaveBtn;
        private System.Windows.Forms.Button optionsCancelBtn;
        private System.Windows.Forms.TextBox optionsFTPRootFolderTF;
        private System.Windows.Forms.Label optionsFTPRootFolderLbl;
        private System.Windows.Forms.TabControl optionsTabControl;
        private System.Windows.Forms.TabPage optionsFTPTab;
        private System.Windows.Forms.TabPage optionsBlisshiveTab;
        private System.Windows.Forms.Label optionsBlisshiveBlacklistItemsLbl;
        private System.Windows.Forms.Label optionsBlisshiveAllItemsLbl;
        private System.Windows.Forms.ListView optionsBlisshiveBlackListListView;
        private System.Windows.Forms.ListView optionsBlisshiveAllItemsListView;
        private System.Windows.Forms.Button optionsBlisshiveAddItemBtn;
        private System.Windows.Forms.TextBox optionsBlisshiveAddItemTF;
        private System.Windows.Forms.ColumnHeader nameHeader;
        private System.Windows.Forms.ColumnHeader blackListNameHeader;
    }
}