using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp11_Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> myInts = new List<int>
            {
                1,2,3,4,5,6,7,8
            };

            // Concat
            Console.WriteLine(string.Concat(myInts));
            string temp = "";
            foreach (var item in myInts)
            {
                temp += item + ",";
            }
            temp = temp.Substring(0, temp.Length - 1);

            // String join
            string temp1 = "";
            for (int i = 0; i < myInts.Count; i++)
            {
                if (i == 0)
                {
                    temp1 += myInts[i];
                }
                else
                {
                    temp1 += "," + myInts[i];
                }
            }

            string temp2 = string.Join(",", myInts);
            Console.WriteLine(temp);
            Console.WriteLine(temp1);
            Console.WriteLine(temp2);


            //string Format
            string name = "alireza";
            string lastName = "Oroumand";
            Console.WriteLine("Welcome " + name + " " + lastName);

            Console.WriteLine(string.Format("Welcome {0} {1} {0} {0}", name, lastName));

            // Index
            string MyText = "After just one day of talks in Istanbul the Kremlin says no breakthroughs were made, while Ukraine's military says Russia's offer to scale back forces around Kyiv is just a rotation of forces.";

            string saysWord = MyText.Substring(MyText.IndexOf(" says "), 4);

            char[] chars = new char[] { 'a', 'z' };
            MyText.IndexOfAny(chars);
            MyText.LastIndexOf("aaa");

            int year = 1396;
            int month = 5;
            int day = 1;

            //YYYY-MM-DD
            string dateFormatted = string.Format("{0}-{1}-{2}", year.ToString(), month.ToString().PadLeft(2, '0'), day.ToString().PadLeft(2, '0'));

            "dfadfirkpefokdionf".ToUpper();
            "dfadfirkpefokdionf".ToLower();
            string.Compare("", "", true);

            // Split
            var myTempList = MyText.Split(',');






            Console.ReadLine();

        }
    }
}
