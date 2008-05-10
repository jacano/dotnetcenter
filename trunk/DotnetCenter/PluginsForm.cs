using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;
using Configuration;

namespace DotnetCenter
{
    public partial class PluginsForm : Form
    {
        private Center center;

        public PluginsForm(Center center)
        {

            this.center = center;
            InitializeComponent();

            LoadPlugins();

            LoadLabels();
        }

        private void LoadLabels()
        {
            Text = Language.GetInstance().PluginsManagerLabels[0];
            groupBox.Text = Language.GetInstance().PluginsManagerLabels[1];
            lbName.Text = Language.GetInstance().PluginsManagerLabels[2];
            lbVersion.Text = Language.GetInstance().PluginsManagerLabels[3];
            lbEmail.Text = Language.GetInstance().PluginsManagerLabels[4];
            btAdvanced.Text = Language.GetInstance().PluginsManagerLabels[5];
            buttonAddPlugin.Text = Language.GetInstance().PluginsManagerLabels[6];
            buttonRemovePlugin.Text = Language.GetInstance().PluginsManagerLabels[7];
        }

        private void LoadPlugins()
        {
            this.listBoxPlugins.Items.Clear();

            foreach (Types.AvailablePlugin pluginOn in Center.Plugins.AvailablePlugins)
            {
                this.listBoxPlugins.Items.Add(pluginOn.Instance.Name);
            }

            if (listBoxPlugins.Items.Count > 0)
                this.listBoxPlugins.SelectedIndex = 0;
        }

        private void listBoxPlugins_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Get the selected Plugin
            Types.AvailablePlugin selectedPlugin = Center.Plugins.AvailablePlugins.Find(this.listBoxPlugins.SelectedItem.ToString());

            if (selectedPlugin != null)
            {
                //This part adds the plugin's info to the 'Plugin Information:' Frame
                this.textBox_PluginName.Text = selectedPlugin.Instance.Name;
                this.textBox_PluginVersion.Text = "(" + selectedPlugin.Instance.Version + ")";
                this.textBox_Email.Text = selectedPlugin.Instance.Email;
            }
        }

        private void buttonAddPlugin_Click(object sender, EventArgs e)
        {
            if (File.Exists(Directories.FilePendingDelete))
                MessageBox.Show(Language.GetInstance().PluginsManagerMessages[0], "Warning");
            else
            {
                if (DialogResult.OK == this.openFileDialog.ShowDialog())
                {
                    String[] l = openFileDialog.FileName.Split('\\');
                    String filename = l[l.Length - 1];
                    if (Center.Plugins.ValidatePlugin(openFileDialog.FileName))
                    {
                        String newPath = Path.Combine(Directories.PluginsDirectory, filename);
                        if (File.Exists(newPath))
                            MessageBox.Show(Language.GetInstance().PluginsManagerMessages[1], "Error");
                        else
                        {
                            center.watcher.EnableRaisingEvents = false;
                            File.Copy(openFileDialog.FileName, newPath);
                            center.watcher.EnableRaisingEvents = true;
                            int operationResult = Center.Plugins.AddPlugin(openFileDialog.FileName);
                            Center.Plugins.DeleteFromPending(newPath);  //ahora mismo no hace falta
                            switch (operationResult)
                            {
                                case 0:
                                    MessageBox.Show(Language.GetInstance().PluginsManagerMessages[2], "Error");
                                    break;

                                case 1:
                                    this.LoadPlugins();
                                    center.LoadingPluginsMenu();
                                    MessageBox.Show(Language.GetInstance().PluginsManagerMessages[3], "Correct operation");
                                    break;

                                case 2:
                                    MessageBox.Show(Language.GetInstance().PluginsManagerMessages[4], "Strange thing");
                                    break;
                            }
                        }
                    }
                    else
                        MessageBox.Show(Language.GetInstance().PluginsManagerMessages[5], "Error");
                }
            }
        }

        private void PluginsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            center.Enabled = true;
        }

        private void buttonRemovePlugin_Click(object sender, EventArgs e)
        {
            this.textBox_PluginName.Text = String.Empty;
            this.textBox_PluginVersion.Text = String.Empty;
            this.textBox_Email.Text = String.Empty;

            if (listBoxPlugins.SelectedItem != null)
            {
                int operationResult = Center.Plugins.RemovePlugin(this.listBoxPlugins.SelectedItem.ToString());
                switch (operationResult)
                {
                    case 0:
                        MessageBox.Show(Language.GetInstance().PluginsManagerMessages[6], "Error");
                        break;
                    case 1:
                        this.LoadPlugins();
                        center.LoadingPluginsMenu();
                        MessageBox.Show(Language.GetInstance().PluginsManagerMessages[7], "Correct operation");
                        break;
                    case 2:
                        MessageBox.Show(Language.GetInstance().PluginsManagerMessages[8], "Strange thing");
                        break;
                }
            }
        }

        private void btAdvanced_Click(object sender, EventArgs e)
        {
            Process.Start("explorer", Directories.PluginsDirectory);
        }
    }
}
