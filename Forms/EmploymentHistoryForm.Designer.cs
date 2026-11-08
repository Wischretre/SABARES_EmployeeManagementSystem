namespace SABARES_EmployeeManagementSystem.Forms
{
	partial class EmploymentHistoryForm
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
			this.txtCompanyName = new System.Windows.Forms.TextBox();
			this.txtJobTitle = new System.Windows.Forms.TextBox();
			this.cboEmploymentType = new System.Windows.Forms.ComboBox();
			this.dtpStartDate = new System.Windows.Forms.DateTimePicker();
			this.dtpEndDate = new System.Windows.Forms.DateTimePicker();
			this.chkCurrent = new System.Windows.Forms.CheckBox();
			this.txtReasonForLeaving = new System.Windows.Forms.TextBox();
			this.txtNotes = new System.Windows.Forms.TextBox();
			this.btnSave = new System.Windows.Forms.Button();
			this.btnUpdate = new System.Windows.Forms.Button();
			this.btnDelete = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.dgvHistory = new System.Windows.Forms.DataGridView();
			this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label8 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
			this.SuspendLayout();
			// 
			// txtCompanyName
			// 
			this.txtCompanyName.Location = new System.Drawing.Point(866, 439);
			this.txtCompanyName.Name = "txtCompanyName";
			this.txtCompanyName.Size = new System.Drawing.Size(227, 20);
			this.txtCompanyName.TabIndex = 0;
			// 
			// txtJobTitle
			// 
			this.txtJobTitle.Location = new System.Drawing.Point(866, 464);
			this.txtJobTitle.Name = "txtJobTitle";
			this.txtJobTitle.Size = new System.Drawing.Size(227, 20);
			this.txtJobTitle.TabIndex = 0;
			// 
			// cboEmploymentType
			// 
			this.cboEmploymentType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cboEmploymentType.FormattingEnabled = true;
			this.cboEmploymentType.Items.AddRange(new object[] {
            "Full-Time",
            "Part-Time",
            "Contract",
            "Internship"});
			this.cboEmploymentType.Location = new System.Drawing.Point(866, 490);
			this.cboEmploymentType.Name = "cboEmploymentType";
			this.cboEmploymentType.Size = new System.Drawing.Size(227, 21);
			this.cboEmploymentType.TabIndex = 1;
			// 
			// dtpStartDate
			// 
			this.dtpStartDate.Location = new System.Drawing.Point(866, 519);
			this.dtpStartDate.Name = "dtpStartDate";
			this.dtpStartDate.Size = new System.Drawing.Size(227, 20);
			this.dtpStartDate.TabIndex = 2;
			// 
			// dtpEndDate
			// 
			this.dtpEndDate.Location = new System.Drawing.Point(866, 545);
			this.dtpEndDate.Name = "dtpEndDate";
			this.dtpEndDate.Size = new System.Drawing.Size(227, 20);
			this.dtpEndDate.TabIndex = 2;
			// 
			// chkCurrent
			// 
			this.chkCurrent.AutoSize = true;
			this.chkCurrent.Location = new System.Drawing.Point(866, 571);
			this.chkCurrent.Name = "chkCurrent";
			this.chkCurrent.Size = new System.Drawing.Size(60, 17);
			this.chkCurrent.TabIndex = 3;
			this.chkCurrent.Text = "Current";
			this.chkCurrent.UseVisualStyleBackColor = true;
			this.chkCurrent.CheckedChanged += new System.EventHandler(this.chkCurrent_CheckedChanged);
			// 
			// txtReasonForLeaving
			// 
			this.txtReasonForLeaving.Location = new System.Drawing.Point(866, 593);
			this.txtReasonForLeaving.Name = "txtReasonForLeaving";
			this.txtReasonForLeaving.Size = new System.Drawing.Size(227, 20);
			this.txtReasonForLeaving.TabIndex = 0;
			// 
			// txtNotes
			// 
			this.txtNotes.Location = new System.Drawing.Point(866, 626);
			this.txtNotes.Multiline = true;
			this.txtNotes.Name = "txtNotes";
			this.txtNotes.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
			this.txtNotes.Size = new System.Drawing.Size(227, 98);
			this.txtNotes.TabIndex = 0;
			// 
			// btnSave
			// 
			this.btnSave.Location = new System.Drawing.Point(813, 739);
			this.btnSave.Name = "btnSave";
			this.btnSave.Size = new System.Drawing.Size(130, 60);
			this.btnSave.TabIndex = 4;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
			// 
			// btnUpdate
			// 
			this.btnUpdate.Location = new System.Drawing.Point(1006, 739);
			this.btnUpdate.Name = "btnUpdate";
			this.btnUpdate.Size = new System.Drawing.Size(130, 60);
			this.btnUpdate.TabIndex = 4;
			this.btnUpdate.Text = "Update";
			this.btnUpdate.UseVisualStyleBackColor = true;
			this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
			// 
			// btnDelete
			// 
			this.btnDelete.Location = new System.Drawing.Point(1006, 814);
			this.btnDelete.Name = "btnDelete";
			this.btnDelete.Size = new System.Drawing.Size(130, 60);
			this.btnDelete.TabIndex = 4;
			this.btnDelete.Text = "Delete";
			this.btnDelete.UseVisualStyleBackColor = true;
			this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(813, 814);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(130, 60);
			this.btnClear.TabIndex = 4;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// dgvHistory
			// 
			this.dgvHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvHistory.Location = new System.Drawing.Point(574, 39);
			this.dgvHistory.MultiSelect = false;
			this.dgvHistory.Name = "dgvHistory";
			this.dgvHistory.ReadOnly = true;
			this.dgvHistory.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgvHistory.Size = new System.Drawing.Size(764, 343);
			this.dgvHistory.TabIndex = 5;
			this.dgvHistory.SelectionChanged += new System.EventHandler(this.dgvHistory_SelectionChanged);
			// 
			// errorProvider1
			// 
			this.errorProvider1.ContainerControl = this;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(775, 446);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(85, 13);
			this.label1.TabIndex = 6;
			this.label1.Text = "Company Name:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(810, 471);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(50, 13);
			this.label2.TabIndex = 6;
			this.label2.Text = "Job Title:";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(766, 498);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(94, 13);
			this.label3.TabIndex = 6;
			this.label3.Text = "Employment Type:";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(802, 526);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(58, 13);
			this.label4.TabIndex = 6;
			this.label4.Text = "Start Date:";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(754, 600);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(106, 13);
			this.label6.TabIndex = 6;
			this.label6.Text = "Reason For Leaving:";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(805, 552);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(55, 13);
			this.label7.TabIndex = 6;
			this.label7.Text = "End Date:";
			// 
			// label8
			// 
			this.label8.AutoSize = true;
			this.label8.Location = new System.Drawing.Point(812, 629);
			this.label8.Name = "label8";
			this.label8.Size = new System.Drawing.Size(38, 13);
			this.label8.TabIndex = 6;
			this.label8.Text = "Notes:";
			// 
			// EmploymentHistoryForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1774, 946);
			this.Controls.Add(this.label8);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label7);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.dgvHistory);
			this.Controls.Add(this.btnUpdate);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.chkCurrent);
			this.Controls.Add(this.dtpEndDate);
			this.Controls.Add(this.dtpStartDate);
			this.Controls.Add(this.cboEmploymentType);
			this.Controls.Add(this.txtNotes);
			this.Controls.Add(this.txtReasonForLeaving);
			this.Controls.Add(this.txtJobTitle);
			this.Controls.Add(this.txtCompanyName);
			this.Name = "EmploymentHistoryForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "EmploymentHistoryForm";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.EmploymentHistoryForm_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgvHistory)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txtCompanyName;
		private System.Windows.Forms.TextBox txtJobTitle;
		private System.Windows.Forms.ComboBox cboEmploymentType;
		private System.Windows.Forms.DateTimePicker dtpStartDate;
		private System.Windows.Forms.DateTimePicker dtpEndDate;
		private System.Windows.Forms.CheckBox chkCurrent;
		private System.Windows.Forms.TextBox txtReasonForLeaving;
		private System.Windows.Forms.TextBox txtNotes;
		private System.Windows.Forms.Button btnSave;
		private System.Windows.Forms.Button btnUpdate;
		private System.Windows.Forms.Button btnDelete;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.DataGridView dgvHistory;
		private System.Windows.Forms.ErrorProvider errorProvider1;
		private System.Windows.Forms.Label label8;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label1;
	}
}