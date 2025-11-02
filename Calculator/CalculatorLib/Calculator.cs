namespace CalculatorLib
{
    public class Calculator
    {
        public double LastResult { get; protected set; }

        public double Add(double a, double b)
        {
            LastResult = a + b;
            return LastResult;
        }
        public double Substract(double a, double b)
        {
            LastResult = a - b;
            return LastResult;
        }
        public double Multiply(double a, double b)
        {
            LastResult = a * b;
            return LastResult;
        }
        public virtual double Divide(double a, double b)
        {
            if (b == 0)
                throw new DivideByZeroException("Division by zero is impossible");
            LastResult = a / b;
            return LastResult;
        }
    }
}
