using System;
using System.Collections.Generic;
using System.Text;
using PluginInterfaces;
using System.Windows.Forms;

namespace GestionPrestamos
{
    public class GestionPrestamos : IPlugin
    {
        string myName = "Gestión Prestamos";
        string myEmail = "Core DotnetCenter";
        string myVersion = "1.0.0";
        IPluginHost myHost = null;
        UserControl myMainInterface;

        #region Properties
        public string Email
        {
            get { return myEmail; }

        }
        public IPluginHost Host
        {
            get { return myHost; }
            set { myHost = value; }
        }

        public string Name
        {
            get { return myName; }
        }

        public System.Windows.Forms.UserControl MainInterface
        {
            get { return myMainInterface; }
        }

        public string Version
        {
            get { return myVersion; }
        }
        #endregion

        public GestionPrestamos()
        {

        }

        public void Initialize()
        {
            myMainInterface = new MainControl();
            ((MainControl)myMainInterface).GestionPrestamos = this;
            ((MainControl)myMainInterface).Log = myHost.Log;
            //InitializeForm();
        }

        public void InitializeForm()
        {
            ((MainControl)myMainInterface).Initialize();
        }

        public void Dispose()
        {
            //Put any cleanup code in here for when the program is stopped
        }

    }
}


