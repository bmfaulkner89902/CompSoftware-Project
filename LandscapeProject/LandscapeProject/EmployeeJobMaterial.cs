using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandscapeProject
{
    public partial class EmployeeJobMaterial : Form
    {
        public EmployeeJobMaterial()
        {
            InitializeComponent();
        }
        CurrencyManager workerManager;
        CurrencyManager customerManager; 
        private void EmployeeJobMaterial_Load(object sender, EventArgs e)
        {
            //open connection 
            ProgOps.Open();

           // ProgOps.empCommand = new SqlCommand("SELECT group1fa202330.Customers.CustomerID, group1fa202330.JobSites.Address, JobType, BeginDate, EndDate, JobSize_In_Yards FROM group1fa202330.JobSites JOIN group1fa202330.CustomerJobs ON group1fa202330.JobSites.JobID = group1fa202330.CustomerJobs.JobID JOIN group1fa202330.Customers ON group1fa202330.CustomerJobs.CustomerID = group1fa202330.Customers.CustomerID;", ProgOps.empConnection);
           //ProgOps.empAdapter.SelectCommand = ProgOps.empCommand;
           // ProgOps.empAdapter.Fill(ProgOps.empCreateJobDT);
           // dgvcustomers.DataSource = ProgOps.empCreateJobDT; 


            //get information to fill workerID checklist. . 
            ProgOps.empCommand = new SqlCommand("SELECT WorkerID FROM group1fa202330.Workers; ", ProgOps.empConnection);
            ProgOps.empAdapter.SelectCommand = ProgOps.empCommand;
            ProgOps.empWorkerIDDT = new DataTable();
            ProgOps.empAdapter.Fill(ProgOps.empWorkerIDDT);

            cklAssignWorkers.DataBindings.Add("Text", ProgOps.empWorkerIDDT, "WorkerID");
            cklAssignWorkers.DataSource = ProgOps.empWorkerIDDT;
            cklAssignWorkers.DisplayMember = "WorkerID";

            //get workerJobs table 
            ProgOps.empCommand = new SqlCommand("SELECT * FROM group1fa202330.WorkerJobs; ", ProgOps.empConnection);
            ProgOps.empAdapter.SelectCommand = ProgOps.empCommand;
            ProgOps.empAssignWorkersDT = new DataTable();
            ProgOps.empAdapter.Fill(ProgOps.empAssignWorkersDT);

            
           
            
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnConfirmJob_Click(object sender, EventArgs e)
        {
            try
            {
                ProgOps.startJobs(txtJobID, txtJobAddress, txtJobType, txtStart, txtEnd, txtJobSize, txtPrice);
                ProgOps.empConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmMaterials_Click(object sender, EventArgs e)
        {
            try
            {
                ProgOps.assignMaterialsToJob(txtMaterialID, txtMaterialJobID);
                ProgOps.startMaterials(txtMaterialID, txtMaterialUnit, txtMaterialName, txtMaterialPrice, txtMaterialDate, txtMaterialJobID);
               

            ProgOps.empConnection.Close();
        }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmCustomer_Click(object sender, EventArgs e)
        {
            try
            {
                ProgOps.startCustomers(txtCustFirst, txtCustLast, txtCustAddress, txtCustEmail, txtCustCity, txtCustZip, txtID)
                    ;
                ProgOps.CloseAll(); 
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmWorkers_Click(object sender, EventArgs e)
        {
            //try
            //{
                ProgOps.startAssign(txtJobID, cklAssignWorkers); 
                ProgOps.empConnection.Close();
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
        }

        
    }
}
