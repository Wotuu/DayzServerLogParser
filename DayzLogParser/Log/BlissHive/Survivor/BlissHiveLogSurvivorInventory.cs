using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.Log.BlissHive.Survivor {
    public class BlissHiveLogSurvivorInventory {
        public LinkedList<BlissHiveLogItem> items { get; protected set; }
        public LogEntry originalLogEntry { get; set; }

        public BlissHiveLogSurvivorInventory() {
            this.items = new LinkedList<BlissHiveLogItem>();
        }

        public BlissHiveLogSurvivorInventory(LogEntry originalLogEntry) {
            this.originalLogEntry = originalLogEntry;
            this.items = new LinkedList<BlissHiveLogItem>();
        }
    }
}
