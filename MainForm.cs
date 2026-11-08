using System;
using System.Configuration;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using SABARES_EmployeeManagementSystem.Forms;

namespace SABARES_EmployeeManagementSystem
{
	public partial class MainForm : Form
	{
		private readonly EmployeeManagementDataContext db =
			new EmployeeManagementDataContext(
				ConfigurationManager.ConnectionStrings["EmployeeDb"].ConnectionString);

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			lblClock.Text = DateTime.Now.ToString("MMM dd, yyyy  h:mm:ss tt");
			clockTimer.Start();
		}

		private void clockTimer_Tick(object sender, EventArgs e)
		{
			lblClock.Text = DateTime.Now.ToString("MMM dd, yyyy  h:mm:ss tt");
		}

		private void btnManageEmployee_Click(object sender, EventArgs e)
		{
			OpenEmployees();
		}

		private void btnEmploymentHistory_Click(object sender, EventArgs e)
		{
			OpenHistoryPicker();
		}

		private void OpenEmployees()
		{
			using (var employees = new EmployeeForm())
			{
				employees.ShowDialog(this);
			}
		}

		private void OpenHistoryPicker()
		{
			// Palette from the Tropascape logo
			Color cream = Color.FromArgb(251, 243, 224);
			Color chocolate = Color.FromArgb(78, 35, 22);
			Color burnt = Color.FromArgb(164, 82, 15);
			Color amber = Color.FromArgb(185, 121, 14);
			Color gold = Color.FromArgb(224, 198, 119);
			Color ivory = Color.FromArgb(255, 253, 247);

			using (var picker = new Form
			{
				Text = "Select an employee",
				Width = 620,
				Height = 420,
				StartPosition = FormStartPosition.CenterParent,
				BackColor = cream,
				ForeColor = chocolate,
				Font = new Font("Calibri", 11F)
			})
			{
				var grid = new DataGridView
				{
					Dock = DockStyle.Fill,
					AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells,
					ReadOnly = true,
					AllowUserToAddRows = false,
					AutoGenerateColumns = true,
					SelectionMode = DataGridViewSelectionMode.FullRowSelect,
					MultiSelect = false,
					BackgroundColor = cream,
					BorderStyle = BorderStyle.None,
					EnableHeadersVisualStyles = false,
					DefaultCellStyle = new DataGridViewCellStyle
					{
						BackColor = ivory,
						ForeColor = chocolate,
						SelectionBackColor = gold,
						SelectionForeColor = chocolate,
						Font = new Font("Calibri", 11F)
					},
					ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
					{
						BackColor = amber,
						ForeColor = cream,
						Font = new Font("Bahnschrift SemiBold", 11F)
					}
				};

				var open = new Button
				{
					Text = "Open History",
					Dock = DockStyle.Bottom,
					Height = 50,
					FlatStyle = FlatStyle.Flat,
					BackColor = burnt,
					ForeColor = cream,
					Font = new Font("Bahnschrift SemiBold", 14F)
				};
				open.FlatAppearance.BorderSize = 0;

				grid.DataSource = db.usp_Employee_Search(null, null, null)
					.Select(x => new { x.EmployeeId, x.FullName, x.JobTitle })
					.ToList();

				open.Click += (s, e) =>
				{
					if (grid.CurrentRow == null)
					{
						MessageBox.Show("Select an employee first.", "Employment History");
						return;
					}

					string id = grid.CurrentRow.Cells["EmployeeId"].Value.ToString();
					string name = grid.CurrentRow.Cells["FullName"].Value.ToString();

					using (var history = new EmploymentHistoryForm(id, name))
					{
						history.ShowDialog(picker);
					}
				};

				picker.Controls.Add(grid);
				picker.Controls.Add(open);
				picker.ShowDialog(this);
			}
		}
	}
}