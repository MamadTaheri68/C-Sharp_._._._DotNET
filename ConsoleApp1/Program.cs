using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p = new Person();
            Student s = new Student();
            test1(s);
            test(p);
            test(s);


        }

        private static void test(Person p)
        {
            throw new NotImplementedException();
        }

        private static void test1(Student s)
        {
            throw new NotImplementedException();
        }
    }
}
