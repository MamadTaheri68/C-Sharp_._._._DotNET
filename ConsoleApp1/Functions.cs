using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Functions
    {
        public int Add(int num01, int num02)
        {
            return num01 + num02;
        }
        public float Add(float num01, float num02)
        {
            return num01 + num02;
        }
        public float Add(float num01 = 5, float num02 = 4, bool x = true)
        {
            Console.WriteLine(x.ToString());
            return num01 + num02;
        }
        public void useAddFunction()
        {
            var result = Add(x:false);
        }
    }
}

