using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.Survivor;
using DayzLogParser.Log.BlissHive.Parsing;
using DayzLogParser.Log.Parsing;
using DayzLogParser.Log.BlissHive.Parsing.Inventory;

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
            BlissHiveInventoryLogParser parser = new BlissHiveInventoryLogParser(blissHive);
            parser.onParseProgressListeners += this.onParseProgressListeners;
            
            LogParseResult result = parser.Parse();
            // Result is kinda pointless with this parse

            this.onParseProgressListeners = null;
        }
    }
}
