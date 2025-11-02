using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorLib
{
    public class ScientificCalculator: Calculator
    {
        public double Pow(double a, double b)
        {
            LastResult = Math.Pow(a, b);
            return LastResult;
        }
        public double Sqrt(double a)
        {
            if (a < 0)
                throw new InvalidOperationException("Impossible to calculate the square root of a negative number");
            LastResult = Math.Sqrt(a);
            return LastResult;
        }

        public double Sin(double angleDegrees)
        {
            double radians = angleDegrees * Math.PI / 180;
            LastResult = Math.Sin(radians);
            return LastResult;
        }

        public double Cos(double angleDegrees)
        {
            double radians = angleDegrees * Math.PI / 180;
            LastResult = Math.Cos(radians);
            return LastResult;
        }
        public override double Divide(double a, double b)
        {
            Console.WriteLine("Scientific division is performed...");
            return base.Divide(a, b);
        }
    }
}
