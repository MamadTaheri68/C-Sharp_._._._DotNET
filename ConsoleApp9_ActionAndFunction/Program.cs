using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9_ActionAndFunction
{
    public enum CustomerType
    {
        Gold,
        Silver,
        Boronz
    }
    public class RemoveSwitch
    {
        public int Value { get; set; }
        public CustomerType CType { get; set; }
        private readonly Dictionary<CustomerType, Action> Discount;
        public RemoveSwitch()
        {
            Discount[CustomerType.Gold] = delegate ()
            {
                Value = Value - 100;
            };


            Discount[CustomerType.Silver] = Silver;
            Discount[CustomerType.Boronz] = Boronz;

        }
        public void CalcDiscount()
        {
            //switch (CType)
            //{
            //    case CustomerType.Gold:
            //        Value = Value - 100;
            //        break;
            //    case CustomerType.Silver:
            //        Value = Value - 50;
            //        break;
            //    case CustomerType.Boronz:
            //        Value = Value - 10;
            //        break;
            //}
            Discount[CType]();
        }
        private void Gold()
        {
            Value = Value - 100;
        }
        private void Silver()
        {
            Value = Value - 50;
        }
        private void Boronz()
        {
            Value = Value - 10;
        }
    }
    public class ActionLogger
    {
        public static void SafeExecute(Action myAction)
        {
            try
            {
                myAction();
            }
            catch (Exception ex)
            {
                //Log MyExecption
                //throw;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MyDB MYdB1 = new MyDB();
            ActionLogger.SafeExecute(MYdB1.save);

            Func<int, int, bool> myFunc =  (a, b) => a > b ;
            Func<int, bool> myFunc2 = b => b > 5 ;
            Func<int, bool> myFunc3 = b =>
            {
                Console.WriteLine("Some Command");
                b += 12;
                return b > 5;
            };

        }
    }
    public class MyDB
    {
        public void save()
        {
             //Code
        }
    }
}
