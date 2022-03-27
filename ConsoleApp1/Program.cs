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
            new Program().TestMethod();
            Console.ReadLine();
        }

        int a = 5;
        public void TestMethod()
        {
            int a = 123;
            Console.WriteLine(a.ToString());
            this.a = 123321456;
            Console.WriteLine(this.a.ToString());
        }
    }
}
