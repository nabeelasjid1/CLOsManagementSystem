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
        int AssCId = 0;
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
                clear();
                fillCmbAssesId();
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
        public void display_data1()
        {
            try
            {
                string query = "Select Id,Name,RubricId,TotalMarks,AssessmentId from AssessmentComponent ";
                SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
                sqlcmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                da.Fill(dt);
                grdAssessmentAC.DataSource = dt;
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
            display_data1();
            fillCmbRubricId();
            fillCmbAssesId();
            btnDeleteAss.Hide();
            btnUpdateAss.Hide();
            btnDeleteASSC.Hide();
            btnUpdateASSC.Hide();
        }
        public void fillCmbRubricId()
        {
            string query = "Select * from Rubric";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                cmbRubricId.Items.Add(reader["Details"].ToString());
            }
            DatabaseConnection.getInstance().closeConnection();
        }
        public void fillCmbAssesId()
        {
            cmbAssessmentId.Items.Clear();
            string query = "Select * from Assessment";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                cmbAssessmentId.Items.Add(reader["Title"].ToString());
            }
            DatabaseConnection.getInstance().closeConnection();
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
                    clear();
                    fillCmbAssesId();
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
                fillCmbAssesId();
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

        private void btnStdSave_Click(object sender, EventArgs e)
        {
            try
            {
                string query = "Insert Into AssessmentComponent(Name, RubricId, TotalMarks,DateCreated,DateUpdated, AssessmentId) " +
                "Values('" + txtNameAC.Text + "', '" + getRubId(cmbRubricId.Text) + "', '" + txtTotalMarksAC.Text + "', '" + DateTime.Now + "', '" + DateTime.Now + "', '" + getAssId(cmbAssessmentId.Text) + "')";

                string messege = txtNameAC.Text + " Added Successfully";

                crud(query, messege);
                display_data1();
                clear1();
                //fillCmbAssesId();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public int getRubId(string str)
        {
            string query = "Select Id from Rubric where Details = '" + str + "' ";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            int id = (int)sqlcmd.ExecuteScalar();
            DatabaseConnection.getInstance().closeConnection();
            return id;

        }
        public string getRubDet(int i)
        {
            string query = "Select Details from Rubric where Id = '" + i + "' ";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            string str = (string)sqlcmd.ExecuteScalar();
            DatabaseConnection.getInstance().closeConnection();
            return str;

        }
        public string getAssDet(int i)
        {
            string query = "Select Title from Assessment where Id = '" + i + "' ";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            string str = (string)sqlcmd.ExecuteScalar();
            DatabaseConnection.getInstance().closeConnection();
            return str;

        }
        public int getAssId(string str)
        {
            string query = "Select Id from Assessment where Title = '" + str + "' ";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            int id = (int)sqlcmd.ExecuteScalar();
            DatabaseConnection.getInstance().closeConnection();
            return id;

        }

        private void grdAssessmentAC_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            AssCId = Convert.ToInt32(grdAssessmentAC.CurrentRow.Cells[0].Value.ToString());
            txtNameAC.Text = grdAssessmentAC.CurrentRow.Cells[1].Value.ToString();
            int RubDet = Convert.ToInt32(grdAssessmentAC.CurrentRow.Cells[2].Value.ToString());
            cmbRubricId.Text = getRubDet(RubDet);
            txtTotalMarksAC.Text = grdAssessmentAC.CurrentRow.Cells[3].Value.ToString();
             int AssDet= Convert.ToInt32(grdAssessmentAC.CurrentRow.Cells[4].Value.ToString());
            cmbAssessmentId.Text = getAssDet(AssDet);
            btnDeleteASSC.Show();
            btnUpdateASSC.Show();
        }

        private void btnDeleteASSC_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtNameAC.Text != "")
                {
                    string query = "Delete AssessmentComponent Where Id = '" + AssCId + "'";
                    string messege = txtNameAC.Text + " Deleted Successfully";
                    crud(query, messege);
                    display_data1();
                    clear1();
                    //fillCmbAssesId();
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
        private void clear1()
        {
            txtNameAC.Text = cmbRubricId.Text = cmbAssessmentId.Text = txtTotalMarksAC.Text = "";
        }

        private void btnUpdateASSC_Click(object sender, EventArgs e)
        {
            if (txtNameAC.Text != "")
            {
                string query = "Update AssessmentComponent Set Name = '" + txtNameAC.Text + "', " +
                    "RubricId = '" + getRubId(cmbRubricId.Text) + "', " +
                    "TotalMarks = '" + txtTotalMarksAC.Text + "', " +
                    "DateUpdated = '" + DateTime.Now + "', " +
                    "AssessmentId = '" + getAssId(cmbAssessmentId.Text) + "' " + " Where Id = '" + AssCId + "'";
                string messege = txtTitle.Text + " Updated Successfully";
                crud(query, messege);
                display_data1();
                //fillCmbAssesId();
                clear1();
            }
            else
            {
                MessageBox.Show("Required Fields are Empty");
            }
        }

        private void btnSearchASSC_Click(object sender, EventArgs e)
        {
            string query = "Select Id,Name,RubricId,TotalMarks,AssessmentId from AssessmentComponent Where Name Like '" + txtSearchASSC.Text + "%'";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            sqlcmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            da.Fill(dt);
            grdAssessmentAC.DataSource = dt;
            DatabaseConnection.getInstance().closeConnection();
        }
    }
}
