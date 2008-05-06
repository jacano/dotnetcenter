﻿using System;
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
            if (DialogResult.OK == this.openFileDialog1.ShowDialog())
            {

                int operationResult = Center.Plugins.AddPlugin(this.openFileDialog1.FileName);
                switch (operationResult)
                {
                    case 0:
                        
                        MessageBox.Show("There has been some error to try to add the new plugin", "Error");
                        break;
                    case 1:
                        this.LoadPlugins();
                        Center.LoadingPluginsMenu();
                        MessageBox.Show("The new plugin has been added correctly", "Correct operation");
                        if (!File.Exists(this.openFileDialog1.FileName))
                        {
                            if (DialogResult.Yes == MessageBox.Show("Would you like to copy this plugin to Plugin Directory?", "Save your plugin", MessageBoxButtons.YesNo, MessageBoxIcon.Question))
                            {
                                string currentPluginsDir = AppDomain.CurrentDomain.BaseDirectory + "\\Plugins\\";
                                string fileNameWithoutExtension = Path.GetFileName(this.openFileDialog1.FileName);
                                Center.watcher.EnableRaisingEvents = false;
                                File.Copy(this.openFileDialog1.FileName, currentPluginsDir + fileNameWithoutExtension);
                                Center.watcher.EnableRaisingEvents = true;
                            }
                        }
                        
                        break;
                    case 2:
                        MessageBox.Show("There wasn't error, but we couldn't add your new plugin. Review it please.", "Strange thing");
                        break;
                }
                

            }
        }

        private void PluginsForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            center.Enabled = true;
        }

       
    }
}