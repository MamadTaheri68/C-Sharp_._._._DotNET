using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp17_Syntaxes
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> mylist = new List<int>() { 1,2,3,4,5,6,6,6,66,7,8,88,586 };

            //Queryable Syntax
            var result = from lst in mylist
                         where lst > 10
                         select lst;

            //Extension Method Syntax
            var resultMethod = mylist.Where(c => c > 10);


        }
    }
}
