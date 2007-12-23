using System;
using System.Collections.Generic;
using System.Text;

namespace Configuration
{
    public sealed class Attributes : IDisposable
    {
        public string Email;
        public string PasswordEmail;
        public int PortServerEmail;
        public string HostServerEmail;
        public string Language;

        #region IDisposable Members

        public void Dispose()
        {

        }

        #endregion
    }
}
