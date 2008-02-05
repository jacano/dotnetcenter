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
        private System.IO.FileSystemWatcher watcher;
        private static TreeView treeViewReference;
        static LoadingPluginsMenuDelegate loadingPluginsMenuDelegate  = LoadingPluginsMenu;

        public Center()
        {
            InitializeComponent();
        }

        #region Load Method
        private void Center_Load(object sender, EventArgs e)
        {
            log = LogFactory.GetInstance().CreateLog("File");

            LoadLanguage();

            log.Write("Loading Plugins ...");
            if(Directory.Exists(Application.StartupPath + @"\Plugins"))
                Plugins.FindPlugins(Application.StartupPath + @"\Plugins");
            else
                Directory.CreateDirectory(Application.StartupPath + @"\Plugins");

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

            watcher.Path = Path.GetDirectoryName(Application.StartupPath + @"\Plugins\");
            watcher.Filter = Path.GetFileName(Application.StartupPath + @"\Plugins\*.dll");

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


        static void LoadingPluginsMenu()
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
            List<Object> lControls = new List<Object>();

            //Add here all controls
            lControls.Add(opcionesToolStripMenuItem);
            lControls.Add(sendFeedbackToolStripMenuItem);
            lControls.Add(aboutToolStripMenuItem);
            lControls.Add(exitToolStripMenuItem);
            lControls.Add(gbPluginsInformation);

            for (int i = 0; i < lControls.Count; i++)
            {
                if (lControls[i] is ToolStripItem)
                    ((ToolStripItem)lControls[i]).Text = Language.GetInstance().Items[i];
                if (lControls[i] is Control)
                    ((Control)lControls[i]).Text = Language.GetInstance().Items[i];
            }
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
            MessageBox.Show("\tDotnetClubs \r\r Version: 1.0.5 \r Web: http://dotnetcenter.dotnetclubs.com");
        }

        #endregion

        #region Utils Methods
        private void sendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendFeedback sf = new SendFeedback();
            sf.Show();
        }

        public static string SendMail(string to, string tuNombre, string subject, string body)
        {
            if (ConfigFile.GetInstance().Email != string.Empty || 
                ConfigFile.GetInstance().HostServerEmail != string.Empty ||
                ConfigFile.GetInstance().PasswordEmail != string.Empty)
            {
                MailMessage msg = new MailMessage();
                msg.To.Add(to);
                msg.From = new MailAddress(ConfigFile.GetInstance().Email, tuNombre, System.Text.Encoding.UTF8);
                msg.Subject = subject;
                msg.SubjectEncoding = System.Text.Encoding.UTF8;
                msg.Body = body;
                msg.BodyEncoding = System.Text.Encoding.UTF8;
                msg.IsBodyHtml = false;

                //Aquí es donde se hace lo especial
                SmtpClient client = new SmtpClient();
                client.Credentials = new System.Net.NetworkCredential(ConfigFile.GetInstance().Email
                    , ConfigFile.GetInstance().PasswordEmail);
                client.Port = ConfigFile.GetInstance().PortServerEmail;
                client.Host = ConfigFile.GetInstance().HostServerEmail;

                //client.EnableSsl = ConfigFile.GetInstance().EnableSslServerEmail; -> No sportado en Mono
                try
                {
                    client.Send(msg);
                    log.Write("Feedback send to: " + to);
                    return "";
                }
                catch (System.Net.Mail.SmtpException ex)
                {
                    log.Write("Error sending feedback: " + ex.ToString());
                    return "Error sending FeedBack";
                }
            }
            else
            {
                log.Write("Error email doesn't configurate");
                return "Error sending FeedBack";
            }
        } 
        #endregion
    }
}