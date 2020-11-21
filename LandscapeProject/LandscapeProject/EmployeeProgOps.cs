using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms; 
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms.VisualStyles;

namespace LandscapeProject
{
    class EmployeeProgOps
    {
        private static string connect = @"Server=cstnt.tstc.edu;Database=INEW2330fa20;User Id=group1fa202330;password=1524152"; 
        private static SqlConnection empConnection = new SqlConnection(connect);
        public static SqlDataAdapter empAdapter = new SqlDataAdapter();
        public static DataTable empJobInfoDT = new DataTable();
        public static DataTable empTimeTableDt = new DataTable();
        public static DataTable empCustomersDT = new DataTable();
        //EMployeeJobMaterial 
        public static DataTable empCreateCustomerDT = new DataTable();
        public static DataTable empCreateJobDT = new DataTable();
        public static DataTable empAssignWorkersDT = new DataTable();
        public static DataTable empGetMaterialsDT = new DataTable();
        public static DataTable empWorkerIDDT = new DataTable();
        public static SqlCommand empCommand;
        public static SqlCommandBuilder empCommBuilder = new SqlCommandBuilder();
       
        public static void ScheduleSearch(string searchSchd, DataGridView dgvEmpWorkerSchd)
        {
            empTimeTableDt = new DataTable();
            string searchItem = searchSchd;
            //ID = term searched for, column = workerid/jobid. 
            if (searchItem == null || searchItem == "")
            {
                empCommand = new SqlCommand("SELECT group1fa202330.TimeTables.WorkerID, Clock_in, Clock_out FROM group1fa202330.TimeTables;", empConnection);
            }
            empCommand = new SqlCommand("SELECT group1fa202330.TimeTables.WorkerID, Clock_in, Clock_out FROM group1fa202330.TimeTables WHERE WorkerID = " + searchItem + " ORDER BY WorkerID; ", empConnection);
            empAdapter.SelectCommand = empCommand;
            empAdapter.Fill(empTimeTableDt);

            dgvEmpWorkerSchd.DataSource = empTimeTableDt;
        }
        public static void startCustomers(TextBox fName, TextBox lName, TextBox address, TextBox email, TextBox city, TextBox zipCode)
        {
            empCommand = new SqlCommand($"INSERT INTO group1fa202330.Customers(FirstName, LastName, Address, Email, City, ZipCode) VALUES('{fName.Text}', '{lName.Text}', '{address.Text}', '{email.Text}', '{city.Text}', '{zipCode.Text}');", empConnection);
            empAdapter.SelectCommand = empCommand;
            empCommand.ExecuteNonQuery();
        }
        public static void startJobs(TextBox ID, TextBox address, TextBox type, TextBox begin, TextBox end, TextBox size, TextBox price)
        {
            //cannot find column 0. maybe use startcustomers way. (INSERT INTO)
            empCreateJobDT = new DataTable();


            //get new jobID. 
            empCommand = new SqlCommand("Select JobId FROM group1fa202330.JobSites ORDER BY JobId DESC", empConnection);
            empCommand.ExecuteNonQuery();
            int jobId = (int)empCommand.ExecuteScalar() + 1;

            //fills table --- JobSites ---

            empCommand = new SqlCommand($"INSERT INTO group1fa202330.JobSites(JobType, Address, BeginDate, EndDate, Price, JobSize_In_Yards) VALUES ('{type.Text}', '{address.Text}', '{begin.Text}', '{end.Text}', '{price.Text}', '{size.Text}');", empConnection);
            //take info from text boxes + put into array 
            empAdapter = new SqlDataAdapter();
            empAdapter.SelectCommand = empCommand;
            //INCORRECT SYNTAX NEAR    ';'.'
            empCommand.ExecuteNonQuery();

            empCommand = new SqlCommand($"INSERT INTO group1fa202330.CustomerJobs(CustomerId, JobId) VALUES('{ID.Text}', '{jobId}')", empConnection);
            empAdapter = new SqlDataAdapter();
            empAdapter.SelectCommand = empCommand;
            empCommand.ExecuteNonQuery();


        }
        public static void startMaterials(TextBox Units, TextBox Type, TextBox price, TextBox date, TextBox jobId)
        {
            //take info from text boxes + put into array 
            empCommand = new SqlCommand("SELECT * FROM group1fa202330.Materials;", empConnection);
            empAdapter.SelectCommand = empCommand;
            empAdapter.Fill(empGetMaterialsDT);
            //add array into datatable. 
            DataRow materialRow = empGetMaterialsDT.NewRow();


            materialRow[1] = date.Text;
            materialRow[2] = Units.Text;
            materialRow[3] = Type.Text;
            materialRow[4] = price.Text;


            empGetMaterialsDT.Rows.Add(materialRow);

            empCommBuilder = new SqlCommandBuilder(empAdapter);
            empCommBuilder.GetUpdateCommand();
            empAdapter.Update(empGetMaterialsDT);

        }
        public static void assignMaterialsToJob(TextBoxBase JobId)
        {//get MaterialId & put into materialJobs. 
            //get materialId. 
            empCommand = new SqlCommand("SELECT MaterialID FROM group1fa202330.Materials ORDER BY MaterialID DESC;", empConnection);
            empCommand.ExecuteNonQuery();
            int materialId = (int)empCommand.ExecuteScalar();
            MessageBox.Show(materialId.ToString());
            //inserts jobid & materialId into jobMaterials. 
            empCommand = new SqlCommand($"INSERT INTO group1fa202330.JobMaterials(JobID, MaterialID) VALUES('{JobId.Text}', '{materialId}');", empConnection);
            empCommand.ExecuteNonQuery();


        }
        public static void startAssign(TextBox JobID, CheckedListBox workerIDs)
        {
            //get workerid/jobid. 
            foreach (object checkedItem in workerIDs.CheckedItems)
            {
                MessageBox.Show(checkedItem.ToString());
                empCommand = new SqlCommand($"INSERT INTO group1fa202330.WorkerJobs(WorkerID, JobId) VALUES('{checkedItem.ToString()}', '{JobID.Text}');", empConnection);
                empCommand.ExecuteNonQuery();
            }
        }
        //populates the datagrid for the "assign workers" tab from database. 
        public static void LoadCheckList(CheckedListBox workerIDs)
        {
            //get information to fill workerID checklist. . 
            empCommand = new SqlCommand("SELECT WorkerID FROM group1fa202330.Workers; ", empConnection);
            empAdapter.SelectCommand = empCommand;
            empWorkerIDDT = new DataTable();
            empAdapter.Fill(empWorkerIDDT);

            //fill the checklist with workerIDs. 

            for (int worker = 0; worker < empWorkerIDDT.Rows.Count; worker++)
            {
                workerIDs.Items.Add(empWorkerIDDT.Rows[worker][0].ToString());
            }
            //get workerJobs table 
            empCommand = new SqlCommand("SELECT * FROM group1fa202330.WorkerJobs; ", empConnection);
            empAdapter.SelectCommand = empCommand;
            empAssignWorkersDT = new DataTable();
            empAdapter.Fill(empAssignWorkersDT);
        }
        public static void CloseAll()
        {
            //close connection. 
            empConnection.Close();
            //dispose of all emp
            empJobInfoDT.Dispose();
            empCommand.Dispose();
            empConnection.Dispose();
            empAdapter.Dispose();
            empCommBuilder.Dispose();

        }
        //fix naming? 
        public static void mainLoad(DataGridView dgvEmpJobInfo, DataGridView dgvEmpWorkerSch)
        {
            //open connection 
            empConnection.Open(); 
            //get information to fill datagridview Job information . 
            empCommand = new SqlCommand("SELECT group1fa202330.JobSites.JobID, group1fa202330.Customers.FirstName, JobType, group1fa202330.Customers.Address, BeginDate, EndDate, Price FROM group1fa202330.Customers JOIN group1fa202330.CustomerJobs ON group1fa202330.Customers.CustomerID = CustomerJobs.CustomerID JOIN group1fa202330.JobSites ON group1fa202330.CustomerJobs.JobID = group1fa202330.JobSites.JobID ORDER BY BeginDate; ", empConnection);
            empAdapter.SelectCommand = empCommand;
            empAdapter.Fill(empJobInfoDT);

            //fill datagrid view. 
            dgvEmpJobInfo.DataSource = empJobInfoDT;

            //fill the worker schedule. 
            empCommand = new SqlCommand("SELECT group1fa202330.TimeTables.WorkerID, Clock_in, Clock_out FROM group1fa202330.TimeTables ORDER BY WorkerID, Clock_In; ", empConnection);
            empAdapter.SelectCommand = empCommand;
            empAdapter.Fill(empTimeTableDt);

            //fill datagrid view. 
            dgvEmpWorkerSch.DataSource = empTimeTableDt;
        }
        public static void empCustLoad(DataGridView dgvEmpCustomer)
        {
            //load datagridview - customerID, customerName, Address, Phone, email, Payment due.
            //get information to fill datagridview Job information . 
            EmployeeProgOps.empCommand = new SqlCommand("SELECT group1fa202330.Customers.CustomerID, FirstName + ' ' + LastName AS CustomerName, address, Email FROM group1fa202330.Customers; ", EmployeeProgOps.empConnection);
            EmployeeProgOps.empAdapter.SelectCommand = EmployeeProgOps.empCommand;
            EmployeeProgOps.empAdapter.Fill(EmployeeProgOps.empCustomersDT);

            //fill datagrid view. 
            dgvEmpCustomer.DataSource = EmployeeProgOps.empCustomersDT;
        }
        public static void empCustSearch(DataGridView dgvEmpCustomer, RadioButton rdoSearchName, RadioButton rdoSearchID, string custSearch)
        {
            EmployeeProgOps.empCustomersDT = new DataTable();
            if (custSearch == null || custSearch == "")//reset grid view. 
                EmployeeProgOps.empCommand = new SqlCommand("SELECT group1fa202330.Customers.CustomerID, FirstName + ' ' + LastName AS CustomerName, address, Email FROM group1fa202330.Customers;", EmployeeProgOps.empConnection);
            else if (rdoSearchName.Checked == true)//Name
                EmployeeProgOps.empCommand = new SqlCommand($"SELECT group1fa202330.Customers.CustomerID, FirstName + ' ' + LastName AS CustomerName, address, Email FROM group1fa202330.Customers WHERE FirstName LIKE '{custSearch}' OR LastName LIKE '{custSearch}'; ", EmployeeProgOps.empConnection);
            else if (rdoSearchID.Checked == true)//ID. 
                EmployeeProgOps.empCommand = new SqlCommand($"SELECT group1fa202330.Customers.CustomerID, FirstName + ' ' + LastName AS CustomerName, address, Email FROM group1fa202330.Customers WHERE CustomerID = '{Convert.ToInt32(custSearch)}'; ", EmployeeProgOps.empConnection);

            //fill datagrid view.
            EmployeeProgOps.empAdapter.SelectCommand = EmployeeProgOps.empCommand;
            EmployeeProgOps.empAdapter.Fill(EmployeeProgOps.empCustomersDT);
            dgvEmpCustomer.DataSource = EmployeeProgOps.empCustomersDT;
        }
    }
}

