using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.Log.BlissHive.Object {
    public class BlissHiveLogObjectHealth {
        public String part { get; set; }
        public double health { get; set; }

        public BlissHiveLogObjectHealth(String part, double health) {
            this.part = part;
            this.health = health;
        }
    }
}
