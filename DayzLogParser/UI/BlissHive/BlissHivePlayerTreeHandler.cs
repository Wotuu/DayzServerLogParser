using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DayzLogParser.Log;
using DayzLogParser.Log.BlissHive.Survivor;
using DayzLogParser.Log.BlissHive;

namespace DayzLogParser.UI.BlissHive {
    public class BlissHivePlayerTreeHandler {

        public DayzLogParserForm dayzLogParserForm { get; set; }
        public BlissHiveLogSurvivor selectedSurvivor { get; set; }

        public BlissHivePlayerTreeHandler(DayzLogParserForm dayzLogParser) {
            this.dayzLogParserForm = dayzLogParser;
            this.dayzLogParserForm.blissHivePlayerTree.AfterSelect += new TreeViewEventHandler(blissHivePlayerTree_AfterSelect);
            // this.dayzLogParserForm.blissHivePlayerTree.NodeMouseClick += new TreeNodeMouseClickEventHandler(blisshivePlayerTree_NodeMouseClick);

            this.dayzLogParserForm.blissHivePlayerDataInventoryHistoryComboBox.SelectedIndexChanged
                += new EventHandler(blissHivePlayerDataInventoryHistoryComboBox_SelectedIndexChanged);
        }

        void blissHivePlayerTree_AfterSelect(object sender, TreeViewEventArgs e) {
            if ((String)e.Node.Tag == "player") {
                this.dayzLogParserForm.blissHivePlayerName.Text = "Player " + e.Node.Text;
                foreach (BlissHiveLogSurvivor survivor in LogController.GetInstance().blissHiveLogContainer.survivorContainer.survivors) {
                    if (survivor.username == e.Node.Text) {
                        this.selectedSurvivor = survivor;

                        // Fill the formatted data control
                        this.dayzLogParserForm.blissHiveFormattedLogDataListView.Items.Clear();
                        foreach (BlissHiveLogEntry logEntry in survivor.logEntries) {
                            this.dayzLogParserForm.blissHiveFormattedLogDataListView.Items.Add(
                                new ListViewItem(
                                    new String[3] { logEntry.timestamp, logEntry.functionName, 
                                        String.Join(", ", logEntry.parameters) }
                                    )
                                );
                        }

                        // Fill the raw data control
                        StringBuilder stringBuilder = new StringBuilder("");
                        foreach (BlissHiveLogEntry logEntry in survivor.logEntries) {
                            stringBuilder.AppendLine(logEntry.original);
                        }
                        this.dayzLogParserForm.blissHiveRawLogDataTextBox.Text = stringBuilder.ToString();


                        // Fill the inventory of this survivor
                        this.dayzLogParserForm.blissHivePlayerDataInventoryInventoryListView.Items.Clear();
                        this.dayzLogParserForm.blissHivePlayerDataInventoryBackpackListView.Items.Clear();
                        foreach (BlissHiveLogItem item in survivor.inventory.items) {
                            ListViewItem listViewItem = new ListViewItem(
                                            new String[2] { item.quantity + "", item.key });
                            if (item.location == BlissHiveLogItem.Location.Inventory) {
                                this.dayzLogParserForm.blissHivePlayerDataInventoryInventoryListView
                                    .Items.Add(listViewItem);
                            } else if (item.location == BlissHiveLogItem.Location.Backpack) {
                                this.dayzLogParserForm.blissHivePlayerDataInventoryBackpackListView
                                    .Items.Add(listViewItem);
                            }
                        }

                        // Fill the combo box for the inventories
                        ComboBox comboBox = this.dayzLogParserForm.blissHivePlayerDataInventoryHistoryComboBox;
                        comboBox.Items.Clear();

                        // Clear the previous history items
                        this.dayzLogParserForm.blissHivePlayerDataInventoryHistoryInventoryListView.Items.Clear();
                        this.dayzLogParserForm.blissHivePlayerDataInventoryHistoryBackpackListView.Items.Clear();
                        

                        foreach (BlissHiveLogSurvivorInventory inv in survivor.inventories) {
                            comboBox.Items.Add(inv.originalLogEntry.timestamp);
                        }

                        if (comboBox.Items.Count > 0)
                            comboBox.SelectedIndex = comboBox.Items.Count - 1;

                        // Enable all the tabs!
                        foreach (TabPage tab in this.dayzLogParserForm.blissHivePlayerDataTabControl.TabPages) {
                            tab.Enabled = true;
                        }
                        this.dayzLogParserForm.blissHivePlayerDataTabControl.Enabled = true;
                    }
                }
            }
        }

        /// <summary>
        /// When someone selected a new inventory to display in the inventory history selectbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void blissHivePlayerDataInventoryHistoryComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox comboBox = this.dayzLogParserForm.blissHivePlayerDataInventoryHistoryComboBox;

            if (this.selectedSurvivor != null) {
                foreach (BlissHiveLogSurvivorInventory inv in this.selectedSurvivor.inventories) {
                    if (inv.originalLogEntry.timestamp == (String)comboBox.SelectedItem) {

                        this.dayzLogParserForm.blissHivePlayerDataInventoryHistoryInventoryListView.Items.Clear();
                        this.dayzLogParserForm.blissHivePlayerDataInventoryHistoryBackpackListView.Items.Clear();
                        
                        foreach (BlissHiveLogItem item in inv.items) {
                            ListViewItem listViewItem = new ListViewItem(
                                            new String[2] { item.quantity + "", item.key });
                            if (item.location == BlissHiveLogItem.Location.Inventory) {
                                this.dayzLogParserForm.blissHivePlayerDataInventoryHistoryInventoryListView
                                    .Items.Add(listViewItem);
                            } else if (item.location == BlissHiveLogItem.Location.Backpack) {
                                this.dayzLogParserForm.blissHivePlayerDataInventoryHistoryBackpackListView
                                    .Items.Add(listViewItem);
                            }
                        }

                        break;
                    }
                }
            }
        }


        #region Load Survivors
        /// <summary>
        /// Loads all survivors from the BlissHive log, and puts them in the tree view
        /// </summary>
        public void LoadSurvivors() {
            if (this.dayzLogParserForm.blissHiveDownloadProgressBar.InvokeRequired) {
                this.dayzLogParserForm.BeginInvoke(new MethodInvoker(delegate() { this.LoadSurvivors(); }));
            } else {
                foreach (BlissHiveLogSurvivor survivor in
                    LogController.GetInstance().blissHiveLogContainer.survivorContainer.survivors) {

                    TreeNode playerNode = new TreeNode(survivor.username);
                    playerNode.Tag = "player";
                    if (survivor.online) {
                        this.GetOnlineSurvivorsTreeNode().Nodes.Add(playerNode);
                    } else {
                        this.GetOfflineSurvivorsTreeNode().Nodes.Add(playerNode);
                    }
                }
            }
        }

        /// <summary>
        /// Gets the online players tree node.
        /// </summary>
        /// <returns></returns>
        private TreeNode GetOnlineSurvivorsTreeNode() {
            return this.GetChildSubNodeByTag("onlineSurvivors");
        }

        /// <summary>
        /// Gets the online players tree node.
        /// </summary>
        /// <returns></returns>
        private TreeNode GetOfflineSurvivorsTreeNode() {
            return this.GetChildSubNodeByTag("offlineSurvivors");
        }

        /// <summary>
        /// Gets a tree node by tag
        /// </summary>
        /// <param name="tag">The tag to search for</param>
        /// <returns></returns>
        private TreeNode GetChildSubNodeByTag(String tag) {
            foreach (TreeNode node in this.dayzLogParserForm.blissHivePlayerTree.Nodes) {
                foreach (TreeNode subNode in node.Nodes) {
                    if (subNode.Tag.ToString() == tag) {
                        return subNode;
                    }
                }
            }
            return null;
        }
        #endregion

        /*
        /// <summary>
        /// Called when the user clicked on a node in the tree
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void blisshivePlayerTree_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e) {
            
        }*/
    }
}
