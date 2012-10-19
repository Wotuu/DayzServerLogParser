using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using DayzLogParser.Log;
using DayzLogParser.Log.BlissHive.Survivor;
using DayzLogParser.Log.BlissHive;
using DayzLogParser.Log.BlissHive.Inventory;

namespace DayzLogParser.UI.BlissHive {
    public class BlissHivePlayerTreeHandler {

        public DayzLogParserForm dayzLogParserForm { get; set; }
        public BlissHiveLogSurvivor selectedSurvivor { get; set; }

        public BlissHivePlayerTreeHandler(DayzLogParserForm dayzLogParser) {
            this.dayzLogParserForm = dayzLogParser;
            this.dayzLogParserForm.blissHiveTree.AfterSelect += new TreeViewEventHandler(blissHivePlayerTree_AfterSelect);
            // this.dayzLogParserForm.blissHivePlayerTree.NodeMouseClick += new TreeNodeMouseClickEventHandler(blisshivePlayerTree_NodeMouseClick);

            this.dayzLogParserForm.blissHivePlayerDataInventoryHistoryComboBox.SelectedIndexChanged
                += new EventHandler(blissHivePlayerDataInventoryHistoryComboBox_SelectedIndexChanged);

            this.dayzLogParserForm.blissHivePlayerDataDebugMonitorHistoryComboBox.SelectedIndexChanged
                += new EventHandler(blissHivePlayerDataDebugMonitorHistoryComboBox_SelectedIndexChanged);
        }



        #region If someone clicked on a node
        void blissHivePlayerTree_AfterSelect(object sender, TreeViewEventArgs e) {
            if ((String)e.Node.Tag == "survivor") {
                this.dayzLogParserForm.blissHiveCardControl.SelectedIndex = 0;
                this.dayzLogParserForm.blissHivePlayerName.Text = "Player " + e.Node.Text;
                foreach (BlissHiveLogSurvivor survivor in LogController.GetInstance().blissHiveLogContainer.survivorContainer.survivors) {
                    if (survivor.username == e.Node.Text) {
                        this.selectedSurvivor = survivor;

                        // Fill the formatted data control
                        this.dayzLogParserForm.blissHivePlayerDataFormattedLogDataListView.Items.Clear();
                        foreach (BlissHiveLogEntry logEntry in survivor.logEntries) {
                            this.dayzLogParserForm.blissHivePlayerDataFormattedLogDataListView.Items.Add(
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
                        this.dayzLogParserForm.blissHivePlayerDataRawLogDataTextBox.Text = stringBuilder.ToString();


                        // Fill the combo box for the inventories
                        ComboBox inventoryComboBox = this.dayzLogParserForm.blissHivePlayerDataInventoryHistoryComboBox;
                        inventoryComboBox.Items.Clear();

                        foreach (BlissHiveLogInventory inv in survivor.inventories) {
                            inventoryComboBox.Items.Add(inv.originalLogEntry.timestamp);
                        }

                        // If selected, the list views will clear & fill
                        if (inventoryComboBox.Items.Count > 0)
                            inventoryComboBox.SelectedIndex = inventoryComboBox.Items.Count - 1;
                        else {
                            // If not selected, the list views need to be cleared still
                            this.dayzLogParserForm
                                .blissHivePlayerDataInventoryHistoryBackpackListView.Items.Clear();
                            this.dayzLogParserForm
                                .blissHivePlayerDataInventoryHistoryInventoryListView.Items.Clear();
                        }

                        // Fill the combo box for the debug log
                        ComboBox debugMonitorComboBox =
                            this.dayzLogParserForm.blissHivePlayerDataDebugMonitorHistoryComboBox;
                        debugMonitorComboBox.Items.Clear();

                        foreach (BlissHiveLogDebugMonitor debug in survivor.debugMonitors) {
                            debugMonitorComboBox.Items.Add(debug.originalLogEntry.timestamp);
                        }

                        // If selected, the list views will clear & fill
                        if (debugMonitorComboBox.Items.Count > 0)
                            debugMonitorComboBox.SelectedIndex = debugMonitorComboBox.Items.Count - 1;
                        else {
                            // If not selected, the list views need to be cleared still
                            this.dayzLogParserForm
                                .blissHivePlayerDataDebugMonitorHistoryListView.Items.Clear();
                        }

                        // Fill the activity log
                        ListView listView = this.dayzLogParserForm.blissHivePlayerDataActivityLogListView;
                        listView.Items.Clear();

                        foreach (BlissHiveLogActivityItem item in survivor.activity) {
                            ListViewItem listViewItem =
                                new ListViewItem(new String[2] { item.timestamp + "", item.ToString() });
                            listView.Items.Add(listViewItem);
                        }

                        // Enable all the tabs!
                        foreach (TabPage tab in this.dayzLogParserForm.blissHivePlayerDataTabControl.TabPages) {
                            tab.Enabled = true;
                        }

                        this.dayzLogParserForm.blissHivePlayerDataTabControl.Enabled = true;
                    }
                }
            }
        }
        #endregion

        #region When someone changed the inventory for a survivor
        /// <summary>
        /// When someone selected a new inventory to display in the inventory history selectbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void blissHivePlayerDataInventoryHistoryComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox comboBox = this.dayzLogParserForm.blissHivePlayerDataInventoryHistoryComboBox;

            if (this.selectedSurvivor != null) {
                foreach (BlissHiveLogInventory inv in this.selectedSurvivor.inventories) {
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
        #endregion

        /// <summary>
        /// When someone selected a new inventory to display in the inventory history selectbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void blissHivePlayerDataDebugMonitorHistoryComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox comboBox = this.dayzLogParserForm.blissHivePlayerDataDebugMonitorHistoryComboBox;

            if (this.selectedSurvivor != null) {
                foreach (BlissHiveLogDebugMonitor debug in this.selectedSurvivor.debugMonitors) {
                    if (debug.originalLogEntry.timestamp == (String)comboBox.SelectedItem) {

                        this.dayzLogParserForm.blissHivePlayerDataDebugMonitorHistoryListView.Items.Clear();

                        // Yes, we're suppose to start at 1. See enum declaration, starts at 1 as well
                        int count = 1;
                        foreach (String stat in debug.stats) {
                            String enumName = "";
                            if (Enum.IsDefined(typeof(BlissHiveLogDebugMonitor.DebugMonitorStat), count))
                                enumName = ((BlissHiveLogDebugMonitor.DebugMonitorStat)count).ToString();
                            else
                                enumName = "Invalid Value";

                            ListViewItem listViewItem = new ListViewItem(
                                            new String[2] { enumName, stat });

                            this.dayzLogParserForm.blissHivePlayerDataDebugMonitorHistoryListView
                                .Items.Add(listViewItem);

                            count++;
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

                    TreeNode survivorNode = new TreeNode(survivor.username);
                    survivorNode.Tag = "survivor";
                    if (survivor.online) {
                        this.GetOnlineSurvivorsTreeNode().Nodes.Add(survivorNode);
                    } else {
                        this.GetOfflineSurvivorsTreeNode().Nodes.Add(survivorNode);
                    }
                }
            }
        }

        /// <summary>
        /// Gets the online survivors tree node.
        /// </summary>
        /// <returns></returns>
        private TreeNode GetOnlineSurvivorsTreeNode() {
            return this.GetChildSubNodeByTag("onlineSurvivors");
        }

        /// <summary>
        /// Gets the online survivors tree node.
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
            foreach (TreeNode node in this.dayzLogParserForm.blissHiveTree.Nodes) {
                foreach (TreeNode subNode in node.Nodes) {
                    if (subNode.Tag.ToString() == tag) {
                        return subNode;
                    }
                }
            }
            return null;
        }
        #endregion
    }
}
