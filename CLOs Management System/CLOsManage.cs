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
    public partial class CLOsManage : UserControl
    {
        int CloId = 0;
        string DateCreated;
        public CLOsManage()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnStdSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Insert Into Clo(Name, DateCreated, DateUpdated) " +
                "Values('" + txtName.Text + "', '"+DateTime.Now+"', '"+DateTime.Now+"' )";

                string messege = txtName.Text + " Added Successfully";

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
        public void display_data()
        {
            try
            {
                string query = "Select * from Clo ";
                SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
                sqlcmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                da.Fill(dt);
                grdStudent.DataSource = dt;
                DatabaseConnection.getInstance().closeConnection();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void clear()
        {
            txtName.Text = "";
        }

        private void CLOsManage_Load(object sender, EventArgs e)
        {
            display_data();
            btnUpdateClo.Hide();
            btnDeleteClo.Hide();
        }

        private void grdStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CloId = Convert.ToInt32(grdStudent.CurrentRow.Cells[0].Value.ToString());
            txtName.Text = grdStudent.CurrentRow.Cells[1].Value.ToString();
            DateCreated = grdStudent.CurrentRow.Cells[2].Value.ToString();
            btnDeleteClo.Show();
            btnUpdateClo.Show();
        }

        private void btnUpdateClo_Click(object sender, EventArgs e)
        {
            if (txtName.Text != "")
            {
                string query = "Update Clo Set Name = '" + txtName.Text + "', " +
                    "DateCreated = '" + DateCreated + "', " +
                    "DateUpdated = '" + DateTime.Now + "' " + " Where Id = '" + CloId + "'";
                string messege = txtName.Text +  " Updated Successfully";
                crud(query, messege);
                display_data();
            }
            else
            {
                MessageBox.Show("Required Fields are Empty");
            }
        }

        private void btnDeleteClo_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtName.Text != "")
                {
                    string query = "Delete Clo Where Name = '" + txtName.Text + "'";
                    string messege = txtName.Text +" Deleted Successfully";
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

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "Select * from Clo Where Name Like '"+txtSearch.Text+"%'";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            sqlcmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            da.Fill(dt);
            grdStudent.DataSource = dt;
            DatabaseConnection.getInstance().closeConnection();
        }
    }
}
