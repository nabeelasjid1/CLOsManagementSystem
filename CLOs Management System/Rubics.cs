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
    public partial class Rubics : UserControl
    {
        int RubId = 0;
        int RubLvlId = 0;
        public Rubics()
        {
            InitializeComponent();
            fillCombo();
            LoadRubric();
        }
        public int getId(string str)
        {
            string query = "Select Id from Clo where Name = '" + str + "' ";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            int id = (int)sqlcmd.ExecuteScalar();
            DatabaseConnection.getInstance().closeConnection();
            return id;

        }
        private void btnRubSave_Click(object sender, EventArgs e)
        {
            
            try
            {
                int k = Convert.ToInt32(txtValue.Text) ;
                string query = "Insert Into Rubric(Id,Details, CloId) " +
                "Values('" + k + "', '" + txtDetails.Text + "', '" + getId(cmbCloName.Text) + "' )";

                string messege = "Rubric Added Successfully Against" + cmbCloName.Text;
                txtValue.Text = (Convert.ToInt32(txtValue.Text) + 1).ToString();
                crud(query, messege);
                display_data();
                LoadRubric();
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
                string query = "Select Rubric.Id,Details,Clo.Name from Rubric Inner Join Clo ON Rubric.CloId = Clo.Id";
                SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
                sqlcmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                da.Fill(dt);
                grdRub.DataSource = dt;
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
                string query = "Select RubricLevel.Id, Rubric.Details as Rubric,RubricLevel.Details,MeasurementLevel from RubricLevel Inner Join Rubric ON Rubric.Id = RubricLevel.RubricId";
                SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
                sqlcmd.ExecuteNonQuery();
                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
                da.Fill(dt);
                grdRubLvl.DataSource = dt;
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
            //Int32 Id = (Int32)sqlcmd.ExecuteScalar();
            MessageBox.Show(messege);
            clear();
            DatabaseConnection.getInstance().closeConnection();
        }
        private void clear()
        {
            txtDetails.Text = cmbCloName.Text = "";
        }
        private void clear1()
        {
            cmbLvl.Text = cmbRubicName.Text = txtRubLvlD.Text = "";
        }
        public void fillCombo()
        {
            string query = "Select * from Clo";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                cmbCloName.Items.Add(reader["Name"].ToString());
            }
            DatabaseConnection.getInstance().closeConnection();
        }
        private void cmbCloName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void grdStudent_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void Rubics_Load(object sender, EventArgs e)
        {
            string query = "Select MAX(Id) from Rubric";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            int count = Convert.ToInt32(sqlcmd.ExecuteScalar());
            txtValue.Text = (count+1).ToString();
            txtValue.Hide();
            btnDeleteRub.Hide();
            btnUpdateRub.Hide();
            btnDeleteRubLvl.Hide();
            btnUpdateRubLvl.Hide();
            display_data();
            display_data1();
        }

        private void grdRub_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RubId = Convert.ToInt32(grdRub.CurrentRow.Cells[0].Value.ToString());
            txtDetails.Text = grdRub.CurrentRow.Cells[1].Value.ToString();
            //string str = grdRub.CurrentRow.Cells[2].Value.ToString();
            cmbCloName.Text = grdRub.CurrentRow.Cells[2].Value.ToString();
            btnDeleteRub.Show();
            btnUpdateRub.Show();
        }
        public string getClo(int CloId)
        {
            string query = "Select Name from Clo where Id = '" + CloId + "' ";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            string name = (string)sqlcmd.ExecuteScalar();
            DatabaseConnection.getInstance().closeConnection();
            return name;

        }

        private void btnUpdateRub_Click(object sender, EventArgs e)
        {
            int k = Convert.ToInt32(txtValue.Text);
            if (txtDetails.Text != "")
            {
                string query = "Update Rubric Set Details = '" + txtDetails.Text + "', " +
                    "CloId = '" + getId(cmbCloName.Text) +  "' " + " Where Id = '" + RubId + "'";
                string messege = "Rubric Added Successfully Against" + cmbCloName.Text;
                crud(query, messege);
                display_data();
                LoadRubric();
            }
            else
            {
                MessageBox.Show("Required Fields are Empty");
            }
        }

        private void btnDeleteRub_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtDetails.Text != "")
                {
                    string query = "Delete Rubric Where Id = '" + RubId + "'";
                    string messege = "Rubric against "+cmbCloName.Text + " Deleted Successfully";
                    crud(query, messege);
                    display_data();
                    LoadRubric();
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
            string query = "Select Rubric.Id,Details,Clo.Name from Rubric Inner Join Clo ON Rubric.CloId = Clo.Id Where Name Like '" + txtSearch.Text + "%'";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            sqlcmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            da.Fill(dt);
            grdRub.DataSource = dt;
            DatabaseConnection.getInstance().closeConnection();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void cmbRubicName_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
        public void LoadRubric()
        {
            cmbRubicName.Items.Clear();
            string query = "Select * from Rubric";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                cmbRubicName.Items.Add(reader["Details"].ToString());
            }
            DatabaseConnection.getInstance().closeConnection();
        }

        private void btnSaveLvl_Click(object sender, EventArgs e)
        {
            try
            {
                //int k = Convert.ToInt32(txtValue.Text);
                string query = "Insert Into RubricLevel(RubricId,Details, MeasurementLevel) " +
                "Values('" + getRubId(cmbRubicName.Text) + "', '" + txtRubLvlD.Text + "', '" + cmbLvl.Text + "' )";

                string messege = "Rubric Level Added Successfully";
                //txtValue.Text = (Convert.ToInt32(txtValue.Text) + 1).ToString();
                crud(query, messege);
                display_data1();
                clear1();
                //LoadRubric();
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

        private void grdRubLvl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void btnDeleteRubLvl_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtRubLvlD.Text != "")
                {
                    string query = "Delete RubricLevel Where Id = '" + RubLvlId + "'";
                    string messege = "RubricLevel Deleted Successfully";
                    crud(query, messege);
                    display_data1();
                    clear1();
                    //LoadRubric();
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

        private void btnUpdateRubLvl_Click(object sender, EventArgs e)
        {
            //int k = Convert.ToInt32(txtValue.Text);
            if (txtRubLvlD.Text != "")
            {
                string query = "Update RubricLevel Set RubricId = '" + getRubId(cmbRubicName.Text) + "', " +
                    "Details = '" + txtRubLvlD.Text + "', " +
                    "MeasurementLevel = '" + cmbLvl.Text + "' " + " Where Id = '" + RubLvlId + "'";
                string messege = "Rubric Added Successfully Against" + cmbCloName.Text;
                crud(query, messege);
                display_data1();
                clear1();
            }
            else
            {
                MessageBox.Show("Required Fields are Empty");
            }
        }

        private void grdRubLvl_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            RubLvlId = Convert.ToInt32(grdRubLvl.CurrentRow.Cells[0].Value.ToString());
            cmbRubicName.Text = grdRubLvl.CurrentRow.Cells[1].Value.ToString();
            //string str = grdRub.CurrentRow.Cells[2].Value.ToString();
            txtRubLvlD.Text = grdRubLvl.CurrentRow.Cells[2].Value.ToString();
            cmbLvl.Text = grdRubLvl.CurrentRow.Cells[3].Value.ToString();
            btnDeleteRubLvl.Show();
            btnUpdateRubLvl.Show();
        }

        private void BtnSearchRubLvl_Click(object sender, EventArgs e)
        {
            //string query1 = "Select Rubric.Id,Details,Clo.Name from Rubric Inner Join Clo ON Rubric.CloId = Clo.Id Where Name Like '" + txtSearch.Text + "%'";
            string query = "Select RubricLevel.Id, Rubric.Details as Rubric,RubricLevel.Details,MeasurementLevel from RubricLevel Inner Join Rubric ON Rubric.Id = RubricLevel.RubricId Where Rubric.Details Like '"+txtSearchRubLvl.Text+"%'";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            sqlcmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            da.Fill(dt);
            grdRubLvl.DataSource = dt;
            DatabaseConnection.getInstance().closeConnection();
        }
    }
}
