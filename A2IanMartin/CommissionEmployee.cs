using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A2IanMartin
{
	class CommissionEmployee : Employee
	{
		public override double GrossSales {
			get => base.GrossSales;
			set => base.GrossSales = value;
		}
		public override double CommissionRate {
			get => base.CommissionRate;
			set => base.CommissionRate = value;
		}
		public override double GrossEarnings()
		{
			return GrossSales * CommissionRate;
		}

		public CommissionEmployee(string name, EmpType type, double grossSales, 
			double commissionRate) : base(name, type)
		{
			GrossSales = grossSales;
			CommissionRate = commissionRate;
		}
	}
}
