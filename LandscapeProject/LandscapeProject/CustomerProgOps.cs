﻿using System;
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
//Opens connection to db
        public static void Open()
        {
            try
            {
                //Checks to see if database is already open
                if (cConnection.State == ConnectionState.Open)
                {
                    cConnection.Close();
                }
                else
                {
                    //Opens Database
                    cConnection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error opening connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
//Creates a customer directed from LoginScreen > LoginCreateUser
        public static void startCreateCustomer(TextBox uName, TextBox pWord, TextBox pWord_test, TextBox fName, TextBox lName, TextBox address, TextBox email, TextBox city, TextBox zipCode)
        {
            try
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
                    {
                        //Create customers login credentials
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
                    {
                        MessageBox.Show("Error Results not found");
                    }
                }
                else
                {
                    MessageBox.Show("Passwords do not match try again!");
                }
                cCommand.Dispose();
                cAdapter.Dispose();
                cCommBuilder.Dispose();
                cCreateCustomerCredDT.Dispose();
                cCreateCustomerDT.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Creating Customer. Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }
        }
//Creates a job requests and sends to databse from UserMain
        public static void startCreateCustomerJob(int custID, string jobType, string Address, string jobBegin, string jobEnd)
        {
            try
            {
                int jobID;
                Open();
                cCommand = new SqlCommand("Insert Into group1fa202330.JobSites (JobType, Address, BeginDate, EndDate) Values" +
                    "('" + jobType + "','" + Address + "','" + jobBegin + "','" + jobEnd + "');", cConnection);
                cCommand.ExecuteNonQuery();
                cCommand.Dispose();

                cCommand = new SqlCommand("SELECT * FROM group1fa202330.JobSites Order By jobID DESC;", cConnection);
                jobID = (int)cCommand.ExecuteScalar();
                cCommand.Dispose();
                cCommand = new SqlCommand("Insert Into group1fa202330.CustomerJobs Values('" + custID.ToString() + "','" + jobID.ToString() +
                    "');", cConnection);
                cCommand.ExecuteNonQuery();
                cCommand.Dispose();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Creating Job. Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
//Loads a DGV based on the custID: Loads custoemr jobs depending on there login info
        public static void LoadJobView(DataGridView custJobInfo, int custID)
        {

            //clear out objects
            cCommand = null;
            cAdapter = new SqlDataAdapter();
            cJobSitesDT = new DataTable();

            try
            {

                //connect to dgv
                cCommand = new SqlCommand("SELECT group1fa202330.CustomerJobs.CustomerID, group1fa202330.JobSites.JobID, group1fa202330.JobSites.JobType," +
                    " group1fa202330.JobSites.Address, group1fa202330.JobSites.BeginDate, group1fa202330.JobSites.EndDate, group1fa202330.JobSites.Price" +
                    " FROM group1fa202330.JobSites LEFT JOIN group1fa202330.CustomerJobs ON group1fa202330.JobSites.JobID = group1fa202330.CustomerJobs.JobID" +
                    " WHERE group1fa202330.CustomerJobs.CustomerID " +
                    "LIKE @custID;", cConnection);//JOIN COMMAND to make new table
                cCommand.Parameters.AddWithValue("@custID", custID);
                cAdapter.SelectCommand = cCommand;
                cAdapter.Fill(cJobSitesDT);
                custJobInfo.DataSource = cJobSitesDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading Jobs. Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //dispose of data
            cCommand.Dispose();
            cAdapter.Dispose();
            cJobSitesDT.Dispose();
        }
        public static void LoadWorkerView(DataGridView custJobWorkerInfo, string jobID)
        {

            //clear out objects
            cCommand = null;
            cAdapter = new SqlDataAdapter();
            cJobSitesDT = new DataTable();

            try
            {

                //connect to dgv
                cCommand = new SqlCommand("SELECT group1fa202330.WorkerJobs.JobID, group1fa202330.Workers.FirstName, group1fa202330.Workers.LastName," +
                    " group1fa202330.Workers.Email FROM group1fa202330.Workers LEFT JOIN group1fa202330.WorkerJobs ON group1fa202330.Workers.WorkerID =" +
                    " group1fa202330.WorkerJobs.WorkerID WHERE group1fa202330.WorkerJobs.JobID " +
                    "LIKE @jobID;", cConnection);//JOIN COMMAND to make new table
                cCommand.Parameters.AddWithValue("@jobID", jobID);
                cAdapter.SelectCommand = cCommand;
                cAdapter.Fill(cJobSitesDT);
                custJobWorkerInfo.DataSource = cJobSitesDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error Loading Workers. Try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            //dispose of data
            cCommand.Dispose();
            cAdapter.Dispose();
            cJobSitesDT.Dispose();
        }

        //Close and dispose of database connections (customer)
        public static void CloseAllCust()
        {
            //wipe connection
            cConnection.Dispose();
            //close connection. 
            cConnection.Close();
        }
    }
}
