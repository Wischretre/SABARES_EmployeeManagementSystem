using System;
using System.Configuration;
using System.Linq;
using System.Windows.Forms;
using System.Drawing;

namespace SABARES_EmployeeManagementSystem.Forms
{
	public partial class EmploymentHistoryForm : Form
	{
		private readonly EmployeeManagementDataContext db =
			new EmployeeManagementDataContext(
				ConfigurationManager.ConnectionStrings["EmployeeDb"].ConnectionString);

		private readonly string _employeeId;
		private long? _selectedHistoryId;

		public EmploymentHistoryForm()
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
			StyleChildren(this);
		}

		private void StyleChildren(Control parent)
		{
			foreach (Control c in parent.Controls)
			{
				if (c is Button b)
				{
					b.FlatStyle = FlatStyle.Flat;
					b.FlatAppearance.BorderSize = 0;
					b.Font = new Font("Segoe UI", 9, FontStyle.Bold);

					if (b.Name == "btnDelete")
					{
						b.BackColor = DangerRed;
						b.ForeColor = Cream;
					}
					else if (b.Name == "btnClear")
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
					g.ColumnHeadersDefaultCellStyle.ForeColor = Cream;
					g.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 9, FontStyle.Bold);
					g.DefaultCellStyle.BackColor = Ivory;
					g.DefaultCellStyle.ForeColor = Chocolate;
					g.DefaultCellStyle.SelectionBackColor = Gold;
					g.DefaultCellStyle.SelectionForeColor = Chocolate;
				}
				else if (c is CheckBox)
				{
					c.BackColor = Cream;
					c.ForeColor = Chocolate;
				}
				else if (c is TextBox || c is ComboBox || c is DateTimePicker)
				{
					c.BackColor = Ivory;
					c.ForeColor = Chocolate;
				}
				else if (c is Label)
				{
					c.BackColor = Color.Transparent;
					c.ForeColor = Chocolate;
				}
				else
				{
					c.BackColor = Cream;
				}

				StyleChildren(c);
			}
		}

		
		public EmploymentHistoryForm(string employeeId, string employeeName) : this()
		{
			_employeeId = employeeId;
			Text = "Employment History - " + employeeName + " (" + employeeId + ")";
		}

		private void EmploymentHistoryForm_Load(object sender, EventArgs e)
		{
			cboEmploymentType.SelectedIndex = -1;
			dtpEndDate.Enabled = !chkCurrent.Checked;
			LoadHistory();
		}

		private void LoadHistory()
		{
			if (string.IsNullOrEmpty(_employeeId)) return;

			dgvHistory.DataSource = db.usp_EmployeeHistory_ReadByEmployee(_employeeId).ToList();
		}

		private void chkCurrent_CheckedChanged(object sender, EventArgs e)
		{
			dtpEndDate.Enabled = !chkCurrent.Checked;
		}

		private void dgvHistory_SelectionChanged(object sender, EventArgs e)
		{
			if (dgvHistory.CurrentRow == null) return;

			var idValue = dgvHistory.CurrentRow.Cells["HistoryId"].Value;
			if (idValue == null) return;

			_selectedHistoryId = Convert.ToInt64(idValue);

			txtCompanyName.Text = dgvHistory.CurrentRow.Cells["CompanyName"].Value?.ToString();
			txtJobTitle.Text = dgvHistory.CurrentRow.Cells["JobTitle"].Value?.ToString();
			cboEmploymentType.Text = dgvHistory.CurrentRow.Cells["EmploymentType"].Value?.ToString();
			txtReasonForLeaving.Text = dgvHistory.CurrentRow.Cells["ReasonForLeaving"].Value?.ToString();
			txtNotes.Text = dgvHistory.CurrentRow.Cells["Notes"].Value?.ToString();

			dtpStartDate.Value = Convert.ToDateTime(dgvHistory.CurrentRow.Cells["StartDate"].Value);

			var endValue = dgvHistory.CurrentRow.Cells["EndDate"].Value;
			chkCurrent.Checked = endValue == null;
			if (endValue != null)
				dtpEndDate.Value = Convert.ToDateTime(endValue);
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (string.IsNullOrEmpty(_employeeId))
			{
				MessageBox.Show("No employee selected.", "Save");
				return;
			}
			if (!ValidateInputs()) return;

			try
			{
				db.usp_EmployeeHistory_Create(
					_employeeId,
					txtCompanyName.Text.Trim(),
					txtJobTitle.Text.Trim(),
					cboEmploymentType.Text,
					dtpStartDate.Value.Date,
					chkCurrent.Checked ? (DateTime?)null : dtpEndDate.Value.Date,
					NullIfBlank(txtReasonForLeaving.Text),
					NullIfBlank(txtNotes.Text));

				MessageBox.Show("History record saved.", "Save");
				ClearInputs();
				LoadHistory();
			}
			catch (Exception ex)
			{
				ShowDbError(ex);
			}
		}

		private void btnUpdate_Click(object sender, EventArgs e)
		{
			if (_selectedHistoryId == null)
			{
				MessageBox.Show("Select a history record first.", "Update");
				return;
			}
			if (!ValidateInputs()) return;

			try
			{
				db.usp_EmployeeHistory_Update(
					_selectedHistoryId,
					txtCompanyName.Text.Trim(),
					txtJobTitle.Text.Trim(),
					cboEmploymentType.Text,
					dtpStartDate.Value.Date,
					chkCurrent.Checked ? (DateTime?)null : dtpEndDate.Value.Date,
					NullIfBlank(txtReasonForLeaving.Text),
					NullIfBlank(txtNotes.Text));

				MessageBox.Show("History record updated.", "Update");
				LoadHistory();
			}
			catch (Exception ex)
			{
				ShowDbError(ex);
			}
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			if (_selectedHistoryId == null)
			{
				MessageBox.Show("Select a history record first.", "Delete");
				return;
			}
			if (MessageBox.Show("Delete this history record?", "Confirm",
				MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;

			try
			{
				db.usp_EmployeeHistory_Delete(_selectedHistoryId);
				ClearInputs();
				LoadHistory();
			}
			catch (Exception ex)
			{
				ShowDbError(ex);
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			ClearInputs();
		}

		private bool ValidateInputs()
		{
			errorProvider1.Clear();
			bool ok = true;

			if (string.IsNullOrWhiteSpace(txtCompanyName.Text))
			{ errorProvider1.SetError(txtCompanyName, "Company name is required."); ok = false; }

			if (string.IsNullOrWhiteSpace(txtJobTitle.Text))
			{ errorProvider1.SetError(txtJobTitle, "Job title is required."); ok = false; }

			if (string.IsNullOrWhiteSpace(cboEmploymentType.Text))
			{ errorProvider1.SetError(cboEmploymentType, "Employment type is required."); ok = false; }

			if (!chkCurrent.Checked && dtpEndDate.Value.Date < dtpStartDate.Value.Date)
			{ errorProvider1.SetError(dtpEndDate, "End date cannot be before start date."); ok = false; }

			return ok;
		}

		private void ClearInputs()
		{
			_selectedHistoryId = null;
			txtCompanyName.Clear();
			txtJobTitle.Clear();
			txtReasonForLeaving.Clear();
			txtNotes.Clear();
			cboEmploymentType.SelectedIndex = -1;
			dtpStartDate.Value = DateTime.Today;
			dtpEndDate.Value = DateTime.Today;
			chkCurrent.Checked = false;
			errorProvider1.Clear();
			dgvHistory.ClearSelection();
		}

		private static string NullIfBlank(string value)
		{
			return string.IsNullOrWhiteSpace(value) ? null : value.Trim();
		}

		private void ShowDbError(Exception ex)
		{
			string msg = ex.Message;

			if (msg.Contains("FK_EmploymentHistory_Employees"))
				msg = "The selected employee no longer exists.";
			else if (msg.Contains("CK_History_Dates"))
				msg = "End date cannot be before start date.";
			else if (msg.Contains("CHECK constraint"))
				msg = "One of the values violates a database rule.";

			MessageBox.Show(msg, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
		}

		
	}
}