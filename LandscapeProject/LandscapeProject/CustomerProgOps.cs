using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace LandscapeProject
{
    class CustomerProgOps
    {
//Connection
        const string connectionString = "Server=cstnt.tstc.edu;Database=INEW2330fa20;User Id = group1fa202330; password=1524152";

//Customer
        public static SqlConnection cConnection = new SqlConnection(connectionString);
        public static SqlDataAdapter cAdapter = new SqlDataAdapter();
        public static SqlCommand cCommand;
        public static SqlCommandBuilder cCommBuilder = new SqlCommandBuilder();
        public static DataTable cCreateCustomerDT = new DataTable();
        public static DataTable cCreateCustomerCredDT = new DataTable();
        public static DataTable cJobSitesDT = new DataTable();
        public static DataTable cJobContactDT = new DataTable();
        public static void Open()
        {
            cConnection.Open();
        }

//Creates a customer directed from LoginScreen > LoginCreateUser
        public static void startCreateCustomer(TextBox uName, TextBox pWord, TextBox pWord_test, TextBox fName, TextBox lName, TextBox address, TextBox email, TextBox city, TextBox zipCode)
        {
            if (pWord.Text.Equals(pWord_test.Text))

            {//Create the Customers information
                int custID = 0;
                string name = fName.Text + " " + lName.Text;
                string[] customerRow = { custID.ToString(), fName.Text, lName.Text, address.Text, email.Text, city.Text, zipCode.Text };
                //get data
                cCommand = new SqlCommand("SELECT * FROM group1fa202330.Customers;", cConnection);
                cAdapter.SelectCommand = cCommand;
                cAdapter.Fill(cCreateCustomerDT);
                //add data
                cCreateCustomerDT.Rows.Add(customerRow);

                cCommBuilder = new SqlCommandBuilder(cAdapter);
                cCommBuilder.GetUpdateCommand();
                cAdapter.Update(cCreateCustomerDT);

                //Link Customers to CustomerLogin
                cCommand = new SqlCommand("SELECT CustomerID FROM group1fa202330.Customers WHERE FirstName + ' ' + LastName LIKE @Name ", cConnection);
                cCommand.Parameters.AddWithValue("@Name", name);
                cConnection.Open();
                custID = (int)cCommand.ExecuteScalar();
                if (custID > 0)
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
        public static void startCreateCustomerJob(int custID, int jobID, TextBox jobType, TextBox Address, DateTimePicker jobBegin, DateTimePicker jobEnd)
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
    }
}
