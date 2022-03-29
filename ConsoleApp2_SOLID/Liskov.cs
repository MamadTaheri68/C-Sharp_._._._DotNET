using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_SOLID
{
    class Liskov
    {
        public abstract class FourAngle
        {
            public abstract int GetArea();
        }
        public class Rectangle: FourAngle
        {
            public int Height { get; set; }
            public int Width { get; set; }

            public override int GetArea()
            {
                return Width * Height;
            }
            

        }
        public class Square : FourAngle
        {
            public override int GetArea()
            {
                throw new NotImplementedException();
            }
        }
    }
}
