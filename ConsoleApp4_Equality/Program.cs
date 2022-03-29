using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4_Equality
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Address Address { get; set; }
        public override bool Equals(object obj)
        {
            Person p2 = obj as Person;
            return FirstName == p2.FirstName && LastName == p2.LastName;
        }
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
            Person p1 = new Person
            {
                FirstName = "Alireza",
                LastName = "Oroumand"
            };
            Person p2 = new Person
            {
                FirstName = "Behdad",
                LastName = "Pedrood"
            };
            Person p3 = p1;
            Person p4 = new Person
            {
                FirstName = "Alireza",
                LastName = "Oroumand"
            };
            Console.WriteLine(ReferenceEquals(p1, p2));
            Console.WriteLine(ReferenceEquals(p1, p3));
            Console.WriteLine(ReferenceEquals(p1, p4));
            Console.WriteLine("1***********************");

            Console.WriteLine(p1.Equals(p2));
            Console.WriteLine(p1.Equals(p3));
            Console.WriteLine(p1.Equals(p4));
            Console.WriteLine("2***********************");

            Console.WriteLine(Equals(p1, p2));
            Console.WriteLine(Equals(p1, p3));
            Console.WriteLine(Equals(p1, p4));
            Console.WriteLine(Equals(p1, null));
            Console.WriteLine(Equals(null, null));
            Console.WriteLine("***********************");




            Console.ReadLine();


        }
    }
}
