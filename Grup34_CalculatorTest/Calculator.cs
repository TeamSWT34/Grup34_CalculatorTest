using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grup34_CalculatorTest
{
    public class Calculator
    {
        public Calculator()
        {
            Accumulator = 0;
        }
        public double Accumulator { get; private set; }

        public double Add(double a, double b) => a + b;


        public double Subst(double a, double b) => a - b;
        public double Multiply(double a, double b) => a * b;
        public double Power(double x, double exp) => Math.Pow(x, exp);

        public double Divide(double dividend, double divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentOutOfRangeException(paramName: "Can't divide by 0");
            }

            return dividend / divisor;
        }


        public double Add(double addend) => (Accumulator += addend);

        public double Subst(double subtractor) => (Accumulator -= subtractor);

        public double Multiply(double multiplier) => (Accumulator *= multiplier);

        public double Power(double exponent) => (Accumulator = Math.Pow(Accumulator, exponent));


        public double Divide(double divisor)
        {
            if (divisor == 0)
            {
                throw new ArgumentOutOfRangeException(paramName: "Can't divide by 0");
            }

            return Accumulator /= divisor;
        }

    }
}