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
    class ProgOps
    {
        //Connection String
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database=INEW2330fa20;User Id=group1fa202330;password=1524152";
        //Build A Connection To MovieStore Tables In The Database
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
        //Add The Command Object
        private static SqlCommand _sqlLandscapeCommand;
        //Add The Data Adapter
        private static SqlDataAdapter _daLandscape = new SqlDataAdapter();
        //Add The Data Table
        private static DataTable _dtLandscape = new DataTable();


        public static void OpenDataBase()
        {
            //Method To Open Database And To Allow Use Of Data
            //Open The Connection To Database
            _cntDatabase.Open();
        }

        public static void CloseDataBase()
        {
            //Method To Close And Dispose Of Objects
            //Close The Database
            _cntDatabase.Close();
            //Dispose Of The Connection 
            _cntDatabase.Dispose();
        }
        public static SqlConnection empConnection = new SqlConnection(CONNECT_STRING); 
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
        public static void Open()
        {
            _cntDatabase.Open();
        }
        public static void startCustomers(TextBox fName, TextBox lName, TextBox address, TextBox email, TextBox city, TextBox zipCode)
        {
            empCommand = new SqlCommand($"INSERT INTO group1fa202330.Customers(FirstName, LastName, Address, Email, City, ZipCode) VALUES('{fName.Text}', '{lName.Text}', '{address.Text}', '{email.Text}', '{city.Text}', '{zipCode.Text}');", _cntDatabase); 
            empAdapter.SelectCommand = empCommand;
            empCommand.ExecuteNonQuery(); 
        }
        public static void startJobs(TextBox ID, TextBox address, TextBox type, TextBox begin, TextBox end, TextBox size, TextBox price)
        {
            //cannot find column 0. maybe use startcustomers way. (INSERT INTO)
            empCreateJobDT = new DataTable();


            //get new jobID. 
            empCommand = new SqlCommand("Select JobId FROM group1fa202330.JobSites ORDER BY JobId DESC", _cntDatabase);
            empCommand.ExecuteNonQuery(); 
            int jobId = (int)empCommand.ExecuteScalar() + 1;
         
            //fills table --- JobSites ---

            empCommand = new SqlCommand($"INSERT INTO group1fa202330.JobSites(JobType, Address, BeginDate, EndDate, Price, JobSize_In_Yards) VALUES ('{type.Text}', '{address.Text}', '{begin.Text}', '{end.Text}', '{price.Text}', '{size.Text}');", _cntDatabase);
            //take info from text boxes + put into array 
            empAdapter = new SqlDataAdapter(); 
            empAdapter.SelectCommand = empCommand;
            //INCORRECT SYNTAX NEAR    ';'.'
            empCommand.ExecuteNonQuery();

            empCommand = new SqlCommand($"INSERT INTO group1fa202330.CustomerJobs(CustomerId, JobId) VALUES('{ID.Text}', '{jobId}')", _cntDatabase);
            empAdapter = new SqlDataAdapter(); 
            empAdapter.SelectCommand = empCommand;
            empCommand.ExecuteNonQuery(); 
            

        }
        public static void startMaterials(TextBox Units, TextBox Type, TextBox price, TextBox date, TextBox jobId)
        {
            //take info from text boxes + put into array 
            empCommand = new SqlCommand("SELECT * FROM group1fa202330.Materials;", _cntDatabase);
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
            empCommand = new SqlCommand("SELECT MaterialID FROM group1fa202330.Materials ORDER BY MaterialID DESC;", _cntDatabase);
            empCommand.ExecuteNonQuery(); 
            int materialId =(int) empCommand.ExecuteScalar();
            MessageBox.Show(materialId.ToString()); 
            //inserts jobid & materialId into jobMaterials. 
            empCommand = new SqlCommand($"INSERT INTO group1fa202330.JobMaterials(JobID, MaterialID) VALUES('{JobId.Text}', '{materialId}');", _cntDatabase);
            empCommand.ExecuteNonQuery(); 


        }
        public static void startAssign(TextBox JobID, CheckedListBox workerIDs)
        {
            //get workerid/jobid. 
            foreach (object checkedItem in workerIDs.CheckedItems)
            {
                MessageBox.Show(checkedItem.ToString()); 
                empCommand = new SqlCommand($"INSERT INTO group1fa202330.WorkerJobs(WorkerID, JobId) VALUES('{checkedItem.ToString()}', '{JobID.Text}');", _cntDatabase);
                empCommand.ExecuteNonQuery(); 
            }
        }
        //populates the datagrid for the "assign workers" tab from database. 
        public static void LoadCheckList(CheckedListBox workerIDs)
        {
            //get information to fill workerID checklist. . 
            empCommand = new SqlCommand("SELECT WorkerID FROM group1fa202330.Workers; ", _cntDatabase);
            empAdapter.SelectCommand = empCommand;
            empWorkerIDDT = new DataTable();
            empAdapter.Fill(empWorkerIDDT);

            //fill the checklist with workerIDs. 

            for (int worker = 0; worker < empWorkerIDDT.Rows.Count; worker++)
            { 
                workerIDs.Items.Add(empWorkerIDDT.Rows[worker][0].ToString());
            }
            //get workerJobs table 
            empCommand = new SqlCommand("SELECT * FROM group1fa202330.WorkerJobs; ", _cntDatabase);
            empAdapter.SelectCommand = empCommand;
            empAssignWorkersDT = new DataTable();
            empAdapter.Fill(empAssignWorkersDT);
        }
        public static void CloseAll()
        {
            //close connection. 
            _cntDatabase.Close();
            //dispose of all emp
            empJobInfoDT.Dispose();
            empCommand.Dispose();
            _cntDatabase.Dispose();
            empAdapter.Dispose();
            empCommBuilder.Dispose();

        }
        //fix naming? 

    }
}
