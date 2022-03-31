using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp16_IEnumerableTest
{
    public static class MyLinq
    {
        //Mimic The TotalCount Functionality
        public static int TotalCount<T>(this IEnumerable<T> input)
        {
            int cnt = 0;
            foreach (var item in input)
            {
                cnt++;

            }
            return cnt;
        }

        //Mimic The Search Functionality
        public static IEnumerable<T> Search<T>(this IEnumerable<T> input,Func<T,bool> exp)
        {
            List<T> result = new List<T>();
            foreach (var item in input)
            {
                if (exp(item))
                {
                    //result.Add(item);
                    yield return item;
                }
            }
            //return result;
        }
    }
}
