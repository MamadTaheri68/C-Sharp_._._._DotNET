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
            SingleTonTest t = SingleTonTest.GetInstance();
            t.Test = 2;
            Change();
            Console.WriteLine(t.Test);
            Console.ReadLine();
        }

        private static void Change()
        {
            SingleTonTest t = SingleTonTest.GetInstance();
            t.Test = 5;
        }
    }
}
