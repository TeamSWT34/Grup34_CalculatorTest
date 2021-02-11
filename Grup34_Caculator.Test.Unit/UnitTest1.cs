using Grup34_CalculatorTest;
using NUnit.Framework;
using System;

namespace Grup34_Caculator.Test.Unit
{
	[TestFixture]
	public class CalculatorTests
	{
		private Calculator uut;

		[SetUp]

		public void Setup()
		{
			uut = new Calculator();
		}

		[TestCase(2, 2, 4)]
		[TestCase(2, -2, 0)]
		[TestCase(1, -2.5, -1.5)]
		public void Add_ToNumbers(double a, double b, double result)
		{
			Assert.That(uut.Add(a, b), Is.EqualTo(result));
		}

		[TestCase(2, 2, 0)]
		[TestCase(2, -6, 8)]
		[TestCase(-4, 2, -6)]
		[TestCase(2, 1, 1)]
		public void Substract_ToNumbers(double a, double b, double result)
		{
			Assert.That(uut.Subst(a, b), Is.EqualTo(result));
		}

		[TestCase(2, 9, 18)]
		[TestCase(29, 0, 0)]
		[TestCase(2, 10, 20)]
		[TestCase(2, 2, 4)]
		public void Multiply_ToNumbers(double a, double b, double result)
		{
			Assert.That(uut.Multiply(a, b), Is.EqualTo(result));
		}

		[TestCase(1232, 0 , 1)]
		[TestCase(2, 4, 16)]
		[TestCase(69, 2, 4761)]
		[TestCase(-23, 0.5, double.NaN)]
		public void Power_ToNumbers(double a, double b, double result)
		{
			Assert.That(uut.Power(a, b), Is.EqualTo(result));
		}

		//[TestCase(0, 2)]
		//[TestCase(2, 2)]
		//public void AddItem_null_Throws(int a, int b)
		//{
		//	//Act + Assert
		//	Assert.That(code: () => uut.Multiply(a, b),
		//		constraint: Throws.TypeOf<ArgumentOutOfRangeException>());
		//}
	}
}