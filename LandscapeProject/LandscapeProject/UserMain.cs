﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandscapeProject
{
    public partial class UserMain : Form
    {
        public string cust = "";
        public int custID;
        public int jobID;
        public UserMain()
        {
            InitializeComponent();
        }
        //On load Form takes in custID creates a personalized user experience
        private void UserMain_Load(object sender, EventArgs e)//*Find jobs depending on custID*
        {
            //point to help file
            hlpCustomer.HelpNamespace = Application.StartupPath + "\\Login-Help.chm";
            //Greeting
            lblUserGreeting.Text = ("Hello " + cust + "(user#: " + custID.ToString() + ")");
            //personalized jobs request            
            CustomerProgOps.Open();
            CustomerProgOps.LoadJobView(dgvJobInfo, custID);


        }
        //Requests a job: Writes job to databse linked to customer who wrote it. Also sends new users to create account
        private void btnRequest_Click(object sender, EventArgs e)
        {

            if (tbxJobAddress.Text.Equals("") || tbxJobType.Text.Equals(""))
            {
                MessageBox.Show("Please give us some more info about the job");
            }
            else
            {
                try
                {
                    if (cust.Equals("Guest"))
                    {
                        MessageBox.Show("Make an account before requesting job");
                        LoginCreateUser form1 = new LoginCreateUser();
                        form1.ShowDialog();
                        this.Hide();
                    }
                    else
                    {
                        string jobType = tbxJobType.Text;
                        string jobAddress = tbxJobAddress.Text;
                        string begDate = dtpBegDate.Value.ToString("yyyy-MM-dd");
                        string endDate = dtpEndDate.Value.ToString("yyyy-MM-dd");
                        if (endDate.Equals(""))
                            endDate = "NULL";
                        CustomerProgOps.Open();
                        CustomerProgOps.startCreateCustomerJob(custID, jobType, jobAddress, begDate, endDate);
                        lblTest.Text = "Success! Your job has been added. Make a payment on your job or contact your contractor";
                        CustomerProgOps.Open();
                        CustomerProgOps.LoadJobView(dgvJobInfo, custID);
                        CustomerProgOps.CloseAllCust();
                        ClearForm();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error Creating Job. Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }
        //Updates output label on click so the user can find the payment due and the contractor contact info
        private void dgvJobInfo_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

            try
            {
                CustomerProgOps.Open();
                //Retreives payment due
                DataGridViewRow pay = dgvJobInfo.Rows[e.RowIndex];
                string payDue = pay.Cells[6].Value.ToString();
                if (payDue.Equals(""))
                    payDue = "Payment is not yet due";
                else
                    payDue = "$" + payDue;
                lblOutput.Text = "Payment Due: " + payDue;

                //Retrieves Jobs Contractor and contact info
                DataGridViewRow job = dgvJobInfo.Rows[e.RowIndex];
                string jobID = job.Cells[1].Value.ToString();

                CustomerProgOps.LoadWorkerView(dgvCustJobWorkerInfo, jobID);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Finding Job Info. Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            ClearForm();
            this.Close();
        }
        public void ClearForm()
        {
            tbxJobAddress.Text = "";
            tbxJobType.Text = "";
        }
        private void UserMain_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, hlpCustomer.HelpNamespace);
        }
    }
}
