namespace SABARES_EmployeeManagementSystem.Forms
{
	partial class EmployeeForm
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
			this.components = new System.ComponentModel.Container();
			this.txtEmployeeId = new System.Windows.Forms.TextBox();
			this.txtFirstName = new System.Windows.Forms.TextBox();
			this.txtMiddleName = new System.Windows.Forms.TextBox();
			this.txtLastName = new System.Windows.Forms.TextBox();
			this.txtEmail = new System.Windows.Forms.TextBox();
			this.txtPhone = new System.Windows.Forms.TextBox();
			this.txtAddress = new System.Windows.Forms.TextBox();
			this.txtJobTitle = new System.Windows.Forms.TextBox();
			this.cboSex = new System.Windows.Forms.ComboBox();
			this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
			this.cboDepartment = new System.Windows.Forms.ComboBox();
			this.cboStatus = new System.Windows.Forms.ComboBox();
			this.dtpHireDate = new System.Windows.Forms.DateTimePicker();
			this.nudSalary = new System.Windows.Forms.NumericUpDown();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnSearch = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.txtSearch = new System.Windows.Forms.TextBox();
			this.cboSearchDepartment = new System.Windows.Forms.ComboBox();
			this.cboSearchStatus = new System.Windows.Forms.ComboBox();
			this.dgvEmployees = new System.Windows.Forms.DataGridView();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			this.label9 = new System.Windows.Forms.Label();
			this.label10 = new System.Windows.Forms.Label();
			this.label11 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.lblAge = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.nudSalary)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtEmployeeId
			// 
			this.txtEmployeeId.Location = new System.Drawing.Point(742, 589);
			this.txtEmployeeId.Name = "txtEmployeeId";
			this.txtEmployeeId.ReadOnly = true;
			this.txtEmployeeId.Size = new System.Drawing.Size(136, 20);
			this.txtEmployeeId.TabIndex = 0;
			// 
			// txtFirstName
			// 
			this.txtFirstName.Location = new System.Drawing.Point(742, 616);
			this.txtFirstName.Name = "txtFirstName";
			this.txtFirstName.Size = new System.Drawing.Size(136, 20);
			this.txtFirstName.TabIndex = 1;
			// 
			// txtMiddleName
			// 
			this.txtMiddleName.Location = new System.Drawing.Point(742, 642);
			this.txtMiddleName.Name = "txtMiddleName";
			this.txtMiddleName.Size = new System.Drawing.Size(136, 20);
			this.txtMiddleName.TabIndex = 1;
			// 
			// txtLastName
			// 
			this.txtLastName.Location = new System.Drawing.Point(742, 668);
			this.txtLastName.Name = "txtLastName";
			this.txtLastName.Size = new System.Drawing.Size(136, 20);
			this.txtLastName.TabIndex = 1;
			// 
			// txtEmail
			// 
			this.txtEmail.Location = new System.Drawing.Point(742, 697);
			this.txtEmail.Name = "txtEmail";
			this.txtEmail.Size = new System.Drawing.Size(136, 20);
			this.txtEmail.TabIndex = 1;
			// 
			// txtPhone
			// 
			this.txtPhone.Location = new System.Drawing.Point(742, 723);
			this.txtPhone.Name = "txtPhone";
			this.txtPhone.Size = new System.Drawing.Size(136, 20);
			this.txtPhone.TabIndex = 1;
			// 
			// txtAddress
			// 
			this.txtAddress.Location = new System.Drawing.Point(742, 749);
			this.txtAddress.Name = "txtAddress";
			this.txtAddress.Size = new System.Drawing.Size(136, 20);
			this.txtAddress.TabIndex = 1;
			// 
			// txtJobTitle
			// 
			this.txtJobTitle.Location = new System.Drawing.Point(742, 775);
			this.txtJobTitle.Name = "txtJobTitle";
			this.txtJobTitle.Size = new System.Drawing.Size(136, 20);
			this.txtJobTitle.TabIndex = 1;
			// 
			// cboSex
			// 
			this.cboSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboSex.FormattingEnabled = true;
			this.cboSex.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Other"});
			this.cboSex.Location = new System.Drawing.Point(978, 589);
			this.cboSex.Name = "cboSex";
			this.cboSex.Size = new System.Drawing.Size(136, 21);
			this.cboSex.TabIndex = 2;
			// 
			// dtpBirthDate
			// 
			this.dtpBirthDate.Location = new System.Drawing.Point(978, 616);
			this.dtpBirthDate.Name = "dtpBirthDate";
			this.dtpBirthDate.Size = new System.Drawing.Size(200, 20);
			this.dtpBirthDate.TabIndex = 3;
			// 
			// cboDepartment
			// 
			this.cboDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboDepartment.FormattingEnabled = true;
			this.cboDepartment.Location = new System.Drawing.Point(978, 668);
			this.cboDepartment.Name = "cboDepartment";
			this.cboDepartment.Size = new System.Drawing.Size(136, 21);
			this.cboDepartment.TabIndex = 5;
			// 
			// cboStatus
			// 
			this.cboStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboStatus.FormattingEnabled = true;
			this.cboStatus.Items.AddRange(new object[] {
            "Active",
            "On Leave",
            "Resigned",
            "Terminated"});
			this.cboStatus.Location = new System.Drawing.Point(978, 696);
			this.cboStatus.Name = "cboStatus";
			this.cboStatus.Size = new System.Drawing.Size(136, 21);
			this.cboStatus.TabIndex = 6;
			// 
			// dtpHireDate
			// 
			this.dtpHireDate.Location = new System.Drawing.Point(978, 723);
			this.dtpHireDate.Name = "dtpHireDate";
			this.dtpHireDate.Size = new System.Drawing.Size(200, 20);
			this.dtpHireDate.TabIndex = 3;
			// 
			// nudSalary
			// 
			this.nudSalary.DecimalPlaces = 2;
			this.nudSalary.Location = new System.Drawing.Point(978, 750);
			this.nudSalary.Maximum = new decimal(new int[] {
            1410065407,
            2,
            0,
            0});
			this.nudSalary.Name = "nudSalary";
			this.nudSalary.Size = new System.Drawing.Size(136, 20);
			this.nudSalary.TabIndex = 7;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(742, 826);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(130, 60);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(984, 826);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(130, 60);
			this.btnUpdate.TabIndex = 4;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(984, 906);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(130, 60);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnSearch
			// 
			this.btnSearch.Location = new System.Drawing.Point(667, 78);
			this.btnSearch.Name = "btnSearch";
			this.btnSearch.Size = new System.Drawing.Size(121, 23);
			this.btnSearch.TabIndex = 8;
			this.btnSearch.Text = "Search";
			this.btnSearch.UseVisualStyleBackColor = true;
			this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(742, 906);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(130, 60);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// txtSearch
			// 
			this.txtSearch.Location = new System.Drawing.Point(337, 81);
			this.txtSearch.Name = "txtSearch";
			this.txtSearch.Size = new System.Drawing.Size(324, 20);
			this.txtSearch.TabIndex = 0;
			// 
			// cboSearchDepartment
			// 
			this.cboSearchDepartment.FormattingEnabled = true;
			this.cboSearchDepartment.Location = new System.Drawing.Point(409, 108);
			this.cboSearchDepartment.Name = "cboSearchDepartment";
			this.cboSearchDepartment.Size = new System.Drawing.Size(121, 21);
			this.cboSearchDepartment.TabIndex = 9;
			// 
			// cboSearchStatus
			// 
			this.cboSearchStatus.FormattingEnabled = true;
			this.cboSearchStatus.Items.AddRange(new object[] {
            "",
            "Active",
            "On Leave",
            "Resigned",
            "Terminated"});
			this.cboSearchStatus.Location = new System.Drawing.Point(667, 108);
			this.cboSearchStatus.Name = "cboSearchStatus";
			this.cboSearchStatus.Size = new System.Drawing.Size(121, 21);
			this.cboSearchStatus.TabIndex = 9;
			// 
			// dgvEmployees
			// 
			this.dgvEmployees.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvEmployees.Location = new System.Drawing.Point(290, 135);
			this.dgvEmployees.Name = "dgvEmployees";
			this.dgvEmployees.ReadOnly = true;
			this.dgvEmployees.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvEmployees.Size = new System.Drawing.Size(1205, 426);
			this.dgvEmployees.TabIndex = 10;
			this.dgvEmployees.SelectionChanged += new System.EventHandler(this.dgvEmployees_SelectionChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(666, 596);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(70, 13);
			this.label1.TabIndex = 11;
			this.label1.Text = "Employee ID:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(676, 623);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 13);
			this.label2.TabIndex = 11;
			this.label2.Text = "First Name:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(675, 675);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(61, 13);
			this.label3.TabIndex = 11;
			this.label3.Text = "Last Name:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(701, 704);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(35, 13);
			this.label4.TabIndex = 11;
			this.label4.Text = "Email:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(664, 649);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(72, 13);
			this.label5.TabIndex = 11;
			this.label5.Text = "Middle Name:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(688, 756);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(48, 13);
			this.label6.TabIndex = 11;
			this.label6.Text = "Address:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(686, 782);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 13);
			this.label7.TabIndex = 11;
			this.label7.Text = "Job Title:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(695, 730);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(41, 13);
			this.label8.TabIndex = 11;
			this.label8.Text = "Phone:";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(944, 597);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(28, 13);
			this.label9.TabIndex = 11;
			this.label9.Text = "Sex:";
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(915, 622);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(57, 13);
			this.label10.TabIndex = 11;
			this.label10.Text = "Birth Date:";
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(943, 649);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(29, 13);
			this.label11.TabIndex = 11;
			this.label11.Text = "Age:";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Location = new System.Drawing.Point(907, 676);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(65, 13);
			this.label12.TabIndex = 11;
			this.label12.Text = "Department:";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(932, 704);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(40, 13);
			this.label13.TabIndex = 11;
			this.label13.Text = "Status:";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Location = new System.Drawing.Point(917, 730);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(55, 13);
			this.label14.TabIndex = 11;
			this.label14.Text = "Hire Date:";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Location = new System.Drawing.Point(933, 757);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(39, 13);
			this.label15.TabIndex = 11;
			this.label15.Text = "Salary:";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Location = new System.Drawing.Point(287, 88);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(44, 13);
			this.label16.TabIndex = 11;
			this.label16.Text = "Search:";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Location = new System.Drawing.Point(287, 114);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(116, 13);
			this.label17.TabIndex = 11;
			this.label17.Text = "Search by Department:";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Location = new System.Drawing.Point(570, 115);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(91, 13);
			this.label18.TabIndex = 11;
			this.label18.Text = "Search by Status:";
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// lblAge
			// 
			this.lblAge.Location = new System.Drawing.Point(978, 642);
			this.lblAge.Name = "lblAge";
			this.lblAge.ReadOnly = true;
			this.lblAge.Size = new System.Drawing.Size(136, 20);
			this.lblAge.TabIndex = 0;
			// 
			// EmployeeForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1746, 1007);
			this.Controls.Add(this.label18);
			this.Controls.Add(this.label17);
			this.Controls.Add(this.label16);
			this.Controls.Add(this.label15);
			this.Controls.Add(this.label14);
			this.Controls.Add(this.label13);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.label11);
			this.Controls.Add(this.label10);
			this.Controls.Add(this.label9);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvEmployees);
			this.Controls.Add(this.cboSearchStatus);
			this.Controls.Add(this.cboSearchDepartment);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnSearch);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.nudSalary);
			this.Controls.Add(this.cboStatus);
			this.Controls.Add(this.cboDepartment);
			this.Controls.Add(this.dtpHireDate);
			this.Controls.Add(this.dtpBirthDate);
			this.Controls.Add(this.cboSex);
			this.Controls.Add(this.txtJobTitle);
			this.Controls.Add(this.txtAddress);
			this.Controls.Add(this.txtPhone);
			this.Controls.Add(this.txtEmail);
			this.Controls.Add(this.txtLastName);
			this.Controls.Add(this.txtMiddleName);
			this.Controls.Add(this.txtFirstName);
			this.Controls.Add(this.txtSearch);
			this.Controls.Add(this.lblAge);
			this.Controls.Add(this.txtEmployeeId);
			this.Name = "EmployeeForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EmployeeForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.EmployeeForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.nudSalary)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.dgvEmployees)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtEmployeeId;
		private System.Windows.Forms.TextBox txtFirstName;
		private System.Windows.Forms.TextBox txtMiddleName;
		private System.Windows.Forms.TextBox txtLastName;
		private System.Windows.Forms.TextBox txtEmail;
		private System.Windows.Forms.TextBox txtPhone;
		private System.Windows.Forms.TextBox txtAddress;
		private System.Windows.Forms.TextBox txtJobTitle;
		private System.Windows.Forms.ComboBox cboSex;
		private System.Windows.Forms.DateTimePicker dtpBirthDate;
		private System.Windows.Forms.ComboBox cboDepartment;
		private System.Windows.Forms.ComboBox cboStatus;
		private System.Windows.Forms.DateTimePicker dtpHireDate;
		private System.Windows.Forms.NumericUpDown nudSalary;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnSearch;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.TextBox txtSearch;
		private System.Windows.Forms.ComboBox cboSearchDepartment;
		private System.Windows.Forms.ComboBox cboSearchStatus;
		private System.Windows.Forms.DataGridView dgvEmployees;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Label label10;
		private System.Windows.Forms.Label label11;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.TextBox lblAge;
	}
}