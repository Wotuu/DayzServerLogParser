using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.BlissHive.Inventory;
using DayzLogParser.Log.BlissHive.Inventory.Survivor;

namespace DayzLogParser.Log.BlissHive.Survivor {
    public class BlissHiveLogSurvivor : LogSurvivor {
        public String survivorID { get; protected set; }
        public String survivorUpdateID { get; set; }
        public double lastSignOfActivity { get; set; }

        public Boolean online { get; set; }

        public LinkedList<BlissHiveLogSurvivorActivityItem> activity { get; set; }
        public LinkedList<BlissHiveLogInventory> inventories { get; set; }
        public LinkedList<BlissHiveLogDebugMonitor> debugMonitors { get; set; }
        public LinkedList<String> locations { get; protected set; }

        public BlissHiveLogSurvivor(String username, String survivorID) : base(username) {
            this.survivorID = survivorID;
            // If this survivor was made, then he must be online right?
            this.online = true;

            this.activity = new LinkedList<BlissHiveLogSurvivorActivityItem>();
            this.inventories = new LinkedList<BlissHiveLogInventory>();
            this.debugMonitors = new LinkedList<BlissHiveLogDebugMonitor>();
            this.locations = new LinkedList<String>();
        }
    }
}
