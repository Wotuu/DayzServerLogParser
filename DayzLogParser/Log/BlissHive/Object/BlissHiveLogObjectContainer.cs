using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.BlissHive.Parsing;
using DayzLogParser.Log.Parsing;
using DayzLogParser.Log.BlissHive.Inventory;
using DayzLogParser.Log.BlissHive.Parsing.Object;
using DayzLogParser.Log.Object;
using DayzLogParser.Log.BlissHive.Parsing.Object.Inventory;
using DayzLogParser.Log.BlissHive.Inventory.Object;
using DayzLogParser.Log.BlissHive.Parsing.Object.Activity;

namespace DayzLogParser.Log.BlissHive.Object {
    public class BlissHiveLogObjectContainer : LogObjectContainer {

        public OnLogParseProgress onParseProgressListeners { get; set; }

        /// <summary>
        /// Loads the survivors into the container list.
        /// </summary>
        /// <param name="blissHive">The blisshive to load survivors from</param>
        public void LoadObjects(BlissHiveLogContainer blissHive) {
            BlissHiveObjectLogParser parser = new BlissHiveObjectLogParser(blissHive);
            parser.onParseProgressListeners += this.onParseProgressListeners;
            LogParseResult result = parser.Parse();

            foreach (BlissHiveObjectLogParseResultEntry entry in result.result) {
                this.logObjects.AddLast(entry.logObject);
            }
            this.onParseProgressListeners = null;
        }

        /// <summary>
        /// Loads the inventory of all survivors. MUST LOAD SURVIVORS FIRST.
        /// </summary>
        /// <param name="blissHive">The hive to parse</param>
        public void LoadObjectInventory(BlissHiveLogContainer blissHive) {

            BlissHiveObjectInventoryLogParser parser = new BlissHiveObjectInventoryLogParser(blissHive);
            parser.onParseProgressListeners += this.onParseProgressListeners;

            LogParseResult result = parser.Parse();
            // Result is kinda pointless with this parse

            this.onParseProgressListeners = null;
        }

        /// <summary>
        /// Loads the activity log of all survivors. MUST LOAD SURVIVORS AND INVENTORIES FIRST.
        /// </summary>
        /// <param name="blissHive">The hive to parse</param>
        public void LoadObjectActivity(BlissHiveLogContainer blissHive) {
            BlissHiveObjectActivityLogParser parser = new BlissHiveObjectActivityLogParser(blissHive);
            parser.onParseProgressListeners += this.onParseProgressListeners;

            LogParseResult result = parser.Parse();

            foreach (BlissHiveObjectActivityLogParseResultEntry entry in result.result) {
                if (entry.changedItems.Count > 0) {
                    foreach (BlissHiveLogObject logObject in this.logObjects) {
                        BlissHiveLogObjectActivityItem castItem =
                            (BlissHiveLogObjectActivityItem)entry.changedItems.ElementAt(0);

                        if (logObject.objectUpdateID == castItem.logObject.objectUpdateID) {
                            foreach (BlissHiveLogObjectActivityItem item in entry.changedItems) {
                                logObject.activity.AddLast(item);
                            }
                        }
                    }
                }
            }

            // Result is kinda pointless with this parse

            this.onParseProgressListeners = null;
        }
    }
}
