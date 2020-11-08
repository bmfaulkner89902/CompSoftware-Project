﻿using System;
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
                EmployeeProgOps.empCustLoad(dgvEmpCustomer); 
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
                EmployeeProgOps.empCustSearch(dgvEmpCustomer, rdoSearchName, rdoSearchID, txtSearch.ToString()); 
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
