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
    public partial class StudentManage : UserControl
    {
        int StdId = 0;
        public StudentManage()
        {
            InitializeComponent();
        }

        private void StudentManage_Load(object sender, EventArgs e)
        {
            display_data();
            btnUpdateStd.Hide();
            btnDeleteStd.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lblFirstName_Click(object sender, EventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtFirstName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFirstName_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void placeholderTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnStdSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Insert Into Student(FirstName, LastName, Contact, Email, RegistrationNumber, Status) " +
                "Values('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtContact.Text + "', '" + txtEmail.Text + "', '" + txtRegNumber.Text + "', '" + status() + "')";

                string messege = txtFirstName.Text + " " + txtLastName.Text + " Added Successfully";

                crud(query, messege);
                display_data();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
        public void display_data()
        {
            try
            {
                string query = "Select * from Student ";
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
            txtFirstName.Text = txtLastName.Text = txtContact.Text
                = txtEmail.Text = txtRegNumber.Text = cmbStatus.Text = "";
        }
        //conver status to int 0 or 1 
        private int status()
        {
            int status;
            if (cmbStatus.Text == "Regular Student")
                status = 1;
            else
                status = 0;

            return status;
        }
        private void cmbStatus_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grdStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grdStudent_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            
        }

        private void grdStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StdId = Convert.ToInt32(grdStudent.CurrentRow.Cells[0].Value.ToString());
            txtFirstName.Text = grdStudent.CurrentRow.Cells[1].Value.ToString();
            txtLastName.Text = grdStudent.CurrentRow.Cells[2].Value.ToString();
            txtContact.Text = grdStudent.CurrentRow.Cells[3].Value.ToString();
            txtEmail.Text = grdStudent.CurrentRow.Cells[4].Value.ToString();
            txtRegNumber.Text = grdStudent.CurrentRow.Cells[5].Value.ToString();
            int k = Convert.ToInt32(grdStudent.CurrentRow.Cells[6].Value.ToString());
            cmbStatus.Text = statuscon(k);
            btnDeleteStd.Show();
            btnUpdateStd.Show();
        }

        private void btnDeleteStd_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFirstName.Text != "")
                {
                    string query = "Delete Student Where RegistrationNumber = '" + txtRegNumber.Text + "'";
                    string messege = txtFirstName.Text + " " + txtLastName.Text + " Deleted Successfully";
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
        private string statuscon(int c)
        {
            string str;
            if (c == 1)
            {
                str = "Regular Student";
            }
            else
            {
                str = "Not Regular Anymore";
            }
            return str ;
        }
        private void btnUpdateStd_Click(object sender, EventArgs e)
        {
            if (txtFirstName.Text != "")
            {
                string query = "Update Student Set FirstName = '" + txtFirstName.Text + "', " +
                    "LastName = '" + txtLastName.Text + "', " +
                    "Contact = '" + txtContact.Text + "', " +
                    "Email = '" + txtEmail.Text + "', " +
                    "RegistrationNumber = '" + txtRegNumber.Text + "', " +
                    "Status = '" + status() + "' " + " Where RegistrationNumber = '" + txtRegNumber.Text + "'";
                string messege = txtFirstName.Text + " " + txtLastName.Text + " Updated Successfully";
                crud(query, messege);
                display_data();
            }
            else
            {
                MessageBox.Show("Required Fields are Empty");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string query = "Select * from Student Where RegistrationNumber Like '" + txtSearch.Text + "%'";
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
