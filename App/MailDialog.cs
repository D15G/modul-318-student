using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace App
{
    public partial class MailDialog : Form
    {

        public string from = "";
        public string to = "";
        public string password;
        public string smtpServer = "";
        public int smtpPort;

        public MailDialog()
        {
            InitializeComponent();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {

            switch (cmbMailService.Text)
            {
                case "Outlook":
                    smtpServer = "SMTP.office365.com";
                    smtpPort = 587;
                    break;
                case "Gmail":
                    smtpServer = "smtp.gmail.com";
                    smtpPort = 465;
                    break;
                default:
                    smtpPort = -1;
                    break;
            }

            if ((smtpPort == -1 && smtpServer.Equals("")) || txtMailAddress.Text.Equals("") || txtMailTo.Text.Equals(""))
            {
                Dialogs dialogs = new Dialogs();
                dialogs.ShowInvalidInputDialog();
            } else
            {
                from = txtMailAddress.Text;
                to = txtMailTo.Text;
                password = txtMailPassword.Text;

                this.Close();
            }

        }
    }
}
