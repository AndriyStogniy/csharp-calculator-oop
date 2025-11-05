using DecimalNumberApp;

Console.Write("Enter decimal number: ");
int number = int.Parse(Console.ReadLine());

DecimalNumber dec = new DecimalNumber(number);

Console.WriteLine("\nResults:");
Console.WriteLine($"Binary: {dec.ToBinary()}");
Console.WriteLine($"Octal: {dec.ToOctal()}");
Console.WriteLine($"Hex: {dec.ToHex()}");