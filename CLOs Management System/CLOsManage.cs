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
            lblValid1.Hide();
            if(NameValid() == 0)
            {
                NameValid();
                MessageBox.Show("Name Should Not contain Special Characters");
            }
            else
            {
                try
                {
                    var myDateTime = DateTime.Now;
                    var sqlFormattedDate = myDateTime.Date.ToString("yyyy-MM-dd HH:mm:ss");
                    string query = "Insert Into Clo(Name, DateCreated, DateUpdated) " +
                    "Values('" + txtName.Text + "', '" + sqlFormattedDate + "', '" + sqlFormattedDate + "' )";

                    string messege = txtName.Text + " Added Successfully";

                    crud(query, messege);
                    lblValid1.Hide();
                    display_data();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
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
            lblValid1.Hide();
            btnUpdateClo.Hide();
            btnDeleteClo.Hide();
        }

        private void btnUpdateClo_Click(object sender, EventArgs e)
        {
            lblValid1.Hide();
            if (NameValid() == 0)
            {
                NameValid();
                MessageBox.Show("Name Should Not contain Special Characters");
            }
            else
            {
                if (txtName.Text != "")
                {
                    var myDateTime = DateTime.Now;
                    var sqlFormattedDate = myDateTime.Date.ToString("yyyy-MM-dd HH:mm:ss");
                    string query = "Update Clo Set Name = '" + txtName.Text + "', " +
                        "DateUpdated = '" + sqlFormattedDate + "' " + " Where Id = '" + CloId + "'";
                    string messege = txtName.Text + " Updated Successfully";
                    crud(query, messege);
                    lblValid1.Hide();
                    btnSaveClo.Hide();
                    btnSaveClo.Enabled = true;
                    display_data();
                }
                else
                {
                    MessageBox.Show("Required Fields are Empty");
                }
            }
            
        }

        private void btnDeleteClo_Click(object sender, EventArgs e)
        {
            try
            {
                if (CloId != -1)
                {
                    string query = "Delete Clo Where Id = '" + CloId + "'";
                    string query1 = "Delete Rubric Where CloId = '" + CloId + "'";
                    string query2 = "Delete AssessmentComponent From AssessmentComponent Inner Join Rubric ON AssessmentComponent.RubricId = Rubric.Id Inner Join Clo ON Clo.Id = Rubric.CloId  Where Clo.Id = '" + CloId + "'";
                    string query3 = "Delete RubricLevel From RubricLevel Inner Join Rubric ON RubricLevel.RubricId = Rubric.Id Inner Join Clo ON Clo.Id = Rubric.CloId  Where Clo.Id = '" + CloId + "'";
                    string query4 = "Delete StudentResult from StudentResult Inner Join RubricLevel ON StudentResult.RubricMeasurementId = RubricLevel.Id Inner Join Rubric ON Rubric.Id = RubricLevel.Id Inner Join Clo ON Clo.Id = Rubric.CloId where Clo.Id = '"+CloId+"'";
                    string query5 = "Delete StudentResult from StudentResult Inner Join AssessmentComponent ON StudentResult.AssessmentComponentId = AssessmentComponent.Id Inner Join Rubric ON Rubric.Id = AssessmentComponent.RubricId Inner Join Clo ON Clo.Id = Rubric.CloId where Clo.Id = '" + CloId + "'";
                    string messege = txtName.Text +" Deleted Successfully";
                    crud1(query4);
                    crud1(query5);
                    crud1(query2);
                    crud1(query3);
                    crud1(query1);
                    crud(query, messege);
                    btnSaveClo.Hide();
                    lblValid1.Hide();
                    btnSaveClo.Enabled = true;
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
        public int NameValid()
        {
            if ((!Regex.IsMatch(txtName.Text, @"^[a-zA-Z0-9 ]+$")) || txtName.Text == "")
            {
                lblValid1.Show();
                //MessageBox.Show("Name Should Not contain Special Characters");
                return 0;
            }
            else
            {
                return 1;
            }
        }

        private void txtName_MouseClick(object sender, MouseEventArgs e)
        {
            //lblValid1.Show();
        }

        private void grdStudent_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSaveClo.Enabled = false;
            CloId = Convert.ToInt32(grdStudent.CurrentRow.Cells[0].Value.ToString());
            txtName.Text = grdStudent.CurrentRow.Cells[1].Value.ToString();
            DateCreated = grdStudent.CurrentRow.Cells[2].Value.ToString();
            btnDeleteClo.Show();
            btnUpdateClo.Show();
        }
    }
}
