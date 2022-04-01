using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ConsoleApp16_IEnumerableTest;

namespace ConsoleApp16_IEnumerableTest
{
    public class Person
    {
        public string FirstName { get; set; }
        //public string LastName { get; set; }
        private string lastName;
        public string LastName
        {
            get {
                Console.WriteLine($"Red data {lastName}");
                return lastName; }
            set { lastName = value; }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //Person[] students = new Person[]
            //{
            //    new Person
            //    {
            //        FirstName = "Student01",
            //        LastName = "Student01"
            //    },
            //    new Person
            //    {
            //        FirstName = "Student02",
            //        LastName = "Student02"
            //    },
            //    new Person
            //    {
            //        FirstName = "Student03",
            //        LastName = "Student03"
            //    }
            //};

            List<Person> Teachers = new List<Person>
            {
                new Person
                {
                    FirstName = "Teacher01",
                    LastName = "Teacher01"
                },
                new Person
                {
                    FirstName = "Teacher02",
                    LastName = "Teacher02"
                },
                new Person
                {
                    FirstName = "Teacher03",
                    LastName = "Teacher03"
                }
            };

            var result001 = Teachers.Search(c => c.LastName == "Teacher02");

            //var result001 = Teachers.Where(c => c.LastName == "Teacher02");


            foreach (var item in result001)
            {
                Console.WriteLine($"{item.FirstName} {item.LastName}");
            }

            Console.ReadLine();

            //foreach (var p in students)
            //{
            //    Console.WriteLine($"{p.FirstName} {p.LastName}");
            //}

            //Teachers.TotalCount();

            //var enumerator = Teachers.GetEnumerator();

            //while (enumerator.MoveNext())
            //{
            //    Console.WriteLine($"{enumerator.Current.FirstName} {enumerator.Current.LastName}");
            //}

            //var searchResults = students.Search(c => c.LastName == "Student02");

            //foreach (var p in searchResults)
            //{
            //    Console.WriteLine($"{p.FirstName} {p.LastName}");
            //}
            //Console.ReadLine();
        }
    }
}
