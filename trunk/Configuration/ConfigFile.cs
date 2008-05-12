using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace Configuration
{
    public class ConfigFile
    {
        private static Attributes handle;

        public static Attributes GetInstance()
        {
            if (handle == null)
            {
                handle = new Attributes();
            }

            return handle;
        }

        public static void Load(string path)
        {
            //Lectura desde el fichero XML de proyecto
            XmlDocument xml = new XmlDocument();
            xml.Load(path);

            foreach (XmlNode node in xml.SelectNodes("/DotnetCenter/Config"))
            {
                handle.Language = node.ChildNodes[0].InnerText;
                handle.PluginDirectory = node.ChildNodes[1].InnerText;
            }
        }

        public static void EditField(string path, int e, string s)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(path);

            xml.SelectNodes("/DotnetCenter/Config")[e].InnerText = s;
            xml.Save(path);
        }
    }
}
