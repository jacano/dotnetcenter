namespace DotnetCenter
{
    partial class PluginsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PluginsForm));
            this.lbName = new System.Windows.Forms.Label();
            this.textBox_PluginName = new System.Windows.Forms.TextBox();
            this.lbVersion = new System.Windows.Forms.Label();
            this.textBox_PluginVersion = new System.Windows.Forms.TextBox();
            this.lbEmail = new System.Windows.Forms.Label();
            this.textBox_Email = new System.Windows.Forms.TextBox();
            this.groupBox = new System.Windows.Forms.GroupBox();
            this.buttonAddPlugin = new System.Windows.Forms.Button();
            this.buttonRemovePlugin = new System.Windows.Forms.Button();
            this.listBoxPlugins = new System.Windows.Forms.ListBox();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btAdvanced = new System.Windows.Forms.Button();
            this.groupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbName
            // 
            this.lbName.AutoSize = true;
            this.lbName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbName.Location = new System.Drawing.Point(21, 31);
            this.lbName.Name = "lbName";
            this.lbName.Size = new System.Drawing.Size(100, 16);
            this.lbName.TabIndex = 1;
            this.lbName.Text = "Plugin Name:";
            // 
            // textBox_PluginName
            // 
            this.textBox_PluginName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_PluginName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PluginName.Location = new System.Drawing.Point(24, 50);
            this.textBox_PluginName.Name = "textBox_PluginName";
            this.textBox_PluginName.Size = new System.Drawing.Size(314, 26);
            this.textBox_PluginName.TabIndex = 2;
            // 
            // lbVersion
            // 
            this.lbVersion.AutoSize = true;
            this.lbVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbVersion.Location = new System.Drawing.Point(21, 84);
            this.lbVersion.Name = "lbVersion";
            this.lbVersion.Size = new System.Drawing.Size(65, 16);
            this.lbVersion.TabIndex = 1;
            this.lbVersion.Text = "Version:";
            // 
            // textBox_PluginVersion
            // 
            this.textBox_PluginVersion.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_PluginVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_PluginVersion.Location = new System.Drawing.Point(24, 103);
            this.textBox_PluginVersion.Name = "textBox_PluginVersion";
            this.textBox_PluginVersion.Size = new System.Drawing.Size(314, 26);
            this.textBox_PluginVersion.TabIndex = 2;
            // 
            // lbEmail
            // 
            this.lbEmail.AutoSize = true;
            this.lbEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbEmail.Location = new System.Drawing.Point(21, 138);
            this.lbEmail.Name = "lbEmail";
            this.lbEmail.Size = new System.Drawing.Size(47, 16);
            this.lbEmail.TabIndex = 1;
            this.lbEmail.Text = "Email";
            // 
            // textBox_Email
            // 
            this.textBox_Email.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox_Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_Email.Location = new System.Drawing.Point(24, 157);
            this.textBox_Email.Name = "textBox_Email";
            this.textBox_Email.Size = new System.Drawing.Size(314, 26);
            this.textBox_Email.TabIndex = 2;
            // 
            // groupBox
            // 
            this.groupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox.Controls.Add(this.lbName);
            this.groupBox.Controls.Add(this.textBox_Email);
            this.groupBox.Controls.Add(this.textBox_PluginName);
            this.groupBox.Controls.Add(this.lbEmail);
            this.groupBox.Controls.Add(this.lbVersion);
            this.groupBox.Controls.Add(this.textBox_PluginVersion);
            this.groupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox.Location = new System.Drawing.Point(204, 14);
            this.groupBox.Name = "groupBox";
            this.groupBox.Size = new System.Drawing.Size(357, 217);
            this.groupBox.TabIndex = 3;
            this.groupBox.TabStop = false;
            this.groupBox.Text = "Plugin Information";
            // 
            // buttonAddPlugin
            // 
            this.buttonAddPlugin.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddPlugin.Image")));
            this.buttonAddPlugin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonAddPlugin.Location = new System.Drawing.Point(369, 287);
            this.buttonAddPlugin.Name = "buttonAddPlugin";
            this.buttonAddPlugin.Size = new System.Drawing.Size(93, 56);
            this.buttonAddPlugin.TabIndex = 4;
            this.buttonAddPlugin.Text = "Add plugin";
            this.buttonAddPlugin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonAddPlugin.UseVisualStyleBackColor = true;
            this.buttonAddPlugin.Click += new System.EventHandler(this.buttonAddPlugin_Click);
            // 
            // buttonRemovePlugin
            // 
            this.buttonRemovePlugin.Image = ((System.Drawing.Image)(resources.GetObject("buttonRemovePlugin.Image")));
            this.buttonRemovePlugin.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.buttonRemovePlugin.Location = new System.Drawing.Point(468, 287);
            this.buttonRemovePlugin.Name = "buttonRemovePlugin";
            this.buttonRemovePlugin.Size = new System.Drawing.Size(93, 56);
            this.buttonRemovePlugin.TabIndex = 5;
            this.buttonRemovePlugin.Text = "Remove plugin";
            this.buttonRemovePlugin.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.buttonRemovePlugin.UseVisualStyleBackColor = true;
            this.buttonRemovePlugin.Click += new System.EventHandler(this.buttonRemovePlugin_Click);
            // 
            // listBoxPlugins
            // 
            this.listBoxPlugins.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)));
            this.listBoxPlugins.FormattingEnabled = true;
            this.listBoxPlugins.Location = new System.Drawing.Point(12, 14);
            this.listBoxPlugins.Name = "listBoxPlugins";
            this.listBoxPlugins.Size = new System.Drawing.Size(172, 329);
            this.listBoxPlugins.TabIndex = 6;
            this.listBoxPlugins.SelectedIndexChanged += new System.EventHandler(this.listBoxPlugins_SelectedIndexChanged);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "MyPluginName.dll";
            this.openFileDialog.Filter = "DLL files|*.dll";
            this.openFileDialog.Title = "Select your plugin dll";
            // 
            // btAdvanced
            // 
            this.btAdvanced.Image = ((System.Drawing.Image)(resources.GetObject("btAdvanced.Image")));
            this.btAdvanced.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btAdvanced.Location = new System.Drawing.Point(204, 287);
            this.btAdvanced.Name = "btAdvanced";
            this.btAdvanced.Size = new System.Drawing.Size(86, 56);
            this.btAdvanced.TabIndex = 7;
            this.btAdvanced.Text = "Advanced";
            this.btAdvanced.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btAdvanced.UseVisualStyleBackColor = true;
            this.btAdvanced.Click += new System.EventHandler(this.btAdvanced_Click);
            // 
            // PluginsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 355);
            this.Controls.Add(this.btAdvanced);
            this.Controls.Add(this.listBoxPlugins);
            this.Controls.Add(this.buttonRemovePlugin);
            this.Controls.Add(this.buttonAddPlugin);
            this.Controls.Add(this.groupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PluginsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Plugins";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PluginsForm_FormClosing);
            this.groupBox.ResumeLayout(false);
            this.groupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbName;
        private System.Windows.Forms.TextBox textBox_PluginName;
        private System.Windows.Forms.Label lbVersion;
        private System.Windows.Forms.TextBox textBox_PluginVersion;
        private System.Windows.Forms.Label lbEmail;
        private System.Windows.Forms.TextBox textBox_Email;
        private System.Windows.Forms.GroupBox groupBox;
        private System.Windows.Forms.Button buttonAddPlugin;
        private System.Windows.Forms.Button buttonRemovePlugin;
        private System.Windows.Forms.ListBox listBoxPlugins;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Button btAdvanced;
    }
}