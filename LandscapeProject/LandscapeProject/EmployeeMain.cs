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
    public partial class EmployeeMain : Form
    {
        CurrencyManager empManager; 
        public EmployeeMain()
        {
            InitializeComponent();
        }
        //const string connectionString = "Server=cstnt.tstc.edu;Database=INEW2330fa20;User Id=group1fa202330;password=1524152"; 

        
        private void btnSearchSchedule_Click(object sender, EventArgs e)
        {
            string searchItem = txtSearchSchedule.Text;
            //ID = term searched for, column = workerid/jobid. 
            //ProgOps.Open();
            ProgOps.empCommand = new SqlCommand("SELECT group1fa202330.TimeTables.WorkerID, Clock_in, Clock_out FROM group1fa202330.TimeTables WHERE WorkerID = " + searchItem + " ORDER BY WorkerID; ", ProgOps.empConnection);
            ProgOps.empAdapter.SelectCommand = ProgOps.empCommand;
            ProgOps.empAdapter.Fill(ProgOps.empTimeTableDt);

            dataGridView2.DataSource = ProgOps.empTimeTableDt;
            ProgOps.empConnection.Close();
            
        }

        private void EmployeeMain_Load(object sender, EventArgs e)
        {
            //open connection 
            ProgOps.Open();
            //get information to fill datagridview Job information . 
            ProgOps.empCommand = new SqlCommand("SELECT group1fa202330.JobSites.JobID, group1fa202330.Customers.FirstName, JobType, group1fa202330.Customers.Address, BeginDate, EndDate, Price FROM group1fa202330.Customers JOIN group1fa202330.CustomerJobs ON group1fa202330.Customers.CustomerID = CustomerJobs.CustomerID JOIN group1fa202330.JobSites ON group1fa202330.CustomerJobs.JobID = group1fa202330.JobSites.JobID ORDER BY BeginDate; ", ProgOps.empConnection);
            ProgOps.empAdapter.SelectCommand = ProgOps.empCommand;
            ProgOps.empAdapter.Fill(ProgOps.empJobInfoDT);

            //fill datagrid view. 
            dataGridView1.DataSource = ProgOps.empJobInfoDT;

            //fill the worker schedule. 
            ProgOps.empCommand = new SqlCommand("SELECT group1fa202330.TimeTables.WorkerID, Clock_in, Clock_out FROM group1fa202330.TimeTables ORDER BY WorkerID, Clock_In; ", ProgOps.empConnection);
            ProgOps.empAdapter.SelectCommand = ProgOps.empCommand;
            ProgOps.empAdapter.Fill(ProgOps.empTimeTableDt);

            //fill datagrid view. 
            dataGridView2.DataSource = ProgOps.empTimeTableDt;

        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            ProgOps.empConnection.Close(); 
            EmployeeCustomer form1 = new EmployeeCustomer();
            form1.Show(); 
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            ProgOps.empConnection.Close();
            EmployeeJobMaterial form2 = new EmployeeJobMaterial();
            form2.Show(); 
        }
    }
}
