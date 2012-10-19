using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DayzLogParser.Log.Parsing;
using DayzLogParser.Log.BlissHive.Survivor;
using DayzLogParser.Log.BlissHive.Inventory;
using DayzLogParser.Log.BlissHive.Object;
using DayzLogParser.Log.Object;

namespace DayzLogParser.Log.BlissHive.Parsing.Object.Inventory {
    public class BlissHiveObjectInventoryLogParser : LogParser {

        // If we didn't hear from someone for at least 3 minutes, assume this nigga offline
        public static readonly int OFFLINE_MS_LIMIT = 180000;

        public BlissHiveObjectInventoryLogParser(BlissHiveLogContainer container)
            : base(container) {

        }

        public override LogParseResult Parse() {
            LinkedList<LogParseResultEntry> result = new LinkedList<LogParseResultEntry>();

            int count = 0;
            BlissHiveLogContainer blissHiveLogContainer = (BlissHiveLogContainer)this.container;
            // proc_updateObjectInventory(56849, 
            // '[[["glock17_EP1","ItemToolbox","ItemHatchet","LeeEnfield"],[1,1,1,1]],[["ItemPainkiller","ItemSodaCoke","ItemEpinephrine","20Rnd_762x51_DMR","15Rnd_9x19_M9SD","15Rnd_9x19_M9","FoodCanFrankBeans","17Rnd_9x19_glock17","SmokeShellGreen","ItemBandage","ItemMorphine","ItemJerrycanEmpty","ItemJerrycan","PartEngine"],[3,3,1,2,1,1,1,2,1,1,1,2,1,1]],[[],[]]]
            foreach (BlissHiveLogEntry entry in container.logs) {

                if (entry.functionName == "proc_updateObjectInventory") {
                    BlissHiveLogObject logObject = GetObjectByUpdateID(entry.parameters[0]);
                    String[] split = entry.parameters[1].Split(new String[1] { "],[" }, StringSplitOptions.None);

                    BlissHiveLogInventory inventory = new BlissHiveLogInventory(entry);
                    for (int i = 0; i < split.Length; i += 2) {
                        String[] items = split[i].Replace("\"", "")
                                                .Replace("[", "")
                                                .Replace("]", "")
                                                .Split(',');
                        String[] quantities = split[i + 1].Replace("\"", "")
                                                .Replace("[", "")
                                                .Replace("]", "")
                                                .Split(',');

                        for (int j = 0; j < items.Length; j++) {
                            if (items[j] == "")
                                continue;
                            BlissHiveLogItem logItem = new BlissHiveLogItem(items[j], BlissHiveLogItem.Location.Inventory);
                            logItem.quantity = Int32.Parse(quantities[j]);


                            // Weapons
                            if (i == 0) {
                                logItem.itemType = BlissHiveLogItemType.Weapon;
                            }
                                // Items
                            else if (i == 2) {
                                logItem.itemType = BlissHiveLogItemType.Item;
                            }
                                // Backpacks
                            else if (i == 4) {
                                logItem.itemType = BlissHiveLogItemType.Backpack;
                            }

                            inventory.items.AddLast(logItem);
                        }
                    }

                    if (inventory.items.Count > 0)
                        logObject.inventories.AddLast(inventory);
                }

                this.onParseProgressListeners(count, this.container.logs.Length);
                count++;
            }

            this.onParseProgressListeners = null;
            return new LogParseResult(result);
        }

        public override int GetProgressMaxLength() {
            return this.container.logs.Length;
        }

        /// <summary>
        /// Gets the object related to the update ID.
        /// </summary>
        /// <param name="updateID"></param>
        /// <returns>Null or the object</returns>
        public BlissHiveLogObject GetObjectByUpdateID(String updateID) {
            LinkedList<LogObject> list = LogController.GetInstance().blissHiveLogContainer.logObjectContainer.logObjects;
            foreach (BlissHiveLogObject obj in list) {
                if (obj.objectUpdateID == updateID)
                    return obj;
            }
            return null;
        }
    }
}
