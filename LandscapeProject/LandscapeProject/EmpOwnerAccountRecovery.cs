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
            string custEmail = tbxEmail.Text.ToString();
            LoginProgOps.empAccountRecovery(custEmail);
            lblEmailOutput.Text = "Check your inbox for account recovery information.";
        }
    }
}
