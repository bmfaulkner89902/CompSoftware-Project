using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LandscapeProject
{
    public partial class EmployeeCustomer : Form
    {
        public EmployeeCustomer()
        {
            InitializeComponent();
        }

        private void EmployeeCustomer_Load(object sender, EventArgs e)
        {
            try
            {
                //load datagridview - customerID, customerName, Address, Phone, email, Payment due.
                //get information to fill datagridview Job information . 
                ProgOps.empCommand = new SqlCommand("SELECT group1fa202330.Customers.CustomerID, FirstName + ' ' + LastName AS CustomerName, address, Email FROM group1fa202330.Customers; ", ProgOps.empConnection);
                ProgOps.empAdapter.SelectCommand = ProgOps.empCommand;
                ProgOps.empAdapter.Fill(ProgOps.empCustomersDT);

                //fill datagrid view. 
                dgvEmpCustomer.DataSource = ProgOps.empCustomersDT;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
           
        }
        //searches the customer database. 
        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                ProgOps.empCustomersDT = new DataTable();
                string custSearch = txtSearch.Text;
                if (custSearch == null || custSearch == "")
                    ProgOps.empCommand = new SqlCommand("SELECT group1fa202330.Customers.CustomerID, FirstName + ' ' + LastName AS CustomerName, address, Email FROM group1fa202330.Customers;", ProgOps.empConnection);
                else if (rdoSearchName.Checked == true)
                    ProgOps.empCommand = new SqlCommand($"SELECT group1fa202330.Customers.CustomerID, FirstName + ' ' + LastName AS CustomerName, address, Email FROM group1fa202330.Customers WHERE FirstName LIKE '{custSearch}' OR LastName LIKE '{custSearch}'; ", ProgOps.empConnection);
                else if (rdoSearchID.Checked == true)
                    ProgOps.empCommand = new SqlCommand($"SELECT group1fa202330.Customers.CustomerID, FirstName + ' ' + LastName AS CustomerName, address, Email FROM group1fa202330.Customers WHERE CustomerID = '{custSearch}'; ", ProgOps.empConnection);

                //fill datagrid view.
                ProgOps.empAdapter.SelectCommand = ProgOps.empCommand;
                ProgOps.empAdapter.Fill(ProgOps.empCustomersDT);
                dgvEmpCustomer.DataSource = ProgOps.empCustomersDT;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
