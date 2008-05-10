using System;
using System.Collections.Generic;
using System.Text;

namespace Configuration
{
    public sealed class Labels
    {
        public List<string> CenterLabels;
        public List<string> PluginsManagerLabels;
        public List<string> PluginsManagerMessages;

        public Labels()
        {
            CenterLabels = new List<string>();
            PluginsManagerLabels = new List<string>();
            PluginsManagerMessages = new List<string>();
        }

        public void clearAll()
        {
            CenterLabels.Clear();
            PluginsManagerLabels.Clear();
            PluginsManagerMessages.Clear();
        }

    }
}
