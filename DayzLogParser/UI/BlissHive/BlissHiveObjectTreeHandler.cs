using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.BlissHive.Object;
using System.Windows.Forms;
using DayzLogParser.Log;
using DayzLogParser.Log.BlissHive;
using DayzLogParser.Log.BlissHive.Inventory;

namespace DayzLogParser.UI.BlissHive {
    public class BlissHiveObjectTreeHandler {
        public DayzLogParserForm dayzLogParserForm { get; set; }
        public BlissHiveLogObject selectedObject { get; set; }

        public BlissHiveObjectTreeHandler(DayzLogParserForm dayzLogParser) {
            this.dayzLogParserForm = dayzLogParser;
            this.dayzLogParserForm.blissHiveTree.AfterSelect += new TreeViewEventHandler(blissHivePlayerTree_AfterSelect);

            this.dayzLogParserForm.blissHiveObjectDataInventoryHistoryComboBox.SelectedIndexChanged
                += new EventHandler(blissHiveObjectDataInventoryHistoryComboBox_SelectedIndexChanged);
        }

        #region If someone clicked on a node
        void blissHivePlayerTree_AfterSelect(object sender, TreeViewEventArgs e) {
            if ((String)e.Node.Tag == "object") {
                this.dayzLogParserForm.blissHiveCardControl.SelectedIndex = 1;
                foreach (BlissHiveLogObject logObject in LogController.GetInstance().blissHiveLogContainer.logObjectContainer.logObjects) {
                    if (logObject.objectUpdateID == e.Node.Text) {
                        this.selectedObject = logObject;
                this.dayzLogParserForm.blissHivePlayerName.Text = "Object " + e.Node.Text + " (" + logObject.EstimateObjectType() + ")";

                        // Fill the formatted data control
                        this.dayzLogParserForm.blissHiveObjectDataFormattedLogDataListView.Items.Clear();
                        foreach (BlissHiveLogEntry logEntry in logObject.logEntries) {
                            this.dayzLogParserForm.blissHiveObjectDataFormattedLogDataListView.Items.Add(
                                new ListViewItem(
                                    new String[3] { logEntry.timestamp, logEntry.functionName, 
                                        String.Join(", ", logEntry.parameters) }
                                    )
                                );
                        }

                        // Fill the raw data control
                        StringBuilder stringBuilder = new StringBuilder("");
                        foreach (BlissHiveLogEntry logEntry in logObject.logEntries) {
                            stringBuilder.AppendLine(logEntry.original);
                        }
                        this.dayzLogParserForm.blissHiveObjectDataRawLogDataTextBox.Text = stringBuilder.ToString();

                        // Fill the combo box for the inventories
                        ComboBox inventoryComboBox = this.dayzLogParserForm.blissHiveObjectDataInventoryHistoryComboBox;
                        inventoryComboBox.Items.Clear();

                        foreach (BlissHiveLogInventory inv in logObject.inventories) {
                            inventoryComboBox.Items.Add(inv.originalLogEntry.timestamp);
                        }

                        // If selected, the list views will clear & fill
                        if (inventoryComboBox.Items.Count > 0)
                            inventoryComboBox.SelectedIndex = inventoryComboBox.Items.Count - 1;
                        else {
                            // If not selected, the list views need to be cleared still
                            this.dayzLogParserForm
                                .blissHiveObjectDataInventoryHistoryBackpackListView.Items.Clear();
                            this.dayzLogParserForm
                                .blissHiveObjectDataInventoryHistoryInventoryListView.Items.Clear();
                        }

                        // Fill the health control
                        this.dayzLogParserForm.blissHiveObjectDataHealthListView.Items.Clear();
                        foreach (BlissHiveLogObjectHealth healthEntry in logObject.health) {
                            this.dayzLogParserForm.blissHiveObjectDataHealthListView.Items.Add(
                                new ListViewItem(new String[2] { healthEntry.part, healthEntry.health + "" }));
                        }

                        this.dayzLogParserForm.blissHiveObjectDataHealthTypeEstimateTextBox.Text =
                            logObject.EstimateObjectType().Replace(", ", "\r\n");
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
        void blissHiveObjectDataInventoryHistoryComboBox_SelectedIndexChanged(object sender, EventArgs e) {
            ComboBox comboBox = this.dayzLogParserForm.blissHiveObjectDataInventoryHistoryComboBox;

            if (this.selectedObject != null) {
                foreach (BlissHiveLogInventory inv in this.selectedObject.inventories) {
                    if (inv.originalLogEntry.timestamp == (String)comboBox.SelectedItem) {

                        this.dayzLogParserForm.blissHiveObjectDataInventoryHistoryInventoryListView.Items.Clear();
                        this.dayzLogParserForm.blissHiveObjectDataInventoryHistoryBackpackListView.Items.Clear();

                        foreach (BlissHiveLogItem item in inv.items) {
                            ListViewItem listViewItem = new ListViewItem(
                                            new String[2] { item.quantity + "", item.key });
                            if (item.location == BlissHiveLogItem.Location.Inventory) {
                                this.dayzLogParserForm.blissHiveObjectDataInventoryHistoryInventoryListView
                                    .Items.Add(listViewItem);
                            } else if (item.location == BlissHiveLogItem.Location.Backpack) {
                                this.dayzLogParserForm.blissHiveObjectDataInventoryHistoryBackpackListView
                                    .Items.Add(listViewItem);
                            }
                        }

                        break;
                    }
                }
            }
        }
        #endregion

        #region Load Objects
        /// <summary>
        /// Loads all objects from the BlissHive log, and puts them in the tree view.
        /// </summary>
        public void LoadObjects() {
            if (this.dayzLogParserForm.blissHiveDownloadProgressBar.InvokeRequired) {
                this.dayzLogParserForm.BeginInvoke(new MethodInvoker(delegate() { this.LoadObjects(); }));
            } else {
                foreach (BlissHiveLogObject logObject in
                    LogController.GetInstance().blissHiveLogContainer.logObjectContainer.logObjects) {

                    TreeNode objectNode = new TreeNode(logObject.objectUpdateID);
                    objectNode.Tag = "object";

                    this.GetObjectsTreeNode().Nodes.Add(objectNode);
                }
            }
        }

        /// <summary>
        /// Gets the online objects tree node.
        /// </summary>
        /// <returns></returns>
        private TreeNode GetObjectsTreeNode() {
            return this.GetChildNodeByTag("objects");
        }

        /// <summary>
        /// Gets a tree node by tag
        /// </summary>
        /// <param name="tag">The tag to search for</param>
        /// <returns></returns>
        private TreeNode GetChildNodeByTag(String tag) {
            foreach (TreeNode node in this.dayzLogParserForm.blissHiveTree.Nodes) {
                if (node.Tag.ToString() == tag) {
                    return node;
                }
            }
            return null;
        }
        #endregion
    }
}
