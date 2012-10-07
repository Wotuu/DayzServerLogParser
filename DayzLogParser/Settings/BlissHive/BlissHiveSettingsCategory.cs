using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace DayzLogParser.Settings.BlissHive {
    public class BlissHiveSettingsCategory : SettingsCategory {
        public LinkedList<String> itemsList { get; private set; }
        public LinkedList<String> blackListItems { get; private set; }


        public BlissHiveSettingsCategory() {
            this.itemsList = new LinkedList<String>();
            this.blackListItems = new LinkedList<String>();
        }

        public override XmlNode Save(XmlDocument document) {
            XmlElement itemsListNode = document.CreateElement("ItemsList");

            foreach (String item in this.itemsList) {
                // Create item xml node
                XmlNode itemNode = document.CreateElement("Item");
                // Create item name xml attribute
                XmlAttribute itemNodeName = document.CreateAttribute("name");
                // Set the value of the attribute
                itemNodeName.Value = item;
                // Append the attribute to the attributes
                itemNode.Attributes.SetNamedItem(itemNodeName);
                // Append the item to the item list
                itemsListNode.AppendChild(itemNode);
            }

            XmlElement blackListItemsNode = document.CreateElement("BlackListItems");

            foreach (String item in this.blackListItems) {
                // Create item xml node
                XmlNode itemNode = document.CreateElement("Item");
                // Create item name xml attribute
                XmlAttribute itemNodeName = document.CreateAttribute("name");
                // Set the value of the attribute
                itemNodeName.Value = item.Trim();
                // Append the attribute to the attributes
                itemNode.Attributes.SetNamedItem(itemNodeName);
                // Append the item to the item list
                blackListItemsNode.AppendChild(itemNode);
            }




            XmlElement blissHiveNode = document.CreateElement(this.GetRootNodeName());
            blissHiveNode.AppendChild(itemsListNode);
            blissHiveNode.AppendChild(blackListItemsNode);

            return blissHiveNode;
        }

        public override void Load(XmlNode toLoad) {
            XmlNode itemsListNode = toLoad.ChildNodes[0];
            foreach (XmlNode item in itemsListNode.ChildNodes) {
                this.itemsList.AddLast(item.Attributes.GetNamedItem("name").Value.Trim());
            }

            XmlNode blackListNode = toLoad.ChildNodes[1];
            foreach (XmlNode item in blackListNode.ChildNodes) {
                this.blackListItems.AddLast(item.Attributes.GetNamedItem("name").Value.Trim());
            }
        }

        public override string GetRootNodeName() {
            return "BlissHive";
        }
    }
}