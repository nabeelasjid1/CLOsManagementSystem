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
using System.Text.RegularExpressions;

namespace CLOs_Management_System
{
    public partial class StudentManage : UserControl
    {
        int StdId = 0;
        public StudentManage()
        {
            InitializeComponent();
        }
        public void HideStrics()
        {
            lblRequired1.Hide();
            lblRequired2.Hide();
            lblRequired3.Hide();
            lblRequired4.Hide();
            lblRequired5.Hide();
            lblRequired6.Hide();
        }
        public void ShowStrics()
        {
            lblRequired1.Show();
            lblRequired2.Show();
            lblRequired3.Show();
            lblRequired4.Show();
            lblRequired5.Show();
            lblRequired6.Show();
        }
        public void HideFormates()
        {
            lblValid1.Hide();
            lblValid2.Hide();
            lblValid3.Hide();
            lblValid4.Hide();
            lblValid5.Hide();
            lblValid6.Hide();
        }
        private void StudentManage_Load(object sender, EventArgs e)
        {
            display_data();
            HideFormates();
            btnUpdateStd.Hide();
            btnDeleteStd.Hide();
        }
        
        private int checkRegNumber(string str)
        {
            string query = "Select count(*) from Student where RegistrationNumber= '"+str+"'";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            Int32 count = (Int32)sqlcmd.ExecuteScalar();
            if(count >= 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        private void btnStdSave_Click(object sender, EventArgs e)
        {
            HideFormates();
            if(ValidationAll() == 0) {
                firstNameValid();
                LastNameValid();
                EmailValid();
                ContactValid();
                RegistrationNumberValid();
                StatusValid();
            }
            else
            {
                try
                {
                    //Validation();
                    string query = "Insert Into Student(FirstName, LastName, Contact, Email, RegistrationNumber, Status) " +
                    "Values('" + txtFirstName.Text + "', '" + txtLastName.Text + "', '" + txtContact.Text + "', '" + txtEmail.Text + "', '" + txtRegNumber.Text + "', '" + status() + "')";

                    string messege = txtFirstName.Text + " " + txtLastName.Text + " Added Successfully";

                    crud(query, messege);
                    HideStrics();
                    display_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
            
            
            //insertValidData();
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
        private void crud1(string query)
        {
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            sqlcmd.ExecuteNonQuery();
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
            if (cmbStatus.Text == "Active")
                status = 1;
            else
                status = 2;

            return status;
        }
        private void grdStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            txtRegNumber.Enabled = false;
            ShowStrics();
            btnStdSave.Enabled = false;
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
                if (StdId != -1)
                {
                    string query = "Delete Student Where Id = '" + StdId + "'";
                    string query1 = "Delete StudentAttendance Where StudentId = '" + StdId + "'";
                    string query2 = "Delete StudentResult Where StudentId = '" + StdId + "'";
                    string messege = txtFirstName.Text + " " + txtLastName.Text + " Deleted Successfully";
                    crud1(query2);
                    crud1(query1);
                    crud(query, messege);
                    btnStdSave.Enabled = true;
                    display_data();
                    btnDeleteStd.Hide();
                    btnUpdateStd.Hide();
                    txtRegNumber.Enabled = true;
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
                str = "Active";
            }
            else
            {
                str = "Not Active";
            }
            return str ;
        }
        private void btnUpdateStd_Click(object sender, EventArgs e)
        {
            HideFormates();
            if (ValidationAllUpdate() == 0)
            {
                firstNameValid();
                LastNameValid();
                EmailValid();
                ContactValid();
                StatusValid();
            }
            else
            {
                if (StdId != -1)
                {
                    
                    string query = "Update Student Set FirstName = '" + txtFirstName.Text + "', " +
                        "LastName = '" + txtLastName.Text + "', " +
                        "Contact = '" + txtContact.Text + "', " +
                        "Email = '" + txtEmail.Text + "', " +
                        "RegistrationNumber = '" + txtRegNumber.Text + "', " +
                        "Status = '" + status() + "' " + " Where Id = '" + StdId + "'";
                    string messege = txtFirstName.Text + " " + txtLastName.Text + " Updated Successfully";
                    crud(query, messege);
                    btnDeleteStd.Hide();
                    btnUpdateStd.Hide();
                    txtRegNumber.Enabled = true;
                    btnStdSave.Enabled = true;
                    display_data();
                }
                else
                {
                    MessageBox.Show("Required Fields are Empty");
                }
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

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void txtFirstName_MouseClick(object sender, MouseEventArgs e)
        {
            //insertValidData();
            ShowStrics();
            

        }
        public int firstNameValid()
        {
            if ((!Regex.IsMatch(txtFirstName.Text, @"[a-zA-Z ]")) || txtFirstName.Text == "")
            {
                lblValid1.Show();
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int LastNameValid()
        {
            if ((!Regex.IsMatch(txtLastName.Text, @"[a-zA-Z ]")) || txtLastName.Text == "")
            {
                lblValid2.Show();
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int ContactValid()
        {
            if ((!Regex.IsMatch(txtContact.Text, @"[1-9]")) || txtContact.Text == "")
            {
                lblValid3.Show();
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int RegistrationNumberValid()
        {
            if (checkRegNumber(txtRegNumber.Text) == 1 || txtEmail.Text == "" || (!Regex.IsMatch(txtRegNumber.Text, @"^[a-zA-Z0-9]+$")))
            {
                lblValid5.Show();
                MessageBox.Show(txtRegNumber.Text + "Already Exist");
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int EmailValid()
        {
            if ((!Regex.IsMatch(txtEmail.Text, @"^\w+@[a-zA-Z_]+?\.[a-zA-Z]{2,3}$")) || txtEmail.Text == "")
            {
                lblValid4.Show();
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int StatusValid()
        {
            if (cmbStatus.Text == "")
            {
                lblValid6.Show();
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int ValidationAll()
        {
            if(firstNameValid() == 1 && LastNameValid() == 1 && ContactValid() == 1 && RegistrationNumberValid() == 1 && EmailValid() == 1 && StatusValid() == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        public int ValidationAllUpdate()
        {
            if (firstNameValid() == 1 && LastNameValid() == 1 && ContactValid() == 1 && EmailValid() == 1 && StatusValid() == 1)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
