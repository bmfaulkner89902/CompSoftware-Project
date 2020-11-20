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
            string custEmail = tbxEmail.ToString().Trim();
            LoginProgOps.custAccountRecovery(custEmail);
            lblEmailOutput.Text = "Check your inbox for account recovery information.";

        }
    }
}
