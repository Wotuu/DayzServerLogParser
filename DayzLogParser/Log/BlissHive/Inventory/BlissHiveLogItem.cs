using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.Log.BlissHive.Inventory {
    public class BlissHiveLogItem {
        public String key { get; set; }
        public Location location { get; set; }
        public int quantity { get; set; }

        public String description { get; set; }

        public BlissHiveLogItemType itemType { get; set; }

        public enum Location {
            Inventory,
            Backpack
        }

        public BlissHiveLogItem(String key, Location location) {
            this.key = key;
            this.location = location;
            this.quantity = 1;

            this.itemType = BlissHiveLogItemType.Item;
        }

        public BlissHiveLogItem(String key, Location location, int quantity) {
            this.key = key;
            this.location = location;
            this.quantity = quantity;

            this.itemType = BlissHiveLogItemType.Item;
        }

        /// <summary>
        /// Clones this object.
        /// </summary>
        /// <returns></returns>
        public BlissHiveLogItem Clone() {
            BlissHiveLogItem item = new BlissHiveLogItem(this.key, this.location, this.quantity);
            item.description = this.description;
            return item;
        }
    }
}
