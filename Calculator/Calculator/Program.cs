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
                Console.WriteLine("Select calculator type");
                Console.WriteLine("1. Base calculator");
                Console.WriteLine("2. Scientific calculator");
                Console.WriteLine("0. Exit");

                Console.Write("Your choise: \n");
                string choise = Console.ReadLine();

                if (choise == "0")
                    break;

                Calculator calc = choise switch
                {
                    "1" => new Calculator(),
                    "2" => new ScientificCalculator(),
                    _ => null
                };

                if (calc == null)
                {
                    Console.WriteLine("Incorrect sellection. Try again.\n");
                    continue;
                }
                try
                {
                    if (calc is ScientificCalculator sciCalc)
                        RunScientificCalculator(sciCalc);
                    else
                        RunBaseCalculator(calc);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Error: Non-numeric value entered.\n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error: {ex.Message}\n");
                }
            }
                
            static void RunBaseCalculator(Calculator calc)
            {
                Console.WriteLine("Base calculator selected...");
                Console.Write("Enter first number: ");
                double firstNumber = double.Parse(Console.ReadLine());
                Console.Write("Enter second number: ");
                double secondNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Select action (enter numder of action): ");
                Console.WriteLine("1. +");
                Console.WriteLine("2. -");
                Console.WriteLine("3. *");
                Console.WriteLine("4. /");

                Console.Write("Your choise: ");
                string action = Console.ReadLine();

                double result = action switch
                {
                    "1" => calc.Add(firstNumber, secondNumber),
                    "2" => calc.Substract(firstNumber, secondNumber),
                    "3" => calc.Multiply(firstNumber, secondNumber),
                    "4" => calc.Divide(firstNumber, secondNumber),
                    _ => throw new InvalidOperationException("Invalid operation!"),
                };
                Console.WriteLine($"Result: {result}");
                Console.WriteLine($"LastResult = {calc.LastResult}\n");                
            }

            static void RunScientificCalculator(ScientificCalculator sciCalc)
            {
                Console.WriteLine("\nScientific calculator selected...");
                Console.WriteLine("Select action (enter numder of action):");
                Console.WriteLine("1. +");
                Console.WriteLine("2. -");
                Console.WriteLine("3. *");
                Console.WriteLine("4. /");
                Console.WriteLine("5. Pow");
                Console.WriteLine("6. Sqrt");
                Console.WriteLine("7. Sin");
                Console.WriteLine("8. Cos");
                Console.Write("Your choise: ");

                string action = Console.ReadLine();
                double result;

                switch (action)
                {
                    case "1":
                        result = sciCalc.Add(Read("first number"), Read("second number"));
                        break;
                    case "2":
                        result = sciCalc.Substract(Read("first number"), Read("second number"));
                        break;
                    case "3":
                        result = sciCalc.Multiply(Read("first Number"), Read("second Number"));
                        break;
                    case "4":
                        result = sciCalc.Divide(Read("first Number"), Read("second Number"));
                        break;
                    case "5":
                        result = sciCalc.Pow(Read("first number (base)"), Read("second number (exponent)"));
                        break;
                    case "6":
                        result = sciCalc.Sqrt(Read("number"));
                        break;
                    case "7":
                        result = sciCalc.Sin(Read("angle in degrees"));
                        break;
                    case "8":
                        result = sciCalc.Cos(Read("angle in degrees"));
                        break;
                    default:
                        throw new InvalidOperationException("Unknown operation!");
                }

                Console.WriteLine($"Result: {result}");
                Console.WriteLine($"LastResult = {sciCalc.LastResult}\n");
            }
            static double Read(string name)
            {
                Console.Write($"Enter {name}: ");
                return double.Parse(Console.ReadLine());
            }

        }
    }
}
