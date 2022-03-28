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

            TestPartial tp = new TestPartial();
            tp.Add();
            tp.MyProperty = 1;

            string test = "123";
            int testConvert = test.ToSaveInt();
            bool result = test.IsSSN();
        }

        private static void Change()
        {
            SingleTonTest t = SingleTonTest.GetInstance();
            t.Test = 5;
        }
    }
}
