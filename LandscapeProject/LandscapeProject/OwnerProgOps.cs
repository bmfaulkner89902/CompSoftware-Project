using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using LandscapeProject.Properties;
using System.Drawing;

namespace LandscapeProject
{
    class OwnerProgOps
    {
        //Connection String
        private const string CONNECT_STRING = "Server=cstnt.tstc.edu;Database=INEW2330fa20;User Id=group1fa202330;password=1524152";
        //Build A Connection To Landscape Tables In The Database
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
        //Add The Command Object
        private static SqlCommand _sqlLandscapeCommand;
        //Add The Data Adapters
        private static SqlDataAdapter _daLandscape = new SqlDataAdapter();
        //Add The Data Tables
        private static DataTable _dtLandscape = new DataTable();

        static bool isSQLSuccessful;

        public static void OpenDatabase()
        {
            try
            {
                //Checks to see if the database has troubles opening up
                if (_cntDatabase.State == ConnectionState.Open)
                {
                    _cntDatabase.Close();
                }
                else
                {
                    //Opens Database if everything is working
                    _cntDatabase.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Loading Database", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void CloseDatabase()
        {
            //Close Database
            _cntDatabase.Close();
            //Dispose of Connection
            _cntDatabase.Dispose();
        }

        //Job Commands------------------------------------------------------------------------------------------------
        public static void JobCommand(DataGridView dgvJobs)
        {
            //Set Command Objects To Null To Begin With
            _sqlLandscapeCommand = null;
            _daLandscape = new SqlDataAdapter();
            _dtLandscape = new DataTable();

            try
            {
                //Establish Command Objects
                _sqlLandscapeCommand = new SqlCommand("Select * From group1fa202330.JobSites;", _cntDatabase);
                //Establish Data Adapter
                _daLandscape.SelectCommand = _sqlLandscapeCommand;
                //Fill Data Table
                _daLandscape.Fill(_dtLandscape);
                //Bind DataGridView
                dgvJobs.DataSource = _dtLandscape;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Dispose Of Command, Adapter And Table Object
            _sqlLandscapeCommand.Dispose();
            _daLandscape.Dispose();
            _dtLandscape.Dispose();
        }

        public static bool AddJob(string JobType, string Address, string BeginDate, string EndDate, double Price, float JobSize)
        {
            try
            {
                if (EndDate == "" || EndDate == " ")
                {
                    //Method for adding new Jobs
                    SqlCommand cmd = new SqlCommand("Insert Into group1fa202330.JobSites " +
                        "Values('" + JobType + "','" + Address + "','" + BeginDate + "', NULL , " + Price + " , " + JobSize + ");", _cntDatabase);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                else
                {
                    //Method for adding new Jobs
                    SqlCommand cmd = new SqlCommand("Insert Into group1fa202330.JobSites " +
                        "Values('" + JobType + "','" + Address + "','" + BeginDate + "','" + EndDate + "', " + Price + " , " + JobSize + ");", _cntDatabase);
                    cmd.ExecuteNonQuery();
                    cmd.Dispose();
                }
                
                MessageBox.Show("Successfully added a new Job.",
                "Adding Job Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isSQLSuccessful = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Adding A Job", MessageBoxButtons.OK, MessageBoxIcon.Error);

                isSQLSuccessful = false;
            }
            return isSQLSuccessful;
        }

        public static bool UpdateJob(string Category, string newInfo, int jobID)
        {
            try
            {
                //Method for updating information of Jobs
                SqlCommand cmd = new SqlCommand("Update group1fa202330.JobSites set " + Category + "=@newInfo Where JobID=" + jobID + ";", _cntDatabase);
                cmd.Parameters.AddWithValue("@newInfo", newInfo);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Successfully updated Job information with the new information entered.",
                        "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isSQLSuccessful = true;             
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Updating Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                isSQLSuccessful = false;
            }
            return isSQLSuccessful;
        }

        public static void DeleteJob(int JobID)
        {
            try
            {
                //Deletes the Jobs From Contracted Jobs
                SqlCommand ContractorJobsCmd = new SqlCommand("Delete From group1fa202330.ContractedJobs Where JobID = " + JobID + ";", _cntDatabase);
                ContractorJobsCmd.ExecuteNonQuery();
                ContractorJobsCmd.Dispose();

                //Deletes the Jobs From Customer Jobs
                SqlCommand CustomerJobsCmd = new SqlCommand("Delete From group1fa202330.CustomerJobs Where JobID = " + JobID + ";", _cntDatabase);
                CustomerJobsCmd.ExecuteNonQuery();
                CustomerJobsCmd.Dispose();

                //Deletes the Jobs From Worker Jobs
                SqlCommand WorkerJobsCmd = new SqlCommand("Delete From group1fa202330.WorkerJobs Where JobID = " + JobID + ";", _cntDatabase);
                WorkerJobsCmd.ExecuteNonQuery();
                WorkerJobsCmd.Dispose();

                //Deletes the Jobs From Job Materials
                SqlCommand JobMaterialsCmd = new SqlCommand("Delete From group1fa202330.JobMaterials Where JobID = " + JobID + ";", _cntDatabase);
                JobMaterialsCmd.ExecuteNonQuery();
                JobMaterialsCmd.Dispose();

                //Method for Deleting the Job
                SqlCommand CustomerCmd = new SqlCommand("Delete From group1fa202330.JobSites Where JobID=" + JobID + ";", _cntDatabase);
                CustomerCmd.ExecuteNonQuery();
                CustomerCmd.Dispose();

                MessageBox.Show("Successfully deleted the selected Job.",
                    "Delete Job Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Deleting Job", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void EmployeeAndContractorJobs(ListBox lbxEmployees, ListBox lbxContractors, int JobID)
        {
            SqlDataReader employeeNames = null;
            
            try
            {
                lbxEmployees.Items.Clear();

                //Establish Command Objects
                _sqlLandscapeCommand = new SqlCommand("Select W.FirstName + ' ' + W.LastName as NAME From group1fa202330.Workers W" +
                    " Join group1fa202330.WorkerJobs WJ On W.WorkerID = WJ.WorkerID Join group1fa202330.JobSites " +
                    "JS On JS.JobID = WJ.JobID Where WJ.JobID = " + JobID + ";", _cntDatabase);
                

                employeeNames = _sqlLandscapeCommand.ExecuteReader();

                while (employeeNames.Read())
                {
                    lbxEmployees.Items.Add(employeeNames["NAME"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Dispose Of Command and Reader
            _sqlLandscapeCommand.Dispose();
            employeeNames.Close();


            SqlDataReader contractorNames = null;

            try
            {
                lbxContractors.Items.Clear();

                //Establish Command Objects
                _sqlLandscapeCommand = new SqlCommand("Select C.FirstName + ' ' + C.LastName as NAME From group1fa202330.Contractors C" +
                    " Join group1fa202330.ContractedJobs CJ On C.ContractorID = CJ.ContractorID Join group1fa202330.JobSites " +
                    "JS On JS.JobID = CJ.JobID Where CJ.JobID = " + JobID + ";", _cntDatabase);

                contractorNames = _sqlLandscapeCommand.ExecuteReader();

                while (contractorNames.Read())
                {
                    lbxContractors.Items.Add(contractorNames["NAME"]);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Dispose Of Command and Reader
            _sqlLandscapeCommand.Dispose();
            contractorNames.Close();           
        }

        public static void RemoveEmployeesFromJobs(string fullName, int jobID)
        {
            int employeeID;

            try
            {
                //Method for Removing Employees from Jobs
                SqlCommand employeeCmd = new SqlCommand("Select WorkerID From group1fa202330.Workers Where FirstName + ' ' + LastName like '" + fullName + "';", _cntDatabase);
                employeeID = (int)employeeCmd.ExecuteScalar();
                employeeCmd.Dispose();

                SqlCommand JobCmd = new SqlCommand("Delete From group1fa202330.WorkerJobs Where JobID = " + jobID + " and WorkerID = " + employeeID + ";", _cntDatabase);
                JobCmd.ExecuteNonQuery();
                JobCmd.Dispose();

                MessageBox.Show("Successfully removed selected employee from the selected job.",
                           "Remove Employee Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Removing Employee From Job", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void RemoveContractorsFromJobs(string fullName, int jobID)
        {
            int contractorID;

            try
            {
                //Method for Removing Contractors from Jobs
                SqlCommand contractorCmd = new SqlCommand("Select ContractorID From group1fa202330.Contractors Where FirstName + ' ' + LastName like '" + fullName + "';", _cntDatabase);
                contractorID = (int)contractorCmd.ExecuteScalar();
                contractorCmd.Dispose();

                SqlCommand JobCmd = new SqlCommand("Delete From group1fa202330.ContractedJobs Where JobID = " + jobID + " and ContractorID = " + contractorID + ";", _cntDatabase);
                JobCmd.ExecuteNonQuery();
                JobCmd.Dispose();

                MessageBox.Show("Successfully removed selected contractor from the selected job.",
                           "Remove Contractor Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Removing Contractor From Job", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void MaterialCommand(DataGridView dgvMaterials, int JobID)
        {
            //Set Command Objects To Null To Begin With
            _sqlLandscapeCommand = null;
            _daLandscape = new SqlDataAdapter();
            _dtLandscape = new DataTable();

            try
            {
                //Establish Command Objects
                _sqlLandscapeCommand = new SqlCommand("Select M.* From group1fa202330.Materials M Join group1fa202330.JobMaterials" +
                    " JM On M.MaterialID = JM.MaterialID Join group1fa202330.JobSites JS On JS.JobID = JM.JobID Where JM.JobID = " + JobID + ";", _cntDatabase);
                //Establish Data Adapter
                _daLandscape.SelectCommand = _sqlLandscapeCommand;
                //Fill Data Table
                _daLandscape.Fill(_dtLandscape);
                //Bind DataGridView
                dgvMaterials.DataSource = _dtLandscape;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Dispose Of Command, Adapter And Table Object
            _sqlLandscapeCommand.Dispose();
            _daLandscape.Dispose();
            _dtLandscape.Dispose();
        }

        public static bool AddMaterial(string MaterialType, string Date, double Price, float UnitsInYards, int JobID)
        {
            try
            {
                //Method for adding new materials
                SqlCommand cmd = new SqlCommand("Insert Into group1fa202330.Materials " +
                    "Values('" + Date + "'," + UnitsInYards + ",'" + MaterialType + "', " + Price + ");", _cntDatabase);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                //Method for connecting material to job
                int MaterialID;

                SqlCommand MaterialCmd = new SqlCommand("Select MaterialID from group1fa202330.Materials Order By 1 desc;", _cntDatabase);
                MaterialID = (int)MaterialCmd.ExecuteScalar();
                MessageBox.Show(MaterialID.ToString());
                MaterialCmd.Dispose();

                SqlCommand JobCmd = new SqlCommand("Insert Into group1fa202330.JobMaterials " +
                    "Values(" + JobID + ", " + MaterialID + ");", _cntDatabase);
                JobCmd.ExecuteNonQuery();
                JobCmd.Dispose();

                MessageBox.Show("Successfully added a new material to the job selected.",
                "Adding Material Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isSQLSuccessful = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Adding A Material", MessageBoxButtons.OK, MessageBoxIcon.Error);

                isSQLSuccessful = false;
            }
            return isSQLSuccessful;
        }

        public static bool UpdateMaterials(string Category, string newInfo, int materialID)
        {
            try
            {
                //Method for updating information of Materials
                SqlCommand cmd = new SqlCommand("Update group1fa202330.Materials set " + Category + "=@newInfo Where MaterialID=" + materialID + ";", _cntDatabase);
                cmd.Parameters.AddWithValue("@newInfo", newInfo);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Successfully updated material information with the new information entered.",
                "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isSQLSuccessful = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Updating Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                isSQLSuccessful = false;    
            }
            return isSQLSuccessful;
        }
        public static void DeleteMaterial(int materialID, int jobID)
        {
            try
            {
                //Method for Removing Materials from Jobs
                SqlCommand JobCmd = new SqlCommand("Delete From group1fa202330.JobMaterials Where JobID = " + jobID + " and MaterialID = " + materialID + ";", _cntDatabase);
                JobCmd.ExecuteNonQuery();
                JobCmd.Dispose();

                //Method for Deleting Materials
                SqlCommand materialCmd = new SqlCommand("Delete From group1fa202330.Materials Where MaterialID=" + materialID + ";", _cntDatabase);
                materialCmd.ExecuteNonQuery();
                materialCmd.Dispose();

                MessageBox.Show("Successfully deleted the selected material.",
                    "Delete Material Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Deleting Material", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //------------------------------------------------------------------------------------------------------------

        //Customer Commands-------------------------------------------------------------------------------------------
        public static void CustomerCommand(DataGridView dgvCustomers)
        {
            //Set Command Objects To Null To Begin With
            _sqlLandscapeCommand = null;
            _daLandscape = new SqlDataAdapter();
            _dtLandscape = new DataTable();

            try
            {
                //Establish Command Objects
                _sqlLandscapeCommand = new SqlCommand("Select * From group1fa202330.Customers;", _cntDatabase);
                //Establish Data Adapter
                _daLandscape.SelectCommand = _sqlLandscapeCommand;
                //Fill Data Table
                _daLandscape.Fill(_dtLandscape);
                //Bind DataGridView
                dgvCustomers.DataSource = _dtLandscape;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Dispose Of Command, Adapter And Table Object
            _sqlLandscapeCommand.Dispose();
            _daLandscape.Dispose();
            _dtLandscape.Dispose();
        }

        public static bool UpdateCustomer(string Category, string newInfo, int cusID)
        {
            try
            {
                //Method for updating information of Customers
                SqlCommand cmd = new SqlCommand("Update group1fa202330.Customers set " + Category + "=@newInfo Where CustomerID=" + cusID + ";", _cntDatabase);
                cmd.Parameters.AddWithValue("@newInfo", newInfo);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Successfully updated Customer information with the new information entered.",
                        "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isSQLSuccessful = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Updating Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                isSQLSuccessful = false;    
            }
            return isSQLSuccessful;
        }

        public static bool AddCustomer(string FirstName, string LastName, string Address, string Email, string City, string ZipCode)
        {
            try
            {
                //Method for adding new employees
                SqlCommand cmd = new SqlCommand("Insert Into group1fa202330.Customers " +
                    "Values('" + FirstName + "','" + LastName + "','" + Address + "','" + Email + "','" + City + "','" + ZipCode + "');", _cntDatabase);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Successfully added a new Customer.",
                    "Adding Customer Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isSQLSuccessful = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Updating Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                isSQLSuccessful = false;
            }
            return isSQLSuccessful;
        }

        public static void DeleteCustomer(int CustomerID)
        {
            try
            {
                SqlCommand JobCmd = new SqlCommand("Delete From group1fa202330.CustomerJobs Where CustomerID = " + CustomerID + ";", _cntDatabase);
                JobCmd.ExecuteNonQuery();
                JobCmd.Dispose();

                //Method for Deleting a Customer
                SqlCommand CustomerCmd = new SqlCommand("Delete From group1fa202330.Customers Where CustomerID=" + CustomerID + ";", _cntDatabase);
                CustomerCmd.ExecuteNonQuery();
                CustomerCmd.Dispose();

                MessageBox.Show("Successfully deleted the selected Customer.",
                    "Delete Customer Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Deleting Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //------------------------------------------------------------------------------------------------------------

        //Contractor Commands-----------------------------------------------------------------------------------------
        public static void ContractorCommand(DataGridView dgvContractors)
        {
            //Set Command Objects To Null To Begin With
            _sqlLandscapeCommand = null;
            _daLandscape = new SqlDataAdapter();
            _dtLandscape = new DataTable();

            try
            {
                //Establish Command Objects
                _sqlLandscapeCommand = new SqlCommand("Select * From group1fa202330.Contractors;", _cntDatabase);
                //Establish Data Adapter
                _daLandscape.SelectCommand = _sqlLandscapeCommand;
                //Fill Data Table
                _daLandscape.Fill(_dtLandscape);
                //Bind DataGridView
                dgvContractors.DataSource = _dtLandscape;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Dispose Of Command, Adapter And Table Object
            _sqlLandscapeCommand.Dispose();
            _daLandscape.Dispose();
            _dtLandscape.Dispose();
        }

        public static bool UpdateContractor(string Category, string newInfo, int conID)
        {
            try
            {
                //Method for updating information of contractors
                SqlCommand cmd = new SqlCommand("Update group1fa202330.Contractors set " + Category + "=@newInfo Where ContractorID=" + conID + ";", _cntDatabase);
                cmd.Parameters.AddWithValue("@newInfo", newInfo);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Successfully updated Contractor information with the new information entered.",
                        "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isSQLSuccessful = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Updating Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                isSQLSuccessful = false;
            }
            return isSQLSuccessful;
        }

        public static bool AddContractor(string FirstName, string LastName, string Email, string Phone, string Address, string City, string ZipCode)
        {
            try
            {
                //Method for adding new employees
                SqlCommand cmd = new SqlCommand("Insert Into group1fa202330.Contractors " +
                    "Values('" + FirstName + "','" + LastName + "','" + Email + "','" + Phone + "','" + Address + "','" + City + "','" + ZipCode + "');", _cntDatabase);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Successfully added a new Contractor.",
                     "Adding Contractor Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isSQLSuccessful = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Updating Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                isSQLSuccessful = false;
            }
            return isSQLSuccessful;
        }

        public static void DeleteContractor(int ContractorID)
        {
            try
            {

                SqlCommand JobCmd = new SqlCommand("Delete From group1fa202330.ContractedJobs Where ContractorID = " + ContractorID + ";", _cntDatabase);
                JobCmd.ExecuteNonQuery();
                JobCmd.Dispose();

                //Method for Deleting a Contractor
                SqlCommand ContractorCmd = new SqlCommand("Delete From group1fa202330.Contractors Where ContractorID=" + ContractorID + ";", _cntDatabase);
                ContractorCmd.ExecuteNonQuery();
                ContractorCmd.Dispose();

                MessageBox.Show("Successfully deleted the selected Contractor.",
                    "Delete Contractor Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Deleting Contractor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //------------------------------------------------------------------------------------------------------------

        //Employee Commands-------------------------------------------------------------------------------------------
        public static void EmployeesCommand(DataGridView dgvEmployees)
        {
            //Set Command Objects To Null To Begin With
            _sqlLandscapeCommand = null;
            _daLandscape = new SqlDataAdapter();
            _dtLandscape = new DataTable();

            try
            {
                //Establish Command Objects
                _sqlLandscapeCommand = new SqlCommand("Select * From group1fa202330.Workers;", _cntDatabase);
                //Establish Data Adapter
                _daLandscape.SelectCommand = _sqlLandscapeCommand;
                //Fill Data Table
                _daLandscape.Fill(_dtLandscape);
                //Bind DataGridView
                dgvEmployees.DataSource = _dtLandscape;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In SQL", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //Dispose Of Command, Adapter And Table Object
            _sqlLandscapeCommand.Dispose();
            _daLandscape.Dispose();
            _dtLandscape.Dispose();
        }

        public static bool UpdateEmployee(string Category, string newInfo, int empID)
        {
            try
            {
                //Method for updating information of employees
                SqlCommand cmd = new SqlCommand("Update group1fa202330.Workers set " + Category + "=@newInfo Where WorkerID=" + empID + ";", _cntDatabase);
                cmd.Parameters.AddWithValue("@newInfo", newInfo);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Successfully updated employee information with the new information entered.",
                        "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isSQLSuccessful = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Updating Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                isSQLSuccessful = false;
            }
            return isSQLSuccessful;
        }
        
        public static bool AddEmployee(string FirstName, string LastName, string Address, string Email, string City, string ZipCode)
        {
            try
            {
                //Method for adding new employees
                SqlCommand cmd = new SqlCommand("Insert Into group1fa202330.Workers " +
                    "Values('"+ FirstName +"','"+ LastName +"','"+ Address +"','"+ Email +"','"+ City +"','"+ ZipCode +"');", _cntDatabase);
                cmd.ExecuteNonQuery();
                cmd.Dispose();

                MessageBox.Show("Successfully added a new employee.",
                "Adding Employee Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                isSQLSuccessful = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Updating Information", MessageBoxButtons.OK, MessageBoxIcon.Error);

                isSQLSuccessful = false;
            }
            return isSQLSuccessful;
        }

        public static void DeleteEmployee(int EmployeeID)
        {
            try
            {

                SqlCommand JobCmd = new SqlCommand("Delete From group1fa202330.WorkerJobs Where WorkerID = " + EmployeeID + ";", _cntDatabase);
                JobCmd.ExecuteNonQuery();
                JobCmd.Dispose();

                //Method for Deleting an Employee
                SqlCommand EmployeeCmd = new SqlCommand("Delete From group1fa202330.Workers Where WorkerID="+ EmployeeID +";", _cntDatabase);
                EmployeeCmd.ExecuteNonQuery();
                EmployeeCmd.Dispose();

                MessageBox.Show("Successfully deleted the selected employee.",
                    "Delete Employee Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Deleting Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //------------------------------------------------------------------------------------------------------------
    }
}
