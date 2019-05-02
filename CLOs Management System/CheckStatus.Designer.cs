namespace CLOs_Management_System
{
    partial class CheckStatus
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
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblAttPer = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblPer = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.PlaceholderTextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSearch
            // 
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Location = new System.Drawing.Point(723, 15);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(70, 23);
            this.btnSearch.TabIndex = 50;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.SystemColors.ControlText;
            this.panel8.Location = new System.Drawing.Point(597, 33);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(120, 3);
            this.panel8.TabIndex = 48;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.lblPer);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Location = new System.Drawing.Point(593, 93);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 100);
            this.panel1.TabIndex = 51;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.lblAttPer);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(200, 35);
            this.panel2.TabIndex = 52;
            // 
            // lblAttPer
            // 
            this.lblAttPer.AutoSize = true;
            this.lblAttPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAttPer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblAttPer.Location = new System.Drawing.Point(39, 8);
            this.lblAttPer.Name = "lblAttPer";
            this.lblAttPer.Size = new System.Drawing.Size(130, 16);
            this.lblAttPer.TabIndex = 52;
            this.lblAttPer.Text = "Attendence %age";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.label1.Location = new System.Drawing.Point(19, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 53;
            this.label1.Text = "Your Attendence is:";
            // 
            // lblPer
            // 
            this.lblPer.AutoSize = true;
            this.lblPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPer.ForeColor = System.Drawing.SystemColors.WindowText;
            this.lblPer.Location = new System.Drawing.Point(118, 58);
            this.lblPer.Name = "lblPer";
            this.lblPer.Size = new System.Drawing.Size(52, 16);
            this.lblPer.TabIndex = 53;
            this.lblPer.Text = "...........";
            // 
            // txtSearch
            // 
            this.txtSearch.BackColor = System.Drawing.SystemColors.Window;
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(597, 20);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.PlaceholderText = "Search Reg#.....";
            this.txtSearch.PlaceholderTextColor = System.Drawing.SystemColors.ActiveBorder;
            this.txtSearch.Size = new System.Drawing.Size(82, 13);
            this.txtSearch.TabIndex = 49;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // CheckStatus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.panel8);
            this.Location = new System.Drawing.Point(0, 140);
            this.Name = "CheckStatus";
            this.Size = new System.Drawing.Size(800, 300);
            this.Load += new System.EventHandler(this.CheckStatus_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.PlaceholderTextBox txtSearch;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblPer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblAttPer;
    }
}
