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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblValid2 = new System.Windows.Forms.Label();
            this.lblValid3 = new System.Windows.Forms.Label();
            this.lblValid5 = new System.Windows.Forms.Label();
            this.lblValid6 = new System.Windows.Forms.Label();
            this.lblValid4 = new System.Windows.Forms.Label();
            this.lblValid1 = new System.Windows.Forms.Label();
            this.lblRequired6 = new System.Windows.Forms.Label();
            this.lblRequired2 = new System.Windows.Forms.Label();
            this.lblRequired3 = new System.Windows.Forms.Label();
            this.lblRequired4 = new System.Windows.Forms.Label();
            this.lblRequired5 = new System.Windows.Forms.Label();
            this.lblRequired1 = new System.Windows.Forms.Label();
            this.btnUpdateStd = new System.Windows.Forms.Button();
            this.btnDeleteStd = new System.Windows.Forms.Button();
            this.btnStdSave = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblStatus = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grdStudent = new System.Windows.Forms.DataGridView();
            this.errorFirstName = new System.Windows.Forms.ErrorProvider(this.components);
            this.txtSearch = new System.Windows.Forms.PlaceholderTextBox();
            this.txtRegNumber = new System.Windows.Forms.PlaceholderTextBox();
            this.txtEmail = new System.Windows.Forms.PlaceholderTextBox();
            this.txtContact = new System.Windows.Forms.PlaceholderTextBox();
            this.txtLastName = new System.Windows.Forms.PlaceholderTextBox();
            this.txtFirstName = new System.Windows.Forms.PlaceholderTextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorFirstName)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lblValid2);
            this.panel1.Controls.Add(this.lblValid3);
            this.panel1.Controls.Add(this.lblValid5);
            this.panel1.Controls.Add(this.lblValid6);
            this.panel1.Controls.Add(this.lblValid4);
            this.panel1.Controls.Add(this.lblValid1);
            this.panel1.Controls.Add(this.lblRequired6);
            this.panel1.Controls.Add(this.lblRequired2);
            this.panel1.Controls.Add(this.lblRequired3);
            this.panel1.Controls.Add(this.lblRequired4);
            this.panel1.Controls.Add(this.lblRequired5);
            this.panel1.Controls.Add(this.lblRequired1);
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
            this.panel1.Size = new System.Drawing.Size(800, 136);
            this.panel1.TabIndex = 4;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // lblValid2
            // 
            this.lblValid2.AutoSize = true;
            this.lblValid2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValid2.ForeColor = System.Drawing.Color.Red;
            this.lblValid2.Location = new System.Drawing.Point(139, 62);
            this.lblValid2.Name = "lblValid2";
            this.lblValid2.Size = new System.Drawing.Size(100, 12);
            this.lblValid2.TabIndex = 60;
            this.lblValid2.Text = "String Format Incorrect";
            // 
            // lblValid3
            // 
            this.lblValid3.AutoSize = true;
            this.lblValid3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValid3.ForeColor = System.Drawing.Color.Red;
            this.lblValid3.Location = new System.Drawing.Point(268, 62);
            this.lblValid3.Name = "lblValid3";
            this.lblValid3.Size = new System.Drawing.Size(109, 12);
            this.lblValid3.TabIndex = 59;
            this.lblValid3.Text = "Contact Format Incorrect";
            // 
            // lblValid5
            // 
            this.lblValid5.AutoSize = true;
            this.lblValid5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValid5.ForeColor = System.Drawing.Color.Red;
            this.lblValid5.Location = new System.Drawing.Point(521, 59);
            this.lblValid5.Name = "lblValid5";
            this.lblValid5.Size = new System.Drawing.Size(100, 12);
            this.lblValid5.TabIndex = 58;
            this.lblValid5.Text = "String Format Incorrect";
            // 
            // lblValid6
            // 
            this.lblValid6.AutoSize = true;
            this.lblValid6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValid6.ForeColor = System.Drawing.Color.Red;
            this.lblValid6.Location = new System.Drawing.Point(677, 62);
            this.lblValid6.Name = "lblValid6";
            this.lblValid6.Size = new System.Drawing.Size(80, 12);
            this.lblValid6.TabIndex = 57;
            this.lblValid6.Text = "Please Select One";
            // 
            // lblValid4
            // 
            this.lblValid4.AutoSize = true;
            this.lblValid4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValid4.ForeColor = System.Drawing.Color.Red;
            this.lblValid4.Location = new System.Drawing.Point(395, 62);
            this.lblValid4.Name = "lblValid4";
            this.lblValid4.Size = new System.Drawing.Size(99, 12);
            this.lblValid4.TabIndex = 56;
            this.lblValid4.Text = "Email Format Incorrect";
            // 
            // lblValid1
            // 
            this.lblValid1.AutoSize = true;
            this.lblValid1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblValid1.ForeColor = System.Drawing.Color.Red;
            this.lblValid1.Location = new System.Drawing.Point(10, 59);
            this.lblValid1.Name = "lblValid1";
            this.lblValid1.Size = new System.Drawing.Size(100, 12);
            this.lblValid1.TabIndex = 55;
            this.lblValid1.Text = "String Format Incorrect";
            // 
            // lblRequired6
            // 
            this.lblRequired6.AutoSize = true;
            this.lblRequired6.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired6.ForeColor = System.Drawing.Color.Red;
            this.lblRequired6.Location = new System.Drawing.Point(675, 47);
            this.lblRequired6.Name = "lblRequired6";
            this.lblRequired6.Size = new System.Drawing.Size(46, 12);
            this.lblRequired6.TabIndex = 54;
            this.lblRequired6.Text = "Required*";
            // 
            // lblRequired2
            // 
            this.lblRequired2.AutoSize = true;
            this.lblRequired2.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired2.ForeColor = System.Drawing.Color.Red;
            this.lblRequired2.Location = new System.Drawing.Point(139, 47);
            this.lblRequired2.Name = "lblRequired2";
            this.lblRequired2.Size = new System.Drawing.Size(46, 12);
            this.lblRequired2.TabIndex = 53;
            this.lblRequired2.Text = "Required*";
            // 
            // lblRequired3
            // 
            this.lblRequired3.AutoSize = true;
            this.lblRequired3.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired3.ForeColor = System.Drawing.Color.Red;
            this.lblRequired3.Location = new System.Drawing.Point(268, 47);
            this.lblRequired3.Name = "lblRequired3";
            this.lblRequired3.Size = new System.Drawing.Size(46, 12);
            this.lblRequired3.TabIndex = 52;
            this.lblRequired3.Text = "Required*";
            // 
            // lblRequired4
            // 
            this.lblRequired4.AutoSize = true;
            this.lblRequired4.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired4.ForeColor = System.Drawing.Color.Red;
            this.lblRequired4.Location = new System.Drawing.Point(395, 47);
            this.lblRequired4.Name = "lblRequired4";
            this.lblRequired4.Size = new System.Drawing.Size(46, 12);
            this.lblRequired4.TabIndex = 51;
            this.lblRequired4.Text = "Required*";
            // 
            // lblRequired5
            // 
            this.lblRequired5.AutoSize = true;
            this.lblRequired5.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired5.ForeColor = System.Drawing.Color.Red;
            this.lblRequired5.Location = new System.Drawing.Point(521, 47);
            this.lblRequired5.Name = "lblRequired5";
            this.lblRequired5.Size = new System.Drawing.Size(46, 12);
            this.lblRequired5.TabIndex = 50;
            this.lblRequired5.Text = "Required*";
            this.lblRequired5.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblRequired1
            // 
            this.lblRequired1.AutoSize = true;
            this.lblRequired1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRequired1.ForeColor = System.Drawing.Color.Red;
            this.lblRequired1.Location = new System.Drawing.Point(10, 47);
            this.lblRequired1.Name = "lblRequired1";
            this.lblRequired1.Size = new System.Drawing.Size(46, 12);
            this.lblRequired1.TabIndex = 49;
            this.lblRequired1.Text = "Required*";
            // 
            // btnUpdateStd
            // 
            this.btnUpdateStd.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateStd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStd.Location = new System.Drawing.Point(121, 94);
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
            this.btnDeleteStd.Location = new System.Drawing.Point(231, 94);
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
            this.btnStdSave.Location = new System.Drawing.Point(12, 94);
            this.btnStdSave.Name = "btnStdSave";
            this.btnStdSave.Size = new System.Drawing.Size(100, 23);
            this.btnStdSave.TabIndex = 46;
            this.btnStdSave.Text = "Save Student";
            this.btnStdSave.UseVisualStyleBackColor = true;
            this.btnStdSave.Click += new System.EventHandler(this.btnStdSave_Click);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel5.Location = new System.Drawing.Point(523, 41);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(100, 3);
            this.panel5.TabIndex = 44;
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
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel2.Location = new System.Drawing.Point(141, 41);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(100, 3);
            this.panel2.TabIndex = 40;
            // 
            // cmbStatus
            // 
            this.cmbStatus.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbStatus.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Items.AddRange(new object[] {
            "Active",
            "Not Active"});
            this.cmbStatus.Location = new System.Drawing.Point(722, 23);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(47, 21);
            this.cmbStatus.TabIndex = 38;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel7.Location = new System.Drawing.Point(12, 41);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 3);
            this.panel7.TabIndex = 27;
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
            this.panel8.Location = new System.Drawing.Point(582, 160);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(120, 3);
            this.panel8.TabIndex = 40;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(708, 142);
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
            // 
            // errorFirstName
            // 
            this.errorFirstName.ContainerControl = this;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(582, 147);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search Reg#.....";
            this.txtSearch.PlaceholderTextColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.Size = new System.Drawing.Size(82, 13);
            this.txtSearch.TabIndex = 41;
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
            // txtEmail
            // 
            this.txtEmail.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtEmail.Location = new System.Drawing.Point(397, 28);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PlaceholderText = "Email";
            this.txtEmail.PlaceholderTextColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtEmail.Size = new System.Drawing.Size(82, 13);
            this.txtEmail.TabIndex = 41;
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
            // txtFirstName
            // 
            this.txtFirstName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtFirstName.Location = new System.Drawing.Point(12, 28);
            this.txtFirstName.Name = "txtFirstName";
            this.txtFirstName.PlaceholderText = "First Name";
            this.txtFirstName.PlaceholderTextColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtFirstName.Size = new System.Drawing.Size(82, 13);
            this.txtFirstName.TabIndex = 39;
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
            ((System.ComponentModel.ISupportInitialize)(this.errorFirstName)).EndInit();
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
        private System.Windows.Forms.Label lblRequired1;
        private System.Windows.Forms.Label lblRequired6;
        private System.Windows.Forms.Label lblRequired2;
        private System.Windows.Forms.Label lblRequired3;
        private System.Windows.Forms.Label lblRequired4;
        private System.Windows.Forms.Label lblRequired5;
        private System.Windows.Forms.Label lblValid2;
        private System.Windows.Forms.Label lblValid3;
        private System.Windows.Forms.Label lblValid5;
        private System.Windows.Forms.Label lblValid6;
        private System.Windows.Forms.Label lblValid4;
        private System.Windows.Forms.Label lblValid1;
        private System.Windows.Forms.ErrorProvider errorFirstName;
    }
}
