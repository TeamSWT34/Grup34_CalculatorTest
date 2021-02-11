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

		[Test]
		public void Add_ToNumbers(int a, int b, int result)
		{
			Assert.That(uut.Add(a, b), Is.EqualTo(result));
		}

		[Test]
		public void Substract_ToNumbers()
		{
			Assert.That(uut.Subst(2, 2), Is.EqualTo(0));
		}

		[Test]
		public void Multiply_ToNumbers()
		{
			Assert.That(uut.Multiply(2, 2), Is.EqualTo(4));
		}

		[Test]
		public void Power_ToNumbers()
		{
			Assert.That(uut.Power(2, 2), Is.EqualTo(4));
		}

		[Test]
		public void AddItem_null_Throws()
		{
			//Act + Assert
			Assert.That(code: () => uut.Multiply(0, 2),
				constraint: Throws.TypeOf<ArgumentOutOfRangeException>());
		}
	}
}