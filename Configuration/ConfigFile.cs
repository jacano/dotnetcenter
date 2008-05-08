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
                handle.Language = node.ChildNodes[0].InnerText;
            }
        }

        public static void EditField(int e, string s)
        {
            XmlDocument xml = new XmlDocument();
            xml.Load(FileName);

            xml.SelectNodes("/DotnetCenter/Config")[e].InnerText = s;
            xml.Save(FileName);
        }
    }
}
