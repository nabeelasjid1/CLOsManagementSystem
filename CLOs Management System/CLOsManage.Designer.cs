namespace CLOs_Management_System
{
    partial class CLOsManage
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
            this.btnUpdateClo = new System.Windows.Forms.Button();
            this.btnDeleteClo = new System.Windows.Forms.Button();
            this.btnSaveClo = new System.Windows.Forms.Button();
            this.panel7 = new System.Windows.Forms.Panel();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.grdStudent = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtSearch = new System.Windows.Forms.PlaceholderTextBox();
            this.txtName = new System.Windows.Forms.PlaceholderTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdStudent)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpdateClo
            // 
            this.btnUpdateClo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnUpdateClo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateClo.Location = new System.Drawing.Point(118, 65);
            this.btnUpdateClo.Name = "btnUpdateClo";
            this.btnUpdateClo.Size = new System.Drawing.Size(100, 23);
            this.btnUpdateClo.TabIndex = 48;
            this.btnUpdateClo.Text = "Update Student";
            this.btnUpdateClo.UseVisualStyleBackColor = true;
            this.btnUpdateClo.Click += new System.EventHandler(this.btnUpdateClo_Click);
            // 
            // btnDeleteClo
            // 
            this.btnDeleteClo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDeleteClo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteClo.Location = new System.Drawing.Point(224, 65);
            this.btnDeleteClo.Name = "btnDeleteClo";
            this.btnDeleteClo.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteClo.TabIndex = 47;
            this.btnDeleteClo.Text = "Delete CLO";
            this.btnDeleteClo.UseVisualStyleBackColor = true;
            this.btnDeleteClo.Click += new System.EventHandler(this.btnDeleteClo_Click);
            // 
            // btnSaveClo
            // 
            this.btnSaveClo.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSaveClo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClo.Location = new System.Drawing.Point(12, 65);
            this.btnSaveClo.Name = "btnSaveClo";
            this.btnSaveClo.Size = new System.Drawing.Size(100, 23);
            this.btnSaveClo.TabIndex = 46;
            this.btnSaveClo.Text = "Save CLO";
            this.btnSaveClo.UseVisualStyleBackColor = true;
            this.btnSaveClo.Click += new System.EventHandler(this.btnStdSave_Click);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel7.Location = new System.Drawing.Point(12, 34);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(100, 3);
            this.panel7.TabIndex = 27;
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(714, 65);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 23);
            this.btnSearch.TabIndex = 52;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel8.Location = new System.Drawing.Point(588, 83);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(120, 3);
            this.panel8.TabIndex = 50;
            // 
            // grdStudent
            // 
            this.grdStudent.BackgroundColor = System.Drawing.SystemColors.Window;
            this.grdStudent.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdStudent.Location = new System.Drawing.Point(16, 108);
            this.grdStudent.Name = "grdStudent";
            this.grdStudent.Size = new System.Drawing.Size(772, 331);
            this.grdStudent.TabIndex = 53;
            this.grdStudent.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdStudent_CellContentClick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnUpdateClo);
            this.panel1.Controls.Add(this.btnSearch);
            this.panel1.Controls.Add(this.panel8);
            this.panel1.Controls.Add(this.btnDeleteClo);
            this.panel1.Controls.Add(this.btnSaveClo);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.panel7);
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 100);
            this.panel1.TabIndex = 49;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(588, 70);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search here.....";
            this.txtSearch.PlaceholderTextColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.Size = new System.Drawing.Size(82, 13);
            this.txtSearch.TabIndex = 51;
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtName.Location = new System.Drawing.Point(12, 21);
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "CLO Name";
            this.txtName.PlaceholderTextColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtName.Size = new System.Drawing.Size(82, 13);
            this.txtName.TabIndex = 39;
            // 
            // CLOsManage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.grdStudent);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(200, 60);
            this.Name = "CLOsManage";
            this.Size = new System.Drawing.Size(800, 440);
            this.Load += new System.EventHandler(this.CLOsManage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdStudent)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpdateClo;
        private System.Windows.Forms.Button btnDeleteClo;
        private System.Windows.Forms.Button btnSaveClo;
        private System.Windows.Forms.PlaceholderTextBox txtName;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.PlaceholderTextBox txtSearch;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.DataGridView grdStudent;
        private System.Windows.Forms.Panel panel1;
    }
}
