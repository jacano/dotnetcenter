using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using PluginInterfaces;

namespace DotnetCenter
{
    public class ConfigFile
    {
        #region Members and Properties
        private const string FileName = "Config.xml";
        private static Atributes handle;
        #endregion

        public static Atributes GetInstance()
        {
            if (handle == null)
            {
                handle = new Atributes();
                Load();
            }

            return handle;
        }

        public static void Load()
        {
            //Lectura desde el fichero XML de proyecto
            XmlDocument xml = new XmlDocument();
            try
            {
                xml.Load(FileName);

                foreach (XmlNode node in xml.SelectNodes("/DotnetCenter/Config"))
                {
                    handle.CuentaEmail = node.ChildNodes[0].InnerText;
                    handle.PasswordEmail = node.ChildNodes[1].InnerText;
                    handle.PortServerEmail = Int16.Parse(node.ChildNodes[2].InnerText);
                    handle.HostServerEmail = node.ChildNodes[3].InnerText;
                    handle.EnableSslServerEmail = Boolean.Parse(node.ChildNodes[4].InnerText);
                    handle.NumeroPrestamosPorSocio = Int16.Parse(node.ChildNodes[5].InnerText);
                }

                Center.log.Write("Fichero de configuración cargado correctamente");
            }
            catch (XmlException e)
            {
                Center.log.Write("Fallo en la carga del fichero de configuración:" + e.ToString());
            }

        }
    }
}
