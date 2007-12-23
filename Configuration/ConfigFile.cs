using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Configuration
{
    public class ConfigFile
    {
        private const string FileName = "Config.xml";
        private static Attributes handle;

        public static Attributes GetInstance()
        {
            if (handle == null)
            {
                handle = new Attributes();
                Load();
            }

            return handle;
        }

        public static void Load()
        {
            //Lectura desde el fichero XML de proyecto
            XmlDocument xml = new XmlDocument();
            xml.Load(FileName);

            foreach (XmlNode node in xml.SelectNodes("/DotnetCenter/Config"))
            {
                handle.Email = node.ChildNodes[0].InnerText;
                handle.PasswordEmail = node.ChildNodes[1].InnerText;
                if(node.ChildNodes[2].InnerText != String.Empty)
                    handle.PortServerEmail = Int16.Parse(node.ChildNodes[2].InnerText);
                handle.HostServerEmail = node.ChildNodes[3].InnerText;
                handle.Language = node.ChildNodes[4].InnerText;
            }
        }
    }
}
