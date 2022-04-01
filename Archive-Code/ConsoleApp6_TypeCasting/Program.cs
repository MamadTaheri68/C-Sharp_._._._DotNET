using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6_TypeCasting
{
    public class Money
    {
        public static implicit operator Money(double input)
        {
            return new Money
            {
                Value = (int)input,
                Ashar = (int)(input - (int)input) * 100
            };
        }
        public static implicit operator double(Money input)
        {
            double d = 123.11;
            return d;
        }
        public int Value { get; set; }
        public int Ashar { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double myMoneyDouble = 1000.2;
            Money m = myMoneyDouble;
        }
    }
}
