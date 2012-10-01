using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Windows.Forms;
using System.Reflection;

namespace DayzLogParser.Settings {
    public class SettingsController {

        private static SettingsController instance { get; set; }
        
        private SettingsController() {

        }

        public static SettingsController GetInstance() {
            if (SettingsController.instance == null) SettingsController.instance = new SettingsController();
            return SettingsController.instance;
        }

        /// <summary>
        /// Loads the settings file!
        /// </summary>
        public LinkedList<SettingsCategory> LoadSettingsFile(String filename) {
            LinkedList<SettingsCategory> loadedCategories = new LinkedList<SettingsCategory>();
            try {
                XmlDocument xmldoc = new XmlDocument();
                xmldoc.Load(filename);

                XmlNode declaration = xmldoc.FirstChild;

                XmlNode rootNode = xmldoc.ChildNodes[1];

                for (int i = 0; i < rootNode.ChildNodes.Count; i++) {
                    XmlNode node = rootNode.ChildNodes[i];
                    String nodeName = node.Name;
                    // Get all classes that extent the SettingsCategory
                    var settingsCategories = Assembly.GetAssembly(typeof(SettingsController)).GetTypes()
                                                .Where(t => t.IsSubclassOf(typeof(SettingsCategory)));

                    // For every class found
                    foreach (Type type in settingsCategories) {
                        // Create an instance
                        SettingsCategory category = (SettingsCategory)Activator.CreateInstance(type);
                        // Compare the found node name to the one reported by the class
                        if (nodeName == category.GetRootNodeName()) {
                            // If it's the correct one, load it
                            category.Load(node);
                            // Add it to the list to be returned
                            loadedCategories.AddLast(category);
                            // Stop searching
                            break;
                        }
                    }
                }

            } catch (Exception e) {
                // Just in case.
            }

            return loadedCategories;
        }


        /// <summary>
        /// Saves the given settings to the disk.
        /// </summary>
        public void SaveSettingFile(LinkedList<SettingsCategory> settings, String filename) {
            XmlDocument settingsXML = new XmlDocument();
            XmlDeclaration xmlDeclaration = settingsXML.CreateXmlDeclaration("1.0", "utf-8", null);
            XmlElement rootNode = settingsXML.CreateElement("Settings");
            settingsXML.InsertBefore(xmlDeclaration, settingsXML.DocumentElement);
            settingsXML.AppendChild(rootNode);

            foreach (SettingsCategory category in settings) {
                rootNode.AppendChild(category.Save(settingsXML));
            }

            settingsXML.Save(filename);
        }
    }
}
