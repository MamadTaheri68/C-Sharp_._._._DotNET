using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        private int _int1;
        private int _int2;

        private Class1():this(0,0)
        {
            _int1 = 5;
        }
        private Class1(int a, int b)
        {
            _int1 = a;
            _int2 = b;
        }

        public int Add(int num01 = 3, int num02 = 2, int num03 = 3)
        {
            return num01 + num02;
        }
        public int Add(int num01, int num02) => num01 + num02;

        public int sum(params int[] inputes)
        {
            int total = 0;
            foreach (var item in inputes)
            {
                total += item;
            }
            return total;
        }
    }
}
