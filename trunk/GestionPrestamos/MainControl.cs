using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using PluginInterfaces;

namespace GestionPrestamos
{
    public partial class MainControl : UserControl
    {
        public IPlugin GestionPrestamos;
        public ILog Log;

        public MainControl()
        {
            InitializeComponent();
        }

        public void Initialize()
        {
            Log.Write("Inicializando " + GestionPrestamos.Name);
        }

    }
}
