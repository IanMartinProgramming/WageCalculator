using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2IanMartin
{
	class SalariedEmployee : Employee
	{
		public override double WeeklySalary {
			get => base.WeeklySalary;
			set => base.WeeklySalary = value;
		}
		public override double GrossEarnings()
		{
			return WeeklySalary;
		}

		public SalariedEmployee(string name, EmpType type,
			double weeklySalary) : base(name, type)
		{
			WeeklySalary = weeklySalary;
		}
	}
}
