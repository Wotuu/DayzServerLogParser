using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.BlissHive.Survivor;

namespace DayzLogParser.Log.BlissHive.Inventory.Survivor {
    public class BlissHiveLogSurvivorActivityItem : BlissHiveLogActivityItem {

        public BlissHiveLogSurvivor survivor { get; private set; }

        public BlissHiveLogSurvivorActivityItem(BlissHiveLogSurvivor survivor,
            int quantity, BlissHiveLogItem item, String timestamp)
            : base(quantity, item, timestamp) {
                this.survivor = survivor;
        }

        public override String ToString() {
            String action = (this.quantity < 0) ? "dropped" : "picked up";
            String where = (this.quantity < 0) ? "from" : "now in";
            return "Survivor " + survivor.username + " " + action + " " + this.item.key +
            " (" + where + " " + this.item.location.ToString() + ")";
        }
    }
}
