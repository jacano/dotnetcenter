using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PluginInterfaces;
using System.Net.Mail;

namespace DotnetCenter
{
    public partial class Center : Form
    {
        public static PluginServices Plugins = new PluginServices();
        public static ILog log;
        
        public Center()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Center_Load(object sender, EventArgs e)
        {
            log = LogFactory.GetInstance().CreateLog("File");

            log.Write("Cargando Plugins ...");
            Plugins.FindPlugins(Application.StartupPath + @"\Plugins");


            log.Write("Cargando el TreeView");
            foreach (Types.AvailablePlugin pluginOn in Plugins.AvailablePlugins)
            {
                TreeNode newNode = new TreeNode(pluginOn.Instance.Name);
                this.treeView.Nodes.Add(newNode);
                newNode = null;
            }

        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            //Make sure there's a selected Plugin
            if (this.treeView.SelectedNode != null)
            {
                this.Text = "DotnetCenter - Cargando " + treeView.SelectedNode.Text;
                
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

        private void sendFeedbackToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendFeedback sf = new SendFeedback();
            sf.Show();
        }

        public static string SendMail(string to, string tuNombre, string subject, string body)
        {
            MailMessage msg = new MailMessage();
            msg.To.Add(to);
            msg.From = new MailAddress(ConfigFile.GetInstance().CuentaEmail, tuNombre, System.Text.Encoding.UTF8);
            msg.Subject = subject;
            msg.SubjectEncoding = System.Text.Encoding.UTF8;
            msg.Body = body;
            msg.BodyEncoding = System.Text.Encoding.UTF8;
            msg.IsBodyHtml = false;

            //Aquí es donde se hace lo especial
            SmtpClient client = new SmtpClient();
            client.Credentials = new System.Net.NetworkCredential(ConfigFile.GetInstance().CuentaEmail
                , ConfigFile.GetInstance().PasswordEmail);
            client.Port = ConfigFile.GetInstance().PortServerEmail;
            client.Host = ConfigFile.GetInstance().HostServerEmail;
            
            //client.EnableSsl = ConfigFile.GetInstance().EnableSslServerEmail; -> No sportado en Mono
            try
            {
                client.Send(msg);
                log.Write("Feedback enviado a: " + to);
                return "";
            }
            catch (System.Net.Mail.SmtpException ex)
            {
                log.Write("Error enviando feedback: " + ex.ToString());
                return "Error enviando FeedBack";
            }
        }

       
    }
}