namespace CLOs_Management_System
{
    partial class Assessment
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
            this.btnUpdateAss = new System.Windows.Forms.Button();
            this.btnDeleteAss = new System.Windows.Forms.Button();
            this.btnSaveAss = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnSearchAss = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.grdAssessment = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearchAss = new System.Windows.Forms.PlaceholderTextBox();
            this.txtTotalWeightage = new System.Windows.Forms.PlaceholderTextBox();
            this.txtTotalMarks = new System.Windows.Forms.PlaceholderTextBox();
            this.txtTitle = new System.Windows.Forms.PlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssessment)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateAss
            // 
            this.btnUpdateAss.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateAss.Location = new System.Drawing.Point(123, 62);
            this.btnUpdateAss.Name = "btnUpdateAss";
            this.btnUpdateAss.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateAss.TabIndex = 48;
            this.btnUpdateAss.Text = "Update Student";
            this.btnUpdateAss.UseVisualStyleBackColor = true;
            this.btnUpdateAss.Click += new System.EventHandler(this.btnUpdateAss_Click);
            // 
            // btnDeleteAss
            // 
            this.btnDeleteAss.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteAss.Location = new System.Drawing.Point(233, 62);
            this.btnDeleteAss.Name = "btnDeleteAss";
            this.btnDeleteAss.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteAss.TabIndex = 47;
            this.btnDeleteAss.Text = "Delete Asses";
            this.btnDeleteAss.UseVisualStyleBackColor = true;
            this.btnDeleteAss.Click += new System.EventHandler(this.btnDeleteAss_Click);
            // 
            // btnSaveAss
            // 
            this.btnSaveAss.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveAss.Location = new System.Drawing.Point(14, 62);
            this.btnSaveAss.Name = "btnSaveAss";
            this.btnSaveAss.Size = new System.Drawing.Size(100, 23);
            this.btnSaveAss.TabIndex = 46;
            this.btnSaveAss.Text = "Save Asses";
            this.btnSaveAss.UseVisualStyleBackColor = true;
            this.btnSaveAss.Click += new System.EventHandler(this.btnSaveAss_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(233, 40);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(80, 3);
            this.panel4.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(123, 40);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 3);
            this.panel3.TabIndex = 42;
            // 
            // btnSearchAss
            // 
            this.btnSearchAss.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearchAss.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchAss.Location = new System.Drawing.Point(140, 122);
            this.btnSearchAss.Name = "btnSearchAss";
            this.btnSearchAss.Size = new System.Drawing.Size(70, 23);
            this.btnSearchAss.TabIndex = 52;
            this.btnSearchAss.Text = "Search";
            this.btnSearchAss.UseVisualStyleBackColor = true;
            this.btnSearchAss.Click += new System.EventHandler(this.btnSearchAss_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel8.Location = new System.Drawing.Point(14, 140);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(120, 3);
            this.panel8.TabIndex = 50;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel7.Location = new System.Drawing.Point(12, 40);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 3);
            this.panel7.TabIndex = 27;
            // 
            // grdAssessment
            // 
            this.grdAssessment.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdAssessment.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdAssessment.Location = new System.Drawing.Point(12, 173);
            this.grdAssessment.Name = "grdAssessment";
            this.grdAssessment.Size = new System.Drawing.Size(371, 266);
            this.grdAssessment.TabIndex = 53;
            this.grdAssessment.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAssessment_CellClick);
            this.grdAssessment.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAssessment_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateAss);
            this.panel1.Controls.Add(this.btnDeleteAss);
            this.panel1.Controls.Add(this.btnSaveAss);
            this.panel1.Controls.Add(this.txtTotalWeightage);
            this.panel1.Controls.Add(this.txtTotalMarks);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtTitle);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 97);
            this.panel1.TabIndex = 49;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtSearchAss
            // 
            this.txtSearchAss.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearchAss.Location = new System.Drawing.Point(14, 127);
            this.txtSearchAss.Name = "txtSearchAss";
            this.txtSearchAss.PlaceholderText = "Search Asses.....";
            this.txtSearchAss.PlaceholderTextColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearchAss.Size = new System.Drawing.Size(82, 13);
            this.txtSearchAss.TabIndex = 51;
            // 
            // txtTotalWeightage
            // 
            this.txtTotalWeightage.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalWeightage.Location = new System.Drawing.Point(233, 27);
            this.txtTotalWeightage.Name = "txtTotalWeightage";
            this.txtTotalWeightage.PlaceholderText = "Total Weightage";
            this.txtTotalWeightage.PlaceholderTextColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtTotalWeightage.Size = new System.Drawing.Size(82, 13);
            this.txtTotalWeightage.TabIndex = 41;
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTotalMarks.Location = new System.Drawing.Point(123, 27);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.PlaceholderText = "Total Marks";
            this.txtTotalMarks.PlaceholderTextColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtTotalMarks.Size = new System.Drawing.Size(82, 13);
            this.txtTotalMarks.TabIndex = 43;
            // 
            // txtTitle
            // 
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTitle.Location = new System.Drawing.Point(12, 27);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.PlaceholderText = "Title";
            this.txtTitle.PlaceholderTextColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtTitle.Size = new System.Drawing.Size(82, 13);
            this.txtTitle.TabIndex = 39;
            // 
            // Assessment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.txtSearchAss);
            this.Controls.Add(this.btnSearchAss);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.grdAssessment);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(200, 60);
            this.Name = "Assessment";
            this.Size = new System.Drawing.Size(800, 440);
            this.Load += new System.EventHandler(this.Assessment_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAssessment)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PlaceholderTextBox txtSearchAss;
        private System.Windows.Forms.Button btnUpdateAss;
        private System.Windows.Forms.Button btnDeleteAss;
        private System.Windows.Forms.Button btnSaveAss;
        private System.Windows.Forms.PlaceholderTextBox txtTotalWeightage;
        private System.Windows.Forms.PlaceholderTextBox txtTotalMarks;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnSearchAss;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.DataGridView grdAssessment;
        private System.Windows.Forms.PlaceholderTextBox txtTitle;
        private System.Windows.Forms.Panel panel1;
    }
}
