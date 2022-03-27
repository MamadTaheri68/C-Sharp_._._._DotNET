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
            System.Data.SqlClient.SqlConnection cnn; // Creates null variable on stack and keeps the address;
            cnn = new System.Data.SqlClient.SqlConnection(); // creates on heap

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
        public void valueTypes()
        {
            SByte a;
            short b;
            int c;
            long d;
            float e;
            double f;
            decimal g;
            var temp = @"c:\\\\\\\\\\\\\";
            Console.WriteLine(temp);
            var str = "ali" + DateTime.Now + "data";
            var str2 = $"ali {DateTime.Now.ToString()} reza";
        }
    }
}
