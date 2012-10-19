using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.BlissHive.Object;

namespace DayzLogParser.Log.BlissHive.Inventory.Object {
    public class BlissHiveLogObjectActivityItem : BlissHiveLogActivityItem{

        public BlissHiveLogObject logObject { get; private set; }

        public BlissHiveLogObjectActivityItem(BlissHiveLogObject survivor,
            int quantity, BlissHiveLogItem item, String timestamp)
            : base(quantity, item, timestamp) {
                this.logObject = survivor;
        }

        public override String ToString() {
            String action = (this.quantity < 0) ? "dropped" : "picked up";
            String where = (this.quantity < 0) ? "from" : "now in";
            return "Object " + this.logObject.objectUpdateID + " " + action + " " + this.item.key +
            " (" + where + " " + this.item.location.ToString() + ")";
        }
    }
}
