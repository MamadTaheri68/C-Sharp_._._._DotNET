using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            var inta = 123;
            var boolb = true;

            Console.WriteLine(inta.GetType().ToString());
            Console.WriteLine(boolb.GetType().ToString());
            Console.ReadLine();
        }
        public void TestMethod()
        {
            int a = 123;
            if (a == 123)
            {
                int b = 1234;
            }
            b = 5;
        }
    }
}
