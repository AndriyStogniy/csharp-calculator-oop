using MoneyAndGoodsLib;

Product product = new Product("Tea", new Money(150, 99, "$"));

while (true)
{
    Console.WriteLine("\tMenu");
    Console.WriteLine("1. Show product");
    Console.WriteLine("2. Increase price");
    Console.WriteLine("3. Decrease price");
    Console.WriteLine("0. Exit");
    Console.Write("Your choise: ");
    string choise = Console.ReadLine();
    Console.WriteLine();

    switch (choise)
    {
        case "1":
            Console.WriteLine(product + "\n");
            break;

        case "2":
            Console.Write("Enter value to increase (ex: 100,50): ");
            string increasingValue = Console.ReadLine();
            string[] incList = increasingValue.Split(',');
            try
            {
                int increaseWholeValue = int.Parse(incList[0]);
                int increaseCents = int.Parse(incList[0]);
                product.IncreasePrice(new Money(increaseWholeValue, increaseCents, product.Price.Curency));
                Console.WriteLine($"Current price is: {product.Price}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            break;

        case "3":
            Console.Write("Enter value to decrease (ex: 100,50): ");
            string decreasingValue = Console.ReadLine();
            string[] decList = decreasingValue.Split(',');
            try
            {
                int decreaseWholeValue = int.Parse(decList[0]);
                int decreaseCents = int.Parse(decList[0]);
                product.DecreasePrice(new Money(decreaseWholeValue, decreaseCents, product.Price.Curency));
                Console.WriteLine($"Current price is: {product.Price}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"ERROR: {ex.Message}");
            }
            break;

        case "0":
            return;

        default:
            Console.WriteLine("Entered option is incorrect. Try again.");
            break;
    }

}

