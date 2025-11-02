using System;
using CalculatorLib;

namespace CalculatorApp
{
    internal class Program
    {
        public static void Main()
        {
            while (true)
            {
                Calculator calc = new Calculator();
                try
                {
                    Console.Write("Enter first number: ");
                    double firstNumber = double.Parse(Console.ReadLine());
                    Console.Write("Enter second number: ");
                    double secondNumber = double.Parse(Console.ReadLine());
                    Console.Write("Select action (+, -, *, /): ");
                    string action = Console.ReadLine();

                    double result = action switch
                    {
                        "+" => calc.Add(firstNumber, secondNumber),
                        "-" => calc.Substract(firstNumber, secondNumber),
                        "*" => calc.Multiply(firstNumber, secondNumber),
                        "/" => calc.Divide(firstNumber, secondNumber),
                        _ => throw new InvalidOperationException("Invalid operation!"),
                    };
                    Console.WriteLine($"Result: {result}");
                    Console.WriteLine($"LastResult = {calc.LastResult}\n");
                }
                catch (FormatException)
                {
                    Console.WriteLine($"⚠️ Error: Non-numeric value entered.\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"⚠️ Error: {ex.Message}\n");

                }
            }
        }
    }
}
