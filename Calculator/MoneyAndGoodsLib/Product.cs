namespace MoneyAndGoodsLib
{
    public class Product
    {
        public string ProductName { get; set; }
        public Money Price { get; set; }

        public Product(string productName, Money price)
        {
            ProductName = productName;
            Price = price;
        }
        public void IncreasePrice(Money amount)
        {
            Price.Increase(amount);
        }
        public void DecreasePrice(Money amount)
        {
            Price.Decrease(amount);
        }

        public override string ToString()
        {
            return 
                $"Name: {ProductName}\n" + 
                $"Price {Price.ToString()}";
        }
    }
}
