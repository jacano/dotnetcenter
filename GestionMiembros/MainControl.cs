#region Using Statements
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PluginInterfaces;
using System.Data.Linq;
#endregion

namespace GestionMiembros
{
    public partial class MainControl : UserControl
    {
        public ILog Log;

        public MainControl()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            Log.Write("Inicializando gestion Miembros");
        }

    }
}
