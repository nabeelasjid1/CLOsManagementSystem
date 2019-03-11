using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace CLOs_Management_System
{
    public partial class Main : UserControl
    {
        public Main()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            LoadCountStd();
            LoadCountClo();
        }
        private void LoadCountStd()
        {
            string query = "Select count(*) from Student";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
            stdCount.Text = count.ToString();
        }
        private void LoadCountClo()
        {
            string query = "Select count(*) from Clo";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
            cloCount.Text = count.ToString();
        }
    }
}
