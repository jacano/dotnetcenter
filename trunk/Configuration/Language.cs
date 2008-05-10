using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Configuration
{
    public class Language
    {
        private static string FileName;
        private static Labels handle;

        public static Labels GetInstance()
        {
            if (handle == null)
            {
                handle = new Labels();
            }

            return handle;
        }

        public static void Load(string path)
        {
            FileName = path + ConfigFile.GetInstance().Language + ".xml";

            //Lectura desde el fichero XML de proyecto
            XmlDocument xml = new XmlDocument();
            xml.Load(FileName);

            GetInstance().clearAll();

            //Center Labels
            foreach (XmlNode node in xml.SelectNodes("/DotnetCenter/Center"))
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    GetInstance().CenterLabels.Add(child.InnerText);
                }
            }

            //PluginsManager Labels
            foreach (XmlNode node in xml.SelectNodes("/DotnetCenter/PluginsManager/Labels"))
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    GetInstance().PluginsManagerLabels.Add(child.InnerText);
                }
            }

            //PluginsManager Messages
            foreach (XmlNode node in xml.SelectNodes("/DotnetCenter/PluginsManager/Messages"))
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    GetInstance().PluginsManagerMessages.Add(child.InnerText);
                }
            }


        }
    }
}
