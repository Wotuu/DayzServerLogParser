using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.Parsing;
using DayzLogParser.Log.BlissHive.Survivor;
using DayzLogParser.Log.BlissHive.Inventory;

namespace DayzLogParser.Log.BlissHive.Parsing.Survivor.Activity {
    public class BlissHiveActivityLogParser : LogParser {

        // If we didn't hear from someone for at least 3 minutes, assume this nigga offline
        public static readonly int OFFLINE_MS_LIMIT = 180000;

        public BlissHiveActivityLogParser(BlissHiveLogContainer container)
            : base(container) {

        }

        public override LogParseResult Parse() {
            LinkedList<LogParseResultEntry> result = new LinkedList<LogParseResultEntry>();

            BlissHiveLogContainer blissHiveLogContainer = (BlissHiveLogContainer)this.container;

            foreach( BlissHiveLogSurvivor survivor in blissHiveLogContainer.survivorContainer.survivors ){
                for( int i = 0; i < survivor.inventories.Count - 1; i++ ){
                    BlissHiveLogInventory inv = survivor.inventories.ElementAt(i);
                    BlissHiveLogInventory nextInv = survivor.inventories.ElementAt(i + 1);

                    LinkedList<BlissHiveLogActivityItem> changedItems =
                        this.GetItemDifference(survivor, inv, nextInv);

                    BlissHiveActivityLogParseResultEntry change =
                        new BlissHiveActivityLogParseResultEntry(nextInv.originalLogEntry);
                    change.changedItems = changedItems;

                    result.AddLast(change);
                }
            }

            this.onParseProgressListeners = null;
            return new LogParseResult(result);
        }

        /// <summary>
        /// Gets the difference between two inventories.
        /// </summary>
        /// <param name="survivor"></param>
        /// <param name="before"></param>
        /// <param name="after"></param>
        /// <returns></returns>
        public LinkedList<BlissHiveLogActivityItem>
            GetItemDifference(BlissHiveLogSurvivor survivor,
                              BlissHiveLogInventory before,
                              BlissHiveLogInventory after) {
            
            LinkedList<BlissHiveLogActivityItem> result = new LinkedList<BlissHiveLogActivityItem>();

            LinkedList<BlissHiveLogItem> beforeMerged = before.items;
            LinkedList<BlissHiveLogItem> afterMerged = after.items;/*
            LinkedList<BlissHiveLogItem> beforeMerged = before.GetMergedItemList();
            LinkedList<BlissHiveLogItem> afterMerged = after.GetMergedItemList();*/
            /*
            List<BlissHiveLogItem> except = afterMerged.Except(beforeMerged).ToList();

            foreach (BlissHiveLogItem item in except) {
                if( beforeMerged.Contains(
            }*/

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
                                    new BlissHiveLogActivityItem(
                                            survivor, otherItem.quantity - item.quantity, item,
                                            after.originalLogEntry.timestamp));
                            }
                            break;
                        }
                    }
                    // If the item apparantly wasn't in the new inventory
                    if (count == afterMerged.Count - 1) {
                        // Log it
                        result.AddLast(
                            new BlissHiveLogActivityItem(
                                    survivor, -1, item,
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
                            /*
                            // But the quantity was different ..
                            if (otherItem.quantity != item.quantity) {
                                // Something changed, log it
                                result.AddLast(
                                    new BlissHiveLogActivityItem(
                                            survivor, otherItem.quantity - item.quantity, item,
                                            after.originalLogEntry.timestamp));
                            }*/
                            break;
                        }
                    }
                    // If the item apparantly wasn't in the old inventory
                    if (count == beforeMerged.Count - 1) {
                        // Log it
                        result.AddLast(
                            new BlissHiveLogActivityItem(
                                    survivor, 1, item,
                                    after.originalLogEntry.timestamp));
                    }
                    count++;
                }
            }


            return result;
        }

        /// <summary>
        /// Checks if a given name already exists in the result set.
        /// </summary>
        /// <param name="result">The result set to search.</param>
        /// <param name="survivorName">The survivor name to search for.</param>
        /// <returns>Yes or no.</returns>
        private Boolean ContainsSurvivor(LinkedList<LogParseResultEntry> result, String survivorName) {
            foreach (BlissHiveSurvivorLogParseResultEntry entry in result) {
                if (entry.survivor.username == survivorName)
                    return true;
            }
            return false;
        }

        private BlissHiveSurvivorLogParseResultEntry GetSurvivor(LinkedList<LogParseResultEntry> result, String survivorName) {
            foreach (BlissHiveSurvivorLogParseResultEntry entry in result) {
                if (entry.survivor.username == survivorName)
                    return entry;
            }
            return null;
        }

        public override int GetProgressMaxLength() {
            return this.container.logs.Length;
        }
    }
}
