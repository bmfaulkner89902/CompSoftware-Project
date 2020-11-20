using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandscapeProject
{
    public partial class EmpOwnerAccountRecovery : Form
    {
        public EmpOwnerAccountRecovery()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string custEmail = tbxEmail.ToString();
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("lansdcapeaccrec1@gmail.com", "Landscaperz"),
                EnableSsl = true,
            };

            smtpClient.Send("lansdcapeaccrec1@gmail.com", custEmail, "Password Recovery", "test");
        }
    }
}
