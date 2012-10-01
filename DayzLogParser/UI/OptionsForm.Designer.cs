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
            this.optionsServerIPTF = new System.Windows.Forms.TextBox();
            this.optionsServerPortTF = new System.Windows.Forms.TextBox();
            this.optionsFTPUsernameLbl = new System.Windows.Forms.Label();
            this.optionsFTPPasswordLbl = new System.Windows.Forms.Label();
            this.optionsFTPUsernameTF = new System.Windows.Forms.TextBox();
            this.optionsFTPPasswordTF = new System.Windows.Forms.TextBox();
            this.optionsSaveBtn = new System.Windows.Forms.Button();
            this.optionsCancelBtn = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.optionsFTPRootFolderLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // optionsFTPIPLbl
            // 
            this.optionsFTPIPLbl.AutoSize = true;
            this.optionsFTPIPLbl.Location = new System.Drawing.Point(13, 15);
            this.optionsFTPIPLbl.Name = "optionsFTPIPLbl";
            this.optionsFTPIPLbl.Size = new System.Drawing.Size(40, 13);
            this.optionsFTPIPLbl.TabIndex = 0;
            this.optionsFTPIPLbl.Text = "FTP IP";
            // 
            // optionsFTPPortLbl
            // 
            this.optionsFTPPortLbl.AutoSize = true;
            this.optionsFTPPortLbl.Location = new System.Drawing.Point(12, 44);
            this.optionsFTPPortLbl.Name = "optionsFTPPortLbl";
            this.optionsFTPPortLbl.Size = new System.Drawing.Size(49, 13);
            this.optionsFTPPortLbl.TabIndex = 1;
            this.optionsFTPPortLbl.Text = "FTP Port";
            // 
            // optionsServerIPTF
            // 
            this.optionsServerIPTF.Location = new System.Drawing.Point(167, 12);
            this.optionsServerIPTF.Name = "optionsServerIPTF";
            this.optionsServerIPTF.Size = new System.Drawing.Size(139, 20);
            this.optionsServerIPTF.TabIndex = 4;
            // 
            // optionsServerPortTF
            // 
            this.optionsServerPortTF.Location = new System.Drawing.Point(167, 41);
            this.optionsServerPortTF.Name = "optionsServerPortTF";
            this.optionsServerPortTF.Size = new System.Drawing.Size(139, 20);
            this.optionsServerPortTF.TabIndex = 5;
            // 
            // optionsFTPUsernameLbl
            // 
            this.optionsFTPUsernameLbl.AutoSize = true;
            this.optionsFTPUsernameLbl.Location = new System.Drawing.Point(13, 73);
            this.optionsFTPUsernameLbl.Name = "optionsFTPUsernameLbl";
            this.optionsFTPUsernameLbl.Size = new System.Drawing.Size(78, 13);
            this.optionsFTPUsernameLbl.TabIndex = 6;
            this.optionsFTPUsernameLbl.Text = "FTP Username";
            // 
            // optionsFTPPasswordLbl
            // 
            this.optionsFTPPasswordLbl.AutoSize = true;
            this.optionsFTPPasswordLbl.Location = new System.Drawing.Point(13, 102);
            this.optionsFTPPasswordLbl.Name = "optionsFTPPasswordLbl";
            this.optionsFTPPasswordLbl.Size = new System.Drawing.Size(76, 13);
            this.optionsFTPPasswordLbl.TabIndex = 7;
            this.optionsFTPPasswordLbl.Text = "FTP Password";
            // 
            // optionsFTPUsernameTF
            // 
            this.optionsFTPUsernameTF.Location = new System.Drawing.Point(167, 70);
            this.optionsFTPUsernameTF.Name = "optionsFTPUsernameTF";
            this.optionsFTPUsernameTF.Size = new System.Drawing.Size(139, 20);
            this.optionsFTPUsernameTF.TabIndex = 8;
            // 
            // optionsFTPPasswordTF
            // 
            this.optionsFTPPasswordTF.Location = new System.Drawing.Point(167, 99);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(167, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(139, 20);
            this.textBox2.TabIndex = 14;
            // 
            // optionsFTPRootFolderLbl
            // 
            this.optionsFTPRootFolderLbl.AutoSize = true;
            this.optionsFTPRootFolderLbl.Location = new System.Drawing.Point(13, 130);
            this.optionsFTPRootFolderLbl.Name = "optionsFTPRootFolderLbl";
            this.optionsFTPRootFolderLbl.Size = new System.Drawing.Size(85, 13);
            this.optionsFTPRootFolderLbl.TabIndex = 12;
            this.optionsFTPRootFolderLbl.Text = "FTP Root Folder";
            // 
            // OptionsForm
            // 
            this.AcceptButton = this.optionsSaveBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 252);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.optionsFTPRootFolderLbl);
            this.Controls.Add(this.optionsCancelBtn);
            this.Controls.Add(this.optionsSaveBtn);
            this.Controls.Add(this.optionsFTPPasswordTF);
            this.Controls.Add(this.optionsFTPUsernameTF);
            this.Controls.Add(this.optionsFTPPasswordLbl);
            this.Controls.Add(this.optionsFTPUsernameLbl);
            this.Controls.Add(this.optionsServerPortTF);
            this.Controls.Add(this.optionsServerIPTF);
            this.Controls.Add(this.optionsFTPPortLbl);
            this.Controls.Add(this.optionsFTPIPLbl);
            this.MaximumSize = new System.Drawing.Size(334, 290);
            this.MinimumSize = new System.Drawing.Size(334, 290);
            this.Name = "OptionsForm";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label optionsFTPIPLbl;
        private System.Windows.Forms.Label optionsFTPPortLbl;
        private System.Windows.Forms.TextBox optionsServerIPTF;
        private System.Windows.Forms.TextBox optionsServerPortTF;
        private System.Windows.Forms.Label optionsFTPUsernameLbl;
        private System.Windows.Forms.Label optionsFTPPasswordLbl;
        private System.Windows.Forms.TextBox optionsFTPUsernameTF;
        private System.Windows.Forms.TextBox optionsFTPPasswordTF;
        private System.Windows.Forms.Button optionsSaveBtn;
        private System.Windows.Forms.Button optionsCancelBtn;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label optionsFTPRootFolderLbl;
    }
}