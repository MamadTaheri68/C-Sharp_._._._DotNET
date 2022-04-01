using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7_ConvertProject
{
    public class Rial
    {
        public int Value { get; set; }
        public static Rial operator +(Rial r1, Rial r2)
        {
            return new Rial
            {
                Value = r1.Value + r2.Value
            };
        }
        public static implicit operator Dolar(Rial r)
        {
            return new Dolar
            {
                Value = r.Value / 4000
            };
        }
        public static implicit operator Rial(Dolar r)
        {
            return new Rial
            {
                Value = r.Value * 4000
            };
        }
        public static Rial operator +(Dolar d, Rial r)
        {
            Rial r2 = d;
            return r + r2;
        }
    }
    public class Dolar
    {
        public int Value { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
