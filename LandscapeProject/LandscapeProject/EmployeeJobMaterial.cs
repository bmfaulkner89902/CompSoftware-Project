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
            try
            {
                MaximizeBox = false;
                MinimizeBox = false;
                this.HelpButton = true; 

                hlpEmpJob.HelpNamespace = Application.StartupPath + "\\landScapeEmployee.chm";
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "The help files failed to load."); 
            }
            try
            {
                EmployeeProgOps.LoadCheckList(cklAssignWorkers);
            }
            catch(SqlException)
            {
                MessageBox.Show("The program failed to connect to the database. Please check your internet connection. If the issue persists then contact the help desk.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }

        private void btnConfirmJob_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeProgOps.startJobs(txtJobCustId, txtJobAddress, txtJobType, txtStart, txtEnd, txtJobSize, txtPrice);
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
                EmployeeProgOps.startMaterials( txtMaterialUnit, txtMaterialName, txtMaterialPrice, txtMaterialDate, txtMaterialJobID);
                EmployeeProgOps.assignMaterialsToJob(txtMaterialJobID);

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
                EmployeeProgOps.startCustomers(txtCustFirst, txtCustLast, txtCustAddress, txtCustEmail, txtCustCity, txtCustZip);
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
                EmployeeProgOps.startAssign(txtWorkerJobID, cklAssignWorkers);
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

        private void EmployeeJobMaterial_HelpButtonClicked(object sender, CancelEventArgs e)
        {
            Help.ShowHelp(this, hlpEmpJob.HelpNamespace);
        }
    }
}
