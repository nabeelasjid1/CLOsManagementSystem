namespace CLOs_Management_System
{
    partial class Attendence
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.CheckStatus = new System.Windows.Forms.PictureBox();
            this.ClassAttendence = new System.Windows.Forms.PictureBox();
            this.MarkAttendence = new System.Windows.Forms.PictureBox();
            this.lblMarkAtt = new System.Windows.Forms.Label();
            this.lblClassAtt = new System.Windows.Forms.Label();
            this.lblCheckStatus = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CheckStatus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassAttendence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkAttendence)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CheckStatus);
            this.panel1.Controls.Add(this.ClassAttendence);
            this.panel1.Controls.Add(this.MarkAttendence);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // CheckStatus
            // 
            this.CheckStatus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CheckStatus.Image = global::CLOs_Management_System.Properties.Resources.fb5b958f;
            this.CheckStatus.Location = new System.Drawing.Point(341, 0);
            this.CheckStatus.Name = "CheckStatus";
            this.CheckStatus.Size = new System.Drawing.Size(100, 100);
            this.CheckStatus.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.CheckStatus.TabIndex = 2;
            this.CheckStatus.TabStop = false;
            this.CheckStatus.Click += new System.EventHandler(this.CheckStatus_Click);
            // 
            // ClassAttendence
            // 
            this.ClassAttendence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ClassAttendence.Image = global::CLOs_Management_System.Properties.Resources.community_student_icon;
            this.ClassAttendence.Location = new System.Drawing.Point(515, 0);
            this.ClassAttendence.Name = "ClassAttendence";
            this.ClassAttendence.Size = new System.Drawing.Size(100, 100);
            this.ClassAttendence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ClassAttendence.TabIndex = 1;
            this.ClassAttendence.TabStop = false;
            // 
            // MarkAttendence
            // 
            this.MarkAttendence.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MarkAttendence.Image = global::CLOs_Management_System.Properties.Resources.compliance_png__1170x0_q85_subsampling_2_upscale;
            this.MarkAttendence.Location = new System.Drawing.Point(167, 0);
            this.MarkAttendence.Name = "MarkAttendence";
            this.MarkAttendence.Size = new System.Drawing.Size(100, 100);
            this.MarkAttendence.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.MarkAttendence.TabIndex = 0;
            this.MarkAttendence.TabStop = false;
            this.MarkAttendence.Click += new System.EventHandler(this.MarkAttendence_Click);
            // 
            // lblMarkAtt
            // 
            this.lblMarkAtt.AutoSize = true;
            this.lblMarkAtt.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMarkAtt.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblMarkAtt.Location = new System.Drawing.Point(144, 103);
            this.lblMarkAtt.Name = "lblMarkAtt";
            this.lblMarkAtt.Size = new System.Drawing.Size(147, 23);
            this.lblMarkAtt.TabIndex = 1;
            this.lblMarkAtt.Text = "Mark Attendence";
            this.lblMarkAtt.Click += new System.EventHandler(this.lblMarkAtt_Click);
            // 
            // lblClassAtt
            // 
            this.lblClassAtt.AutoSize = true;
            this.lblClassAtt.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClassAtt.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblClassAtt.Location = new System.Drawing.Point(492, 103);
            this.lblClassAtt.Name = "lblClassAtt";
            this.lblClassAtt.Size = new System.Drawing.Size(146, 23);
            this.lblClassAtt.TabIndex = 2;
            this.lblClassAtt.Text = "Class Attendence";
            // 
            // lblCheckStatus
            // 
            this.lblCheckStatus.AutoSize = true;
            this.lblCheckStatus.Font = new System.Drawing.Font("Sitka Text", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCheckStatus.ForeColor = System.Drawing.SystemColors.MenuText;
            this.lblCheckStatus.Location = new System.Drawing.Point(335, 103);
            this.lblCheckStatus.Name = "lblCheckStatus";
            this.lblCheckStatus.Size = new System.Drawing.Size(113, 23);
            this.lblCheckStatus.TabIndex = 3;
            this.lblCheckStatus.Text = "Check Status";
            // 
            // Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.lblCheckStatus);
            this.Controls.Add(this.lblClassAtt);
            this.Controls.Add(this.lblMarkAtt);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(200, 60);
            this.Name = "Attendence";
            this.Size = new System.Drawing.Size(800, 440);
            this.Load += new System.EventHandler(this.Attendence_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.CheckStatus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ClassAttendence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarkAttendence)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox CheckStatus;
        private System.Windows.Forms.PictureBox ClassAttendence;
        private System.Windows.Forms.PictureBox MarkAttendence;
        private System.Windows.Forms.Label lblMarkAtt;
        private System.Windows.Forms.Label lblClassAtt;
        private System.Windows.Forms.Label lblCheckStatus;
    }
}
