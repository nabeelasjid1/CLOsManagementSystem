using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CLOs_Management_System
{
    public partial class Attendence : UserControl
    {
        public Attendence()
        {
            InitializeComponent();
        }

        private void Attendence_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MarkAttendence_Click(object sender, EventArgs e)
        {
            MarkAttendence markatt = new MarkAttendence();
            Controls.Add(markatt);
            markatt.BringToFront();
        }

        private void lblMarkAtt_Click(object sender, EventArgs e)
        {

        }

        private void CheckStatus_Click(object sender, EventArgs e)
        {
            CheckStatus check = new CheckStatus();
            Controls.Add(check);
            check.BringToFront();
        }
    }
}
