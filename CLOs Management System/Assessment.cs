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
    public partial class Assessment : UserControl
    {
        int AssId = 0;
        public Assessment()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSaveAss_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Insert Into Assessment(Title, DateCreated, TotalMarks, TotalWeightage) " +
                "Values('" + txtTitle.Text + "', '" + DateTime.Now + "', '" + txtTotalMarks.Text + "', '" + txtTotalWeightage.Text + "')";

                string messege = txtTitle.Text + " Added Successfully";

                crud(query, messege);
                display_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void crud(string query, string messege)
        {
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            sqlcmd.ExecuteNonQuery();
            MessageBox.Show(messege);
            clear();
            DatabaseConnection.getInstance().closeConnection();
        }
        //clear after the successfull action
        private void clear()
        {
            txtTitle.Text = txtTotalMarks.Text = txtTotalWeightage.Text = "";
        }
        public void display_data()
        {
            try
            {
                string query = "Select * from Assessment ";
                SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
                sqlcmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                da.Fill(dt);
                grdAssessment.DataSource = dt;
                DatabaseConnection.getInstance().closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void grdAssessment_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Assessment_Load(object sender, EventArgs e)
        {
            display_data();
            btnDeleteAss.Hide();
            btnUpdateAss.Hide();
        }
        DateTime date;
        private void grdAssessment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AssId = Convert.ToInt32(grdAssessment.CurrentRow.Cells[0].Value.ToString());
            txtTitle.Text = grdAssessment.CurrentRow.Cells[1].Value.ToString();
            date = Convert.ToDateTime(grdAssessment.CurrentRow.Cells[2].Value.ToString());
            txtTotalMarks.Text = grdAssessment.CurrentRow.Cells[3].Value.ToString();
            txtTotalWeightage.Text = grdAssessment.CurrentRow.Cells[4].Value.ToString();
            btnDeleteAss.Show();
            btnUpdateAss.Show();
        }

        private void btnDeleteAss_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtTitle.Text != "")
                {
                    string query = "Delete Assessment Where Id = '" + AssId + "'";
                    string messege = txtTitle.Text + " Deleted Successfully";
                    crud(query, messege);
                    display_data();
                }
                else
                {
                    MessageBox.Show("Required Fields are Empty");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdateAss_Click(object sender, EventArgs e)
        {
            if (txtTitle.Text != "")
            {
                string query = "Update Assessment Set Title = '" + txtTitle.Text + "', " +
                    "DateCreated = '" + date + "', " +
                    "TotalMarks = '" + txtTotalMarks.Text + "', " +
                    "TotalWeightage = '" + txtTotalWeightage.Text + "' " + " Where Id = '" + AssId + "'";
                string messege = txtTitle.Text + " Updated Successfully";
                crud(query, messege);
                display_data();
                clear();
            }
            else
            {
                MessageBox.Show("Required Fields are Empty");
            }
        }

        private void btnSearchAss_Click(object sender, EventArgs e)
        {
            string query = "Select * from Assessment Where Title Like '" + txtSearchAss.Text + "%'";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            sqlcmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            da.Fill(dt);
            grdAssessment.DataSource = dt;
            DatabaseConnection.getInstance().closeConnection();
        }
    }
}
