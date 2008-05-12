using System;
using System.Collections.Generic;
using System.Text;

namespace Configuration
{
    public sealed class Attributes : IDisposable
    {
        public string Language;
        public string PluginDirectory;

        #region IDisposable Members

        public void Dispose()
        {

        }

        #endregion
    }
}
