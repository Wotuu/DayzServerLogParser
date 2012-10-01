using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace DayzLogParser.Settings {
    public abstract class SettingsCategory {


        public abstract XmlNode Save(XmlDocument document);

        public abstract void Load(XmlNode toLoad);

        public abstract String GetRootNodeName();
    }
}
