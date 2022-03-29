using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_SOLID
{
    public enum CustomerType
    {
        Gold = 1,
        Common = 2,
        silver = 3
    }
    public interface IDiscountCalculator
    {
        int GetTotalPrice(int value);
    }
    public class GoldDiscount : IDiscountCalculator
    {
        public int GetTotalPrice(int value)
        {
            return value - 100;
        }
    }
    public class SilverDiscount : IDiscountCalculator
    {
        public int GetTotalPrice(int value)
        {
            return value - 50;
        }
    }

    public class OCP
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int Price { get; set; }
        //public CustomerType Type { get; set; }
        public IDiscountCalculator Calculator { get; set; }
        public int GetTotalPrice()
        {
            return Calculator.GetTotalPrice(Price);
            //switch (Type)
            //{
            //    case CustomerType.Gold:
            //        return Price - 100;
            //    case CustomerType.silver:
            //        return Price - 50;
            //    case CustomerType.Common:
            //        return Price;
            //    default:
            //        return Price;
            //}
        }
    }
}
