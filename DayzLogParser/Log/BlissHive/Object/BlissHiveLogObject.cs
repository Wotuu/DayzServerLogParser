using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.BlissHive.Inventory;
using DayzLogParser.Log.Object;
using DayzLogParser.Log.BlissHive.Object.Type;

namespace DayzLogParser.Log.BlissHive.Object {
    public class BlissHiveLogObject : LogObject {
        public String survivorID { get; set; }
        public String objectUpdateID { get; set; }

        public LinkedList<BlissHiveLogActivityItem> activity { get; set; }
        public LinkedList<BlissHiveLogInventory> inventories { get; set; }
        public LinkedList<BlissHiveLogObjectHealth> health { get; protected set; }
        public LinkedList<String[]> locations { get; protected set; }

        public BlissHiveLogObject(String objectUpdateID)
            : base() {
            this.objectUpdateID = objectUpdateID;

            this.activity = new LinkedList<BlissHiveLogActivityItem>();
            this.inventories = new LinkedList<BlissHiveLogInventory>();
            this.health = new LinkedList<BlissHiveLogObjectHealth>();
            this.locations = new LinkedList<String[]>();
        }

        /// <summary>
        /// Sets the health of a certain part, to a certain value.
        /// </summary>
        /// <param name="what">The value to set.</param>
        /// <param name="health">The health to set.</param>
        public void SetHealth(String what, double health) {
            int count = 0;
            Boolean hasModified = false;
            foreach (BlissHiveLogObjectHealth currentHealth in this.health) {
                if (what == currentHealth.part) {
                    currentHealth.health = health;
                    hasModified = true;
                    break;
                }
                count++;
            }
            if ((count == 0 || count == this.health.Count) && !hasModified) {
                this.health.AddLast(new BlissHiveLogObjectHealth(what, health));
            }
        }

        /// <summary>
        /// Attempts to guess the object type for this vehicle.
        /// </summary>
        /// <returns></returns>
        public String EstimateObjectType() {

            int glassCount = this.GetGlassCount();
            int wheelCount = this.GetWheelCount();
            int items = this.GetItemCount();
            int backpacks = this.GetBackpackCount();
            int weapons = this.GetWeaponCount();
            Boolean hasRotor = this.HasRotor();
            Boolean hasHull = this.HasHull();
            Boolean hasEngine = this.HasEngine();
            Boolean hasFuel = this.HasFuel();
            Boolean hasFuelTankParts = this.HasFuelTankParts();

            LinkedList<BlissHiveLogObjectType> result =
                BlissHiveLogObjectType.EstimateObjectType(
                items, backpacks, weapons, wheelCount, glassCount, hasRotor,
                hasHull, hasEngine, hasFuel, hasFuelTankParts);

            // Format it to a string.
            String[] implode = new String[result.Count];
            int count = 0;
            foreach (BlissHiveLogObjectType type in result) {
                implode[count] = type.name;
                count++;
            }

            return String.Join(", ", implode);
        }

        /// <summary>
        /// Gets the amount of glass on this object (if any..).
        /// </summary>
        /// <returns>The estimated amount of glass.</returns>
        private int GetGlassCount() {
            return this.GetItemCountByString("glass");
        }

        /// <summary>
        /// Gets the amount of wheels on this object (if any..).
        /// </summary>
        /// <returns>The estimated amount of wheels.</returns>
        private int GetWheelCount() {
            return this.GetItemCountByString("wheel");
        }

        /// <summary>
        /// Checks whether this object has a rotor or not.
        /// </summary>
        /// <returns>Yes or no.</returns>
        private Boolean HasRotor() {
            return this.GetItemCountByString("rotor") > 0;
        }

        /// <summary>
        /// Checks whether this object has fuel or not.
        /// </summary>
        /// <returns>Yes or no.</returns>
        private Boolean HasFuel() {
            return this.GetItemCountByString("palivo") > 0;
        }

        /// <summary>
        /// Checks whether this object has a hull or not.
        /// </summary>
        /// <returns>Yes or no.</returns>
        private Boolean HasHull() {
            return this.GetItemCountByString("karoserie") > 0;
        }

        /// <summary>
        /// Checks whether this object has an engine or not.
        /// </summary>
        /// <returns>Yes or no.</returns>
        private Boolean HasEngine() {
            return this.GetItemCountByString("motor") > 0;
        }

        /// <summary>
        /// Checks whether this object has a fuel tank part or not.
        /// </summary>
        /// <returns>Yes or no.</returns>
        private Boolean HasFuelTankParts() {
            return this.GetItemCountByString("fuel") > 0;
        }

        /// <summary>
        /// Gets the item count of a certain part in the current health list.
        /// </summary>
        /// <param name="contains"></param>
        /// <returns></returns>
        private int GetItemCountByString(String contains) {
            int count = 0;
            foreach (BlissHiveLogObjectHealth health in this.health) {
                if (health.part.Contains(contains))
                    count++;
            }
            return count;
        }

        /// <summary>
        /// Gets the item count for this vehicle.
        /// TODO: Count in the amount of backpacks.
        /// </summary>
        /// <returns></returns>
        private int GetItemCount() {
            return this.GetObjectTypeCount(BlissHiveLogItemType.Item);
        }

        /// <summary>
        /// Gets the backpack count for this vehicle.
        /// </summary>
        /// <returns></returns>
        private int GetBackpackCount() {
            return this.GetObjectTypeCount(BlissHiveLogItemType.Backpack);
        }

        /// <summary>
        /// Gets the weapon count for this vehicle.
        /// </summary>
        /// <returns></returns>
        private int GetWeaponCount() {
            return this.GetObjectTypeCount(BlissHiveLogItemType.Weapon);
        }

        /// <summary>
        /// Get the count for a certain item type in the current inventory.
        /// </summary>
        /// <param name="itemType"></param>
        /// <returns>The amount.</returns>
        private int GetObjectTypeCount(BlissHiveLogItemType itemType) {
            if (this.inventories.Count > 0) {
                BlissHiveLogInventory inv = this.inventories.Last.Value;
                int count = 0;
                foreach (BlissHiveLogItem item in inv.items) {
                    if (item.itemType == itemType)
                        count++;
                }
                return count;
            } else return 0;
        }

        public override string ToString() {
            return this.objectUpdateID + " BlissHiveLogObject";
        }
    }
}
