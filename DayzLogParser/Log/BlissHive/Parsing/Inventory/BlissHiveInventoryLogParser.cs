using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.Parsing;
using DayzLogParser.Log.BlissHive.Survivor;

namespace DayzLogParser.Log.BlissHive.Parsing.Inventory {
    public class BlissHiveInventoryLogParser : LogParser {

        // If we didn't hear from someone for at least 3 minutes, assume this nigga offline
        public static readonly int OFFLINE_MS_LIMIT = 180000;

        public BlissHiveInventoryLogParser(BlissHiveLogContainer container)
            : base(container) {

        }

        public override LogParseResult Parse() {
            LinkedList<LogParseResultEntry> result = new LinkedList<LogParseResultEntry>();

            int count = 0;
            /*
             * 0 = ID
             * 1 = Position     [???,[x, y, z?]]
             * 2 = Inventory    [[<tool>, <sidearm>, <mainWeapon>], [<sidearm>, <item>]]
             * 3 = Backpack     [<backpackName>, [[<weapon>], [qty]], [[<item1>, <item2>], [<item1Qty>, [item2Qty]]]
             * 4 = Medical      [false,false,false,true,false,false,true,11714.7,["aimpoint"],[0,0],0,[159.803,247.991]] ??
             *                  [Probably broken bones, fever, etc here ,<blood>,    rest unknown
             * 5 = lastAte,     0 || 1
             * 6 = lastDrank,   0 || 1
             * 7 = survivalTime 
             * 8 = model      Seems to be 'any' all the time, but perhaps 'hero' and 'bandit' are values as well
             * 9 = humanity
             * 10 = zombiekills
             * 11 = headshots
             * 12 = murders
             * 13 = banditkills
             * 14 = state       ["M16A2","ainvpknlmstpslaywrfldnon_medic",100]
             *                  [<equiped weapon?>, <gibberish>, <???>]
             **/
            BlissHiveLogContainer blissHiveLogContainer = (BlissHiveLogContainer)this.container;

            foreach (BlissHiveLogEntry entry in container.logs) {

                if (entry.functionName == "proc_updateSurvivor") {
                    BlissHiveLogSurvivorInventory inventory = new BlissHiveLogSurvivorInventory(entry);

                    String inventoryParam = entry.parameters[2];
                    // No point parsing empty inventories
                    if (inventoryParam != "[]") {


                        String[] invTypes = inventoryParam.Split(new String[1] { "],[" }, StringSplitOptions.None);
                        String[] invWeapons = invTypes[0]
                                                .Replace("[[", "")
                                                .Replace("\"", "")
                                                .Split(',');
                        String[] invItems = invTypes[1]
                                                .Replace("]]", "")
                                                .Replace("\"", "")
                                                .Split(',');

                        foreach (String weapon in invWeapons) {
                            inventory.items.AddLast(new BlissHiveLogItem(weapon, BlissHiveLogItem.Location.Inventory));
                        }

                        foreach (String item in invItems) {
                            inventory.items.AddLast(new BlissHiveLogItem(item, BlissHiveLogItem.Location.Inventory));
                        }
                    }
                    String backpackParam = entry.parameters[3];
                    // No point parsing empty inventories
                    Boolean addedWeapon = false, addedItem = false;
                    if (backpackParam != "[]") {

                        String[] backpackTypes = backpackParam
                                    .Split(new String[1] { "],[" }, StringSplitOptions.None);

                        String[] temp = backpackTypes[0]
                                    .Split(new String[1] { ",[[" }, StringSplitOptions.None);
                        String backpackName = temp[0]
                                    .Replace("[", "")
                                    .Replace("\"", "");
                        String[] backpackWeapons = new String[0];
                        String[] backpackQuantities = new String[0];
                        String[] backpackItems = new String[0];
                        String[] backpackItemQuantities = new String[0];


                        // If there's weapons in the backpack
                        if (temp.Length > 1) {
                            backpackWeapons = temp[1]
                                        .Replace("\"", "")
                                        .Split(',');
                            backpackQuantities = backpackTypes[1]
                                        .Replace("]", "")
                                        .Split(',');
                        }

                        // If there's items in the backpack
                        if (backpackTypes.Length > 2) {
                            backpackItems = backpackTypes[2]
                                        .Replace("[", "")
                                        .Replace("\"", "")
                                        .Split(',');
                            backpackItemQuantities = backpackTypes[3]
                                        .Replace("]]]", "")
                                        .Split(',');
                        }

                        inventory.items.AddLast(
                            new BlissHiveLogItem(backpackName, BlissHiveLogItem.Location.Backpack));

                        int itemCount = 0;
                        foreach (String backpackWeapon in backpackWeapons) {
                            if (backpackWeapon == "")
                                continue;
                            inventory.items.AddLast(
                                new BlissHiveLogItem(
                                    backpackWeapon,
                                    BlissHiveLogItem.Location.Backpack,
                                    Int32.Parse(backpackQuantities[itemCount])
                                )
                            );
                            addedWeapon = true;
                            itemCount++;
                        }

                        itemCount = 0;
                        foreach (String backpackItem in backpackItems) {
                            if (backpackItem == "")
                                continue;
                            inventory.items.AddLast(
                                new BlissHiveLogItem(
                                    backpackItem,
                                    BlissHiveLogItem.Location.Backpack,
                                    Int32.Parse(backpackItemQuantities[itemCount])
                                )
                            );
                            addedItem = true;
                            itemCount++;
                        }
                    }

                    // If both the inventory and the backpack has changed
                    // if (inventoryParam != "[]" && backpackParam != "[]") {
                    // }

                    if (inventoryParam != "[]" || backpackParam != "[]" &&
                        (addedItem || addedWeapon )) {
                        foreach (BlissHiveLogSurvivor survivor in
                            blissHiveLogContainer.survivorContainer.survivors) {
                            if (survivor.survivorUpdateID == entry.parameters[0]) {
                                survivor.inventory = inventory;
                                survivor.inventories.AddLast(inventory);
                            }
                        }
                        result.AddLast(new BlissHiveInventoryLogParseResultEntry(entry));
                    }

                } else if (entry.functionName == "proc_killSurvivor") {

                }

                this.onParseProgressListeners(count, this.container.logs.Length);
                count++;
            }

            this.onParseProgressListeners = null;
            return new LogParseResult(result);
        }

        /// <summary>
        /// Checks if a given name already exists in the result set.
        /// </summary>
        /// <param name="result">The result set to search.</param>
        /// <param name="survivorName">The survivor name to search for.</param>
        /// <returns>Yes or no.</returns>
        private Boolean ContainsSurvivor(LinkedList<LogParseResultEntry> result, String survivorName) {
            foreach (BlissHiveSurvivorLogParseResultEntry entry in result) {
                if (entry.survivor.username == survivorName)
                    return true;
            }
            return false;
        }

        private BlissHiveSurvivorLogParseResultEntry GetSurvivor(LinkedList<LogParseResultEntry> result, String survivorName) {
            foreach (BlissHiveSurvivorLogParseResultEntry entry in result) {
                if (entry.survivor.username == survivorName)
                    return entry;
            }
            return null;
        }

        public override int GetProgressMaxLength() {
            return this.container.logs.Length;
        }
    }
}
