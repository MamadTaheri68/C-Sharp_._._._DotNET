using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22_Cshap7
{
    class RefReturn
    {
        public void MyFunction()
        {
            int[,] myArray = new int[2, 2];
            myArray[0, 0] = 1;
            myArray[0, 1] = 2;
            myArray[1, 0] = 3;
            myArray[1, 1] = 4;

            var findResult = Find(myArray);
            findResult = 9;
        }
        public ref int Find(int[,] myarray)
        {
            return ref myarray[0, 0];
        }
    }
}
