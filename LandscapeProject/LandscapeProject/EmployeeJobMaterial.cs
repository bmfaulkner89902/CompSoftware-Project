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
                ProgOps.startJobs(txtJobCustId, txtJobAddress, txtJobType, txtStart, txtEnd, txtJobSize, txtPrice);
                lblUpdated.Visible = true; 
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
                ProgOps.startMaterials( txtMaterialUnit, txtMaterialName, txtMaterialPrice, txtMaterialDate, txtMaterialJobID);
                ProgOps.assignMaterialsToJob(txtMaterialJobID);

                lblUpdated.Visible = true; 
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
                ProgOps.startCustomers(txtCustFirst, txtCustLast, txtCustAddress, txtCustEmail, txtCustCity, txtCustZip);
                lblUpdated.Visible = true; 
                 
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
                lblUpdated.Visible = true; 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void tpgAssignMaterials_TextChanged(object sender, EventArgs e)
        {
            lblUpdated.Visible = false; 
        }

        private void txtCustFirst_TextChanged(object sender, EventArgs e)
        {
            lblUpdated.Visible = false; 
        }

        private void txtJobCustId_TextChanged(object sender, EventArgs e)
        {
            lblUpdated.Visible = false; 
        }

        private void txtMaterialName_TextChanged(object sender, EventArgs e)
        {
            lblUpdated.Visible = false; 
        }

        private void txtWorkerJobID_TextChanged(object sender, EventArgs e)
        {
            lblUpdated.Visible = false; 
        }
    }
}
