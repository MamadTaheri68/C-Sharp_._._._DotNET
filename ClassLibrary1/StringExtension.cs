using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public static class StringExtension
    {
        public static int ToSaveInt(this string input)
        {
            int output = 0;
            int.TryParse(input, out output);
            return output;
        }

        public static bool IsSSN(this string input)
        {
            return true;
        }
    }
}
