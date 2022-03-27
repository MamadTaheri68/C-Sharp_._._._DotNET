using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ConsoleApp1
{
    class Program
    {

        public enum WeekDay
        {
            Sat = 1,
            Fri = 7,
            Wed = 4
        }
        static void Main(string[] args)
        {

            WeekDay day;
            day = WeekDay.Sat;
            string wd = Console.ReadLine();
            day = (WeekDay)Enum.Parse(typeof(WeekDay), wd);

            List<string> names = new List<string> { "ali", "mamad", "zahra" };
            foreach (var item in names)
            {
                Console.WriteLine(item);
            }
            SqlConnection cnn;
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.Write(i + " - ");
            //}
            //Console.WriteLine();
            //for (int i = 10; i > 0; i--)
            //{
            //    Console.Write(i + " - ");
            //}

            //for (int i = 1; i < 10; i++)
            //{
            //    for (int j = 1; j <= i; j++)
            //    {
            //        Console.Write(i + "." + j + " - ");
            //    }
            //    Console.WriteLine();
            //}

            //var input = Console.ReadLine();
            //if (input == "1")
            //{
            //    Console.WriteLine("1");
            //}
            //else if(input == "2")
            //{
            //    Console.WriteLine("2");
            //}
            //else
            //{
            //    Console.WriteLine("Not Valid");
            //}

            //switch (input)
            //{
            //    case "1":
            //        Console.WriteLine("1");
            //        break;
            //    case "2":
            //        Console.WriteLine("2");
            //        break;
            //    default:
            //        Console.WriteLine("Not Valid");
            //        break;
            //}

            Console.ReadLine();

            //System.Data.SqlClient.SqlConnection cnn; // Creates null variable on stack and keeps the address;
            //cnn = new System.Data.SqlClient.SqlConnection(); // creates on heap

            //var inta = 123;
            //var boolb = true;

            //Console.WriteLine(inta.GetType().ToString());
            //Console.WriteLine(boolb.GetType().ToString());
            //new Program().TestMethod();
            //Console.ReadLine();
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
