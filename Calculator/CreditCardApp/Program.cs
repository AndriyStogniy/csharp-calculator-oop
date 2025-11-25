using CreditCardApp;

CreditCard card1 = new CreditCard("4444 1111 2222 3333", 123, 5000);
CreditCard card2 = new CreditCard("5555 8888 9999 0000", 123, 3000);
CreditCard card3 = new CreditCard("1111 2222 3333 4444", 555, 8000);

var card1New = card1 + 1000;
var card2New = card2 - 500;

Console.WriteLine(card1New);
Console.WriteLine(card2New);
Console.WriteLine();

Console.WriteLine($"CVC1 == CVC2: {card1 == card2}");
Console.WriteLine($"CVC1 != CVC3: {card1 != card3}");
Console.WriteLine();

Console.WriteLine($"Balance1 > Balance2: {card1 > card2}");
Console.WriteLine($"Balance2 < Balance3: {card2 < card3}");