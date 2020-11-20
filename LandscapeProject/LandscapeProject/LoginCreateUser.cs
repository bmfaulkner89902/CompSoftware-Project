﻿using System;
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
    public partial class LoginCreateUser : Form
    {
        public LoginCreateUser()
        {
            InitializeComponent();
        }

        private void btnConfirmCustomer_Click(object sender, EventArgs e)
        {
            //input validation
            if (tbxUsername.Text.Equals("") || tbxUserPassword.Text.Equals("")|| tbxConfirmUserPassword.Text.Equals("")|| tbxUserFname.Text.Equals("") || tbxUserLname.Text.Equals("") || tbxUserAddress.Text.Equals("")|| tbxUserEmail.Text.Equals("") || tbxUserCity.Text.Equals("") || tbxUserZip.Text.Equals(""))
            {
                MessageBox.Show("Please fill out the information");
            }
            //writes customer info to database then returns to login screen
            else
            {
                try
                {
                    
                    CustomerProgOps.startCreateCustomer(tbxUsername, tbxUserPassword, tbxConfirmUserPassword, tbxUserFname, tbxUserLname, tbxUserAddress, tbxUserEmail, tbxUserCity, tbxUserZip);
                    CustomerProgOps.CloseAllCust();
                    ClearForm();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                MessageBox.Show("Your account has been created!");
                Application.Restart();
            }
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.Hide();
            LoginScreen form1 = new LoginScreen();
            form1.ShowDialog();
        }
        public void ClearForm()
        {
            tbxConfirmUserPassword.Text = "";
            tbxUserAddress.Text = "";
            tbxUserCity.Text = "";
            tbxUserEmail.Text = "";
            tbxUserFname.Text = "";
            tbxUserLname.Text = "";
            tbxUsername.Text = "";
            tbxUserPassword.Text = "";
            tbxUserZip.Text = "";
        }
    }
}
