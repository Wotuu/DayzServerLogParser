using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.Log.BlissHive.Survivor {
    public class BlissHiveLogSurvivor : LogSurvivor {
        public String survivorID { get; protected set; }
        public String survivorUpdateID { get; set; }
        public double lastSignOfActivity { get; set; }

        public Boolean online { get; set; }

        public BlissHiveLogSurvivorInventory inventory { get; set; }
        public LinkedList<BlissHiveLogSurvivorInventory> inventories { get; set; }
        public LinkedList<String> locations { get; protected set; }

        public BlissHiveLogSurvivor(String username, String survivorID) : base(username) {
            this.survivorID = survivorID;
            // If this survivor was made, then he must be online right?
            this.online = true;

            this.inventory = new BlissHiveLogSurvivorInventory();
            this.inventories = new LinkedList<BlissHiveLogSurvivorInventory>();
            this.locations = new LinkedList<String>();
        }
    }
}
