namespace A2IanMartin
{
	partial class WageCalculator
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
			this.gbEmployee = new System.Windows.Forms.GroupBox();
			this.rdoWeekly = new System.Windows.Forms.RadioButton();
			this.rdoCommission = new System.Windows.Forms.RadioButton();
			this.rdoHourly = new System.Windows.Forms.RadioButton();
			this.gbEmployeeInfo = new System.Windows.Forms.GroupBox();
			this.txtWage = new System.Windows.Forms.TextBox();
			this.txtName = new System.Windows.Forms.TextBox();
			this.txtHours = new System.Windows.Forms.TextBox();
			this.lblWageType = new System.Windows.Forms.Label();
			this.lblHours = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.btnCalculate = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.btnClose = new System.Windows.Forms.Button();
			this.gbCalculatedWage = new System.Windows.Forms.GroupBox();
			this.txtNetEarnings = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtGrossEarnings = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txtLessTaxes = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.cbEmployees = new System.Windows.Forms.ComboBox();
			this.gbEmployee.SuspendLayout();
			this.gbEmployeeInfo.SuspendLayout();
			this.gbCalculatedWage.SuspendLayout();
			this.SuspendLayout();
			// 
			// gbEmployee
			// 
			this.gbEmployee.Controls.Add(this.rdoWeekly);
			this.gbEmployee.Controls.Add(this.rdoCommission);
			this.gbEmployee.Controls.Add(this.rdoHourly);
			this.gbEmployee.Location = new System.Drawing.Point(12, 12);
			this.gbEmployee.Name = "gbEmployee";
			this.gbEmployee.Size = new System.Drawing.Size(430, 80);
			this.gbEmployee.TabIndex = 0;
			this.gbEmployee.TabStop = false;
			this.gbEmployee.Text = "Select Type of Employee";
			// 
			// rdoWeekly
			// 
			this.rdoWeekly.AutoSize = true;
			this.rdoWeekly.Location = new System.Drawing.Point(292, 33);
			this.rdoWeekly.Name = "rdoWeekly";
			this.rdoWeekly.Size = new System.Drawing.Size(75, 21);
			this.rdoWeekly.TabIndex = 2;
			this.rdoWeekly.Text = "Weekly";
			this.rdoWeekly.UseVisualStyleBackColor = true;
			this.rdoWeekly.CheckedChanged += new System.EventHandler(this.rdoWeekly_CheckedChanged);
			// 
			// rdoCommission
			// 
			this.rdoCommission.AutoSize = true;
			this.rdoCommission.Location = new System.Drawing.Point(137, 33);
			this.rdoCommission.Name = "rdoCommission";
			this.rdoCommission.Size = new System.Drawing.Size(104, 21);
			this.rdoCommission.TabIndex = 1;
			this.rdoCommission.Text = "Commission";
			this.rdoCommission.UseVisualStyleBackColor = true;
			this.rdoCommission.CheckedChanged += new System.EventHandler(this.rdoCommission_CheckedChanged);
			// 
			// rdoHourly
			// 
			this.rdoHourly.AutoSize = true;
			this.rdoHourly.Checked = true;
			this.rdoHourly.Location = new System.Drawing.Point(16, 33);
			this.rdoHourly.Name = "rdoHourly";
			this.rdoHourly.Size = new System.Drawing.Size(70, 21);
			this.rdoHourly.TabIndex = 0;
			this.rdoHourly.TabStop = true;
			this.rdoHourly.Text = "Hourly";
			this.rdoHourly.UseVisualStyleBackColor = true;
			this.rdoHourly.CheckedChanged += new System.EventHandler(this.rdoHourly_CheckedChanged);
			// 
			// gbEmployeeInfo
			// 
			this.gbEmployeeInfo.Controls.Add(this.txtWage);
			this.gbEmployeeInfo.Controls.Add(this.txtName);
			this.gbEmployeeInfo.Controls.Add(this.txtHours);
			this.gbEmployeeInfo.Controls.Add(this.lblWageType);
			this.gbEmployeeInfo.Controls.Add(this.lblHours);
			this.gbEmployeeInfo.Controls.Add(this.label1);
			this.gbEmployeeInfo.Location = new System.Drawing.Point(12, 98);
			this.gbEmployeeInfo.Name = "gbEmployeeInfo";
			this.gbEmployeeInfo.Size = new System.Drawing.Size(324, 167);
			this.gbEmployeeInfo.TabIndex = 1;
			this.gbEmployeeInfo.TabStop = false;
			this.gbEmployeeInfo.Text = "Employee Information";
			// 
			// txtWage
			// 
			this.txtWage.Location = new System.Drawing.Point(148, 116);
			this.txtWage.Name = "txtWage";
			this.txtWage.Size = new System.Drawing.Size(152, 22);
			this.txtWage.TabIndex = 5;
			// 
			// txtName
			// 
			this.txtName.Location = new System.Drawing.Point(148, 34);
			this.txtName.Name = "txtName";
			this.txtName.Size = new System.Drawing.Size(152, 22);
			this.txtName.TabIndex = 3;
			// 
			// txtHours
			// 
			this.txtHours.Location = new System.Drawing.Point(148, 75);
			this.txtHours.Name = "txtHours";
			this.txtHours.Size = new System.Drawing.Size(152, 22);
			this.txtHours.TabIndex = 4;
			// 
			// lblWageType
			// 
			this.lblWageType.AutoSize = true;
			this.lblWageType.Location = new System.Drawing.Point(16, 119);
			this.lblWageType.Name = "lblWageType";
			this.lblWageType.Size = new System.Drawing.Size(94, 17);
			this.lblWageType.TabIndex = 2;
			this.lblWageType.Text = "Hourly Wage:";
			// 
			// lblHours
			// 
			this.lblHours.AutoSize = true;
			this.lblHours.Location = new System.Drawing.Point(16, 78);
			this.lblHours.Name = "lblHours";
			this.lblHours.Size = new System.Drawing.Size(103, 17);
			this.lblHours.TabIndex = 1;
			this.lblHours.Text = "Hours Worked:";
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(16, 37);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(49, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Name:";
			// 
			// btnCalculate
			// 
			this.btnCalculate.Location = new System.Drawing.Point(342, 117);
			this.btnCalculate.Name = "btnCalculate";
			this.btnCalculate.Size = new System.Drawing.Size(100, 35);
			this.btnCalculate.TabIndex = 6;
			this.btnCalculate.Text = "Calculate";
			this.btnCalculate.UseVisualStyleBackColor = true;
			this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(342, 167);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(100, 35);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// btnClose
			// 
			this.btnClose.Location = new System.Drawing.Point(342, 217);
			this.btnClose.Name = "btnClose";
			this.btnClose.Size = new System.Drawing.Size(100, 35);
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
			// 
			// gbCalculatedWage
			// 
			this.gbCalculatedWage.Controls.Add(this.txtNetEarnings);
			this.gbCalculatedWage.Controls.Add(this.label4);
			this.gbCalculatedWage.Controls.Add(this.txtGrossEarnings);
			this.gbCalculatedWage.Controls.Add(this.label3);
			this.gbCalculatedWage.Controls.Add(this.txtLessTaxes);
			this.gbCalculatedWage.Controls.Add(this.label2);
			this.gbCalculatedWage.Location = new System.Drawing.Point(12, 271);
			this.gbCalculatedWage.Name = "gbCalculatedWage";
			this.gbCalculatedWage.Size = new System.Drawing.Size(430, 149);
			this.gbCalculatedWage.TabIndex = 5;
			this.gbCalculatedWage.TabStop = false;
			this.gbCalculatedWage.Text = "Calculated Wage";
			// 
			// txtNetEarnings
			// 
			this.txtNetEarnings.Location = new System.Drawing.Point(132, 110);
			this.txtNetEarnings.Name = "txtNetEarnings";
			this.txtNetEarnings.ReadOnly = true;
			this.txtNetEarnings.Size = new System.Drawing.Size(279, 22);
			this.txtNetEarnings.TabIndex = 11;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(16, 31);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(110, 17);
			this.label4.TabIndex = 6;
			this.label4.Text = "Gross Earnings:";
			// 
			// txtGrossEarnings
			// 
			this.txtGrossEarnings.Location = new System.Drawing.Point(132, 28);
			this.txtGrossEarnings.Name = "txtGrossEarnings";
			this.txtGrossEarnings.ReadOnly = true;
			this.txtGrossEarnings.Size = new System.Drawing.Size(279, 22);
			this.txtGrossEarnings.TabIndex = 9;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(16, 72);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(65, 17);
			this.label3.TabIndex = 7;
			this.label3.Text = "Less Tax";
			// 
			// txtLessTaxes
			// 
			this.txtLessTaxes.Location = new System.Drawing.Point(132, 69);
			this.txtLessTaxes.Name = "txtLessTaxes";
			this.txtLessTaxes.ReadOnly = true;
			this.txtLessTaxes.Size = new System.Drawing.Size(279, 22);
			this.txtLessTaxes.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(16, 113);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 17);
			this.label2.TabIndex = 8;
			this.label2.Text = "Net Earnings:";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(28, 444);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 17);
			this.label5.TabIndex = 6;
			this.label5.Text = "Employees:";
			// 
			// cbEmployees
			// 
			this.cbEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cbEmployees.FormattingEnabled = true;
			this.cbEmployees.Location = new System.Drawing.Point(144, 441);
			this.cbEmployees.Name = "cbEmployees";
			this.cbEmployees.Size = new System.Drawing.Size(279, 24);
			this.cbEmployees.TabIndex = 12;
			this.cbEmployees.SelectedIndexChanged += new System.EventHandler(this.cbEmployees_SelectedIndexChanged);
			// 
			// WageCalculator
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(464, 496);
			this.Controls.Add(this.cbEmployees);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.gbCalculatedWage);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnCalculate);
			this.Controls.Add(this.gbEmployeeInfo);
			this.Controls.Add(this.gbEmployee);
			this.MaximizeBox = false;
			this.Name = "WageCalculator";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Wage Calculator";
			this.gbEmployee.ResumeLayout(false);
			this.gbEmployee.PerformLayout();
			this.gbEmployeeInfo.ResumeLayout(false);
			this.gbEmployeeInfo.PerformLayout();
			this.gbCalculatedWage.ResumeLayout(false);
			this.gbCalculatedWage.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.GroupBox gbEmployee;
		private System.Windows.Forms.RadioButton rdoWeekly;
		private System.Windows.Forms.RadioButton rdoCommission;
		private System.Windows.Forms.RadioButton rdoHourly;
		private System.Windows.Forms.GroupBox gbEmployeeInfo;
		private System.Windows.Forms.Label lblWageType;
		private System.Windows.Forms.Label lblHours;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txtWage;
		private System.Windows.Forms.TextBox txtName;
		private System.Windows.Forms.TextBox txtHours;
		private System.Windows.Forms.Button btnCalculate;
		private System.Windows.Forms.Button btnClear;
		private System.Windows.Forms.Button btnClose;
		private System.Windows.Forms.GroupBox gbCalculatedWage;
		private System.Windows.Forms.TextBox txtNetEarnings;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox txtGrossEarnings;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txtLessTaxes;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.ComboBox cbEmployees;
	}
}

