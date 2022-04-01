using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20_LinqToEntity
{
    public class Program
    {
        static void Main(string[] args)
        {
            //var persons = LoadData();
            PersonContext ctx = new PersonContext();
            ctx.Database.Log = Console.Write;
            //foreach (var item in persons)
            //{
            //    ctx.Persons.Add(item);
            //    ctx.SaveChanges();
            //}
            //var persons = ctx.Persons.OrderBy(c=>c.LastName).Where(c=>c.Age == 1985);
            var persons = ctx.Persons.Where(c => c.FirstName.StartsWith("Ali")).ToList();

            foreach (var item in persons)
            {
                Console.WriteLine($"{item.Age} - {item.FirstName} - {item.LastName}");
            }














            Console.ReadLine();

        }

        private static List<Person> LoadData()
        {
            string NamesFilePath = @"D:\projects\dotNet && C#\ConsoleApp1\ConsoleApp19_CSVFile\Names.csv";

            return System.IO.File.ReadAllLines(NamesFilePath).Select(c =>
            {
                var temp = c.Split(',');
                return new Person
                {
                    FirstName = temp[0],
                    LastName = temp[1],
                    Age = int.Parse(temp[2])
                };
            }).ToList();
        }

    } 
}
