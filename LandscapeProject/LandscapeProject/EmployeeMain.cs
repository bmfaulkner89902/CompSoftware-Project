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
       
        private void btnSearchSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                ProgOps.empTimeTableDt = new DataTable(); 
                string searchItem = txtSearchSchedule.Text;
                //ID = term searched for, column = workerid/jobid. 
                if (searchItem == null || searchItem == "")
                {
                    ProgOps.empCommand = new SqlCommand("SELECT group1fa202330.TimeTables.WorkerID, Clock_in, Clock_out FROM group1fa202330.TimeTables;", ProgOps.empConnection);
                }
                ProgOps.empCommand = new SqlCommand("SELECT group1fa202330.TimeTables.WorkerID, Clock_in, Clock_out FROM group1fa202330.TimeTables WHERE WorkerID = " + searchItem + " ORDER BY WorkerID; ", ProgOps.empConnection);
                ProgOps.empAdapter.SelectCommand = ProgOps.empCommand;
                ProgOps.empAdapter.Fill(ProgOps.empTimeTableDt);

                dgvEmpWorkerSch.DataSource = ProgOps.empTimeTableDt;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            
        }

        private void EmployeeMain_Load(object sender, EventArgs e)
        {
            try
            {
                //open connection 
                ProgOps.Open();
                //get information to fill datagridview Job information . 
                ProgOps.empCommand = new SqlCommand("SELECT group1fa202330.JobSites.JobID, group1fa202330.Customers.FirstName, JobType, group1fa202330.Customers.Address, BeginDate, EndDate, Price FROM group1fa202330.Customers JOIN group1fa202330.CustomerJobs ON group1fa202330.Customers.CustomerID = CustomerJobs.CustomerID JOIN group1fa202330.JobSites ON group1fa202330.CustomerJobs.JobID = group1fa202330.JobSites.JobID ORDER BY BeginDate; ", ProgOps.empConnection);
                ProgOps.empAdapter.SelectCommand = ProgOps.empCommand;
                ProgOps.empAdapter.Fill(ProgOps.empJobInfoDT);

                //fill datagrid view. 
                dgvEmpJobInfo.DataSource = ProgOps.empJobInfoDT;

                //fill the worker schedule. 
                ProgOps.empCommand = new SqlCommand("SELECT group1fa202330.TimeTables.WorkerID, Clock_in, Clock_out FROM group1fa202330.TimeTables ORDER BY WorkerID, Clock_In; ", ProgOps.empConnection);
                ProgOps.empAdapter.SelectCommand = ProgOps.empCommand;
                ProgOps.empAdapter.Fill(ProgOps.empTimeTableDt);

                //fill datagrid view. 
                dgvEmpWorkerSch.DataSource = ProgOps.empTimeTableDt;
            }
            catch (SqlException)
            {
                MessageBox.Show("The connection to the database may be down. Please check your internet connection. If the problem persists then please contact support.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            
            EmployeeCustomer form1 = new EmployeeCustomer();
            form1.ShowDialog(); 
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            
            EmployeeJobMaterial form2 = new EmployeeJobMaterial();
            form2.ShowDialog(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            ProgOps.CloseAll(); 
            this.Close(); 
        }

        private void btnEmpLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}
