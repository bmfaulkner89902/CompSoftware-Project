using System;
using System.Net;
using System.Net.Mail;
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
                this.Hide();
                LoginProgOps.startEmpLogin(tbxEmpUsername, tbxEmpPassword);
                LoginProgOps.CloseAllLog();
                ClearForm();
                this.Show();

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
                this.Hide();
                LoginProgOps.startOwnLogin(tbxOwnUsername, tbxOwnPassword);
                LoginProgOps.CloseAllLog();
                ClearForm();
                this.Show();

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
                this.Hide();
                LoginProgOps.startCustLogin(tbxCustUsername, tbxCustPassword);
                LoginProgOps.CloseAllLog();
                ClearForm();
                this.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void linkUserRecover_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string custEmail="";
            var smtpClient = new SmtpClient("smtp.gmail.com")
            {
                Port = 587,
                Credentials = new NetworkCredential("lansdcapeaccrec1@gmail.com", "Landscaperz"),
                EnableSsl = true,
            };

            smtpClient.Send("lansdcapeaccrec1@gmail.com", custEmail, "Password Recovery", "body");

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

        private void LoginScreen_Load(object sender, EventArgs e)
        {
            LoginProgOps.Open();
        }

        private void LoginScreen_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginProgOps.CloseAllLog();
        }


    }
}
