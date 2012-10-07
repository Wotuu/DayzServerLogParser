using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.BlissHive.Survivor;

namespace DayzLogParser.Log.BlissHive {
    public class BlissHiveLogContainer : LogContainer {
        public BlissHiveLogSurvivorContainer survivorContainer { get; private set; }

        public BlissHiveLogContainer() {
            this.survivorContainer = new BlissHiveLogSurvivorContainer();
        }

        public override LogEntry CreateLog(string original) {
            return new BlissHiveLogEntry(original);
        }

        public override void ParseLog() {
            this.survivorContainer.onParseProgressListeners += this.onParseProgressListeners;
            this.survivorContainer.LoadSurvivors(this);
            // It's cleared at the end of the function, so re-attach
            this.survivorContainer.onParseProgressListeners += this.onParseProgressListeners;
            this.survivorContainer.LoadSurvivorInventory(this);
        }
    }
}
