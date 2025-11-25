using CityApp;

City kyiv = new City("Kyiv", 3000000);
City lviv = new City("Lviv", 700000);

City kyivGrowth = kyiv + 50000;
City lvivLoss = lviv - 20000;

Console.WriteLine(kyivGrowth);
Console.WriteLine(lvivLoss);
Console.WriteLine();

Console.WriteLine($"Kyiv > Lviv: {kyiv > lviv}");
Console.WriteLine($"Kyiv < Lviv: {lviv < kyiv}");
Console.WriteLine($"Kyiv == Lviv: {kyiv == lviv}");
Console.WriteLine();

City a = new City("A", 100000);
City b = new City("B", 100000);

Console.WriteLine($"A == B: {a == b}");

