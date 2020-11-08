using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; 

namespace LandscapeProject
{
    public partial class EmployeeMain : Form
    {
        CurrencyManager empManager; 
        public EmployeeMain()
        {
            InitializeComponent();
        }
       
        private void btnSearchSchedule_Click(object sender, EventArgs e)
        {
            try
            {
                EmployeeProgOps.ScheduleSearch(txtSearchSchedule.Text, dgvEmpWorkerSch); 
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
            
        }

        private void EmployeeMain_Load(object sender, EventArgs e)
        {
            try
            {
                EmployeeProgOps.mainLoad(dgvEmpJobInfo, dgvEmpWorkerSch); 
            }
            catch (SqlException)
            {
                MessageBox.Show("The connection to the database may be down. Please check your internet connection. If the problem persists then please contact support.");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message); 
            }
        }

        private void btnCustomer_Click(object sender, EventArgs e)
        {
            
            EmployeeCustomer form1 = new EmployeeCustomer();
            form1.ShowDialog(); 
        }

        private void btnAssign_Click(object sender, EventArgs e)
        {
            
            EmployeeJobMaterial form2 = new EmployeeJobMaterial();
            form2.ShowDialog(); 
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            EmployeeProgOps.CloseAll(); 
            this.Close(); 
        }

        private void btnEmpLogOut_Click(object sender, EventArgs e)
        {
            //to do..
        }
    }
}
