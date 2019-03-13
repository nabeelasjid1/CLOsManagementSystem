using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLOs_Management_System
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            Main main = new Main();
            Controls.Add(main);
            main.BringToFront();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Controls.Add(main);
            main.BringToFront();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox12_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void Students_Click(object sender, EventArgs e)
        {
            StudentManage std = new StudentManage();
            Controls.Add(std);
            std.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CLOsManage clo = new CLOsManage();
            Controls.Add(clo);
            clo.BringToFront();
        }

        private void BtnRubricsTab_Click(object sender, EventArgs e)
        {
            Rubics rub = new Rubics();
            Controls.Add(rub);
            rub.BringToFront();
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BtnAssessmentsTab_Click(object sender, EventArgs e)
        {
            Assessment ass = new Assessment();
            Controls.Add(ass);
            ass.BringToFront();
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnAttendenceTab_Click(object sender, EventArgs e)
        {
            Attendence att = new Attendence();
            Controls.Add(att);
            att.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Evaluation eval = new Evaluation();
            Controls.Add(eval);
            eval.BringToFront();
        }
    }
}
