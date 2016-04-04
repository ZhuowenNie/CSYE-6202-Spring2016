namespace StudentRegistration.MVP
{
	partial class StudentRegistrationForm
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

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
            this.groupBoxStudentInfo = new System.Windows.Forms.GroupBox();
            this.groupBoxEnrollmentType = new System.Windows.Forms.GroupBox();
            this.radPTime = new System.Windows.Forms.RadioButton();
            this.radFTime = new System.Windows.Forms.RadioButton();
            this.cmbDpt = new System.Windows.Forms.ComboBox();
            this.lstName = new System.Windows.Forms.TextBox();
            this.fstName = new System.Windows.Forms.TextBox();
            this.stuID = new System.Windows.Forms.TextBox();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblStudentID = new System.Windows.Forms.Label();
            this.dataGridViewStudents = new System.Windows.Forms.DataGridView();
            this.newStu = new System.Windows.Forms.Button();
            this.removeStu = new System.Windows.Forms.Button();
            this.editStu = new System.Windows.Forms.Button();
            this.groupBoxStudentInfo.SuspendLayout();
            this.groupBoxEnrollmentType.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxStudentInfo
            // 
            this.groupBoxStudentInfo.Controls.Add(this.groupBoxEnrollmentType);
            this.groupBoxStudentInfo.Controls.Add(this.cmbDpt);
            this.groupBoxStudentInfo.Controls.Add(this.lstName);
            this.groupBoxStudentInfo.Controls.Add(this.fstName);
            this.groupBoxStudentInfo.Controls.Add(this.stuID);
            this.groupBoxStudentInfo.Controls.Add(this.lblDepartment);
            this.groupBoxStudentInfo.Controls.Add(this.lblLastName);
            this.groupBoxStudentInfo.Controls.Add(this.lblFirstName);
            this.groupBoxStudentInfo.Controls.Add(this.lblStudentID);
            this.groupBoxStudentInfo.Location = new System.Drawing.Point(13, 12);
            this.groupBoxStudentInfo.Name = "groupBoxStudentInfo";
            this.groupBoxStudentInfo.Size = new System.Drawing.Size(601, 217);
            this.groupBoxStudentInfo.TabIndex = 0;
            this.groupBoxStudentInfo.TabStop = false;
            this.groupBoxStudentInfo.Text = "Student Info";
            // 
            // groupBoxEnrollmentType
            // 
            this.groupBoxEnrollmentType.Controls.Add(this.radPTime);
            this.groupBoxEnrollmentType.Controls.Add(this.radFTime);
            this.groupBoxEnrollmentType.Location = new System.Drawing.Point(316, 31);
            this.groupBoxEnrollmentType.Name = "groupBoxEnrollmentType";
            this.groupBoxEnrollmentType.Size = new System.Drawing.Size(257, 132);
            this.groupBoxEnrollmentType.TabIndex = 9;
            this.groupBoxEnrollmentType.TabStop = false;
            this.groupBoxEnrollmentType.Text = "Enrollment Type";
            // 
            // radPTime
            // 
            this.radPTime.AutoSize = true;
            this.radPTime.Location = new System.Drawing.Point(141, 58);
            this.radPTime.Name = "radPTime";
            this.radPTime.Size = new System.Drawing.Size(100, 19);
            this.radPTime.TabIndex = 1;
            this.radPTime.TabStop = true;
            this.radPTime.Text = "Part Time";
            this.radPTime.UseVisualStyleBackColor = true;
            // 
            // radFTime
            // 
            this.radFTime.AutoSize = true;
            this.radFTime.Location = new System.Drawing.Point(7, 58);
            this.radFTime.Name = "radFTime";
            this.radFTime.Size = new System.Drawing.Size(100, 19);
            this.radFTime.TabIndex = 0;
            this.radFTime.TabStop = true;
            this.radFTime.Text = "Full Time";
            this.radFTime.UseVisualStyleBackColor = true;
            // 
            // cmbDpt
            // 
            this.cmbDpt.FormattingEnabled = true;
            this.cmbDpt.Location = new System.Drawing.Point(108, 137);
            this.cmbDpt.Name = "cmbDpt";
            this.cmbDpt.Size = new System.Drawing.Size(170, 23);
            this.cmbDpt.TabIndex = 8;
            // 
            // lstName
            // 
            this.lstName.Location = new System.Drawing.Point(108, 101);
            this.lstName.Name = "lstName";
            this.lstName.Size = new System.Drawing.Size(170, 25);
            this.lstName.TabIndex = 7;
            // 
            // fstName
            // 
            this.fstName.Location = new System.Drawing.Point(108, 64);
            this.fstName.Name = "fstName";
            this.fstName.Size = new System.Drawing.Size(170, 25);
            this.fstName.TabIndex = 6;
            // 
            // stuID
            // 
            this.stuID.Location = new System.Drawing.Point(108, 28);
            this.stuID.Name = "stuID";
            this.stuID.Size = new System.Drawing.Size(170, 25);
            this.stuID.TabIndex = 5;
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Location = new System.Drawing.Point(19, 143);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(87, 15);
            this.lblDepartment.TabIndex = 3;
            this.lblDepartment.Text = "Department";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(19, 106);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(79, 15);
            this.lblLastName.TabIndex = 2;
            this.lblLastName.Text = "Last Name";
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(19, 68);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(87, 15);
            this.lblFirstName.TabIndex = 1;
            this.lblFirstName.Text = "First Name";
            // 
            // lblStudentID
            // 
            this.lblStudentID.AutoSize = true;
            this.lblStudentID.Location = new System.Drawing.Point(19, 31);
            this.lblStudentID.Name = "lblStudentID";
            this.lblStudentID.Size = new System.Drawing.Size(87, 15);
            this.lblStudentID.TabIndex = 0;
            this.lblStudentID.Text = "Student ID";
            // 
            // dataGridViewStudents
            // 
            this.dataGridViewStudents.AllowUserToAddRows = false;
            this.dataGridViewStudents.AllowUserToDeleteRows = false;
            this.dataGridViewStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewStudents.GridColor = System.Drawing.SystemColors.Control;
            this.dataGridViewStudents.Location = new System.Drawing.Point(13, 245);
            this.dataGridViewStudents.Name = "dataGridViewStudents";
            this.dataGridViewStudents.ReadOnly = true;
            this.dataGridViewStudents.RowTemplate.Height = 24;
            this.dataGridViewStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewStudents.Size = new System.Drawing.Size(601, 334);
            this.dataGridViewStudents.TabIndex = 3;
            this.dataGridViewStudents.SelectionChanged += new System.EventHandler(this.HandleDataGridViewStudentsSelectionChanged);
            // 
            // newStu
            // 
            this.newStu.Location = new System.Drawing.Point(679, 72);
            this.newStu.Margin = new System.Windows.Forms.Padding(4);
            this.newStu.Name = "newStu";
            this.newStu.Size = new System.Drawing.Size(128, 29);
            this.newStu.TabIndex = 5;
            this.newStu.Text = "New";
            this.newStu.UseVisualStyleBackColor = true;
            this.newStu.Click += new System.EventHandler(this.newStu_Click);
            // 
            // removeStu
            // 
            this.removeStu.Location = new System.Drawing.Point(679, 155);
            this.removeStu.Margin = new System.Windows.Forms.Padding(4);
            this.removeStu.Name = "removeStu";
            this.removeStu.Size = new System.Drawing.Size(128, 29);
            this.removeStu.TabIndex = 6;
            this.removeStu.Text = "Remove";
            this.removeStu.UseVisualStyleBackColor = true;
            this.removeStu.Click += new System.EventHandler(this.removeStu_Click);
            // 
            // editStu
            // 
            this.editStu.Location = new System.Drawing.Point(679, 245);
            this.editStu.Margin = new System.Windows.Forms.Padding(4);
            this.editStu.Name = "editStu";
            this.editStu.Size = new System.Drawing.Size(128, 29);
            this.editStu.TabIndex = 7;
            this.editStu.Text = "Edit";
            this.editStu.UseVisualStyleBackColor = true;
            this.editStu.Click += new System.EventHandler(this.editStu_Click);
            // 
            // StudentRegistrationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 590);
            this.Controls.Add(this.editStu);
            this.Controls.Add(this.removeStu);
            this.Controls.Add(this.newStu);
            this.Controls.Add(this.dataGridViewStudents);
            this.Controls.Add(this.groupBoxStudentInfo);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(647, 631);
            this.Name = "StudentRegistrationForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Registration Form";
            this.groupBoxStudentInfo.ResumeLayout(false);
            this.groupBoxStudentInfo.PerformLayout();
            this.groupBoxEnrollmentType.ResumeLayout(false);
            this.groupBoxEnrollmentType.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewStudents)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.GroupBox groupBoxStudentInfo;
		private System.Windows.Forms.Label lblDepartment;
		private System.Windows.Forms.Label lblLastName;
		private System.Windows.Forms.Label lblFirstName;
		private System.Windows.Forms.Label lblStudentID;
		private System.Windows.Forms.TextBox lstName;
		private System.Windows.Forms.TextBox fstName;
		private System.Windows.Forms.TextBox stuID;
		private System.Windows.Forms.ComboBox cmbDpt;
		private System.Windows.Forms.GroupBox groupBoxEnrollmentType;
		private System.Windows.Forms.RadioButton radPTime;
		private System.Windows.Forms.RadioButton radFTime;
		private System.Windows.Forms.DataGridView dataGridViewStudents;
        private System.Windows.Forms.Button newStu;
        private System.Windows.Forms.Button removeStu;
        private System.Windows.Forms.Button editStu;
    }
}

