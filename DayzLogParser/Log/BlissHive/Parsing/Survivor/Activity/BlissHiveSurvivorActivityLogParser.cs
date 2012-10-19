using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.Parsing;
using DayzLogParser.Log.BlissHive.Survivor;
using DayzLogParser.Log.BlissHive.Inventory;

namespace DayzLogParser.Log.BlissHive.Parsing.Survivor.Activity {
    public class BlissHiveSurvivorActivityLogParser : LogParser {

        // If we didn't hear from someone for at least 3 minutes, assume this nigga offline
        public static readonly int OFFLINE_MS_LIMIT = 180000;

        public BlissHiveSurvivorActivityLogParser(BlissHiveLogContainer container)
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
                        BlissHiveLogInventory.GetItemDifference(inv, nextInv);

                    changedItems = BlissHiveLogInventory.AddSurvivor(survivor, changedItems);

                    BlissHiveSurvivorActivityLogParseResultEntry change =
                        new BlissHiveSurvivorActivityLogParseResultEntry(nextInv.originalLogEntry);
                    change.changedItems = changedItems;

                    result.AddLast(change);
                }
            }

            this.onParseProgressListeners = null;
            return new LogParseResult(result);
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
