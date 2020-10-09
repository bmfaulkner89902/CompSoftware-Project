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
                    //load datagridview - customerID, customerName, Address, Phone, email, Payment due.
            //open connection 
            ProgOps.Open();
            //get information to fill datagridview Job information . 
            ProgOps.empCommand = new SqlCommand("SELECT group1fa202330.Customers.CustomerID, FirstName + ' ' + LastName AS CustomerName, address, Email FROM group1fa202330.Customers; ", ProgOps.empConnection);
            ProgOps.empAdapter.SelectCommand = ProgOps.empCommand;
            ProgOps.empAdapter.Fill(ProgOps.empCustomersDT);

            //fill datagrid view. 
            dgvEmpCustomer.DataSource = ProgOps.empCustomersDT;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string custSearch = txtSearch.Text;
            ProgOps.empAdapter.SelectCommand = ProgOps.empCommand;
            ProgOps.empAdapter.Fill(ProgOps.empCustomersDT);
            if (rdoSearchID.Checked == true)
                ProgOps.empCommand = new SqlCommand("SELECT group1fa202330.Customers.CustomerID, FirstName + ' ' + LastName AS CustomerName, address, Email FROM group1fa202330.Customers WHERE FirstName LIKE '" + custSearch + "' OR LastName LIKE '" + custSearch + "'; ", ProgOps.empConnection);
            else
                ProgOps.empCommand = new SqlCommand("SELECT group1fa202330.Customers.CustomerID, FirstName + ' ' + LastName AS CustomerName, address, Email FROM group1fa202330.Customers WHERE CustomerID = " + custSearch + "; ", ProgOps.empConnection);
            //fill datagrid view. 
            dgvEmpCustomer.DataSource = ProgOps.empCustomersDT;
        }

        private void btnMainMenu_Click(object sender, EventArgs e)
        {
            this.Close(); 
        }
    }
}
