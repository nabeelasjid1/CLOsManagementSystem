namespace CLOs_Management_System
{
    partial class StudentManage
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
            this.btnUpdateStd = new System.Windows.Forms.Button();
            this.btnDeleteStd = new System.Windows.Forms.Button();
            this.btnStdSave = new System.Windows.Forms.Button();
            this.txtRegNumber = new System.Windows.Forms.PlaceholderTextBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.txtEmail = new System.Windows.Forms.PlaceholderTextBox();
            this.txtContact = new System.Windows.Forms.PlaceholderTextBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtLastName = new System.Windows.Forms.PlaceholderTextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtFirstName = new System.Windows.Forms.PlaceholderTextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdStudent = new System.Windows.Forms.DataGridView();
            this.txtSearch = new System.Windows.Forms.PlaceholderTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudent)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnUpdateStd);
            this.panel1.Controls.Add(this.btnDeleteStd);
            this.panel1.Controls.Add(this.btnStdSave);
            this.panel1.Controls.Add(this.txtRegNumber);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.txtContact);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.txtLastName);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.txtFirstName);
            this.panel1.Controls.Add(this.cmbStatus);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Controls.Add(this.lblStatus);
            this.panel1.Controls.Add(this.panel6);
            this.panel1.Location = new System.Drawing.Point(1, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnUpdateStd
            // 
            this.btnUpdateStd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStd.Location = new System.Drawing.Point(121, 65);
            this.btnUpdateStd.Name = "btnUpdateStd";
            this.btnUpdateStd.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateStd.TabIndex = 48;
            this.btnUpdateStd.Text = "Update Student";
            this.btnUpdateStd.UseVisualStyleBackColor = true;
            this.btnUpdateStd.Click += new System.EventHandler(this.btnUpdateStd_Click);
            // 
            // btnDeleteStd
            // 
            this.btnDeleteStd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStd.Location = new System.Drawing.Point(231, 65);
            this.btnDeleteStd.Name = "btnDeleteStd";
            this.btnDeleteStd.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteStd.TabIndex = 47;
            this.btnDeleteStd.Text = "Delete Student";
            this.btnDeleteStd.UseVisualStyleBackColor = true;
            this.btnDeleteStd.Click += new System.EventHandler(this.btnDeleteStd_Click);
            // 
            // btnStdSave
            // 
            this.btnStdSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnStdSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStdSave.Location = new System.Drawing.Point(12, 65);
            this.btnStdSave.Name = "btnStdSave";
            this.btnStdSave.Size = new System.Drawing.Size(100, 23);
            this.btnStdSave.TabIndex = 46;
            this.btnStdSave.Text = "Save Student";
            this.btnStdSave.UseVisualStyleBackColor = true;
            this.btnStdSave.Click += new System.EventHandler(this.btnStdSave_Click);
            // 
            // txtRegNumber
            // 
            this.txtRegNumber.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRegNumber.Location = new System.Drawing.Point(523, 28);
            this.txtRegNumber.Name = "txtRegNumber";
            this.txtRegNumber.PlaceholderText = "Reg Number";
            this.txtRegNumber.PlaceholderTextColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtRegNumber.Size = new System.Drawing.Size(82, 13);
            this.txtRegNumber.TabIndex = 45;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(523, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 3);
            this.panel5.TabIndex = 44;
            // 
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(397, 28);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.PlaceholderTextColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtEmail.Size = new System.Drawing.Size(82, 13);
            this.txtEmail.TabIndex = 41;
            this.txtEmail.TextChanged += new System.EventHandler(this.placeholderTextBox3_TextChanged);
            // 
            // txtContact
            // 
            this.txtContact.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtContact.Location = new System.Drawing.Point(270, 28);
            this.txtContact.Name = "txtContact";
            this.txtContact.PlaceholderText = "Contact";
            this.txtContact.PlaceholderTextColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtContact.Size = new System.Drawing.Size(82, 13);
            this.txtContact.TabIndex = 43;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel4.Location = new System.Drawing.Point(397, 41);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(100, 3);
            this.panel4.TabIndex = 40;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel3.Location = new System.Drawing.Point(270, 41);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(100, 3);
            this.panel3.TabIndex = 42;
            // 
            // txtLastName
            // 
            this.txtLastName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastName.Location = new System.Drawing.Point(141, 28);
            this.txtLastName.Name = "txtLastName";
            this.txtLastName.PlaceholderText = "Last Name";
            this.txtLastName.PlaceholderTextColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtLastName.Size = new System.Drawing.Size(82, 13);
            this.txtLastName.TabIndex = 41;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(141, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 3);
            this.panel2.TabIndex = 40;
            // 
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Location = new System.Drawing.Point(12, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.PlaceholderTextColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtFirstName.Size = new System.Drawing.Size(82, 13);
            this.txtFirstName.TabIndex = 39;
            this.txtFirstName.TextChanged += new System.EventHandler(this.txtFirstName_TextChanged_1);
            // 
            // cmbStatus
            // 
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Regular Student",
            "Not Regular Student"});
            this.cmbStatus.Location = new System.Drawing.Point(722, 23);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(47, 21);
            this.cmbStatus.TabIndex = 38;
            this.cmbStatus.SelectedIndexChanged += new System.EventHandler(this.cmbStatus_SelectedIndexChanged);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel7.Location = new System.Drawing.Point(12, 41);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 3);
            this.panel7.TabIndex = 27;
            this.panel7.Paint += new System.Windows.Forms.PaintEventHandler(this.panel7_Paint);
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Candara", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.SystemColors.Desktop;
            this.lblStatus.Location = new System.Drawing.Point(674, 29);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(42, 15);
            this.lblStatus.TabIndex = 25;
            this.lblStatus.Text = "Status";
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.SystemColors.Desktop;
            this.panel6.Location = new System.Drawing.Point(722, 43);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(47, 3);
            this.panel6.TabIndex = 31;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel8.Location = new System.Drawing.Point(585, 136);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(120, 3);
            this.panel8.TabIndex = 40;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(711, 118);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 23);
            this.btnSearch.TabIndex = 47;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grdStudent
            // 
            this.grdStudent.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudent.Location = new System.Drawing.Point(13, 171);
            this.grdStudent.Name = "grdStudent";
            this.grdStudent.Size = new System.Drawing.Size(765, 266);
            this.grdStudent.TabIndex = 48;
            this.grdStudent.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudent_CellClick);
            this.grdStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudent_CellContentClick);
            this.grdStudent.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudent_CellContentDoubleClick);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(585, 123);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search Reg#.....";
            this.txtSearch.PlaceholderTextColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.Size = new System.Drawing.Size(82, 13);
            this.txtSearch.TabIndex = 41;
            // 
            // StudentManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grdStudent);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(200, 60);
            this.Name = "StudentManage";
            this.Size = new System.Drawing.Size(800, 440);
            this.Load += new System.EventHandler(this.StudentManage_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudent)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PlaceholderTextBox txtFirstName;
        private System.Windows.Forms.PlaceholderTextBox txtRegNumber;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.PlaceholderTextBox txtEmail;
        private System.Windows.Forms.PlaceholderTextBox txtContact;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.PlaceholderTextBox txtLastName;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnStdSave;
        private System.Windows.Forms.PlaceholderTextBox txtSearch;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.DataGridView grdStudent;
        private System.Windows.Forms.Button btnUpdateStd;
        private System.Windows.Forms.Button btnDeleteStd;
    }
}
