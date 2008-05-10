using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace DotnetCenter
{
    class Directories
    {
        public static string PluginsDirectory 
        {
            get { return Application.StartupPath + @"\Plugins\"; }
        }

        public static string PluginsFilter
        {
            get { return "*.dll"; }
        }

        public static string FilePendingDelete
        {
            get { return Application.StartupPath + @"\Plugins\removePlugins.dc";}
        }

        public static string ConfigFile
        {
            get { return "/DotnetCenter/Config"; }
        }
    }
}
