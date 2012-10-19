using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.BlissHive.Survivor;
using DayzLogParser.Log.BlissHive.Inventory.Object;
using DayzLogParser.Log.BlissHive.Object;
using DayzLogParser.Log.BlissHive.Inventory.Survivor;

namespace DayzLogParser.Log.BlissHive.Inventory {
    public class BlissHiveLogInventory {
        public LinkedList<BlissHiveLogItem> items { get; protected set; }
        public LogEntry originalLogEntry { get; set; }

        public BlissHiveLogInventory() {
            this.items = new LinkedList<BlissHiveLogItem>();
        }

        public BlissHiveLogInventory(LogEntry originalLogEntry) {
            this.originalLogEntry = originalLogEntry;
            this.items = new LinkedList<BlissHiveLogItem>();
        }

        /// <summary>
        /// Merges the inventory and backpack to the inventory, and gets the list
        /// </summary>
        /// <returns></returns>
        public LinkedList<BlissHiveLogItem> GetMergedItemList() {
            LinkedList<BlissHiveLogItem> result = new LinkedList<BlissHiveLogItem>();
            foreach (BlissHiveLogItem item in this.items) {
                // All items are in the inventory now for easing calculation-+
                BlissHiveLogItem newItem = item.Clone();
                newItem.location = BlissHiveLogItem.Location.Inventory;
                result.AddLast(newItem);
            }

            return this.Group(result);
        }

        /// <summary>
        /// Groups all the items within this collection.
        /// </summary>
        public void GroupItems() {
            this.items = this.Group(this.items);
        }

        /// <summary>
        /// Groups the given items (adds quantities), in the inventory and backpack seperately
        /// </summary>
        /// <param name="items">The items to group.</param>
        /// <returns>The grouped list.</returns>
        private LinkedList<BlissHiveLogItem> Group(LinkedList<BlissHiveLogItem> items) {
            for (int i = 0; i < items.Count; i++) {
                BlissHiveLogItem item = items.ElementAt(i);
                for (int j = 0; j < items.Count; j++) {
                    if (i == j)
                        continue;
                    BlissHiveLogItem otherItem = items.ElementAt(j);

                    if (item.location != otherItem.location)
                        continue;

                    if (item.key == otherItem.key) {
                        items.Remove(otherItem);
                        item.quantity += otherItem.quantity;
                        i--;
                        j--;
                        // Continue, re-search the entire backpack for more duplicates
                        // of the same item
                        break;
                    }
                }
            }


            return items;
        }

        #region Get difference between two inventories
        /// <summary>
        /// Gets the difference between two inventories.
        /// </summary>
        /// <param name="survivor"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <returns></returns>
        public static LinkedList<BlissHiveLogActivityItem>
            GetItemDifference(BlissHiveLogInventory before,
                              BlissHiveLogInventory after) {

            LinkedList<BlissHiveLogActivityItem> result = new LinkedList<BlissHiveLogActivityItem>();

            LinkedList<BlissHiveLogItem> beforeMerged = before.items;
            LinkedList<BlissHiveLogItem> afterMerged = after.items;

            // Comparing items which were in the inventory, but aren't now
            //
            // For each item which was in the inventory before
            foreach (BlissHiveLogItem item in beforeMerged) {
                int count = 0;
                // For each item that was in the inventory after
                foreach (BlissHiveLogItem otherItem in afterMerged) {
                    // Can't compare inventory items to backpack items
                    if (item.location == otherItem.location) {
                        // If the key is the same
                        if (otherItem.key == item.key) {
                            // But the quantity was different ..
                            if (otherItem.quantity != item.quantity) {
                                // Something changed, log it
                                result.AddLast(
                                    new BlissHiveLogActivityItem(otherItem.quantity - item.quantity, item,
                                            after.originalLogEntry.timestamp));
                            }
                            break;
                        }
                    }
                    // If the item apparantly wasn't in the new inventory
                    if (count == afterMerged.Count - 1) {
                        // Log it
                        result.AddLast(
                            new BlissHiveLogActivityItem(-1, item,
                                    after.originalLogEntry.timestamp));
                    }
                    // Increase the count
                    count++;
                }
            }

            // Comparing items that are now in the inventory,
            // but weren't there before
            //
            // For each item which was in the inventory after
            foreach (BlissHiveLogItem item in afterMerged) {
                int count = 0;
                // For each item that was in the inventory before
                foreach (BlissHiveLogItem otherItem in beforeMerged) {
                    // Can't compare inventory items to backpack items
                    if (item.location == otherItem.location) {
                        // If the key is the same
                        if (otherItem.key == item.key) {
                            // We already checked it above, skip it
                            break;
                        }
                    }
                    // If the item apparantly wasn't in the old inventory
                    if (count == beforeMerged.Count - 1) {
                        // Log it
                        result.AddLast(
                            new BlissHiveLogActivityItem(1, item,
                                    after.originalLogEntry.timestamp));
                    }
                    count++;
                }
            }


            return result;
        }
        #endregion



        /// <summary>
        /// Adds an object to a list of normal activity items
        /// </summary>
        /// <param name="logObject"></param>
        /// <param name="activityItems"></param>
        /// <returns></returns>
        public static LinkedList<BlissHiveLogActivityItem>
            AddObject(BlissHiveLogObject logObject,
                    LinkedList<BlissHiveLogActivityItem> activityItems) {

            LinkedList<BlissHiveLogActivityItem> result =
                new LinkedList<BlissHiveLogActivityItem>();

            foreach (BlissHiveLogActivityItem activityItem in activityItems) {
                result.AddLast(
                    new BlissHiveLogObjectActivityItem(
                        logObject, activityItem.quantity,
                        activityItem.item, activityItem.timestamp
                    )
                );
            }

            return result;
        }

        /// <summary>
        /// Adds a survivor to a list of normal activity items
        /// </summary>
        /// <param name="survivor"></param>
        /// <param name="activityItems"></param>
        /// <returns></returns>
        public static LinkedList<BlissHiveLogActivityItem>
            AddSurvivor(BlissHiveLogSurvivor survivor,
                    LinkedList<BlissHiveLogActivityItem> activityItems) {

            LinkedList<BlissHiveLogActivityItem> result =
                new LinkedList<BlissHiveLogActivityItem>();

            foreach (BlissHiveLogActivityItem activityItem in activityItems) {
                result.AddLast(
                    new BlissHiveLogSurvivorActivityItem(
                        survivor, activityItem.quantity,
                        activityItem.item, activityItem.timestamp
                    )
                );
            }

            return result;
        }
    }
}
