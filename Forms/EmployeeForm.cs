using System;
using System.Configuration;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using System.Drawing;

namespace SABARES_EmployeeManagementSystem.Forms
{
	public partial class EmployeeForm : Form
	{
		private readonly EmployeeManagementDataContext db =
			new EmployeeManagementDataContext(
				ConfigurationManager.ConnectionStrings["EmployeeDb"].ConnectionString);

		public EmployeeForm()
		{
			InitializeComponent();
			ApplyTheme();
		}

		private static readonly Color Cream = Color.FromArgb(0xFB, 0xF3, 0xE0);
		private static readonly Color Chocolate = Color.FromArgb(0x4E, 0x23, 0x16);
		private static readonly Color Burnt = Color.FromArgb(0xA4, 0x52, 0x0F);
		private static readonly Color Amber = Color.FromArgb(0xB9, 0x79, 0x0E);
		private static readonly Color Gold = Color.FromArgb(0xE0, 0xC6, 0x77);
		private static readonly Color Ivory = Color.FromArgb(0xFF, 0xFD, 0xF7);
		private static readonly Color DangerRed = Color.FromArgb(0x8B, 0x2E, 0x1F);

		private void ApplyTheme()
		{
			BackColor = Cream;
			ForeColor = Chocolate;
			StyleControls(this);
		}

		private void StyleControls(Control parent)
		{
			foreach (Control c in parent.Controls)
			{
				if (c is Button b)
				{
					b.FlatStyle = FlatStyle.Flat;
					b.FlatAppearance.BorderSize = 0;
					b.Font = new Font("Segoe UI", 9, FontStyle.Bold);
					b.Height = 32;

					if (b.Name == "btnDelete")
					{
						b.BackColor = DangerRed;
						b.ForeColor = Cream;
					}
					else if (b.Name == "btnClear" || b.Name == "btnHistory")
					{
						b.BackColor = Gold;
						b.ForeColor = Chocolate;
					}
					else
					{
						b.BackColor = Burnt;
						b.ForeColor = Cream;
					}
				}
				else if (c is DataGridView g)
				{
					g.BackgroundColor = Cream;
					g.BorderStyle = BorderStyle.None;
					g.EnableHeadersVisualStyles = false;
					g.ColumnHeadersDefaultCellStyle.BackColor = Amber;
					g.DefaultCellStyle.ForeColor = Chocolate;
					g.ColumnHeadersDefaultCellStyle.ForeColor = Cream;
					g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
					g.DefaultCellStyle.BackColor = Ivory;
					g.DefaultCellStyle.SelectionBackColor = Gold;
					g.DefaultCellStyle.SelectionForeColor = Chocolate;
					g.AlternatingRowsDefaultCellStyle.BackColor = Cream;
				}
				else if (c is TextBox || c is ComboBox || c is DateTimePicker || c is NumericUpDown)
				{
					c.BackColor = Ivory;
					c.ForeColor = Chocolate;
				}
				else if (c is Label)
				{
					c.ForeColor = Chocolate;
					c.BackColor = Color.Transparent;
				}
				else
				{
					c.BackColor = Cream;
				}

				StyleControls(c);
			}
		}


		private void EmployeeForm_Load(object sender, EventArgs e)
		{
			dtpBirthDate.MaxDate = DateTime.Today;
			dtpHireDate.MaxDate = DateTime.Today.AddYears(10);
			LoadDepartments();
			LoadEmployees(null);
		}

		private void LoadDepartments()
		{
			var depts = db.Departments
				.Select(d => new { DepartmentId = (int?)d.DepartmentId, d.DepartmentName })
				.ToList();

			var inputDepts = depts.Where(d => d.DepartmentId != null).ToList();
			cboDepartment.DataSource = inputDepts;
			cboDepartment.DisplayMember = "DepartmentName";
			cboDepartment.ValueMember = "DepartmentId";
			cboDepartment.SelectedIndex = -1;

			var searchDepts = depts.ToList();
			searchDepts.Insert(0, new { DepartmentId = (int?)null, DepartmentName = "" });
			cboSearchDepartment.DataSource = searchDepts;
			cboSearchDepartment.DisplayMember = "DepartmentName";
			cboSearchDepartment.ValueMember = "DepartmentId";
		}

		private void LoadEmployees(string search)
		{
			int? deptId = cboSearchDepartment.SelectedValue as int?;
			string status = string.IsNullOrWhiteSpace(cboSearchStatus.Text) ? null : cboSearchStatus.Text.Trim();

			dgvEmployees.DataSource = db.usp_Employee_Search(
				string.IsNullOrWhiteSpace(search) ? null : search.Trim(),
				deptId,
				status).ToList();
		}

		private void btnSearch_Click(object sender, EventArgs e)
		{
			LoadEmployees(txtSearch.Text);
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearInputs();
		}

		private void dgvEmployees_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvEmployees.CurrentRow == null) return;

			string id = dgvEmployees.CurrentRow.Cells["EmployeeId"].Value?.ToString();
			if (string.IsNullOrEmpty(id)) return;

			var emp = db.vw_EmployeeDirectories.FirstOrDefault(v => v.EmployeeId == id);
			if (emp == null) return;

			txtEmployeeId.Text = emp.EmployeeId;
			txtFirstName.Text = emp.FirstName;
			txtMiddleName.Text = emp.MiddleName;
			txtLastName.Text = emp.LastName;
			txtEmail.Text = emp.Email;
			txtPhone.Text = emp.Phone;
			txtAddress.Text = emp.Address;
			txtJobTitle.Text = emp.JobTitle;
			cboSex.Text = emp.Sex;
			dtpBirthDate.Value = emp.BirthDate;
			lblAge.Text = emp.Age.HasValue ? emp.Age.Value.ToString() : "N/A";
			cboDepartment.SelectedIndex = -1;
			if (emp.DepartmentId.HasValue)
				cboDepartment.SelectedValue = emp.DepartmentId.Value; cboStatus.Text = emp.EmploymentStatus;
			dtpHireDate.Value = emp.HireDate;
			nudSalary.Value = emp.Salary;
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (!ValidateInputs()) return;

			try
			{
				string newId = null;
				db.usp_Employee_Create(
					txtFirstName.Text.Trim(),
					NullIfBlank(txtMiddleName.Text),
					txtLastName.Text.Trim(),
					cboSex.Text,
					dtpBirthDate.Value.Date,
					txtEmail.Text.Trim(),
					NullIfBlank(txtPhone.Text),
					NullIfBlank(txtAddress.Text),
					cboDepartment.SelectedValue as int?,
					txtJobTitle.Text.Trim(),
					cboStatus.Text,
					dtpHireDate.Value.Date,
					nudSalary.Value,
					ref newId);

				txtEmployeeId.Text = newId;
				MessageBox.Show("Saved as " + newId, "Success");
				LoadEmployees(null);
			}
			catch (Exception ex)
			{
				ShowDbError(ex);
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtEmployeeId.Text))
			{
				MessageBox.Show("Select an employee first.", "Update");
				return;
			}
			if (!ValidateInputs()) return;

			try
			{
				db.usp_Employee_Update(
					txtEmployeeId.Text,
					txtFirstName.Text.Trim(),
					NullIfBlank(txtMiddleName.Text),
					txtLastName.Text.Trim(),
					cboSex.Text,
					dtpBirthDate.Value.Date,
					txtEmail.Text.Trim(),
					NullIfBlank(txtPhone.Text),
					NullIfBlank(txtAddress.Text),
					cboDepartment.SelectedValue as int?,
					txtJobTitle.Text.Trim(),
					cboStatus.Text,
					dtpHireDate.Value.Date,
					nudSalary.Value);

				MessageBox.Show("Employee updated.", "Update");
				LoadEmployees(null);
			}
			catch (Exception ex)
			{
				ShowDbError(ex);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtEmployeeId.Text))
			{
				MessageBox.Show("Select an employee first.", "Delete");
				return;
			}
			if (MessageBox.Show("Delete this employee and their employment history?", "Confirm",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

			try
			{
				db.usp_Employee_Delete(txtEmployeeId.Text);
				ClearInputs();
				LoadEmployees(null);
			}
			catch (Exception ex)
			{
				ShowDbError(ex);
			}
		}

		private bool ValidateInputs()
		{
			errorProvider1.Clear();
			bool ok = true;

			if (string.IsNullOrWhiteSpace(txtFirstName.Text))
			{ errorProvider1.SetError(txtFirstName, "First name is required."); ok = false; }

			if (string.IsNullOrWhiteSpace(txtLastName.Text))
			{ errorProvider1.SetError(txtLastName, "Last name is required."); ok = false; }

			if (string.IsNullOrWhiteSpace(txtJobTitle.Text))
			{ errorProvider1.SetError(txtJobTitle, "Job title is required."); ok = false; }

			if (string.IsNullOrWhiteSpace(txtEmail.Text) ||
				!Regex.IsMatch(txtEmail.Text.Trim(), @"^[^@\s]+@[^@\s]+\.[^@\s]+$"))
			{ errorProvider1.SetError(txtEmail, "A valid email is required."); ok = false; }

			if (dtpHireDate.Value.Date < dtpBirthDate.Value.Date)
			{ errorProvider1.SetError(dtpHireDate, "Hire date cannot be before birth date."); ok = false; }

			if (nudSalary.Value < 0)
			{ errorProvider1.SetError(nudSalary, "Salary must be 0 or more."); ok = false; }

			return ok;
		}

		private void ClearInputs()
		{
			txtEmployeeId.Clear();
			txtFirstName.Clear();
			txtMiddleName.Clear();
			txtLastName.Clear();
			txtEmail.Clear();
			txtPhone.Clear();
			txtAddress.Clear();
			txtJobTitle.Clear();
			cboSex.SelectedIndex = -1;
			cboStatus.SelectedIndex = -1;
			cboDepartment.SelectedIndex = -1;
			dtpBirthDate.Value = DateTime.Today;
			dtpHireDate.Value = DateTime.Today;
			nudSalary.Value = 0;
			lblAge.Text = "N/A";
			errorProvider1.Clear();
		}

		private static string NullIfBlank(string value)
		{
			return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
		}

		private void ShowDbError(Exception ex)
		{
			string msg = ex.Message;

			if (msg.Contains("UQ_Employees_Email"))
				msg = "That email is already used by another employee.";
			else if (msg.Contains("FK_"))
				msg = "A selected value (such as the department) is invalid.";
			else if (msg.Contains("CHECK constraint"))
				msg = "One of the values violates a database rule.";

			MessageBox.Show(msg, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		private void btnHistory_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrWhiteSpace(txtEmployeeId.Text))
			{
				MessageBox.Show("Select an employee first.", "History");
				return;
			}

			string name = txtFirstName.Text.Trim() + " " + txtLastName.Text.Trim();
			using (var historyForm = new EmploymentHistoryForm(txtEmployeeId.Text, name))
			{
				historyForm.ShowDialog(this);
			}
		}
	}
}