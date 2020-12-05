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
    public partial class CustomerAccountRecovery : Form
    {
        public CustomerAccountRecovery()
        {
            InitializeComponent();
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            string custEmail = tbxEmail.Text.ToString();
            LoginProgOps.custAccountRecovery(custEmail);
            lblEmailOutput.Text = "Check your inbox for account recovery information.";

        }

        private void CustomerAccountRecovery_Load(object sender, EventArgs e)
        {
            //point to help file
            hlpCustAccRecovery.HelpNamespace = Application.StartupPath + "\\Login-Help.chm";
        }

        private void CustomerAccountRecovery_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, hlpCustAccRecovery.HelpNamespace);
        }
    }
}
