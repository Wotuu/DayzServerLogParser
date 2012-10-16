using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.BlissHive.Survivor;

namespace DayzLogParser.Log.BlissHive.Inventory {
    public class BlissHiveLogActivityItem {

        public BlissHiveLogSurvivor survivor { get; set; }
        public int quantity { get; set; }
        public BlissHiveLogItem item { get; set; }
        public String timestamp { get; set; }

        public BlissHiveLogActivityItem(BlissHiveLogSurvivor survivor, int quantity, BlissHiveLogItem item, String timestamp) {
            this.survivor = survivor;
            this.quantity = quantity;
            this.item = item;
            this.timestamp = timestamp;
        }

        public override String ToString() {
            String action = (this.quantity < 0) ? "dropped" : "picked up";
            String where = (this.quantity < 0) ? "from" : "now in";
            return "Survivor " + survivor.username + " " + action + " " + this.item.key +
            " (" + where + " " + this.item.location.ToString() + ")";
        }
    }
}
