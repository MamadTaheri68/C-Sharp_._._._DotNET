using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19_CSVFile
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

    }
    public class Program
    {
        public static List<Person> Persons { get; set; }
        public static List<Person> Persons2 { get; set; }

        static void Main(string[] args)
        {
            Persons = LoadData();
            Persons2 = LoadData();


            // Sort
            //var sortedPersonByFirstName = Persons.OrderBy(c => c.FirstName);
            //var sortedPersonByLastName = Persons.OrderBy(c => c.LastName);
            //var sortedPersonByAge = Persons.OrderBy(c => c.Age);

            //int i = 1;
            //foreach (var item in sortedPersonByAge)
            //{
            //    Console.WriteLine($"{i}    -    {item.FirstName}    -    {item.LastName} {item.Age}");
            //    i++;
            //}


            // Search
            //var searchPersons = Persons.Where(c => c.FirstName.StartsWith("Ali") );

            //int i = 1;
            //foreach (var item in searchPersons)
            //{
            //    Console.WriteLine($"{i}    -    {item.FirstName}    -    {item.LastName} {item.Age}");
            //    i++;
            //}


            // Performance
            //Stopwatch st = new Stopwatch();
            //st.Start();
            //for (int index = 0; index < 50000; index++)
            //{
            //    var result01 = Persons.Where(c => c.LastName.StartsWith("O")).OrderBy(c => c.FirstName);
            //}
            //st.Stop();
            //Console.WriteLine(st.ElapsedTicks);

            //st.Reset();

            //st.Start();
            //for (int index = 0; index < 50000; index++)
            //{
            //    var result02 = Persons.OrderBy(c => c.FirstName).Where(c => c.LastName.StartsWith("O"));
            //}
            //st.Stop();
            //Console.WriteLine(st.ElapsedTicks);


            // Paging
            //for (int i = 0; i < 10; i++)
            //{
            //    Console.WriteLine($"-------------start page {i}---------------");
            //    var result03 = Persons.OrderBy(c => c.FirstName).Skip(i*10).Take(10);
            //    int count = 1;
            //    foreach (var item in result03)
            //    {
            //        Console.WriteLine($"{count}    -    {item.FirstName}    -    {item.LastName} {item.Age}");
            //        count++;
            //    }
            //}


            // LINQ
            //var res0001 = Persons.OrderBy(c => c.FirstName).Take(1);
            //var res0002 = Persons.OrderBy(c => c.FirstName).First();
            //var res0003 = Persons.OrderBy(c => c.FirstName).FirstOrDefault();
            //var res0004 = Persons.OrderBy(c => c.FirstName).Last();
            //var res0005 = Persons.OrderBy(c => c.FirstName).LastOrDefault();

            //var res0006 = Persons.OrderBy(c => c.FirstName).Where(c=>c.FirstName == "Mamad").Count() == 0;
            //var res0007 = Persons.OrderBy(c => c.FirstName).Any(c => c.FirstName == "Mamad");
            //var res0008 = Persons.OrderBy(c => c.FirstName).All(c => c.FirstName == "Mamad");


            // Join
            //var joinResult = Persons.Join(Persons2,c=> new { c.Age, c.LastName},d=> new { d.Age, d.LastName},(c,d)=> {
            //    return new
            //    {
            //        c.FirstName,
            //        c.LastName,
            //        d.Age
            //    };
            //});


            // GroupBy
            var groupByResult = Persons.GroupBy(c => c.Age);
            foreach (var item in groupByResult)
            {
                Console.WriteLine($"{item.Key}");
                foreach (var p in item)
                {
                    Console.WriteLine($"{p.FirstName} {p.LastName}");
                }
                Console.WriteLine("-------------------");
            }
            Persons.Min(c => c.Age);





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
