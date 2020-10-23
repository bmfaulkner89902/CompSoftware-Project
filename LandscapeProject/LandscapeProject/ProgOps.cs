using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;

namespace LandscapeProject
{
    class ProgOps
    {
        const string connectionString = "Server=cstnt.tstc.edu;Database=INEW2330fa20;User Id = group1fa202330; password=1524152";
        public static SqlConnection empConnection = new SqlConnection(connectionString);
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
            empConnection.Open();
        }
        public static void startCustomers(TextBox fName, TextBox lName, TextBox address, TextBox email, TextBox city, TextBox zipCode, TextBox CustID)
        {
            string[] customerRow = { CustID.Text,fName.Text, lName.Text, address.Text, email.Text, city.Text, zipCode.Text};
            //take info from text boxes + put into array 
            empCommand = new SqlCommand("SELECT * FROM group1fa202330.Customers;",  empConnection);
             empAdapter.SelectCommand =  empCommand;
             empAdapter.Fill( empCreateCustomerDT);
            //add array into datatable. 
            empCreateCustomerDT.Rows.Add(customerRow); 

            empCommBuilder = new SqlCommandBuilder(empAdapter);
            empCommBuilder.GetUpdateCommand();
            empAdapter.Update(empCreateCustomerDT);

        }
        public static void startJobs(TextBox ID, TextBox address, TextBox type, TextBox begin, TextBox end, TextBox size, TextBox price )
        {
            //take info from text boxes + put into array 
            empCommand = new SqlCommand("SELECT * FROM group1fa202330.JobSites;", empConnection);
            empAdapter.SelectCommand = empCommand;
            empAdapter.Fill(empCreateJobDT);
            //add array into datatable. 
            DataRow jobRow = empCreateJobDT.NewRow();

            jobRow[0] = Convert.ToInt32(ID.Text);
            jobRow[1] = address.Text;
            jobRow[2] = type.Text;
            jobRow[3] = begin.Text;
            jobRow[4] = end.Text;
            jobRow[5] = Convert.ToInt32( price.Text);
            jobRow[6] = Convert.ToInt32(size.Text);

            empCreateJobDT.Rows.Add(jobRow); 

            empCommBuilder = new SqlCommandBuilder(empAdapter);
            empCommBuilder.GetUpdateCommand();
            empAdapter.Update(empCreateJobDT);

        }
        public static void startMaterials(TextBox materialID, TextBox Units, TextBox Type, TextBox price, TextBox date, TextBox jobId)
        {
            //take info from text boxes + put into array 
            empCommand = new SqlCommand("SELECT * FROM group1fa202330.Materials;", empConnection);
            empAdapter.SelectCommand = empCommand;
            empAdapter.Fill(empGetMaterialsDT);
            //add array into datatable. 
            DataRow materialRow = empGetMaterialsDT.NewRow();

            materialRow[0] = Convert.ToInt32(materialID.Text);
            materialRow[1] = date.Text;
            materialRow[2] = Units.Text;
            materialRow[3] = Type.Text;
            materialRow[4] = price.Text; 
            

            empGetMaterialsDT.Rows.Add(materialRow);

            empCommBuilder = new SqlCommandBuilder(empAdapter);
            empCommBuilder.GetUpdateCommand();
            empAdapter.Update(empGetMaterialsDT);

        }
        public static void assignMaterialsToJob(TextBox MaterialID,TextBoxBase JobId)
        {
            empCommand = new SqlCommand("SELECT * FROM group1fa202330.JobMaterials; ", empConnection);
            empAdapter.SelectCommand = empCommand;
            empAdapter.Fill(empGetMaterialsDT);

            DataRow materialRelations = empGetMaterialsDT.NewRow();
            materialRelations[0] = Convert.ToInt32(JobId.Text);
            materialRelations[1] = Convert.ToInt32( MaterialID.Text);

            empGetMaterialsDT.Rows.Add(materialRelations);
            empCommBuilder = new SqlCommandBuilder(empAdapter);
            empCommBuilder.GetUpdateCommand();
            empAdapter.Update(empGetMaterialsDT);
        }
        public static void startAssign(TextBox JobID, CheckedListBox workerIDs)
        {
           
            //take info from text boxes (jobid); 
            

            //add array into datatable. 
            //take info from text boxes (jobid); 
            empCommand = new SqlCommand("SELECT * FROM group1fa202330.WorkerJobs;", empConnection);
            empAdapter.SelectCommand = empCommand;
            empAdapter.Fill(empAssignWorkersDT);
            //add workerIds into datatable. 
            DataRow workerJobsRow = empAssignWorkersDT.NewRow();

            empCommand = new SqlCommand("SELECT WorkerID FROM group1fa202330.Workers;", empConnection);
            empAdapter.SelectCommand = empCommand;
            empAdapter.Fill(empWorkerIDDT);

            
            foreach (int indexChecked in workerIDs.CheckedIndices)
            {
                workerJobsRow[0] = empWorkerIDDT.Rows[0][indexChecked]; 
                workerJobsRow[1] = Convert.ToInt32(JobID.Text);
                MessageBox.Show(workerJobsRow[0].ToString()); 
            }
           

            empAssignWorkersDT.Rows.Add(workerJobsRow);

            empCommBuilder = new SqlCommandBuilder(empAdapter);
            empCommBuilder.GetUpdateCommand();
            empAdapter.Update(empAssignWorkersDT);




        }
        public static void LoadCheckList(CheckedListBox workerIDs)
        {
            //get information to fill workerID checklist. . 
            empCommand = new SqlCommand("SELECT WorkerID FROM group1fa202330.Workers; ", empConnection);
            empAdapter.SelectCommand = empCommand;
            empWorkerIDDT = new DataTable();
            empAdapter.Fill(empWorkerIDDT);

            workerIDs.DataBindings.Add("Text", empWorkerIDDT, "WorkerID");
            workerIDs.DataSource = empWorkerIDDT;
            workerIDs.DisplayMember = "WorkerID";

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
        

    }
}
