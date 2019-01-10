using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace A2IanMartin
{

	public partial class WageCalculator : Form
	{
		// Common variables
		string name;
		Employee newEmp;

		// Hourly only
		double hours;
		double wage;

		// Commission only
		double grossSales;
		double commissionRate;

		// Weekly only
		double weeklySalary;

		// List of Employee Objects
		List<Employee> emps;

		// Enumeration for Employee type
		EmpType type;

		public WageCalculator()
		{
			InitializeComponent();
			emps = new List<Employee>();
		}

		private void btnCalculate_Click(object sender, EventArgs e)
		{
			// Error handling for name
			if (txtName.Text != "") {
				name = txtName.Text;
				if (cbEmployees.Items.Contains(name))
				{
					MessageBox.Show("Employee already exists", "Error", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
			} else {
				MessageBox.Show("Name can not be blank", "Error",
					MessageBoxButtons.OK, MessageBoxIcon.Error);
				return;
			}

			if (rdoHourly.Checked == true)
			{
				type = EmpType.Hourly;

				// Hours input with error handling
				try
				{
					hours = double.Parse(txtHours.Text);
					if (hours <= 0 || hours > 80)
					{ 
						MessageBox.Show("Hours cannot be less than 0 or more than 80", 
							"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				catch
				{
					MessageBox.Show("Hours must be numerical", "Error", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// Wage input with error handling
				try
				{
					wage = double.Parse(txtWage.Text);
					if (wage <= 0)
					{
						MessageBox.Show("Wage must be a positive number", 
							"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				catch
				{
					MessageBox.Show("Wage must be numerical", "Error", 
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				newEmp = new HourlyEmployee(name, type, hours, wage);
				emps.Add(newEmp);
				cbEmployees.Items.Add(newEmp.Name);

				UpdateForm(newEmp);
			}
			else if (rdoCommission.Checked == true)
			{
				type = EmpType.Commission;

				// Error handling for Gross Sales
				try
				{
					grossSales = double.Parse(txtHours.Text);
					if (grossSales <= 0)
					{
						MessageBox.Show("Gross Sales must be a positive number",
							"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				catch
				{
					MessageBox.Show("Gross Sales must be numerical", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				// Commission Rate input with error handling
				try
				{
					commissionRate = double.Parse(txtWage.Text) / 100;
					if (commissionRate <= 0)
					{
						MessageBox.Show("Commission Rate must be a positive number", 
							"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				catch
				{
					MessageBox.Show("Commission Rate must be numerical", "Error",
						MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				

				newEmp = new CommissionEmployee(name, type, grossSales, commissionRate);
				emps.Add(newEmp);
				cbEmployees.Items.Add(newEmp.Name);

				UpdateForm(newEmp);
			}
			else if (rdoWeekly.Checked == true)
			{
				type = EmpType.Salary;

				// Weekly Salary input with error handling
				try
				{
					weeklySalary = double.Parse(txtHours.Text);
					if (weeklySalary <= 0)
					{
						MessageBox.Show("Weekly Salary must be a positive number", 
							"Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
						return;
					}
				}
				catch
				{
					MessageBox.Show("Weekly Salary must be numerical", "Error", 
							MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}
				
				newEmp = new SalariedEmployee(name, type, weeklySalary);
				emps.Add(newEmp);
				cbEmployees.Items.Add(newEmp.Name);

				UpdateForm(newEmp);
			}
		}

		private void btnClear_Click(object sender, EventArgs e)
		{
			// Clear all fields
			txtGrossEarnings.Text = "";
			txtHours.Text = "";
			txtName.Text = "";
			txtNetEarnings.Text = "";
			txtLessTaxes.Text = "";
			txtWage.Text = "";
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			// Close Form
			this.Close();
		}

		private void rdoCommission_CheckedChanged(object sender, EventArgs e)
		{
			// Update Form
			lblHours.Text = "Gross Sales:";
			lblWageType.Text = "Commission Rate:";
			txtWage.ReadOnly = false;
		}

		private void rdoWeekly_CheckedChanged(object sender, EventArgs e)
		{
			// Update Form
			lblHours.Text = "Weekly Salary:";
			lblWageType.Text = "";
			txtWage.Text = "";
			txtWage.ReadOnly = true;
		}

		private void rdoHourly_CheckedChanged(object sender, EventArgs e)
		{
			// Update Form
			lblHours.Text = "Hours Worked:";
			lblWageType.Text = "Hourly Wage:";
			txtWage.ReadOnly = false;
		}

		private void cbEmployees_SelectedIndexChanged(object sender, EventArgs e)
		{
			string employeeName = cbEmployees.Text;
			Employee oldEntry = emps.Find(Employee => Employee.Name == employeeName);

			if(oldEntry.Type == EmpType.Hourly)
			{
				rdoHourly.Checked = true;
				txtHours.Text = oldEntry.HoursWorked.ToString();
				txtWage.Text = oldEntry.HourlyWage.ToString("C");
			}
			else if (oldEntry.Type == EmpType.Commission)
			{
				rdoCommission.Checked = true;
				txtHours.Text = oldEntry.GrossSales.ToString("C");
				txtWage.Text = oldEntry.CommissionRate.ToString("P");
			}
			else if (oldEntry.Type == EmpType.Salary)
			{
				rdoWeekly.Checked = true;
				txtHours.Text = oldEntry.WeeklySalary.ToString("C");
				txtWage.Text = "";
			}

			UpdateForm(oldEntry);
		}

		private void UpdateForm(Employee currentEmp)
		{
			txtName.Text = currentEmp.Name;
			txtGrossEarnings.Text = currentEmp.GrossEarnings().ToString("C");
			txtLessTaxes.Text = currentEmp.Tax.ToString("C");
			txtNetEarnings.Text = currentEmp.NetEarnings.ToString("C");
		}
	}
}
