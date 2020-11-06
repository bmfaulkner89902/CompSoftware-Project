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
using System.Security.Cryptography.X509Certificates;

namespace LandscapeProject
{
    class ProgOps
    {
        const string connectionString = "Server=cstnt.tstc.edu;Database=INEW2330fa20;User Id = group1fa202330; password=1524152";
        //Customer
        public static SqlConnection cConnection = new SqlConnection(connectionString);
        public static SqlDataAdapter cAdapter = new SqlDataAdapter();
        public static SqlCommand cCommand;
        public static SqlCommandBuilder cCommBuilder = new SqlCommandBuilder();
        public static DataTable cCreateCustomerCredDT = new DataTable();
        public static DataTable cJobSitesDT = new DataTable();
        public static DataTable cJobContactDT = new DataTable();



        //Login
        public static SqlConnection logConnection = new SqlConnection(connectionString);
        public static SqlDataAdapter logAdapter = new SqlDataAdapter();
        public static DataTable logUserInfoDT = new DataTable();
        public static DataTable logEmpInfoDT = new DataTable();
        public static DataTable logOwnInfoDT = new DataTable();
        public static SqlCommand logCommand;
        public static SqlCommandBuilder logCommBuilder = new SqlCommandBuilder();

        //Employee
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
            materialRelations[1] =Convert.ToInt32( MaterialID.Text);

            empGetMaterialsDT.Rows.Add(materialRelations);
            empCommBuilder = new SqlCommandBuilder(empAdapter);
            empCommBuilder.GetUpdateCommand();
            empAdapter.Update(empGetMaterialsDT);
        }
        public static void startAssign(TextBox JobID, CheckedListBox workerIDs)
        {
            //take info from text boxes 
            empCommand = new SqlCommand("SELECT * FROM group1fa202330.WorkerJobs;", empConnection);
            empAdapter.SelectCommand = empCommand;
            empAdapter.Fill(empAssignWorkersDT);
            //add array into datatable. 
            DataRow workerJobsRow = empAssignWorkersDT.NewRow();

            for (int i = 0; i < workerIDs.CheckedItems.Count; i++)
            {
                workerJobsRow[1] = Convert.ToInt32(workerIDs.CheckedItems[i].ToString());
                workerJobsRow[0] = Convert.ToInt32(JobID.Text);
            }
           

            empAssignWorkersDT.Rows.Add(workerJobsRow);

            empCommBuilder = new SqlCommandBuilder(empAdapter);
            empCommBuilder.GetUpdateCommand();
            empAdapter.Update(empAssignWorkersDT);


            
            
        }
        public static void CloseAll()
        {
            //close connection. 
            empConnection.Close();
            //dispose of all emp
            empConnection.Dispose();
            empAdapter.Dispose();
            empCommBuilder.Dispose();
            empJobInfoDT.Dispose();
            empCommand.Dispose();


        }
        //Creates a customer directed from LoginScreen > LoginCreateUser
        public static void startCreateCustomer(TextBox uName, TextBox pWord, TextBox pWord_test, TextBox fName, TextBox lName, TextBox address, TextBox email, TextBox city, TextBox zipCode)
        {
            if (pWord.Text.Equals(pWord_test.Text))

            {//Create the Customers information
                int custID = 0;
                string name = fName.Text + " " + lName.Text;
                string[] customerRow = {custID.ToString(), fName.Text, lName.Text, address.Text, email.Text, city.Text, zipCode.Text };
                //get data
                cCommand = new SqlCommand("SELECT * FROM group1fa202330.Customers;", cConnection);
                cAdapter.SelectCommand = cCommand;
                cAdapter.Fill(empCreateCustomerDT);
                //add data
                empCreateCustomerDT.Rows.Add(customerRow);

                cCommBuilder = new SqlCommandBuilder(cAdapter);
                cCommBuilder.GetUpdateCommand();
                cAdapter.Update(empCreateCustomerDT);

                //Link Customers to CustomerLogin
                cCommand = new SqlCommand("SELECT CustomerID FROM group1fa202330.Customers WHERE FirstName + ' ' + LastName LIKE @Name ", cConnection);
                cCommand.Parameters.AddWithValue("@Name", name);
                cConnection.Open();
                custID = (int)cCommand.ExecuteScalar();
                if (custID>0)
                { //Create customers login credentials
                    string[] customerCredentials = { uName.Text, pWord.Text, custID.ToString() };
                    //get data
                    cCommand = new SqlCommand("SELECT * FROM group1fa202330.CustomerLogin;", cConnection);
                    cAdapter.SelectCommand = cCommand;
                    cAdapter.Fill(cCreateCustomerCredDT);
                    //add data 
                    cCreateCustomerCredDT.Rows.Add(customerCredentials);
                    cCommBuilder = new SqlCommandBuilder(cAdapter);
                    cCommBuilder.GetUpdateCommand();
                    cAdapter.Update(cCreateCustomerCredDT);
                }
             else
               MessageBox.Show("Error Results not found");

            }
            else
                MessageBox.Show("Passwords do not match try again!");
        }
//Creates a job requests and sends to databse from UserMain
        public static void startCreateCustomerJob(int jobID ,TextBox jobType, TextBox Address, DateTimePicker jobBegin, DateTimePicker jobEnd)
        {
            //get data
            cCommand = new SqlCommand("SELECT * FROM group1fa202330.JobSites;", cConnection);
            cAdapter.SelectCommand = cCommand;
            cAdapter.Fill(cJobSitesDT);
            //add data
            cJobSitesDT.Rows.Add(new string[] { jobID.ToString(), jobType.Text, Address.Text, jobBegin.Value.Date.Date.ToString(), jobBegin.Value.Date.ToString() });

            cCommBuilder = new SqlCommandBuilder(cAdapter);
            cCommBuilder.GetUpdateCommand();
            cAdapter.Update(cJobSitesDT);


        }
//Customer login code
        public static void startCustLogin(TextBox username, TextBox password)
        {
            int custID;
            //get data
            logCommand = new SqlCommand("SELECT CustomerID, Username, Password FROM group1fa202330.CustomerLogin WHERE UserName=@UserName and Password =@Password;", logConnection);
            logCommand.Parameters.AddWithValue("@UserName", username.Text);
            logCommand.Parameters.AddWithValue("@Password", password.Text);
            logAdapter.SelectCommand = logCommand;
            logAdapter.Fill(logUserInfoDT);
            logConnection.Open();
            int i = logCommand.ExecuteNonQuery();
            custID = (int)logCommand.ExecuteScalar();
            logConnection.Close();
            if (logUserInfoDT.Rows.Count > 0)//redirects to next page
            {
                MessageBox.Show("Access Granted User: " + username.Text + " ID#: " + custID);
                LoginScreen form1 = new LoginScreen();
                UserMain form2 = new UserMain();
                form2.cust = username.Text;
                form2.custID = custID;
                form1.Hide();
                form2.Show();
            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");
            }
        }
//Employee login code
        public static void startEmpLogin(TextBox username, TextBox password)
        {
            //get data
            logCommand = new SqlCommand("SELECT * FROM group1fa202330.WorkerLogin where UserName=@UserName and Password =@Password", logConnection);
            logCommand.Parameters.AddWithValue("@UserName", username.Text);
            logCommand.Parameters.AddWithValue("@Password", password.Text);
            logAdapter.SelectCommand = logCommand;
            logAdapter.Fill(logEmpInfoDT);
            logConnection.Open();
            int i = logCommand.ExecuteNonQuery();
            logConnection.Close();
            if (logEmpInfoDT.Rows.Count > 0)//redirects to next page
            {
                MessageBox.Show("Access Granted");
                LoginScreen form1 = new LoginScreen();
                EmployeeMain form2 = new EmployeeMain();
                //form2.user = username.Text;
                //form2.pass = password.Text;
                form1.Hide();
                form2.Show();

            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");

            }
        }

//Owner login code
        public static void startOwnLogin(TextBox username, TextBox password)
        {
            
            //get data
            logCommand = new SqlCommand("SELECT * FROM group1fa202330.WorkerLogin where UserName=@UserName and Password =@Password", logConnection);
            logCommand.Parameters.AddWithValue("@UserName", username.Text);
            logCommand.Parameters.AddWithValue("@Password", password.Text);
            logAdapter.SelectCommand = logCommand;
            logAdapter.Fill(logOwnInfoDT);
            logConnection.Open();
            int i = logCommand.ExecuteNonQuery();
            logConnection.Close();
            if (logOwnInfoDT.Rows.Count > 0)//redirects to next page
            {
                MessageBox.Show("Access Granted");
                LoginScreen form1 = new LoginScreen();
                OwnerMain form2 = new OwnerMain();
                //form2.user = username.Text;
                //form2.pass = password.Text;

                form1.Hide();
                form2.Show();

            }
            else
            {
                MessageBox.Show("Please enter Correct Username and Password");

            }
        }

//Close and dispose of database connections (customer)
        public static void CloseAllCust()
        {
            //wipe connection
            cConnection.Dispose();
            //close connection. 
            cConnection.Close();
            //dispose of all c
            
            cAdapter.Dispose();
            cCommBuilder.Dispose();
            cCommand.Dispose();
            cCreateCustomerCredDT.Dispose();

        }
//Close and dispose of database connections (login portal)
        public static void CloseAllLog()
        {
            //wipe connection
            logConnection.Dispose();
            //close connection. 
            logConnection.Close();
            //dispose of all log
            logAdapter.Dispose();
            logCommBuilder.Dispose();
            logCommand.Dispose();
           
            logEmpInfoDT.Dispose();
            logOwnInfoDT.Dispose();
            logUserInfoDT.Dispose();

        }





    }
}
