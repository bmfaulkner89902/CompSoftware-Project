using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

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
//open connection
        public static void Open()
        {
            try
            {
                //Checks to see if database is already open
                if (logConnection.State == ConnectionState.Open)
                {
                    logConnection.Close();
                }
                else
                {
                    //Opens Database
                    logConnection.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Opening Connection", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
//Customer login code
        public static void startCustLogin(TextBox username, TextBox password)
        {
            try
            {
                int custID;
                //get data
                logCommand = new SqlCommand("SELECT CustomerID, Username, Password FROM group1fa202330.CustomerLogin WHERE UserName=@UserName" +
                    " and Password =@Password;", logConnection);
                logCommand.Parameters.AddWithValue("@UserName", username.Text);
                logCommand.Parameters.AddWithValue("@Password", password.Text);
                logAdapter.SelectCommand = logCommand;
                logAdapter.Fill(logUserInfoDT);
                int i = logCommand.ExecuteNonQuery();                
                if (logUserInfoDT.Rows.Count > 0)//redirects to next page
                {
                    custID = (int)logCommand.ExecuteScalar();
                    MessageBox.Show("Access Granted User: " + username.Text + " ID#: " + custID);
                    UserMain form2 = new UserMain();
                    form2.cust = username.Text;
                    form2.custID = custID;
                    form2.Text = "LandscaperZ - " + form2.cust;
                    form2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please enter Correct Username and Password");
                }
                logAdapter.Dispose();
                logCommand.Dispose();
                logUserInfoDT.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Logging In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
//Employee login code
        public static void startEmpLogin(TextBox username, TextBox password)
        {
            try
            {
                //get data
                logCommand = new SqlCommand("SELECT * FROM group1fa202330.WorkerLogin where UserName=@UserName and Password =@Password and Position = 'Employee';", logConnection);
                logCommand.Parameters.AddWithValue("@UserName", username.Text);
                logCommand.Parameters.AddWithValue("@Password", password.Text);
                logAdapter.SelectCommand = logCommand;
                logAdapter.Fill(logEmpInfoDT);
                int i = logCommand.ExecuteNonQuery();
                if (logEmpInfoDT.Rows.Count > 0)//redirects to next page
                {
                    MessageBox.Show("Access Granted");
                    EmployeeMain form2 = new EmployeeMain();
                    form2.Text = "LandscaperZ - " + username.Text;
                    form2.ShowDialog();

                }
                else
                {
                    MessageBox.Show("Please enter Correct Username and Password");

                }
                logAdapter.Dispose();
                logCommand.Dispose();
                logEmpInfoDT.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Logging In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

//Owner login code
        public static void startOwnLogin(TextBox username, TextBox password)
        {
            try
            {
                //get data
                logCommand = new SqlCommand("SELECT * FROM group1fa202330.WorkerLogin where UserName=@UserName and Password =@Password and Position = 'Owner';", logConnection);
                logCommand.Parameters.AddWithValue("@UserName", username.Text);
                logCommand.Parameters.AddWithValue("@Password", password.Text);
                logAdapter.SelectCommand = logCommand;
                logAdapter.Fill(logOwnInfoDT);
                int i = logCommand.ExecuteNonQuery();
                if (logOwnInfoDT.Rows.Count > 0)//redirects to next page
                {
                    MessageBox.Show("Access Granted");
                    OwnerMain form2 = new OwnerMain();
                    form2.Text = "LandscaperZ - " + username.Text;
                    form2.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please enter Correct Username and Password");

                }
                logAdapter.Dispose();
                logCommand.Dispose();
                logOwnInfoDT.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Logging In", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
//Takes Custoemr email finds username and password
        public static void custAccountRecovery(string custEmail)
        {
            try
            {
                custEmail.Trim();
                string username;
                string password;
                //uses email to find login
                logCommand = new SqlCommand("SELECT group1fa202330.CustomerLogin.Username FROM group1fa202330.CustomerLogin JOIN" +
                    " group1fa202330.Customers ON group1fa202330.Customers.CustomerID = group1fa202330.CustomerLogin.CustomerID WHERE" +
                    " group1fa202330.Customers.Email LIKE @email;", logConnection);
                logCommand.Parameters.AddWithValue("@email",custEmail);
                username = (string) logCommand.ExecuteScalar();
                logCommand.Dispose();

                logCommand = new SqlCommand("SELECT group1fa202330.CustomerLogin.Password FROM group1fa202330.CustomerLogin JOIN" +
                   " group1fa202330.Customers ON group1fa202330.Customers.CustomerID = group1fa202330.CustomerLogin.CustomerID WHERE" +
                   " group1fa202330.Customers.Email LIKE @email;", logConnection);
                logCommand.Parameters.AddWithValue("@email", custEmail);
                password = (string)logCommand.ExecuteScalar();
                logCommand.Dispose();

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("lansdcapeaccrec1@gmail.com", "Landscaperz"),
                    EnableSsl = true,
                };
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("lansdcapeaccrec1@gmail.com"),
                    Subject = "Account Recovery",
                    Body = "Hello, here are your credentials. Username: " + username + " Password: " + password,
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(custEmail); 

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Account Recovery", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
//Takes Custoemr email finds username and password
        public static void empAccountRecovery(string empEmail)
        {
            try
            {
                empEmail.Trim();
                string username;
                string password;
                //uses email to find login
                logCommand = new SqlCommand("SELECT group1fa202330.WorkerLogin.Username FROM group1fa202330.WorkerLogin JOIN" +
                    " group1fa202330.Workers ON group1fa202330.Workers.WorkerID = group1fa202330.WorkerLogin.WorkerID WHERE" +
                    " group1fa202330.Workers.Email LIKE @email;", logConnection);
                logCommand.Parameters.AddWithValue("@email", empEmail);
                username = (string)logCommand.ExecuteScalar();
                logCommand.Dispose();

                logCommand = new SqlCommand("SELECT group1fa202330.WorkerLogin.Password FROM group1fa202330.WorkerLogin JOIN" +
                    " group1fa202330.Workers ON group1fa202330.Workers.WorkerID = group1fa202330.WorkerLogin.WorkerID WHERE" +
                    " group1fa202330.Workers.Email LIKE @email;", logConnection);
                logCommand.Parameters.AddWithValue("@email", empEmail);
                password = (string)logCommand.ExecuteScalar();
                logCommand.Dispose();                

                var smtpClient = new SmtpClient("smtp.gmail.com")
                {
                    Port = 587,
                    Credentials = new NetworkCredential("lansdcapeaccrec1@gmail.com", "Landscaperz"),
                    EnableSsl = true,
                };
                var mailMessage = new MailMessage
                {
                    From = new MailAddress("lansdcapeaccrec1@gmail.com"),
                    Subject = "Account Recovery",
                    Body = "Hello, here are your credentials. Username: " + username + " Password: " + password,
                    IsBodyHtml = true,
                };
                mailMessage.To.Add(empEmail);

                smtpClient.Send(mailMessage);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error In Account Recovery", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Close and dispose of database connections
        public static void CloseAllLog()
        {
            //wipe connection
            logConnection.Dispose();
            //close connection. 
            logConnection.Close();
        }

    }
}
