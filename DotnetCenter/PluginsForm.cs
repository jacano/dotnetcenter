using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DotnetCenter
{
    public partial class PluginsForm : Form
    {
        private Form center;

        public PluginsForm(Form center)
        {

            this.center = center;
            InitializeComponent();

            LoadPlugins();
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
            //if (File.Exists(Directories.FilePendingDelete))
            //    MessageBox.Show("Before to install any plugin, The application need restart", "Warning");
            //else{
                if (DialogResult.OK == this.openFileDialog.ShowDialog())
                {
                    String[] l = openFileDialog.FileName.Split('\\');
                    String filename = l[l.Length - 1];
                    if (Center.Plugins.ValidatePlugin(openFileDialog.FileName))
                    {
                        String newPath = Path.Combine(Directories.PluginsDirectory, filename);
                        if (File.Exists(newPath))
                            MessageBox.Show("Already exists any plugin with same name", "Error");
                        else
                        {
                            File.Copy(openFileDialog.FileName, newPath);
                            int operationResult = Center.Plugins.AddPlugin(openFileDialog.FileName);
                            Center.Plugins.DeleteFromPending(newPath);
                            switch (operationResult)
                            {
                                case 0:
                                    MessageBox.Show("There has been some error to try to add the new plugin", "Error");
                                    break;

                                case 1:
                                    this.LoadPlugins();
                                    Center.LoadingPluginsMenu();
                                    MessageBox.Show("The new plugin has been added correctly", "Correct operation");
                                    break;

                                case 2:
                                    MessageBox.Show("There wasn't error, but we couldn't add your new plugin. Review it please.", "Strange thing");
                                    break;
                            }
                        }
                    }
                    else
                        MessageBox.Show("This dll is not available plugin", "Error");
                }
            //}
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
                        MessageBox.Show("The plugin hasn't been found. Review the name.", "Error");
                        break;
                    case 1:
                        this.LoadPlugins();
                        Center.LoadingPluginsMenu();
                        MessageBox.Show("The new plugin has been removed correctly, but you need restart de application to that complete operation", "Correct operation");
                        break;
                    case 2:
                        MessageBox.Show("The plugin assembly doesn't exit. Review it please.", "Strange thing");
                        break;
                }
            }
        }
    }
}
