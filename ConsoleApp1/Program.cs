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
            //Class1 c1 = new Class1();
            //Console.WriteLine(c1.Add());
            //Console.ReadLine();

            //c1.sum();
            //c1.sum(1);
            //c1.sum(1,2,3,4,5,6,33,25,75);
            //ClassTestRef testRef = new ClassTestRef();
            //Console.WriteLine(testRef.A);
            //ChangeA(testRef);
            //Console.WriteLine(testRef.A);

            int testref = 2 ;
            int testOut;
            ChangeByRef(ref testref);
            ChangeByOut(out testOut);
            
            
            Console.ReadLine();




        }

        private static void ChangeA(ClassTestRef testRef)
        {
            testRef.A = 123;
        }
        private static void ChangeByRef(ref int input)
        {
            input = 1;
        }
        private static void ChangeByOut(out int input)
        {
            input = 1;
        }
    }
}
