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

        public static void OpenDatabase()
        {
            //Open Connection to Database
            _cntDatabase.Open();
        }

        public static void CloseDatabase()
        {
            //Close Database
            _cntDatabase.Close();
            //Dispose of Connection
            _cntDatabase.Dispose();
        }

        public static void JobCommand(DataGridView dgvJobs, DataGridView dgvMaterials)
        {
            //Job Sites Table--------------------------------------------------------------------------------
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
            //-----------------------------------------------------------------------------------------------

            //Materials Table--------------------------------------------------------------------------------
            //Set Command Objects To Null To Begin With
            _sqlLandscapeCommand = null;
            _daLandscape = new SqlDataAdapter();
            _dtLandscape = new DataTable();

            try
            {
                //Establish Command Objects
                _sqlLandscapeCommand = new SqlCommand("Select * From group1fa202330.Materials;", _cntDatabase);
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
            //-----------------------------------------------------------------------------------------------
        }



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

        public static void UpdateCustomer(string Category, string newInfo, int cusID)
        {
            try
            {
                //Method for updating information of Customers
                SqlCommand cmd = new SqlCommand("Update group1fa202330.Customers set " + Category + "=@newInfo Where CustomerID=@cusID;", _cntDatabase);
                cmd.Parameters.AddWithValue("@newInfo", newInfo);
                cmd.Parameters.AddWithValue("@cusID", cusID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Updating Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AddCustomer(string FirstName, string LastName, string Address, string Email, string City, string ZipCode)
        {
            try
            {
                //Method for adding new employees
                SqlCommand cmd = new SqlCommand("Insert Into group1fa202330.Customers " +
                    "Values('" + FirstName + "','" + LastName + "','" + Address + "','" + Email + "','" + City + "','" + ZipCode + "');", _cntDatabase);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Updating Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteCustomer(int CustomerID)
        {
            try
            {
                //Method for Deleting a Customer
                SqlCommand cmd = new SqlCommand("Delete From group1fa202330.Customers Where CustomerID=" + CustomerID + ";", _cntDatabase);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Deleting Customer", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



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

        public static void UpdateContractor(string Category, string newInfo, int conID)
        {
            try
            {
                //Method for updating information of contractors
                SqlCommand cmd = new SqlCommand("Update group1fa202330.Contractors set " + Category + "=@newInfo Where ContractorID=@conID;", _cntDatabase);
                cmd.Parameters.AddWithValue("@newInfo", newInfo);
                cmd.Parameters.AddWithValue("@conID", conID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Updating Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void AddContractor(string FirstName, string LastName, string Email, string Phone, string Address, string City, string ZipCode)
        {
            try
            {
                //Method for adding new employees
                SqlCommand cmd = new SqlCommand("Insert Into group1fa202330.Contractors " +
                    "Values('" + FirstName + "','" + LastName + "','" + Email + "','" + Phone + "','" + Address + "','" + City + "','" + ZipCode + "');", _cntDatabase);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Updating Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteContractor(int ContractorID)
        {
            try
            {
                //Method for Deleting a Contractor
                SqlCommand cmd = new SqlCommand("Delete From group1fa202330.Contractors Where ContractorID=" + ContractorID + ";", _cntDatabase);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Deleting Contractor", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



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

        public static void UpdateEmployee(string Category, string newInfo, int empID)
        {
            try
            {
                //Method for updating information of employees
                SqlCommand cmd = new SqlCommand("Update group1fa202330.Workers set " + Category + "=@newInfo Where WorkerID=@empID;", _cntDatabase);
                cmd.Parameters.AddWithValue("@newInfo", newInfo);
                cmd.Parameters.AddWithValue("@empID", empID);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Updating Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }          
        }
        
        public static void AddEmployee(string FirstName, string LastName, string Address, string Email, string City, string ZipCode)
        {
            try
            {
                //Method for adding new employees
                SqlCommand cmd = new SqlCommand("Insert Into group1fa202330.Workers " +
                    "Values('"+ FirstName +"','"+ LastName +"','"+ Address +"','"+ Email +"','"+ City +"','"+ ZipCode +"');", _cntDatabase);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Updating Information", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static void DeleteEmployee(int EmployeeID)
        {
            try
            {
                //Method for Deleting an Employee
                SqlCommand cmd = new SqlCommand("Delete From group1fa202330.Workers Where WorkerID="+ EmployeeID +";", _cntDatabase);
                cmd.ExecuteNonQuery();
                cmd.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Deleting Employee", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
      
    }
}
