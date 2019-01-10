using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2IanMartin
{
	public enum EmpType
	{
		Hourly, Commission, Salary
	}

	abstract class Employee
	{
		public string Name { get; set; }
		public EmpType Type { get; set; }

		public abstract double GrossEarnings();

		private readonly double tax = 0.2;
		public double Tax
		{
			get { return GrossEarnings() * tax; }
		}

		public double NetEarnings
		{
			get { return GrossEarnings() - Tax; }
		}

		public virtual double HoursWorked { get; set; }
		public virtual double HourlyWage { get; set; }
		public virtual double GrossSales { get; set; }
		public virtual double CommissionRate { get; set; }
		public virtual double WeeklySalary { get; set; }

		public Employee(string name, EmpType type)
		{
			Name = name;
			Type = type;
		}
	}
}
