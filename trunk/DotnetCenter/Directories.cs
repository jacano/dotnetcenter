using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DotnetCenter
{
    class Directories
    {
        public static string PluginsDirectory 
        {
            get 
            {
                if (Configuration.ConfigFile.GetInstance().PluginDirectory == String.Empty)
                    return Environment.GetEnvironmentVariable("userprofile") + "\\DotnetCenter\\Plugins" + "\\";
                else
                    return Configuration.ConfigFile.GetInstance().PluginDirectory + "\\";
            }
        }

        public static string PluginsFilter
        {
            get { return "*.dll"; }
        }

        public static string ConfigFile
        {
            get { return Application.StartupPath + @"\Config.xml"; }
        }

        public static string LanguageDirectory
        {
            get { return Application.StartupPath + @"\Languages\"; }
        }

        public static string FilePendingDelete
        {
            get { return Application.StartupPath + @"\Plugins\removePlugins.dc";}
        }

        public static string FilePluginInterfaces
        {
            get { return Application.StartupPath + @"\Plugins\PluginInterfaces.dll"; }
        }
    }
}
