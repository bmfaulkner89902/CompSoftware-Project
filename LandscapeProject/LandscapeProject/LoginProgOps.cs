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
    class LoginProgOps
    {
//Connection
        const string connectionString = "Server=cstnt.tstc.edu;Database=INEW2330fa20;User Id = group1fa202330; password=1524152";
//Login
        public static SqlConnection logConnection = new SqlConnection(connectionString);
        public static SqlDataAdapter logAdapter = new SqlDataAdapter();
        public static DataTable logUserInfoDT = new DataTable();
        public static DataTable logEmpInfoDT = new DataTable();
        public static DataTable logOwnInfoDT = new DataTable();
        public static SqlCommand logCommand;
        public static SqlCommandBuilder logCommBuilder = new SqlCommandBuilder();

        public static void Open()
        {
            logConnection.Open();
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
