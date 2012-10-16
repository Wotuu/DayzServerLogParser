using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DayzLogParser.Log.BlissHive.Object.Type {
    public class BlissHiveLogObjectType {

        public static BlissHiveLogObjectType motorCycle { get; private set; }
        public static BlissHiveLogObjectType car { get; private set; }
        public static BlissHiveLogObjectType uaz { get; private set; }
        public static BlissHiveLogObjectType hatchback { get; private set; }
        public static BlissHiveLogObjectType uh1h { get; private set; }
        public static BlissHiveLogObjectType ural { get; private set; }
        public static BlissHiveLogObjectType bicycle { get; private set; }
        public static BlissHiveLogObjectType tent { get; private set; }

        public static LinkedList<BlissHiveLogObjectType> typeList { get; private set; }

        static BlissHiveLogObjectType() {
            BlissHiveLogObjectType.motorCycle =
                new BlissHiveLogObjectType(5, 0, 0, 2, 0, false, true, true, true, true, "Motorcycle");
            BlissHiveLogObjectType.car =
                new BlissHiveLogObjectType(50, 2, 5, 4, 4, false, true, true, true, true, "Car");
            BlissHiveLogObjectType.uaz =
                new BlissHiveLogObjectType(50, 7, 10, 4, 6, false, true, true, true, true, "UAZ");
            BlissHiveLogObjectType.hatchback =
                new BlissHiveLogObjectType(50, 2, 10, 4, 5, false, true, true, true, true, "Old Hatchback");
            BlissHiveLogObjectType.uh1h =
                new BlissHiveLogObjectType(20, 1, 2, 0, 9, true, true, true, true, false, "UH-1H");
            BlissHiveLogObjectType.ural =
                new BlissHiveLogObjectType(200, 8, 50, 6, 6, false, true, true, true, false, "Ural Civilian");
            BlissHiveLogObjectType.bicycle =
                new BlissHiveLogObjectType(0, 0, 0, 2, 0, false, true, false, false, false, "Bicycle");
            BlissHiveLogObjectType.tent =
                new BlissHiveLogObjectType(0, 0, 10, 0, 0, false, false, false, false, false, "Tent");

            BlissHiveLogObjectType.typeList = new LinkedList<BlissHiveLogObjectType>();
            BlissHiveLogObjectType.typeList.AddLast(BlissHiveLogObjectType.motorCycle);
            BlissHiveLogObjectType.typeList.AddLast(BlissHiveLogObjectType.car);
            BlissHiveLogObjectType.typeList.AddLast(BlissHiveLogObjectType.uaz);
            BlissHiveLogObjectType.typeList.AddLast(BlissHiveLogObjectType.hatchback);
            BlissHiveLogObjectType.typeList.AddLast(BlissHiveLogObjectType.uh1h);
            BlissHiveLogObjectType.typeList.AddLast(BlissHiveLogObjectType.ural);
            BlissHiveLogObjectType.typeList.AddLast(BlissHiveLogObjectType.bicycle);
            BlissHiveLogObjectType.typeList.AddLast(BlissHiveLogObjectType.tent);
        }

        public int itemSlots { get; set; }
        public int backpackSlots { get; set; }
        public int weaponSlots { get; set; }
        public int wheels { get; set; }
        public int glass { get; set; }
        public Boolean hasRotor { get; set; }
        public Boolean hasHull { get; set; }
        public Boolean hasEngine { get; set; }
        public Boolean hasFuel { get; set; }
        public Boolean hasFuelTankParts { get; set; }
        public String name { get; set; }

        private BlissHiveLogObjectType(
            int itemSlots, int backpackSlots, int weaponSlots,
            int wheels, int glass,
            Boolean hasRotor, Boolean hasHull, Boolean hasEngine,
            Boolean hasFuel, Boolean hasFuelTankParts, String name) {

            this.itemSlots = itemSlots;
            this.backpackSlots = backpackSlots;
            this.weaponSlots = weaponSlots;

            this.wheels = wheels;
            this.glass = glass;

            this.hasRotor = hasRotor;
            this.hasHull = hasHull;
            this.hasEngine = hasEngine;
            this.hasFuel = hasFuel;
            this.hasFuelTankParts = hasFuelTankParts;

            this.name = name;
        }

        /// <summary>
        /// Estimates the object type based on a lot of parameters.
        /// </summary>
        /// <param name="itemSlots"></param>
        /// <param name="backpackSlots"></param>
        /// <param name="weaponSlots"></param>
        /// <param name="wheels"></param>
        /// <param name="glass"></param>
        /// <param name="hasRotor"></param>
        /// <param name="hasHull"></param>
        /// <param name="hasEngine"></param>
        /// <param name="hasFuel"></param>
        /// <param name="hasFuelTankParts"></param>
        /// <returns>A list with items which may be the object.</returns>
        public static LinkedList<BlissHiveLogObjectType> EstimateObjectType(
            int itemSlots, int backpackSlots, int weaponSlots,
            int wheels, int glass,
            Boolean hasRotor, Boolean hasHull, Boolean hasEngine,
            Boolean hasFuel, Boolean hasFuelTankParts) {
            
            LinkedList<BlissHiveLogObjectType> result = new LinkedList<BlissHiveLogObjectType>();

            if (itemSlots <= 50 &&
                backpackSlots <= 5 &&
                weaponSlots <= 10 &&
                wheels == 0 && glass == 0 &&
                !hasRotor && !hasHull && !hasEngine &&
                !hasFuel && !hasFuelTankParts) {
                // This must only be a tent, end of story!
                result.AddLast(BlissHiveLogObjectType.tent);
                return result;
            }

            foreach (BlissHiveLogObjectType type in BlissHiveLogObjectType.typeList) {
                if (type.itemSlots < itemSlots ||
                    type.backpackSlots < backpackSlots ||
                    type.weaponSlots < weaponSlots ||
                    type.wheels < wheels ||
                    type.glass < glass ||
                    (!type.hasRotor && hasRotor) ||
                    (!type.hasFuel && hasFuel) ||
                    (!type.hasFuelTankParts && hasFuelTankParts) ||
                    (!type.hasHull && hasHull) ||
                    (!type.hasEngine && hasEngine)
                    )
                    continue;
                result.AddLast(type);
            }
            return result;
        }
    }
}
