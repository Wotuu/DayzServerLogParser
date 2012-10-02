using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DayzLogParser.Settings.BlissHive;
using DayzLogParser.Settings;

namespace DayzLogParser.UI {
    public partial class OptionsForm : Form {

        private Point ownerWindowOffset = new Point(25, 25);
        public static String SettingsFileLocation = AppDomain.CurrentDomain.BaseDirectory + "settings.2ez";

        public OptionsForm() {
            InitializeComponent();

            this.Shown += new EventHandler(OptionsForm_Shown);
            this.optionsBlisshiveAllItemsListView.MouseDoubleClick += new MouseEventHandler(optionsBlisshiveAllItemsListView_MouseDoubleClick);

            this.optionsBlisshiveBlackListListView.MouseDoubleClick += new MouseEventHandler(optionsBlisshiveBlackListListView_MouseDoubleClick);

        }

        void optionsBlisshiveBlackListListView_MouseDoubleClick(object sender, MouseEventArgs e) {

            if (this.optionsBlisshiveBlackListListView.SelectedItems.Count >= 1) {
                foreach (ListViewItem item in this.optionsBlisshiveBlackListListView.SelectedItems) {
                    this.optionsBlisshiveAllItemsListView.Items.Add(new ListViewItem(item.Text));
                }

                for (int i = 0; i < this.optionsBlisshiveBlackListListView.SelectedItems.Count; i++) {
                    ListViewItem item = this.optionsBlisshiveBlackListListView.SelectedItems[i];
                    this.optionsBlisshiveBlackListListView.Items.Remove(item);
                }
            }
        }

        void optionsBlisshiveAllItemsListView_MouseDoubleClick(object sender, MouseEventArgs e) {

            if (this.optionsBlisshiveAllItemsListView.SelectedItems.Count >= 1) {
                foreach (ListViewItem item in this.optionsBlisshiveAllItemsListView.SelectedItems) {
                    this.optionsBlisshiveBlackListListView.Items.Add(new ListViewItem(item.Text));
                }

                for (int i = 0; i < this.optionsBlisshiveAllItemsListView.SelectedItems.Count; i++) {
                    ListViewItem item = this.optionsBlisshiveAllItemsListView.SelectedItems[i];
                    this.optionsBlisshiveAllItemsListView.Items.Remove(item);
                }
            }

        }

        #region Load settings file
        void OptionsForm_Shown(object sender, EventArgs e) {
            this.Location = new Point(this.Owner.Location.X + ownerWindowOffset.X, this.Owner.Location.Y + ownerWindowOffset.Y);

            LinkedList<SettingsCategory> categories =
                SettingsController.GetInstance().LoadSettingsFile(OptionsForm.SettingsFileLocation);

            foreach (SettingsCategory category in categories) {
                if (category is BlissHiveSettingsCategory) {
                    // Load blisshive settings into the interface
                    BlissHiveSettingsCategory blissCategory = (BlissHiveSettingsCategory)category;
                    foreach (String item in blissCategory.itemsList) {
                        this.optionsBlisshiveAllItemsListView.Items.Add(item);
                    }

                    foreach (String item in blissCategory.blackListItems) {
                        this.optionsBlisshiveBlackListListView.Items.Add(item);
                    }
                } else if (category is FTPSettingsCategory) {
                    FTPSettingsCategory ftpCategory = (FTPSettingsCategory)category;
                    this.optionsFTPIPTF.Text = ftpCategory.ip;
                    this.optionsFTPPortTF.Text = ftpCategory.port;
                    this.optionsFTPUsernameTF.Text = ftpCategory.username;
                    this.optionsFTPPasswordTF.Text = ftpCategory.password;
                    this.optionsFTPRootFolderTF.Text = ftpCategory.rootFolder;
                }
            }
        }
        #endregion

        private void optionsCancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        #region Save settings file
        private void optionsSaveBtn_Click(object sender, EventArgs e) {
            LinkedList<SettingsCategory> categories = new LinkedList<SettingsCategory>();

            // Start blisshive save
            BlissHiveSettingsCategory blisshiveCategory = new BlissHiveSettingsCategory();
            foreach (ListViewItem item in this.optionsBlisshiveAllItemsListView.Items) {
                blisshiveCategory.itemsList.AddLast(item.Text);
            }
            foreach (ListViewItem item in this.optionsBlisshiveBlackListListView.Items) {
                blisshiveCategory.blackListItems.AddLast(item.Text);
            }
            categories.AddLast(blisshiveCategory);
            // End blisshive save

            // Start FTP save
            FTPSettingsCategory ftpCategory = new FTPSettingsCategory();
            ftpCategory.ip = this.optionsFTPIPTF.Text;
            ftpCategory.port = this.optionsFTPPortTF.Text;
            ftpCategory.username = this.optionsFTPUsernameTF.Text;
            ftpCategory.password = this.optionsFTPPasswordTF.Text;
            ftpCategory.rootFolder = this.optionsFTPRootFolderTF.Text;
            categories.AddLast(ftpCategory);
            // End FTP save

            
            SettingsController.GetInstance().SaveSettingFile(categories, OptionsForm.SettingsFileLocation);
            this.Close();
        }
        #endregion

        private void tabPage1_Click(object sender, EventArgs e) {

        }

        private void optionsBlisshiveAddItemBtn_Click(object sender, EventArgs e) {
            if (this.optionsBlisshiveAddItemTF.TextLength > 0) {
                this.optionsBlisshiveAllItemsListView.Items.Add(this.optionsBlisshiveAddItemTF.Text);
                this.optionsBlisshiveAddItemTF.Text = "";
            }
        }
    }
}
