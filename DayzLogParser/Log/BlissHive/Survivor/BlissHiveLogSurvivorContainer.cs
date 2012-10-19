using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.Survivor;
using DayzLogParser.Log.BlissHive.Parsing;
using DayzLogParser.Log.Parsing;
using DayzLogParser.Log.BlissHive.Parsing.Survivor.DebugMonitor;
using DayzLogParser.Log.BlissHive.Parsing.Survivor.Activity;
using DayzLogParser.Log.BlissHive.Parsing.Survivor.Inventory;
using DayzLogParser.Log.BlissHive.Inventory;
using DayzLogParser.Log.BlissHive.Parsing.Survivor;
using DayzLogParser.Log.BlissHive.Inventory.Survivor;

namespace DayzLogParser.Log.BlissHive.Survivor {
    public class BlissHiveLogSurvivorContainer : LogSurvivorContainer {

        public OnLogParseProgress onParseProgressListeners { get; set; }

        /// <summary>
        /// Loads the survivors into the container list.
        /// </summary>
        /// <param name="blissHive">The blisshive to load survivors from</param>
        public void LoadSurvivors(BlissHiveLogContainer blissHive) {
            BlissHiveSurvivorLogParser parser = new BlissHiveSurvivorLogParser(blissHive);
            parser.onParseProgressListeners += this.onParseProgressListeners;
            LogParseResult result = parser.Parse();

            foreach (BlissHiveSurvivorLogParseResultEntry entry in result.result) {
                this.survivors.AddLast(entry.survivor);
            }
            this.onParseProgressListeners = null;
        }

        /// <summary>
        /// Loads the inventory of all survivors. MUST LOAD SURVIVORS FIRST.
        /// </summary>
        /// <param name="blissHive">The hive to parse</param>
        public void LoadSurvivorInventory(BlissHiveLogContainer blissHive) {
            BlissHiveSurvivorInventoryLogParser parser = new BlissHiveSurvivorInventoryLogParser(blissHive);
            parser.onParseProgressListeners += this.onParseProgressListeners;
            
            LogParseResult result = parser.Parse();
            // Result is kinda pointless with this parse

            this.onParseProgressListeners = null;
        }

        /// <summary>
        /// Loads the activity log of all survivors. MUST LOAD SURVIVORS AND INVENTORIES FIRST.
        /// </summary>
        /// <param name="blissHive">The hive to parse</param>
        public void LoadSurvivorActivity(BlissHiveLogContainer blissHive) {
            BlissHiveSurvivorActivityLogParser parser = new BlissHiveSurvivorActivityLogParser(blissHive);
            parser.onParseProgressListeners += this.onParseProgressListeners;

            LogParseResult result = parser.Parse();

            foreach (BlissHiveSurvivorActivityLogParseResultEntry entry in result.result) {
                if( entry.changedItems.Count > 0 ){
                    foreach (BlissHiveLogSurvivor survivor in this.survivors) {
                        BlissHiveLogSurvivorActivityItem castItem = 
                            (BlissHiveLogSurvivorActivityItem)entry.changedItems.ElementAt(0);

                        if (survivor.survivorID == castItem.survivor.survivorID) {
                            foreach( BlissHiveLogSurvivorActivityItem item in entry.changedItems){
                                survivor.activity.AddLast(item);
                            }
                        }
                    }
                }
            }

            // Result is kinda pointless with this parse

            this.onParseProgressListeners = null;
        }

        /// <summary>
        /// Loads the debug monitors of all survivors. MUST LOAD SURVIVORS FIRST.
        /// </summary>
        /// <param name="blissHive">The hive to parse</param>
        public void LoadSurvivorDebugMonitor(BlissHiveLogContainer blissHive) {
            BlissHiveDebugMonitorLogParser parser = new BlissHiveDebugMonitorLogParser(blissHive);
            parser.onParseProgressListeners += this.onParseProgressListeners;

            LogParseResult result = parser.Parse();
            // Result is kinda pointless with this parse

            this.onParseProgressListeners = null;
        }
    }
}
