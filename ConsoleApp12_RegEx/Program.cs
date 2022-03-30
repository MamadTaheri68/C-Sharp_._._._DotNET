using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace ConsoleApp12_RegEx
{
    class Program
    {
        static void Main(string[] args)
        {
            Regex regx = new Regex("");
            string pattern = @"\d+";
            string mytext1 = "dfkfeworpewijidjgoujufejkg";
            string mytext2 = "sdfasfdfdfs234234fsdfdsdsfds";
            bool containsNum = Regex.IsMatch(mytext1, pattern);
            bool containsNum2 = Regex.IsMatch(mytext2, pattern);


            string mytext3 = "alireza 1 mohammad 2 hassan 3";
            var resultFindNumber = Regex.Match(mytext3, pattern);
            var resultFindNumbers = Regex.Matches(mytext3, pattern);

            string withWhiteSpace = "alireza        Ahmad  Reza          Mobin";
            string myPatternWhiteSpace = @"\s{2,}";
            string withouthWhiteSpace = Regex.Replace(withWhiteSpace, myPatternWhiteSpace, " ");



            Console.ReadLine();

        }
    }
}
