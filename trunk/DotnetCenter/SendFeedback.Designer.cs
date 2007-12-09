namespace DotnetCenter
{
    partial class SendFeedback
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
            this.tbTo = new System.Windows.Forms.TextBox();
            this.lblEnviar = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.tbMensaje = new System.Windows.Forms.TextBox();
            this.btnSend = new System.Windows.Forms.Button();
            this.lblEstado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbTo
            // 
            this.tbTo.Location = new System.Drawing.Point(80, 61);
            this.tbTo.Name = "tbTo";
            this.tbTo.Size = new System.Drawing.Size(439, 20);
            this.tbTo.TabIndex = 1;
            // 
            // lblEnviar
            // 
            this.lblEnviar.AutoSize = true;
            this.lblEnviar.Location = new System.Drawing.Point(13, 64);
            this.lblEnviar.Name = "lblEnviar";
            this.lblEnviar.Size = new System.Drawing.Size(49, 13);
            this.lblEnviar.TabIndex = 1;
            this.lblEnviar.Text = "Enviar a:";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(13, 24);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 13);
            this.lblNombre.TabIndex = 2;
            this.lblNombre.Text = "Mi nombre";
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(80, 21);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.Size = new System.Drawing.Size(439, 20);
            this.tbNombre.TabIndex = 0;
            // 
            // tbMensaje
            // 
            this.tbMensaje.Location = new System.Drawing.Point(16, 146);
            this.tbMensaje.Multiline = true;
            this.tbMensaje.Name = "tbMensaje";
            this.tbMensaje.Size = new System.Drawing.Size(503, 288);
            this.tbMensaje.TabIndex = 2;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(16, 113);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(75, 23);
            this.btnSend.TabIndex = 3;
            this.btnSend.Text = "Enviar";
            this.btnSend.UseVisualStyleBackColor = true;
            this.btnSend.Click += new System.EventHandler(this.btnSend_Click);
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.ForeColor = System.Drawing.Color.Red;
            this.lblEstado.Location = new System.Drawing.Point(187, 122);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(0, 13);
            this.lblEstado.TabIndex = 8;
            // 
            // SendFeedback
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(531, 446);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.btnSend);
            this.Controls.Add(this.tbMensaje);
            this.Controls.Add(this.tbNombre);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.lblEnviar);
            this.Controls.Add(this.tbTo);
            this.MaximizeBox = false;
            this.Name = "SendFeedback";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SendFeedback";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbTo;
        private System.Windows.Forms.Label lblEnviar;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.TextBox tbMensaje;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.Label lblEstado;
    }
}