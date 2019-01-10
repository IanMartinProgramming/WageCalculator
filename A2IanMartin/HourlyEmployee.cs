using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2IanMartin
{
	class HourlyEmployee : Employee
	{
		public override double HoursWorked {
			get => base.HoursWorked;
			set => base.HoursWorked = value;
		}
		public override double HourlyWage {
			get => base.HourlyWage;
			set => base.HourlyWage = value;
		}
		public override double GrossEarnings()
		{
			if (HoursWorked <= 40)
				return HourlyWage * HoursWorked;
			else
				return (HourlyWage * HoursWorked) + (HoursWorked - 40) * (HourlyWage * 1.5);
		}

		public HourlyEmployee(string name, EmpType type, double hoursWorked, 
			double hourlyWage) : base(name, type)
		{
			HoursWorked = hoursWorked;
			HourlyWage = hourlyWage;
		}
	}
}
