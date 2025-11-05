namespace MoneyAndGoodsLib
{
    public class Money
    {
        private int _wholePart;
        private int _cents;

        public string Curency { get; private set; }

        public int WholePart
        {
            get => _wholePart;
            private set
            {
                //if (value < 0 || value > 99)
                    //throw new ArgumentException("Whole part must be in range 0-99.");
                _wholePart = value;
            }
        }

        public int Cents
        {
            get => _cents;
            private set
            {
                //if (value < 0 || value > 99)
                    //throw new ArgumentException("Cents must be in range 0-99.");
                _cents = value;
            }
        }

        public Money(int wholePart, int cents, string curency)
        {
            Curency = curency;
            SetAmount(wholePart,cents);
        }

        public void SetAmount(int wholePart, int cents)
        {
            WholePart = wholePart;
            Cents = cents;
        }

        public override string ToString()
        {
            return $"{WholePart} {Curency} | {Cents} coins/cents";
        }

        public void Increase(Money amount)
        {
            int totalCents = ToTotalCents() + amount.ToTotalCents();
            FromTotalCents(totalCents);
        }

        public void Decrease(Money amount)
        {
            int totalCents = ToTotalCents() - amount.ToTotalCents();
            FromTotalCents(totalCents);
        }

        private int ToTotalCents()
        {
            return WholePart * 100 + Cents;
        }

        private void FromTotalCents(int totalCents)
        {
            WholePart = totalCents / 100;
            Cents = totalCents % 100;
        }
    }
}
