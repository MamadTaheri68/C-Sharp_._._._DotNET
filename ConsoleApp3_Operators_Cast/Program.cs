using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3_Operators_Cast
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
    }
    public class Address
    {
        public string AddressText { get; set; }
        public string Phone { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int mod = 5 % 3;
            //mod += 2;

            //mod -= 1;

            //bool a1 = true, a2 = false, b1 = true, b2 = false;
            //bool result1;
            //result1 = a1 && a2 && b1 && b2; //false
            //result1 = a1 && b1; //true

            //result1 = a1 || a2 || b1 || b2;

            //int a = 1;

            //a++;

            //var result2 = a++;
            //var result3 = ++a;

            //int a4 = a1 ? 3 : 5;

            //Console.WriteLine(sizeof(int));

            //byte mybyte = byte.MaxValue;
            //Console.WriteLine(mybyte);
            //mybyte++;
            //Console.WriteLine(mybyte);
            //Console.ReadLine();

            Person p = GetPerson();
            string fName = p?.FirstName;
            string add = p?.Address?.AddressText;

            Console.WriteLine(nameof(p));
            Console.ReadLine();

            int aex = 123;
            double adb = 12.22;
            adb = aex;
            aex = (int)adb;
                                       
        }

        private static Person GetPerson()
        {
            return null;
        }

        public bool IsAfternoon()
        {
            return DateTime.Now.Hour > 2 ? true : false;
        }
    }
}
