using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8_Delegates
{
    class Program
    {
        public delegate bool SortMethod(int a1, int a2);
        //public static void BobbleSorter(int[] sortArray ,SortMethod sortMethod)
        public static void BobbleSorter(int[] sortArray, Func<int,int,bool> sortMethod)
        {
            bool swapped = true;
            do
            {
                swapped = false;
                for (int i = 0; i < sortArray.Length - 1; i++)
                {
                    //if((isAsc && sortArray[i] < sortArray[i + 1]) || (!isAsc && sortArray[i] > sortArray[i + 1]))
                    if(sortMethod(sortArray[i], sortArray[i+1]))
                    {
                        int temp = sortArray[i];
                        sortArray[i] = sortArray[i + 1];
                        sortArray[i + 1] = temp;
                        swapped = true;
                    }
                }
            } while (swapped);

        }
        static void Main(string[] args)
        {
            int[] myArray = new int[] { 1, 4, 5, 7, 89, 9, 3, 5, 6, 7 };
            SortMethod smethod = asc;
            BobbleSorter(myArray, asc);
            SortMethod smethod2 = desc;
            BobbleSorter(myArray, desc);
            SortMethod smethod3 = desc;
            BobbleSorter(myArray, desc);

            List<SortMethod> smethodList = new List<SortMethod>();
            smethodList.Add(asc);
            smethodList.Add(asc);
            smethodList.Add(desc);
            smethodList.Add(asc);
            smethodList.Add(MyFunction);
            
            foreach (var item in smethodList)
            {
                item(1, 4);
            }

            SortMethod smethodMulticast = asc;
            smethodMulticast += desc;
            smethodMulticast += MyFunction;
            smethodMulticast(3, 5);



        }
        public static bool asc(int a1,int a2)
        {
            return a1 > a2;
        }
        public static bool desc(int a1, int a2)
        {
            return a1 < a2;
        }
        public static bool MyFunction(int a1, int a2)
        {
            if (a1 * 4 + 5 < a2 * a2 )
            {
                return true;
            }
            return false;
        }
    }
}
