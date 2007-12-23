using System;
using System.Collections.Generic;
using System.Text;

namespace Configuration
{
    public sealed class Labels : IDisposable
    {
        public List<string> Items;

        public Labels()
        {
            Items = new List<string>();
        }

        #region IDisposable Members

        public void Dispose()
        {
            Items.Clear();
        }

        #endregion
    }
}
