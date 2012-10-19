using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.BlissHive.Survivor;
using DayzLogParser.Log.BlissHive.Object;

namespace DayzLogParser.Log.BlissHive.Inventory {
    public class BlissHiveLogActivityItem {
        /*
        public BlissHiveLogObject logObject { get; private set; }*/
        public int quantity { get; set; }
        public BlissHiveLogItem item { get; set; }
        public String timestamp { get; set; }

        public BlissHiveLogActivityItem(int quantity, BlissHiveLogItem item, String timestamp) {
            this.quantity = quantity;
            this.item = item;
            this.timestamp = timestamp;
        }
    }
}
