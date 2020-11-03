using System;
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
    public partial class OwnerMain : Form
    {
        public OwnerMain()
        {
            InitializeComponent();
        }

        private void OwnerMain_Load(object sender, EventArgs e)
        {
            //Open Database then load JobCommand
            OwnerProgOps.OpenDatabase();
            OwnerProgOps.JobCommand(dgvJobs);
            MaterialsAndWorkersForJobs();
        }

        private void tcMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tabIndex = tcMain.SelectedIndex;

            switch (tabIndex)
            {
                case 0:
                    OwnerProgOps.JobCommand(dgvJobs);
                    MaterialsAndWorkersForJobs();
                    break;
                case 1:
                    OwnerProgOps.CustomerCommand(dgvCustomers);
                    break;
                case 2:
                    OwnerProgOps.ContractorCommand(dgvContractors);                    
                    break;
                case 3:
                    OwnerProgOps.EmployeesCommand(dgvEmployees);
                    break;
                case 4:
                    //Shows the Crystal Reports -- Do Later
                    break;

            }
        }


        private void dgvJobs_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (tcMain.SelectedIndex == 0)
            {
                if (e.RowIndex != -1)
                {
                    MaterialsAndWorkersForJobs();
                }
            }          
        }

        private void MaterialsAndWorkersForJobs()
        {
            int selectedJob = dgvJobs.CurrentRow.Index;
            int JobID = (int)dgvJobs.Rows[selectedJob].Cells[0].Value;
            OwnerProgOps.MaterialCommand(dgvJobMaterials, JobID);
            OwnerProgOps.EmployeeAndContractorJobs(lbxJobEmployees, lbxJobContractors, JobID);
        }

        private void btnRemoveContractorFromJob_Click(object sender, EventArgs e)
        {
            int selectedJob = dgvJobs.CurrentRow.Index;
            int JobID = (int)dgvJobs.Rows[selectedJob].Cells[0].Value;

            string contractorName;

            if (lbxJobContractors.SelectedIndex > -1)
            {
                DialogResult result =
                MessageBox.Show("Are you sure you want to remove selected contractor from the selected job?",
                "Remove Contractor From Job", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    contractorName = lbxJobContractors.SelectedItem.ToString();
                    OwnerProgOps.RemoveContractorsFromJobs(contractorName, JobID);

                    MessageBox.Show("Successfully removed selected contractor from the selected job.",
                           "Remove Contractor Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OwnerProgOps.EmployeeAndContractorJobs(lbxJobEmployees, lbxJobContractors, JobID);
                }
                else
                {
                    MessageBox.Show("The process for removing the selected contractor for the selected job has been cancelled.",
                        "Remove Contractor From Job Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                
            }           
            else
            {
                MessageBox.Show("No Contractor selected.", "Error With Removing Contractor", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnRemoveEmployeeFromJob_Click(object sender, EventArgs e)
        {
            int selectedJob = dgvJobs.CurrentRow.Index;
            int JobID = (int)dgvJobs.Rows[selectedJob].Cells[0].Value;

            string employeeName;

            if (lbxJobEmployees.SelectedIndex > -1)
            {
                DialogResult result =
                MessageBox.Show("Are you sure you want to remove selected employee from the selected job?",
                "Remove Employee From Job", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    employeeName = lbxJobEmployees.SelectedItem.ToString();
                    OwnerProgOps.RemoveEmployeesFromJobs(employeeName, JobID);

                    MessageBox.Show("Successfully removed selected employee from the selected job.",
                           "Remove Employee Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    OwnerProgOps.EmployeeAndContractorJobs(lbxJobEmployees, lbxJobContractors, JobID);
                }
                else
                {
                    MessageBox.Show("The process for removing the selected employee for the selected job has been cancelled.",
                       "Remove Employee From Job Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("No Employee selected.", "Error With Removing Employee", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        //Employee Functions-----------------------------------------------------------------------------------------

        private void btnEmployeeSubmit_Click(object sender, EventArgs e)
        {
            int selectedEmployee = dgvEmployees.CurrentRow.Index;
            int employeeID = (int)dgvEmployees.Rows[selectedEmployee].Cells[0].Value;
            

            if (cboEmployeeCategory.SelectedIndex > -1)
            {
                string selectedCategory = (string)cboEmployeeCategory.SelectedItem;

                if (tbxEmployeeInfoNew.Text != "" && tbxEmployeeInfoNew.Text != " ")
                {
                    string newInformation = tbxEmployeeInfoNew.Text;

                    OwnerProgOps.UpdateEmployee(selectedCategory, newInformation, employeeID);

                    MessageBox.Show("Successfully updated employee information with the new information entered.",
                        "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                    clearEmployeeBoxes();

                    OwnerProgOps.EmployeesCommand(dgvEmployees);
                }
                else
                {
                    //Makes User Enter New Information before trying to submit
                    MessageBox.Show("You must enter new information before submitting any changes.",
                        "Error With Updating Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Makes User Select a Category before trying to submit
                MessageBox.Show("Category must be selected before submitting any changes.",
                    "Error With Updating Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnEmployeeCancel_Click(object sender, EventArgs e)
        {
            if (cboEmployeeCategory.SelectedIndex > -1 || tbxEmployeeInfoNew.Text != "")
            {
                DialogResult result =
                MessageBox.Show("Are you sure you want to cancel editing employee information?",
                "Cancel Employee Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    //Clear New Employee Information
                    clearEmployeeBoxes();
                }
            }            
        }

        private void btnEmployeeDelete_Click(object sender, EventArgs e)
        {
            int selectedEmployee = dgvEmployees.CurrentRow.Index;
            int employeeID = (int)dgvEmployees.Rows[selectedEmployee].Cells[0].Value;

            DialogResult result =
                MessageBox.Show("Are you sure you want to delete the selected employee?",
                "Delete Employee", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                //Deletes Selected Employee
                OwnerProgOps.DeleteEmployee(employeeID);

                MessageBox.Show("Successfully deleted the selected employee.", 
                    "Delete Employee Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OwnerProgOps.EmployeesCommand(dgvEmployees);
            }
        }

        private void btnAddNewEmployee_Click(object sender, EventArgs e)
        {
            string Fname = tbxEmployeeFirstName.Text;
            string Lname = tbxEmployeeLastName.Text;
            string Address = tbxEmployeeAddress.Text;
            string City = tbxEmployeeCity.Text;
            string Zip = tbxEmployeeZip.Text;
            string Email = tbxEmployeeEmail.Text;

            if (Fname != "" && Fname != " ")
            {
                if (Lname != "" && Lname != " ")
                {
                    if (Address != "" && Address != " ")
                    {
                        if (City != "" && City != " ")
                        {
                            if (Zip != "" && Zip != " ")
                            {
                                if (Email != "" && Email != " ")
                                {
                                    OwnerProgOps.AddEmployee(Fname, Lname, Address, Email, City, Zip);

                                    MessageBox.Show("Successfully added a new employee.", 
                                        "Adding Employee Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearEmployeeBoxes();

                                    OwnerProgOps.EmployeesCommand(dgvEmployees);
                                }
                                else
                                {
                                    //Makes User Enter New Information before trying to submit
                                    MessageBox.Show("You must enter an Email before submitting a new employee",
                                        "Error With Adding Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                //Makes User Enter New Information before trying to submit
                                MessageBox.Show("You must enter a Zip Code before submitting a new employee",
                                    "Error With Adding Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            //Makes User Enter New Information before trying to submit
                            MessageBox.Show("You must enter a City before submitting a new employee",
                                "Error With Adding Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //Makes User Enter New Information before trying to submit
                        MessageBox.Show("You must enter an Address before submitting a new employee",
                            "Error With Adding Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Makes User Enter New Information before trying to submit
                    MessageBox.Show("You must enter a Last Name before submitting a new employee",
                        "Error With Adding Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Makes User Enter New Information before trying to submit
                MessageBox.Show("You must enter a First Name before submitting a new employee",
                    "Error With Adding Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelNewEmployee_Click(object sender, EventArgs e)
        {
            clearEmployeeBoxes();
        }

        private void clearEmployeeBoxes()
        {
            cboEmployeeCategory.SelectedIndex = -1;
            cboEmployeeCategory.Text = "";
            tbxEmployeeInfoNew.Text = "";
            tbxEmployeeFirstName.Text = "";
            tbxEmployeeLastName.Text = "";
            tbxEmployeeAddress.Text = "";
            tbxEmployeeCity.Text = "";
            tbxEmployeeZip.Text = "";
            tbxEmployeeEmail.Text = "";
        }

        //-----------------------------------------------------------------------------------------------------------

        //Contractor Functions---------------------------------------------------------------------------------------

        private void btnContractorSubmit_Click(object sender, EventArgs e)
        {
            int selectedContractor = dgvContractors.CurrentRow.Index;
            int ContractorID = (int)dgvContractors.Rows[selectedContractor].Cells[0].Value;


            if (cboContractorCategory.SelectedIndex > -1)
            {
                string selectedCategory = (string)cboContractorCategory.SelectedItem;

                if (tbxContractorInfoNew.Text != "" && tbxContractorInfoNew.Text != " ")
                {
                    string newInformation = tbxContractorInfoNew.Text;

                    OwnerProgOps.UpdateContractor(selectedCategory, newInformation, ContractorID);

                    MessageBox.Show("Successfully updated Contractor information with the new information entered.",
                        "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearContractorBoxes();

                    OwnerProgOps.ContractorCommand(dgvContractors);
                }
                else
                {
                    //Makes User Enter New Information before trying to submit
                    MessageBox.Show("You must enter new information before submitting any changes.",
                        "Error With Updating Contractor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Makes User Select a Category before trying to submit
                MessageBox.Show("Category must be selected before submitting any changes.",
                    "Error With Updating Contractor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnContractorCancel_Click(object sender, EventArgs e)
        {
            if (cboContractorCategory.SelectedIndex > -1 || tbxContractorInfoNew.Text != "")
            {
                DialogResult result =
                MessageBox.Show("Are you sure you want to cancel editing Contractor information?",
                "Cancel Contractor Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    //Clear New Contractor Information
                    clearContractorBoxes();
                }
            }
        }

        private void btnContractorDelete_Click(object sender, EventArgs e)
        {
            int selectedContractor = dgvContractors.CurrentRow.Index;
            int ContractorID = (int)dgvContractors.Rows[selectedContractor].Cells[0].Value;

            DialogResult result =
                MessageBox.Show("Are you sure you want to delete the selected Contractor?",
                "Delete Contractor", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                //Deletes Selected Contractor
                OwnerProgOps.DeleteContractor(ContractorID);

                MessageBox.Show("Successfully deleted the selected Contractor.",
                    "Delete Contractor Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OwnerProgOps.ContractorCommand(dgvContractors);
            }
        }

        private void btnAddNewContractor_Click(object sender, EventArgs e)
        {
            string Fname = tbxContractorFirstName.Text;
            string Lname = tbxContractorLastName.Text;
            string Address = tbxContractorAddress.Text;
            string City = tbxContractorCity.Text;
            string Zip = tbxContractorZip.Text;
            string Email = tbxContractorEmail.Text;
            string Phone = tbxContractorPhone.Text;

            if (Fname != "" && Fname != " ")
            {
                if (Lname != "" && Lname != " ")
                {
                    if (Email != "" && Email != " ")
                    {
                        if (Phone != "" && Phone != " ")
                        {
                            if (Address != "" && Address != " ")
                            {
                                if (City != "" && City != " ")
                                {
                                    if (Zip != "" && Zip != " ")
                                    {
                                        OwnerProgOps.AddContractor(Fname, Lname, Email, Phone, Address, City, Zip);

                                        MessageBox.Show("Successfully added a new Contractor.",
                                            "Adding Contractor Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                        clearContractorBoxes();

                                        OwnerProgOps.ContractorCommand(dgvContractors);
                                    }
                                    else
                                    {
                                        //Makes User Enter New Information before trying to submit
                                        MessageBox.Show("You must enter a Zip Code before submitting the new Contractor",
                                            "Error With Adding Contractor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    }
                                }
                                else
                                {
                                    //Makes User Enter New Information before trying to submit
                                    MessageBox.Show("You must enter a City before submitting the new Contractor",
                                        "Error With Adding Contractor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                //Makes User Enter New Information before trying to submit
                                MessageBox.Show("You must enter an Address before submitting the new Contractor",
                                    "Error With Adding Contractor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            //Makes User Enter New Information before trying to submit
                            MessageBox.Show("You must enter a Phone Number before submitting the new Contractor",
                                "Error With Adding Contractor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //Makes User Enter New Information before trying to submit
                        MessageBox.Show("You must enter an Email before submitting the new Contractor",
                            "Error With Adding Contractor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Makes User Enter New Information before trying to submit
                    MessageBox.Show("You must enter a Last Name before submitting the new Contractor",
                        "Error With Adding Contractor", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Makes User Enter New Information before trying to submit
                MessageBox.Show("You must enter a First Name before submitting the new Contractor",
                    "Error With Adding Contractor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelNewContractor_Click(object sender, EventArgs e)
        {
            clearContractorBoxes();
        }

        private void clearContractorBoxes()
        {
            cboContractorCategory.SelectedIndex = -1;
            cboContractorCategory.Text = "";
            tbxContractorInfoNew.Text = "";
            tbxContractorFirstName.Text = "";
            tbxContractorLastName.Text = "";
            tbxContractorAddress.Text = "";
            tbxContractorCity.Text = "";
            tbxContractorZip.Text = "";
            tbxContractorEmail.Text = "";
            tbxContractorPhone.Text = "";
        }

        //-----------------------------------------------------------------------------------------------------------

        //Customer Functions-----------------------------------------------------------------------------------------

        private void btnCustomerSubmit_Click(object sender, EventArgs e)
        {
            int selectedCustomer = dgvCustomers.CurrentRow.Index;
            int CustomerID = (int)dgvCustomers.Rows[selectedCustomer].Cells[0].Value;


            if (cboCustomerCategory.SelectedIndex > -1)
            {
                string selectedCategory = (string)cboCustomerCategory.SelectedItem;

                if (tbxCustomerInfoNew.Text != "" && tbxCustomerInfoNew.Text != " ")
                {
                    string newInformation = tbxCustomerInfoNew.Text;

                    OwnerProgOps.UpdateCustomer(selectedCategory, newInformation, CustomerID);

                    MessageBox.Show("Successfully updated Customer information with the new information entered.",
                        "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    clearCustomerBoxes();

                    OwnerProgOps.CustomerCommand(dgvCustomers);
                }
                else
                {
                    //Makes User Enter New Information before trying to submit
                    MessageBox.Show("You must enter new information before submitting any changes.",
                        "Error With Updating Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Makes User Select a Category before trying to submit
                MessageBox.Show("Category must be selected before submitting any changes.",
                    "Error With Updating Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCustomerCancel_Click(object sender, EventArgs e)
        {
            if (cboCustomerCategory.SelectedIndex > -1 || tbxCustomerInfoNew.Text != "")
            {
                DialogResult result =
                MessageBox.Show("Are you sure you want to cancel editing Customer information?",
                "Cancel Customer Information", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                if (result == DialogResult.Yes)
                {
                    //Clear New Customer Information
                    clearCustomerBoxes();
                }
            }
        }

        private void btnCustomerDelete_Click(object sender, EventArgs e)
        {
            int selectedCustomer = dgvCustomers.CurrentRow.Index;
            int CustomerID = (int)dgvCustomers.Rows[selectedCustomer].Cells[0].Value;

            DialogResult result =
                MessageBox.Show("Are you sure you want to delete the selected Customer?",
                "Delete Customer", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (result == DialogResult.Yes)
            {
                //Deletes Selected Customer
                OwnerProgOps.DeleteCustomer(CustomerID);

                MessageBox.Show("Successfully deleted the selected Customer.",
                    "Delete Customer Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                OwnerProgOps.CustomerCommand(dgvCustomers);
            }
        }

        private void btnAddNewCustomer_Click(object sender, EventArgs e)
        {
            string Fname = tbxCustomerFirstName.Text;
            string Lname = tbxCustomerLastName.Text;
            string Address = tbxCustomerAddress.Text;
            string City = tbxCustomerCity.Text;
            string Zip = tbxCustomerZip.Text;
            string Email = tbxCustomerEmail.Text;

            if (Fname != "" && Fname != " ")
            {
                if (Lname != "" && Lname != " ")
                {
                    if (Address != "" && Address != " ")
                    {
                        if (City != "" && City != " ")
                        {
                            if (Zip != "" && Zip != " ")
                            {
                                if (Email != "" && Email != " ")
                                {
                                    OwnerProgOps.AddCustomer(Fname, Lname, Address, Email, City, Zip);

                                    MessageBox.Show("Successfully added a new Customer.",
                                        "Adding Customer Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    clearCustomerBoxes();

                                    OwnerProgOps.CustomerCommand(dgvCustomers);
                                }
                                else
                                {
                                    //Makes User Enter New Information before trying to submit
                                    MessageBox.Show("You must enter an Email before submitting a new Customer",
                                        "Error With Adding Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                }
                            }
                            else
                            {
                                //Makes User Enter New Information before trying to submit
                                MessageBox.Show("You must enter a Zip Code before submitting a new Customer",
                                    "Error With Adding Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                        else
                        {
                            //Makes User Enter New Information before trying to submit
                            MessageBox.Show("You must enter a City before submitting a new Customer",
                                "Error With Adding Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    else
                    {
                        //Makes User Enter New Information before trying to submit
                        MessageBox.Show("You must enter an Address before submitting a new Customer",
                            "Error With Adding Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //Makes User Enter New Information before trying to submit
                    MessageBox.Show("You must enter a Last Name before submitting a new Customer",
                        "Error With Adding Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //Makes User Enter New Information before trying to submit
                MessageBox.Show("You must enter a First Name before submitting a new Customer",
                    "Error With Adding Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelNewCustomer_Click(object sender, EventArgs e)
        {
            clearCustomerBoxes();
        }

        private void clearCustomerBoxes()
        {
            cboCustomerCategory.SelectedIndex = -1;
            cboCustomerCategory.Text = "";
            tbxCustomerInfoNew.Text = "";
            tbxCustomerFirstName.Text = "";
            tbxCustomerLastName.Text = "";
            tbxCustomerAddress.Text = "";
            tbxCustomerCity.Text = "";
            tbxCustomerZip.Text = "";
            tbxCustomerEmail.Text = "";
        }

        //-----------------------------------------------------------------------------------------------------------
    }
}
