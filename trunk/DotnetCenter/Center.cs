using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PluginInterfaces;
using System.Net.Mail;
using Configuration;
using System.IO;

namespace DotnetCenter
{
    /// <summary>
    /// This delegate is used to load new plugins (.dll) for execution of the application.
    /// </summary>
    delegate void LoadingPluginsMenuDelegate();

    
    public partial class Center : Form
    {
        public static PluginServices Plugins = new PluginServices();
        public static ILog log;
        public static System.IO.FileSystemWatcher watcher;
        private static TreeView treeViewReference;
        private static LoadingPluginsMenuDelegate loadingPluginsMenuDelegate  = LoadingPluginsMenu;
        private static List<Object> lControls = new List<Object>();

        public static TreeView TreeViewRefenrence
        { 
            get{return treeViewReference; }
        }

        public Center()
        {
            InitializeComponent();
            
        }

        #region Load Method
        private void Center_Load(object sender, EventArgs e)
        {
            log = LogFactory.GetInstance().CreateLog("File");

            Plugins.PendingDelete();

            LoadLanguage();

            log.Write("Loading Plugins ...");
            if(Directory.Exists(Directories.PluginsDirectory))
                Plugins.FindPlugins(Directories.PluginsDirectory);
            else
                Directory.CreateDirectory(Directories.PluginsDirectory);

            treeViewReference = this.treeView;
            log.Write("Loading el menu");
            foreach (Types.AvailablePlugin pluginOn in Plugins.AvailablePlugins)
            {
                TreeNode newNode = new TreeNode(pluginOn.Instance.Name);
                this.treeView.Nodes.Add(newNode);
                newNode = null;
            }

            //Starting the FieSystemWatcher to notice new dll's
            watcher = new System.IO.FileSystemWatcher();

            watcher.Path = Path.GetDirectoryName(Directories.PluginsDirectory);
            watcher.Filter = Path.GetFileName(Directories.PluginsFilter);

            watcher.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName | NotifyFilters.Size;

            watcher.Created += new System.IO.FileSystemEventHandler(OnCreate);
            watcher.EnableRaisingEvents = true;

        }
       
        public static void OnCreate(object source, FileSystemEventArgs e)
        {
            Plugins.AddPlugin(e.FullPath);
            log.Write("It`s going to add the new plugin: " + Path.GetFileName(e.FullPath));
            //We're goint to clean the treeViewMenu by other thead, so we need Invoke(..)
            treeViewReference.Invoke(loadingPluginsMenuDelegate);
            MessageBox.Show("The plugin " + Path.GetFileNameWithoutExtension(e.FullPath) + " has been loaded successfully");
            
        }

        public static void LoadingPluginsMenu()
        {
            treeViewReference.Nodes.Clear();
            TreeNode newNode;
            foreach (Types.AvailablePlugin pluginOn in Plugins.AvailablePlugins)
            {
                newNode = new TreeNode(pluginOn.Instance.Name);
                treeViewReference.Nodes.Add(newNode);
            }
        }
        
        private void LoadLanguage()
        {
            //Add language list
            foreach (string fileOn in Directory.GetFiles(AppDomain.CurrentDomain.BaseDirectory + "\\Languages\\"))
            {
                FileInfo file = new FileInfo(fileOn);
                string[] name = file.Name.Split('.');
                ToolStripMenuItem i = new ToolStripMenuItem();
                i.Name = name[0];
                i.Text = name[0];
                i.Click += new EventHandler(i_Click);
                languageToolStripMenuItem.DropDownItems.Add(i);
            }

            //Add here all controls
            lControls.Add(opcionesToolStripMenuItem);
            lControls.Add(pluginsToolStripMenuItem);
            lControls.Add(languageToolStripMenuItem);            
            lControls.Add(aboutToolStripMenuItem);
            lControls.Add(exitToolStripMenuItem);
            lControls.Add(gbPluginsInformation);

            GetLabes();
        }

        private static void GetLabes()
        {
            Language.Load();

            for (int i = 0; i < lControls.Count; i++)
            {
                if (lControls[i] is ToolStripItem)
                    ((ToolStripItem)lControls[i]).Text = Language.GetInstance().Items[i];
                if (lControls[i] is Control)
                    ((Control)lControls[i]).Text = Language.GetInstance().Items[i];
            }
        }

        private void i_Click(object sender, EventArgs e)
        {
            ConfigFile.GetInstance().Language = ((ToolStripMenuItem)sender).Name;
            ConfigFile.EditField(0, ConfigFile.GetInstance().Language);
            GetLabes();
        } 

        #endregion

        #region Actions Methods
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Make sure there's a selected Plugin
            if (this.treeView.SelectedNode != null)
            {
                this.Text = "DotnetCenter - Loading " + treeView.SelectedNode.Text;

                //Get the selected Plugin
                Types.AvailablePlugin selectedPlugin = Plugins.AvailablePlugins.Find(treeView.SelectedNode.Text.ToString());

                if (selectedPlugin != null)
                {
                    //Again, if the plugin is found, do some work...


                    //This part adds the plugin's info to the 'Plugin Information:' Frame
                    this.lblPluginName.Text = selectedPlugin.Instance.Name;
                    this.lblPluginVersion.Text = "(" + selectedPlugin.Instance.Version + ")";
                    this.lblPluginEmail.Text = selectedPlugin.Instance.Email;

                    //Clear the current panel of any other plugin controls... 
                    //Note: this only affects visuals.. doesn't close the instance of the plugin
                    this.pnlPlugin.Controls.Clear();

                    //Set the dockstyle of the plugin to fill, to fill up the space provided
                    selectedPlugin.Instance.MainInterface.Dock = DockStyle.Fill;

                    selectedPlugin.Instance.InitializeForm();
                    this.pnlPlugin.AutoScrollMinSize = selectedPlugin.Instance.MainInterface.Size;

                    //Finally, add the usercontrol to the panel... Tadah!
                    this.pnlPlugin.Controls.Add(selectedPlugin.Instance.MainInterface);

                }

                this.Text = "DotnetCenter";
            }
        }

        private void Center_FormClosing(object sender, FormClosingEventArgs e)
        {
            Plugins.ClosePlugins();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\tDotnetClubs \r\r Version: 1.0.6 \r Web: http://dotnetcenter.dotnetclubs.com");
        }

        private void pluginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PluginsForm pluginsForm = new PluginsForm(this);
            pluginsForm.Show();
            Enabled = false;
        }
        #endregion

       
        #region Utils Methods

        #endregion
    }
}