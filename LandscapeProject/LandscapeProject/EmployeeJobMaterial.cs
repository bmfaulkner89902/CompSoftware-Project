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
        private void EmployeeJobMaterial_Load(object sender, EventArgs e)
        {
            //open connection 
            ProgOps.Open();

           // ProgOps.LoadCheckList(cklAssignWorkers); 
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
                ProgOps.startCustomers(txtCustFirst, txtCustLast, txtCustAddress, txtCustEmail, txtCustCity, txtCustZip, txtID);
                ProgOps.CloseAll(); 
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnConfirmWorkers_Click(object sender, EventArgs e)
        {
            try
            {
                ProgOps.startAssign(txtWorkerJobID, cklAssignWorkers);
                ProgOps.empConnection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        
    }
}
