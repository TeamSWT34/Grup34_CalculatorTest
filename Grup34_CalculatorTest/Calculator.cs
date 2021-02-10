using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup34_CalculatorTest
{
	public class Calculator
	{
		public double Add(double a, double b)
		{
			return a + b;
		}

		public double Subst(double a, double b)
		{
			return a - b;
		}

		public double Multiply(double a, double b)
		{
			if (a == 0 || b == 0)
			{
				throw new ArgumentOutOfRangeException(paramName: "Du kan ikke gange med 0");
			}
			else
			{
				return a * b;
			}
		}

		public double Power(double x, double exp)
		{
			return Math.Pow(x, exp);
		}
	}
}
