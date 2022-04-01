using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp22_Cshap7
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class OutVaiable
    {
        public void TestOutVariable()
        {
            // C# 6
            int test;
            if(int.TryParse("dfssd213", out test))
            {
                //
            } else
            {
                //
            }

            //C# 7
            if (int.TryParse("dfssd213", out int test2))
            {
                //
            }
            else
            {
                //
            }
        }

        public void PatternMatching(object myObject)
        {
            //if(myObject is string)
            //{
            //    var str = myObject as string;
            //}
            //else if(myObject is int)
            //{
            //    var _int = (int)myObject;
            //}
            //else if(myObject is Person)
            //{
            //    var p = myObject as Person;
            //}

            switch (myObject)
            {
                case string s:
                    break;
                case int i:
                    break;
                case Person p:
                    break;
                default:
                    break;
            }
        }
    }
}
