using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecimalNumberApp
{
    public struct DecimalNumber
    {
        public int Value { get; set; }

        public DecimalNumber(int value)
        {
            Value = value;
        }

        public string ToBinary()
        {
            return Convert.ToString(Value, 2);
        }

        public string ToOctal()
        {
            return Convert.ToString(Value, 8);
        }

        public string ToHex()
        {
            return Convert.ToString(Value, 16).ToUpper();
        }

        public override string ToString()
        {
            return $"Decimal: {Value}";
        }
    }
}
