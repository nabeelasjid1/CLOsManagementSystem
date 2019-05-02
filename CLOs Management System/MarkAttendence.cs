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
    public partial class MarkAttendence : UserControl
    {
        public MarkAttendence()
        {
            InitializeComponent();
        }

        private void dgvMarkAttendence_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MarkAttendence_Load(object sender, EventArgs e)
        {
            markAtt();
        }
       
        private void markAtt()
        {
            string query = "Select FirstName + ' ' + LastName As Name, " +
                "RegistrationNumber As [Registration Number]" +
                "from Student where Status = '" + 1 + "'" +
                "Order by RegistrationNumber";

            SqlDataAdapter sqladp = new SqlDataAdapter(query, DatabaseConnection.getInstance().getConnection());
            DataTable dt = new DataTable();
            sqladp.Fill(dt);
            dgvMarkAttendence.DataSource = dt;
            dgvMarkAttendence.Columns["Name"].ReadOnly = true;
            dgvMarkAttendence.Columns["Registration Number"].ReadOnly = true;

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            var myDateTime = DateTime.Now;
            var sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            var myDateTime1 = DateTime.Now;
            var sqlFormattedDate1 = myDateTime1.Date.ToString("yyyy-MM-dd");
            //var sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd");
            string query0 = "Select Count(*) from  ClassAttendance where AttendanceDate = '"+ sqlFormattedDate1 + "' ";
            SqlCommand sqlcmd1 = new SqlCommand(query0, DatabaseConnection.getInstance().getConnection());
            int count = Convert.ToInt32(sqlcmd1.ExecuteScalar());
            if(count == 1 || count > 1)
            {
                MessageBox.Show("Todays Attendance Already Marked");
                for (int i = 0; i < dgvMarkAttendence.Rows.Count; i++)
                {
                    dgvMarkAttendence.Rows[i].Cells[0].Value = null;
                }
            }
            else
            {
                string query = "Insert Into ClassAttendance(AttendanceDate) OUTPUT INSERTED.ID Values('" + sqlFormattedDate + "')";
                SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
                int classId = Convert.ToInt32(sqlcmd.ExecuteScalar());

                for (int i = 0; i < dgvMarkAttendence.Rows.Count - 1; i++)
                {
                    int studentId = 0;
                    string query1 = "Select * from Student where RegistrationNumber = '" + dgvMarkAttendence.Rows[i].Cells[2].Value.ToString() + "'";
                    SqlCommand sqlcmd2 = new SqlCommand(query1, DatabaseConnection.getInstance().getConnection());
                    SqlDataReader reader = sqlcmd2.ExecuteReader();
                    while (reader.Read())
                    {
                        studentId = (int)reader["Id"];
                    }

                    int attendanceId = 0;
                    if (dgvMarkAttendence.Rows[i].Cells[0].Value == null)
                    {
                        attendanceId = 2;
                    }
                    else
                    {
                        attendanceId = 1;
                    }

                    string query2 = "Insert Into StudentAttendance(AttendanceId, StudentId, AttendanceStatus) " +
                        "Values('" + classId + "', '" + studentId + "', '" + attendanceId + "')";
                    SqlCommand sqlcmd3 = new SqlCommand(query2, DatabaseConnection.getInstance().getConnection());
                    sqlcmd3.ExecuteNonQuery();
                }
            
            DatabaseConnection.getInstance().closeConnection();
            MessageBox.Show("Attendence Marked Successfully");

            for (int i = 0; i < dgvMarkAttendence.Rows.Count; i++)
            {
                dgvMarkAttendence.Rows[i].Cells[0].Value = null;
            }
            }
        }
        private void crud(string query)
        {
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            sqlcmd.ExecuteNonQuery();
            DatabaseConnection.getInstance().closeConnection();
        }

        private void dgvMarkAttendence_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
