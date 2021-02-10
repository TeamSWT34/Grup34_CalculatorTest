using System;

namespace Grup34_CalculatorTest
{
	class Program
	{
		static void Main(string[] args)
		{
			Calculator calculator = new Calculator();

			Console.WriteLine("Når man lægger 2 og 2 sammen, giver det: " + calculator.Add(2, 2));
			Console.WriteLine("Når man Trækker 2 og 2 fra hinanden, giver det: " + calculator.Subst(2, 2));
			Console.WriteLine("Når man ganger 2 og 2 sammen, giver det: " + calculator.Multiply(2, 2));
			Console.WriteLine("2 op i 3 giver: " + calculator.Power(2, 3));

		}
	}
}
