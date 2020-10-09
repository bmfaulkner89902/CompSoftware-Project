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

namespace LandscapeProject
{
    class ProgOps
    {
        //Connection String
        private const string CONNECT_STRING = @"Server=cstnt.tstc.edu;Database=INEW2330fa20;User Id=group1fa202330;password=1524152";
        //Build A Connection To MovieStore Tables In The Database
        private static SqlConnection _cntDatabase = new SqlConnection(CONNECT_STRING);
        //Add The Command Object
        private static SqlCommand _sqlLandscapeCommand;
        //Add The Data Adapter
        private static SqlDataAdapter _daLandscape = new SqlDataAdapter();
        //Add The Data Table
        private static DataTable _dtLandscape = new DataTable();


        public static void OpenDataBase()
        {
            //Method To Open Database And To Allow Use Of Data
            //Open The Connection To Database
            _cntDatabase.Open();
        }

        public static void CloseDataBase()
        {
            //Method To Close And Dispose Of Objects
            //Close The Database
            _cntDatabase.Close();
            //Dispose Of The Connection 
            _cntDatabase.Dispose();
        }

    }
}
