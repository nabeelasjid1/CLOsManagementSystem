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
            lblValid1.Hide();
            lblValid2.Hide();
            lblValid3.Hide();
            if(AsTitleValid() == 0 || AsTotalMarksValid() == 0 || AsTotalWeightValid() == 0)
            {
                AsTitleValid();
                AsTotalMarksValid();
                AsTotalWeightValid();
                MessageBox.Show("Enter Valid Data");
            }
            else
            {
                try
                {
                    var myDateTime = DateTime.Now;
                    var sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                    string query = "Insert Into Assessment(Title, DateCreated, TotalMarks, TotalWeightage) " +
                    "Values('" + txtTitle.Text + "', '" + sqlFormattedDate + "', '" + txtTotalMarks.Text + "', '" + txtTotalWeightage.Text + "')";

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
            lblValid1.Hide();
            lblValid2.Hide();
            lblValid3.Hide();
            lblValid4.Hide();
            lblValid5.Hide();
            lblValid6.Hide();
            lblValid7.Hide();
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
            string query1 = "Select Count(*) from Assessment";
            SqlCommand sqlcmd1 = new SqlCommand(query1, DatabaseConnection.getInstance().getConnection());
            Int32 count = (Int32)sqlcmd1.ExecuteScalar();
            if(count > 0)
            {
                string query = "Select * from Assessment";
                SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
                SqlDataReader reader = sqlcmd.ExecuteReader();
                while (reader.Read())
                {
                    cmbAssessmentId.Items.Add(reader["Title"].ToString());
                }
            }

            
            DatabaseConnection.getInstance().closeConnection();
        }
        DateTime date;
        private void grdAssessment_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSaveAss.Enabled = false;
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
                if (AssId != -1)
                {
                    string query = "Delete Assessment Where Id = '" + AssId + "'";
                    string query1 = "Delete AssessmentComponent From AssessmentComponent Inner Join Assessment ON Assessment.Id = AssessmentComponent.AssessmentId where Assessment.Id = '" + AssId + "'";
                    string messege = txtTitle.Text + " Deleted Successfully";
                    crud1(query1);
                    crud(query, messege);
                    display_data();
                    display_data1();
                    btnDeleteAss.Hide();
                    btnUpdateAss.Hide();
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
            lblValid1.Hide();
            lblValid2.Hide();
            lblValid3.Hide();
            if (AsTitleValid() == 0 || AsTotalMarksValid() == 0 || AsTotalWeightValid() == 0)
            {
                AsTitleValid();
                AsTotalMarksValid();
                AsTotalWeightValid();
                MessageBox.Show("Enter Valid Data");
            }
            else
            {
                if (AssId != -1)
                {
                    string query = "Update Assessment Set Title = '" + txtTitle.Text + "', " +
                        "TotalMarks = '" + txtTotalMarks.Text + "', " +
                        "TotalWeightage = '" + txtTotalWeightage.Text + "' " + " Where Id = '" + AssId + "'";
                    string messege = txtTitle.Text + " Updated Successfully";
                    crud(query, messege);
                    display_data();
                    display_data1();
                    btnDeleteAss.Hide();
                    btnUpdateAss.Hide();
                    fillCmbAssesId();
                    clear();
                }
                else
                {
                    MessageBox.Show("Required Fields are Empty");
                }
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
            lblValid4.Hide();
            lblValid5.Hide();
            lblValid6.Hide();
            lblValid7.Hide();
            if (ASCAsIdValid() == 0 || ASCNameValid() == 0 || ASCTotalMarksValid() == 0 || ASCRubicValid() == 0)
            {
                ASCAsIdValid();
                ASCNameValid();
                ASCTotalMarksValid();
                ASCRubicValid();
                MessageBox.Show("Enter Valid Data");
            }
            else
            {
                try
                {
                    var myDateTime = DateTime.Now;
                    var sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                    string query = "Insert Into AssessmentComponent(Name, RubricId, TotalMarks,DateCreated,DateUpdated, AssessmentId) " +
                    "Values('" + txtNameAC.Text + "', '" + getRubId(cmbRubricId.Text) + "', '" + txtTotalMarksAC.Text + "', '" + sqlFormattedDate + "', '" + sqlFormattedDate + "', '" + getAssId(cmbAssessmentId.Text) + "')";

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
            btnSaveASSC.Enabled = false;
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
                    string query1 = "Delete StudentResult From StudentResult Inner Join AssessmentComponent ON AssessmentComponent.Id = StudentResult.AssessmentComponentId where AssessmentComponent.Id = '" + AssCId + "'";
                    string messege = txtNameAC.Text + " Deleted Successfully";
                    crud1(query1);
                    crud(query, messege);
                    display_data1();
                    btnUpdateASSC.Hide();
                    btnDeleteASSC.Hide();
                    btnSaveASSC.Enabled = true;
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
            lblValid4.Hide();
            lblValid5.Hide();
            lblValid6.Hide();
            lblValid7.Hide();
            if (ASCAsIdValid() == 0 || ASCNameValid() == 0 || ASCTotalMarksValid() == 0 || ASCRubicValid() == 0)
            {
                ASCAsIdValid();
                ASCNameValid();
                ASCTotalMarksValid();
                ASCRubicValid();
                MessageBox.Show("Enter Valid Data");
            }
            else
            {
                if (AssCId != -1)
                {
                    var myDateTime = DateTime.Now;
                    var sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                    string query = "Update AssessmentComponent Set Name = '" + txtNameAC.Text + "', " +
                        "RubricId = '" + getRubId(cmbRubricId.Text) + "', " +
                        "TotalMarks = '" + txtTotalMarksAC.Text + "', " +
                        "DateUpdated = '" + sqlFormattedDate + "', " +
                        "AssessmentId = '" + getAssId(cmbAssessmentId.Text) + "' " + " Where Id = '" + AssCId + "'";
                    string messege = txtTitle.Text + " Updated Successfully";
                    crud(query, messege);
                    display_data1();
                    btnUpdateASSC.Hide();
                    btnDeleteASSC.Hide();
                    btnSaveASSC.Enabled = true;
                    //fillCmbAssesId();
                    clear1();
                }
                else
                {
                    MessageBox.Show("Required Fields are Empty");
                }
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
        public int AsTitleValid()
        {
            if ((!Regex.IsMatch(txtTitle.Text, @"^[a-zA-Z ]+$")) || txtTitle.Text == "")
            {
                lblValid1.Show();
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int ASCNameValid()
        {
            if ((!Regex.IsMatch(txtNameAC.Text, @"^[a-zA-Z ]+$")) || txtNameAC.Text == "")
            {
                lblValid4.Show();
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int ASCRubicValid()
        {
            if (cmbRubricId.Text == "")
            {
                lblValid5.Show();
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int ASCAsIdValid()
        {
            if (cmbAssessmentId.Text == "")
            {
                lblValid7.Show();
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int AsTotalMarksValid()
        {
            if ((!Regex.IsMatch(txtTotalMarks.Text, @"^[0-9]+$")) || txtTotalMarks.Text == "")
            {
                lblValid2.Show();
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int ASCTotalMarksValid()
        {
            if ((!Regex.IsMatch(txtTotalMarksAC.Text, @"^[0-9]+$")) || txtTotalMarksAC.Text == "")
            {
                lblValid6.Show();
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int AsTotalWeightValid()
        {
            if ((!Regex.IsMatch(txtTotalWeightage.Text, @"^[0-9]+$")) || txtTotalWeightage.Text == "")
            {
                lblValid3.Show();
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
}
