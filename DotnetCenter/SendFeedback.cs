using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;


namespace DotnetCenter
{
    public partial class SendFeedback : Form
    {
        public SendFeedback()
        {
            InitializeComponent();
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            if (tbNombre.Text != string.Empty && tbTo.Text != string.Empty
                && tbMensaje.Text != string.Empty)
            {
                lblEstado.Text = "Enviando feedback ...";
                this.Refresh();
                string res = Center.SendMail(tbTo.Text, tbNombre.Text, "[FeedBack_DotnetCenter]", tbMensaje.Text);
                if (res == "")
                    MessageBox.Show("Feedback Enviado");
                else
                    MessageBox.Show("Error al enviar Feedback");

                lblEstado.Text = string.Empty;                
            }
            else
                MessageBox.Show("Falta algún campo por rellenar");
        }

       
    }
}
