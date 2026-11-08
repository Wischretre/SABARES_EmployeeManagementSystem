namespace SABARES_EmployeeManagementSystem
{
	partial class MainForm
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.label1 = new System.Windows.Forms.Label();
			this.lblWelcome = new System.Windows.Forms.Label();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.btnManageEmployee = new System.Windows.Forms.Button();
			this.btnEmploymentHistory = new System.Windows.Forms.Button();
			this.statusStrip1 = new System.Windows.Forms.StatusStrip();
			this.lblDatabase = new System.Windows.Forms.ToolStripStatusLabel();
			this.lblClock = new System.Windows.Forms.ToolStripStatusLabel();
			this.clockTimer = new System.Windows.Forms.Timer(this.components);
			this.tableLayoutPanel1.SuspendLayout();
			this.statusStrip1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Dock = System.Windows.Forms.DockStyle.Top;
			this.label1.Font = new System.Drawing.Font("Bahnschrift SemiBold", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
			this.label1.Location = new System.Drawing.Point(0, 0);
			this.label1.Name = "label1";
			this.label1.Padding = new System.Windows.Forms.Padding(0, 40, 0, 0);
			this.label1.Size = new System.Drawing.Size(1200, 281);
			this.label1.TabIndex = 2;
			this.label1.Text = "Employee Management System";
			this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// lblWelcome
			// 
			this.lblWelcome.Dock = System.Windows.Forms.DockStyle.Top;
			this.lblWelcome.Font = new System.Drawing.Font("Calibri", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
			this.lblWelcome.Location = new System.Drawing.Point(0, 281);
			this.lblWelcome.Name = "lblWelcome";
			this.lblWelcome.Size = new System.Drawing.Size(1200, 132);
			this.lblWelcome.TabIndex = 3;
			this.lblWelcome.Text = "Welcome. Choose an option below.";
			this.lblWelcome.TextAlign = System.Drawing.ContentAlignment.TopCenter;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 5;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 300F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanel1.Controls.Add(this.btnManageEmployee, 1, 0);
			this.tableLayoutPanel1.Controls.Add(this.btnEmploymentHistory, 3, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 413);
			this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(0, 50, 0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.Padding = new System.Windows.Forms.Padding(0, 60, 0, 0);
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(1200, 161);
			this.tableLayoutPanel1.TabIndex = 4;
			// 
			// btnManageEmployee
			// 
			this.btnManageEmployee.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(82)))), ((int)(((byte)(15)))));
			this.btnManageEmployee.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnManageEmployee.FlatAppearance.BorderSize = 0;
			this.btnManageEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnManageEmployee.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnManageEmployee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
			this.btnManageEmployee.Location = new System.Drawing.Point(293, 63);
			this.btnManageEmployee.Name = "btnManageEmployee";
			this.btnManageEmployee.Size = new System.Drawing.Size(294, 95);
			this.btnManageEmployee.TabIndex = 5;
			this.btnManageEmployee.Text = "Manage Employee";
			this.btnManageEmployee.UseVisualStyleBackColor = false;
			this.btnManageEmployee.Click += new System.EventHandler(this.btnManageEmployee_Click);
			// 
			// btnEmploymentHistory
			// 
			this.btnEmploymentHistory.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(164)))), ((int)(((byte)(82)))), ((int)(((byte)(15)))));
			this.btnEmploymentHistory.Dock = System.Windows.Forms.DockStyle.Fill;
			this.btnEmploymentHistory.FlatAppearance.BorderSize = 0;
			this.btnEmploymentHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnEmploymentHistory.Font = new System.Drawing.Font("Bahnschrift SemiBold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnEmploymentHistory.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
			this.btnEmploymentHistory.Location = new System.Drawing.Point(613, 63);
			this.btnEmploymentHistory.Name = "btnEmploymentHistory";
			this.btnEmploymentHistory.Size = new System.Drawing.Size(294, 95);
			this.btnEmploymentHistory.TabIndex = 6;
			this.btnEmploymentHistory.Text = "Employment History";
			this.btnEmploymentHistory.UseVisualStyleBackColor = false;
			this.btnEmploymentHistory.Click += new System.EventHandler(this.btnEmploymentHistory_Click);
			// 
			// statusStrip1
			// 
			this.statusStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
			this.statusStrip1.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.statusStrip1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(35)))), ((int)(((byte)(22)))));
			this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDatabase,
            this.lblClock});
			this.statusStrip1.Location = new System.Drawing.Point(0, 677);
			this.statusStrip1.Name = "statusStrip1";
			this.statusStrip1.Size = new System.Drawing.Size(1200, 23);
			this.statusStrip1.TabIndex = 7;
			this.statusStrip1.Text = "statusStrip1";
			// 
			// lblDatabase
			// 
			this.lblDatabase.Name = "lblDatabase";
			this.lblDatabase.Size = new System.Drawing.Size(233, 18);
			this.lblDatabase.Text = "Database: EmployeeManagementDB";
			// 
			// lblClock
			// 
			this.lblClock.Name = "lblClock";
			this.lblClock.Size = new System.Drawing.Size(952, 18);
			this.lblClock.Spring = true;
			this.lblClock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// clockTimer
			// 
			this.clockTimer.Interval = 1000;
			this.clockTimer.Tick += new System.EventHandler(this.clockTimer_Tick);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(243)))), ((int)(((byte)(224)))));
			this.ClientSize = new System.Drawing.Size(1200, 700);
			this.Controls.Add(this.statusStrip1);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Controls.Add(this.lblWelcome);
			this.Controls.Add(this.label1);
			this.MinimumSize = new System.Drawing.Size(900, 600);
			this.Name = "MainForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Employee Management System";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.Load += new System.EventHandler(this.MainForm_Load);
			this.tableLayoutPanel1.ResumeLayout(false);
			this.statusStrip1.ResumeLayout(false);
			this.statusStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label lblWelcome;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Button btnManageEmployee;
		private System.Windows.Forms.Button btnEmploymentHistory;
		private System.Windows.Forms.StatusStrip statusStrip1;
		private System.Windows.Forms.ToolStripStatusLabel lblDatabase;
		private System.Windows.Forms.ToolStripStatusLabel lblClock;
		private System.Windows.Forms.Timer clockTimer;
	}
}