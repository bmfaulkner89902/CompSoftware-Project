using System;
using System.Windows.Forms;

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
            try
            {
                ClearForm();
                this.Hide();
                UserMain form1 = new UserMain();
                form1.cust = "Guest";
                form1.ShowDialog();
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

            private void btnCreate_Click(object sender, EventArgs e)
        {
            try
            {
                ClearForm();
                this.Hide();
                LoginCreateUser form1 = new LoginCreateUser();
                form1.ShowDialog();
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnEmpSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                LoginProgOps.startEmpLogin(tbxEmpUsername, tbxEmpPassword);
                LoginProgOps.CloseAllLog();
                ClearForm();

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
                ClearForm();
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
                ClearForm();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void linkUserRecover_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        public void ClearForm()
        {
            tbxCustPassword.Text = "";
            tbxCustUsername.Text = "";
            tbxEmpPassword.Text = "";
            tbxEmpUsername.Text = "";
            tbxOwnPassword.Text = "";
            tbxOwnUsername.Text = "";
        }
    }
}
