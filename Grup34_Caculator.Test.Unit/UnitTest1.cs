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

        [TestCase(2, 0)]
        public void Divide_NumbByZero(double a, double b)
        {
            //Act + Assert
            Assert.That(code: () => uut.Divide(a, b),
                constraint: Throws.TypeOf<ArgumentOutOfRangeException>());
        }

		[TestCase(10, 2, 5)]
        [TestCase(45, 5, 9)]
        [TestCase(90, 10, 9)]
        [TestCase(4, 32, 0.125)]
        public void Divide_ToNumbers(double a, double b, double result)
        {
            Assert.That(uut.Divide(a, b), Is.EqualTo(result));
		}


        //
        // ------- Accumulator --------
        //
        

        [TestCase(2, 2, 4)]
        [TestCase(2, -2, 0)]
        [TestCase(1, -2.5, -1.5)]
        public void Add_ToAccumulator(double a, double b, double result)
        {
            uut.Add(a);
            uut.Add(b);
			Assert.AreEqual(result,uut.Accumulator);
        }

        [TestCase(2, 2, -4)]
        [TestCase(2, -2, 0)]
        [TestCase(1, -5, 4)]
        public void Subtract_ToAccumulator(double a, double b, double result)
        {
            uut.Subst(a);
            uut.Subst(b);
            Assert.AreEqual(result, uut.Accumulator);
        }

        [TestCase(2, 9, 18)]
        [TestCase(29, 0, 0)]
        [TestCase(2, 10, 20)]
        [TestCase(2, 2, 4)]
        public void Multiply_ToAccumulator(double a, double b, double result)
        {
            uut.Add(a);
            uut.Multiply(b);
            Assert.AreEqual(result, uut.Accumulator);
        }


		[TestCase(1232, 0, 1)]
        [TestCase(2, 4, 16)]
        [TestCase(69, 2, 4761)]
        [TestCase(-23, 0.5, double.NaN)]
        public void Power_ToAccumulator(double a, double b, double result)
        {
            uut.Add(a);
            uut.Power(b);
            Assert.AreEqual(result, uut.Accumulator);
        }


        [TestCase(10, 2, 5)]
        [TestCase(45, 5, 9)]
        [TestCase(90, 10, 9)]
        [TestCase(4, 32, 0.125)]
        public void Divide_ToAccumulator(double a, double b, double result)
        {
            uut.Add(a);
            uut.Divide(b);
            Assert.AreEqual(result, uut.Accumulator);
        }

        //
        // ------- Accumulator Advanced --------
        //

        [TestCase(10, 2, 12, 96)]
        public void Add_ToAccumulator(double a, double b, double c, double result)
        {
            uut.Add(a);
            uut.Subst(b);
            uut.Multiply(c);
            Assert.AreEqual(result, uut.Accumulator);
        }

        [TestCase(10, 43, 2, 184900)]
        public void Subtract_ToAccumulator(double a, double b, double c, double result)
        {
            uut.Subst(a);
            uut.Multiply(b);
            uut.Power(c);
            Assert.AreEqual(result, uut.Accumulator);
        }


        [TestCase(10, 184900, double.PositiveInfinity)]
        public void Power_OutOfRange(double a, double b,  double result)
        {
            uut.Add(a);
            uut.Power(b);
            Assert.AreEqual(result, uut.Accumulator);
        }

        //
        // ------- Clear function --------
        //


        [TestCase(10, 43, 10, 10)]
        [TestCase(1515, 215, 0, 0)]
        public void Clear_ToAccumulator(double a, double b, double c, double result)
        {
            uut.Subst(a);
            uut.Multiply(b);
            uut.Clear();
            uut.Add(c);
            Assert.AreEqual(result, uut.Accumulator);
        }

    }
}