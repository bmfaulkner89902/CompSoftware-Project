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
    public partial class UserMain : Form
    {
        public string cust = "";
        public int custID;
        public UserMain()
        {
            InitializeComponent();
        }

        private void UserMain_Load(object sender, EventArgs e)//*Find jobs depending on custID*
        {
            //Greeting
            lblUserGreeting.Text = ("Hello " + cust + "(user#: " + custID.ToString() + "), request a job, contact a contractor, or make a payment below.");
            //load datagridview - 
            //open connection 
            ProgOps.Open();
            //get information to fill datagridview Job information . 
            ProgOps.cCommand = new SqlCommand("SELECT JobID AS 'Job Number', JobType AS 'Job',Address, BeginDate AS 'Start Date', EndDate AS 'End Date', Price AS 'Payment Due:' FROM group1fa202330.JobSites; ", ProgOps.cConnection);
            ProgOps.cAdapter.SelectCommand = ProgOps.cCommand;
            ProgOps.cAdapter.Fill(ProgOps.cJobSitesDT);
            //start data grid viewer
            dgvJobInfo.DataSource = ProgOps.cJobSitesDT;

        }

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
                        this.Hide();
                        LoginCreateUser form1 = new LoginCreateUser();
                        form1.Show();
                    }
                    else
                    {
                        ProgOps.startCreateCustomerJob(1, tbxJobType, tbxJobAddress, dtpBegDate, dtpEndDate);
                        ProgOps.CloseAllCust();
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                lblTest.Text = "Success! Your job has been added. Make a payment on your job or contact your contractor";
            }
        }

        private void btnContact_Click(object sender, EventArgs e)
        {
            //Take what row is clicked on link job ID to contractor and display info
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            //Show price and take to payment portal?
        }

       
    }
}
