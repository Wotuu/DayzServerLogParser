using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
