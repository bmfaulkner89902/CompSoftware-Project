using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace LandscapeProject
{
    public partial class LoginScreen : Form
    {
       
        public LoginScreen()
        {
            InitializeComponent();
        }

        private void btnGuest_Click(object sender, EventArgs e)
        {
           
            this.Hide();
            UserMain form1 = new UserMain();
            form1.cust = "Guest";
            form1.Show();
            
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginCreateUser form1 = new LoginCreateUser();
            form1.Show();
        }
        private void btnEmpSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                LoginProgOps.startEmpLogin(tbxEmpUsername, tbxEmpPassword);
                LoginProgOps.CloseAllLog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnOwnerSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                LoginProgOps.startOwnLogin(tbxOwnUsername, tbxOwnPassword);
                LoginProgOps.CloseAllLog();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
           
        }

        private void btnCustSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                LoginProgOps.startCustLogin(tbxCustUsername, tbxCustPassword);
                LoginProgOps.CloseAllLog();
                

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void linkUserRecover_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
