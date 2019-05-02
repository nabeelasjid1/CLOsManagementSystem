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
    public partial class CheckStatus : UserControl
    {
        public CheckStatus()
        {
            InitializeComponent();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "SELECT COUNT(*) FROM Student WHERE RegistrationNumber = '" + txtSearch.Text + "'";
                SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
                int count = (int)sqlcmd.ExecuteScalar();
                if (count > 0)
                {
                    string query1 = "SELECT * from Student " +"INNER JOIN StudentAttendance " +"ON Student.Id = StudentAttendance.StudentId " +
                        " WHERE RegistrationNumber = '" + txtSearch.Text + "' ";
                    PercentageAtt(query1);
                    clear();
                }
                else
                {
                    MessageBox.Show("Student Not Exist");
                    clear();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clear()
        {
            txtSearch.Text = "";
        }
        private void PercentageAtt(string query)
        {
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            SqlDataReader reader = sqlcmd.ExecuteReader();
            int totalAtt = 0;
            int stdAtt = 0;
            while (reader.Read())
            {
                totalAtt = totalAtt + 1;
                if (reader["AttendanceStatus"].ToString() == "1")
                {
                    stdAtt = stdAtt + 1;
                }
            }

            if (totalAtt == 0)
            {
                lblPer.Text = "0 ";
            }
            else
            {
                int percentage = (100 * stdAtt) / totalAtt;
                lblPer.Text = percentage.ToString() + " %";
            }
            lblPer.Show();

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }

        private void CheckStatus_Load(object sender, EventArgs e)
        {
            lblPer.Hide();
        }
    }
}
