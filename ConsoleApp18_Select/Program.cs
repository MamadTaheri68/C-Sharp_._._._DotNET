using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp18_Select
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

    }
    class Program
    {
        static void Main(string[] args)
        {
            var persons = new List<Person>
            {
                new Person
                {
                    FirstName = "Alireza",
                    LastName = "Orumand"
                },
                new Person
                {
                    FirstName = "Karim",
                    LastName = "Biabani"
                },
                new Person
                {
                    FirstName = "Ali",
                    LastName = "Ghasemi"
                },
            };
            var result = persons.Where(c => c.FirstName.StartsWith("Ali")).Select(c => $"{c.FirstName} {c.LastName}");
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            var resultP = result.Select(c => {
                var temp = c.Split(' ');
                return new Person
                {
                    FirstName = temp[0],
                    LastName = temp[1]
                };
            }).ToList();
            Console.ReadLine();
        }
    }
}
