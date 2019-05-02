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
using iTextSharp.text.pdf;
using iTextSharp.text;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ProgressBar;
using System.IO;

namespace CLOs_Management_System
{
    public partial class Evaluation : UserControl
    {
        public Evaluation()
        {
            InitializeComponent();
        }

        private void cmbStdId_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        public void fillAttDate()
        {
            cmbAttDate.Items.Clear();
            string query = "Select * from ClassAttendance";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                cmbAttDate.Items.Add(reader["AttendanceDate"].ToString());
            }
            DatabaseConnection.getInstance().closeConnection();
        }
        public void fillCmbACId()
        {
            cmbACId.Items.Clear();
            string query = "Select * from AssessmentComponent";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                cmbACId.Items.Add(reader["Name"].ToString());
            }
            DatabaseConnection.getInstance().closeConnection();
        }
        public void fillCmbRubricLvl()
        {
            cmbRubricLvl.Items.Clear();
            string query = "Select * from RubricLevel";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            SqlDataReader reader = sqlcmd.ExecuteReader();
            while (reader.Read())
            {
                cmbRubricLvl.Items.Add(reader["Details"].ToString());
            }
            DatabaseConnection.getInstance().closeConnection();
        }
        public int getACId(string str)
        {
            string query = "Select Id from AssessmentComponent where Name = '" + str + "' ";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            int id = (int)sqlcmd.ExecuteScalar();
            DatabaseConnection.getInstance().closeConnection();
            return id;

        }
        public int getStdId(string str)
        {
            string query = "Select Id from Student where FirstName = '" + str + "' ";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            int id = (int)sqlcmd.ExecuteScalar();
            DatabaseConnection.getInstance().closeConnection();
            return id;

        }
        public int getRubLvlId(string str)
        {
            string query = "Select Id from RubricLevel where Details = '" + str + "' ";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            int id = (int)sqlcmd.ExecuteScalar();
            DatabaseConnection.getInstance().closeConnection();
            return id;

        }
        private void Evaluation_Load(object sender, EventArgs e)
        {
            fillAttDate();
            lblMarks.Hide();
            //fillCmbStdId();
            fillCmbACId();
            fillCmbRubricLvl();
        }
        public int ValidEval()
        {
            string query = "Select count(*) from StudentResult where StudentId = '"+ getStdId(txtStdName.Text) + "' and AssessmentComponentId ='"+ getACId(cmbACId.Text) + "' ";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            Int32 count = (Int32)sqlcmd.ExecuteScalar();
            DatabaseConnection.getInstance().closeConnection();
            if (count == 1 || count > 1)
            {
                return 0;
            }
            else
            {
                return 1;
            }
            //
            
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            lblValid1.Hide();
            lblValid2.Hide();
            //lblValid3.Hide();
            if(RubLvlValid() == 0 || ACIdValid() == 0)
            {
                //StdRubLvlValid();
                RubLvlValid();
                ACIdValid();
                MessageBox.Show("Enter Valid Data");
            }
            else if(ValidEval() == 0)
            {
                MessageBox.Show("Student Result Against this Assessment Component Already Added");
                //obtainedMarks();
                lblMarks.Show();
            }
            else
            {
                try
                {
                    var myDateTime = DateTime.Now;
                    var sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
                    string query = "Insert Into StudentResult(StudentId,AssessmentComponentId, RubricMeasurementId,EvaluationDate) " +
                    "Values('" + getStdId(txtStdName.Text) + "', '" + getACId(cmbACId.Text) + "', '" + getRubLvlId(cmbRubricLvl.Text) + "','" + sqlFormattedDate + "' )";

                    string messege = "Result Added Successfully";
                    crud(query, messege);

                    lblMarks.Show();
                    clear();
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
            DatabaseConnection.getInstance().closeConnection();
            //obtainedMarks();
        }
        private void clear()
        {
            cmbRubricLvl.Text = cmbACId.Text = txtStdName.Text = ""; //= cmbStdRubLvl.Text = "";
        }
        

        private void btnDgvStd_Click(object sender, EventArgs e)
        {
            var myDateTime = Convert.ToDateTime(cmbAttDate.Text);
            var sqlFormattedDate = myDateTime.ToString("yyyy-MM-dd HH:mm:ss");
            string query = "Select Student.Id, Student.FirstName, Student.LastName, Student.RegistrationNumber from Student Inner Join StudentAttendance ON StudentAttendance.StudentId = Student.Id Inner Join ClassAttendance ON ClassAttendance.Id = StudentAttendance.AttendanceId Where ClassAttendance.AttendanceDate = '"+ sqlFormattedDate + "'";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            sqlcmd.ExecuteNonQuery();
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sqlcmd);
            da.Fill(dt);
            dgvStudents.DataSource = dt;
            DatabaseConnection.getInstance().closeConnection();
        }
        int StdId;
        private void dgvStudents_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            StdId = Convert.ToInt32(dgvStudents.CurrentRow.Cells[0].Value.ToString());
            txtStdName.Text = dgvStudents.CurrentRow.Cells[1].Value.ToString();
            txtStdName.Enabled = false;
        }
        public int ACIdValid()
        {
            if (cmbACId.Text == "")
            {
                lblValid1.Show();
                return 0;
            }
            else
            {
                return 1;
            }
        }
        public int RubLvlValid()
        {
            if (cmbRubricLvl.Text == "")
            {
                lblValid2.Show();
                return 0;
                
            }
            else
            {
                return 1;
            }
        }
        //public int StdRubLvlValid()
        //{
        //    if (cmbStdRubLvl.Text == "")
        //    {
        //        lblValid3.Show();
        //        return 0;

        //    }
        //    else
        //    {
        //        return 1;
        //    }
        //}
        public int obtainedMarks(int Id, string assComp, string rubLvl)
        {
            string query1 = "Select TotalMarks from AssessmentComponent where Id= '" + assComp + "'";
            string query2 = "Select MeasurementLevel from RubricLevel where Id = '" + rubLvl + "'";
            SqlCommand sqlcmd = new SqlCommand(query1, DatabaseConnection.getInstance().getConnection());
            int AssessmentComponentMarks = Convert.ToInt32(sqlcmd.ExecuteScalar());
            DatabaseConnection.getInstance().closeConnection();
            SqlCommand sqlcmd1 = new SqlCommand(query2, DatabaseConnection.getInstance().getConnection());
            int RubricMeasurementLevel = (int)sqlcmd1.ExecuteScalar();
            DatabaseConnection.getInstance().closeConnection();

            //int marks = ((Convert.ToInt32(cmbStdRubLvl.Text)) * (AssessmentComponentMarks)) / RubricMeasurementLevel;
            int marks = 0;
            return marks;
            //lblMarks.Text = Convert.ToString(marks);

        }
        DataTable CloWiseDataTabel()
        {
            DataTable CLO = new DataTable();
            CLO.Columns.Add("STudent Id");
            CLO.Columns.Add("CLO Name");
            CLO.Columns.Add("Marks Obtained");
            string query = "select count(*) from StudentResult";
            SqlCommand sqlcmd = new SqlCommand(query, DatabaseConnection.getInstance().getConnection());
            int TotalStudent = (int)sqlcmd.ExecuteScalar();
            string query1 = "Select DISTINCT StudentId, Clo.Name,Sum((MeasurementLevel * AssessmentComponent.TotalMarks) / 4) as ObtaintedMarks from StudentResult inner join RubricLevel on StudentResult.RubricMeasurementId = RubricLevel.Id inner join Rubric on Rubric.Id = RubricLevel.RubricId inner join Clo on Clo.Id = Rubric.CloId inner join AssessmentComponent on AssessmentComponent.RubricId = Rubric.Id Group By CLo.Name,StudentId";
            SqlCommand sqlcmd1 = new SqlCommand(query1, DatabaseConnection.getInstance().getConnection());
            SqlDataReader dr = sqlcmd1.ExecuteReader();
            while (dr.Read())
            {
                CLO.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }
    
            return CLO;
        }
        DataTable AssessmentWiseDataTabel()
        {
            DataTable Ass = new DataTable();
            Ass.Columns.Add("STudent Id");
            Ass.Columns.Add("Assessment Title");
            Ass.Columns.Add("Marks Obtained");
            string query1 = "Select StudentId, Assessment.Title, sum(TotalWeightage * AssessmentComponent.TotalMarks)/ sum(Assessment.TotalMarks) as ObtainedMarks from StudentResult inner join RubricLevel on StudentResult.RubricMeasurementId = RubricLevel.Id inner join Rubric on Rubric.Id = RubricLevel.RubricId inner join Clo on Clo.Id = Rubric.CloId inner join AssessmentComponent on AssessmentComponent.RubricId = Rubric.Id inner join Assessment on Assessment.Id = AssessmentComponent.AssessmentId Group By Assessment.Title,StudentId";
            SqlCommand sqlcmd1 = new SqlCommand(query1, DatabaseConnection.getInstance().getConnection());
            SqlDataReader dr = sqlcmd1.ExecuteReader();
            while (dr.Read())
            {
                Ass.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString());
            }

            return Ass;
        }
        void ExportDataTableToPdf(DataTable dtblTable, String strPdfPath, string strHeader)
        {
            System.IO.FileStream fs = new FileStream(strPdfPath, FileMode.Create, FileAccess.Write, FileShare.None);
            Document document = new Document();
            document.SetPageSize(iTextSharp.text.PageSize.A4);
            PdfWriter writer = PdfWriter.GetInstance(document, fs);
            document.Open();

            //Report Header
            BaseFont bfntHead = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntHead = new iTextSharp.text.Font(bfntHead, 16, 1, iTextSharp.text.Color.GRAY);
            Paragraph prgHeading = new Paragraph();
            prgHeading.Alignment = Element.ALIGN_CENTER;
            prgHeading.Add(new iTextSharp.text.Chunk(strHeader.ToUpper(), fntHead));
            document.Add(prgHeading);

            //Author
            Paragraph prgAuthor = new Paragraph();
            BaseFont btnAuthor = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntAuthor = new iTextSharp.text.Font(btnAuthor, 8, 2, iTextSharp.text.Color.GRAY);
            prgAuthor.Alignment = Element.ALIGN_RIGHT;
            prgAuthor.Add(new iTextSharp.text.Chunk("Author : CLO's Manager", fntAuthor));
            prgAuthor.Add(new iTextSharp.text.Chunk("\nRun Date : " + DateTime.Now.ToShortDateString(), fntAuthor));
            document.Add(prgAuthor);

            //Add a line seperation
            Paragraph p = new Paragraph(new iTextSharp.text.Chunk(new iTextSharp.text.pdf.draw.LineSeparator(0.0F, 100.0F, iTextSharp.text.Color.BLACK, Element.ALIGN_LEFT, 1)));
            document.Add(p);

            //Add line break
            document.Add(new iTextSharp.text.Chunk("\n", fntHead));

            //Write the table
            PdfPTable table = new PdfPTable(dtblTable.Columns.Count);
            //Table header
            BaseFont btnColumnHeader = BaseFont.CreateFont(BaseFont.TIMES_ROMAN, BaseFont.CP1252, BaseFont.NOT_EMBEDDED);
            iTextSharp.text.Font fntColumnHeader = new iTextSharp.text.Font(btnColumnHeader, 10, 1, iTextSharp.text.Color.WHITE);
            for (int i = 0; i < dtblTable.Columns.Count; i++)
            {
                PdfPCell cell = new PdfPCell();
                cell.BackgroundColor = iTextSharp.text.Color.GRAY;
                cell.AddElement(new iTextSharp.text.Chunk(dtblTable.Columns[i].ColumnName.ToUpper(), fntColumnHeader));
                table.AddCell(cell);
            }
            //table Data
            for (int i = 0; i < dtblTable.Rows.Count; i++)
            {
                for (int j = 0; j < dtblTable.Columns.Count; j++)
                {
                    table.AddCell(dtblTable.Rows[i][j].ToString());
                }
            }

            document.Add(table);
            document.Close();
            writer.Close();
            fs.Close();
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtbl = CloWiseDataTabel();
                ExportDataTableToPdf(dtbl, @"E:\cloWiseResult.pdf", "CLO's Wise Result List");
                
                    System.Diagnostics.Process.Start(@"E:\cloWiseResult.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Close the File in PDF Reader and Try Again :D");
            }
            
        }

        private void btnAssResult_Click(object sender, EventArgs e)
        {
            try
            {
                DataTable dtbl = AssessmentWiseDataTabel();
                ExportDataTableToPdf(dtbl, @"E:\assessmentWiseResult.pdf", "Assessment's Wise Result List");

                System.Diagnostics.Process.Start(@"E:\assessmentWiseResult.pdf");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Please Close the File in PDF Reader and Try Again :D");
            }
        }
    }
}
