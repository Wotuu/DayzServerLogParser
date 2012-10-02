using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;

namespace DayzLogParser.Settings.BlissHive {
    public class FTPSettingsCategory : SettingsCategory {
        public String ip { get; set; }
        public String port { get; set; }
        public String username { get; set; }
        public String password { get; set; }
        public String rootFolder { get; set; }

        public FTPSettingsCategory()
        {

        }

        public override XmlNode Save(XmlDocument document) {




            XmlElement ftpNode = document.CreateElement(this.GetRootNodeName());

            XmlElement ipNode = document.CreateElement("IP");
            ipNode.InnerText = this.ip;
            XmlElement portNode = document.CreateElement("Port");
            portNode.InnerText = this.port;
            XmlElement usernameNode = document.CreateElement("Username");
            usernameNode.InnerText = this.username;
            XmlElement passwordNode = document.CreateElement("Password");
            passwordNode.InnerText = this.password;
            XmlElement rootFolderNode = document.CreateElement("RootFolder");
            rootFolderNode.InnerText = this.rootFolder;


            ftpNode.AppendChild(ipNode);
            ftpNode.AppendChild(portNode);
            ftpNode.AppendChild(usernameNode);
            ftpNode.AppendChild(passwordNode);
            ftpNode.AppendChild(rootFolderNode);

            return ftpNode;
        }

        public override void Load(XmlNode toLoad) {
            XmlNode ipNode = toLoad.ChildNodes[0];
            this.ip = ipNode.InnerText;

            XmlNode portNode = toLoad.ChildNodes[1];
            this.port = portNode.InnerText;

            XmlNode usernameNode = toLoad.ChildNodes[2];
            this.username = usernameNode.InnerText;

            XmlNode passwordNode = toLoad.ChildNodes[3];
            this.password = passwordNode.InnerText;

            XmlNode rootFolderNode = toLoad.ChildNodes[4];
            this.rootFolder = rootFolderNode.InnerText;
        }

        public override string GetRootNodeName() {
            return "FTP";
        }
    }
}