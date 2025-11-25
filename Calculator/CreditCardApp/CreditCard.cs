using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CreditCardApp
{
    public class CreditCard
    {
        public string CardNumber { get; set; }
        public int Cvc { get; set; }
        public decimal Balance { get; set; }

        public CreditCard(string cardNumber, int cvc, decimal balance)
        {
            CardNumber = cardNumber;
            Cvc = cvc;
            Balance = balance;
        }

        public static CreditCard operator +(CreditCard card, decimal amount)
        {
            return new CreditCard(card.CardNumber, card.Cvc, card.Balance + amount);
        }

        public static CreditCard operator -(CreditCard card, decimal amount)
        {
            return new CreditCard(card.CardNumber, card.Cvc, card.Balance - amount);
        }

        public static bool operator ==(CreditCard a, CreditCard b)
        {
            if (ReferenceEquals(a, b)) return true;
            if (a is null || b is null) return false;
            return a.Cvc == b.Cvc;
        }

        public static bool operator !=(CreditCard a, CreditCard b)
        {
            return !(a == b);
        }

        public static bool operator <(CreditCard a, CreditCard b)
        {
            return a.Balance < b.Balance;
        }

        public static bool operator >(CreditCard a, CreditCard b)
        {
            return a.Balance > b.Balance;
        }

        public override bool Equals(object obj)
        {
            if (obj is CreditCard other)
                return Cvc == other.Cvc;
            return false;
        }

        public override int GetHashCode()
        {
            return Cvc.GetHashCode();
        }

        public override string ToString()
        {
            return $"Card: {CardNumber}, CVC: {Cvc}, Balance: {Balance} UAH";
        }
    }
}
