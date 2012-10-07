using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.Log.BlissHive.Survivor {
    public class BlissHiveLogItem {
        public String key { get; set; }
        public Location location { get; set; }
        public int quantity { get; set; }

        public String description { get; set; }

        public enum Location {
            Inventory,
            Backpack
        }

        public BlissHiveLogItem(String key, Location location) {
            this.key = key;
            this.location = location;
            this.quantity = 1;
        }

        public BlissHiveLogItem(String key, Location location, int quantity) {
            this.key = key;
            this.location = location;
            this.quantity = quantity;
        }
    }
}
