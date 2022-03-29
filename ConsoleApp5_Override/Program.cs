using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5_Override
{
    public class Rectangle
    {
        public static Rectangle operator +(Rectangle left, Rectangle Right)
        {
            return new Rectangle
            {
                Width = left.Width + left.Width,
                Height = left.Height + left.Height
            }
        }
        public int Width { get; set; }
        public int Height { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle r1 = new Rectangle
            {
                Height = 10,
                Width = 15
            };
            Rectangle r2 = new Rectangle
            {
                Height = 20,
                Width = 20
            };
            Rectangle r3 = new Rectangle
            {
                Width = r1.Width + r2.Width,
                Height = r1.Height + r2.Height
            };
            Rectangle r4 = r1 + r2;
             
        }
    }
}
