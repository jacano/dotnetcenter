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
                FileName = "Languages/" + ConfigFile.GetInstance().Language + ".xml";
                handle = new Labels();
                Load();
            }

            return handle;
        }

        public static void Load()
        {
            //Lectura desde el fichero XML de proyecto
            XmlDocument xml = new XmlDocument();
            xml.Load(FileName);

            foreach (XmlNode node in xml.SelectNodes("/DotnetCenter/Labels"))
            {
                foreach (XmlNode child in node.ChildNodes)
                {
                    handle.Items.Add(child.InnerText);
                }
            }
        }
    }
}
