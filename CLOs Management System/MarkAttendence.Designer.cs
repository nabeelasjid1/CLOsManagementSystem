namespace CLOs_Management_System
{
    partial class MarkAttendence
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
            this.dgvMarkAttendence = new System.Windows.Forms.DataGridView();
            this.Attendance = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnsubmit = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkAttendence)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsubmit)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMarkAttendence
            // 
            this.dgvMarkAttendence.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvMarkAttendence.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvMarkAttendence.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMarkAttendence.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Attendance});
            this.dgvMarkAttendence.GridColor = System.Drawing.SystemColors.Control;
            this.dgvMarkAttendence.Location = new System.Drawing.Point(0, 0);
            this.dgvMarkAttendence.Name = "dgvMarkAttendence";
            this.dgvMarkAttendence.Size = new System.Drawing.Size(800, 232);
            this.dgvMarkAttendence.TabIndex = 2;
            this.dgvMarkAttendence.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMarkAttendence_CellContentClick_1);
            // 
            // Attendance
            // 
            this.Attendance.HeaderText = "Attendance";
            this.Attendance.Name = "Attendance";
            // 
            // btnsubmit
            // 
            this.btnsubmit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnsubmit.Image = global::CLOs_Management_System.Properties.Resources.submit_button;
            this.btnsubmit.Location = new System.Drawing.Point(12, 238);
            this.btnsubmit.Name = "btnsubmit";
            this.btnsubmit.Size = new System.Drawing.Size(100, 33);
            this.btnsubmit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.btnsubmit.TabIndex = 1;
            this.btnsubmit.TabStop = false;
            this.btnsubmit.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // MarkAttendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.Controls.Add(this.dgvMarkAttendence);
            this.Controls.Add(this.btnsubmit);
            this.Location = new System.Drawing.Point(0, 140);
            this.Name = "MarkAttendence";
            this.Size = new System.Drawing.Size(800, 300);
            this.Load += new System.EventHandler(this.MarkAttendence_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMarkAttendence)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnsubmit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox btnsubmit;
        private System.Windows.Forms.DataGridView dgvMarkAttendence;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Attendance;
    }
}
