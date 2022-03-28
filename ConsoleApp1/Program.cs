using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibrary1;


namespace ConsoleApp1
{
    
    class Program
    {
        static void Main(string[] args)
        {
            SortInputArray();
            
        }
        
        
        public static void SortInputArray()
        {
            var c = Console.ReadLine();

            var a = new int[int.Parse(c)];
            Console.WriteLine("--------------");

            for (int i = 0; i < int.Parse(c); i++)
            {
                var d = Console.ReadLine();
                a[i] = int.Parse(d);
            }
            Console.WriteLine("--------------");

            int temp = 0;

            for (int write = 0; write < a.Length; write++)
            {
                for (int sort = 0; sort < a.Length - 1; sort++)
                {
                    if (a[sort] > a[sort + 1])
                    {
                        temp = a[sort + 1];
                        a[sort + 1] = a[sort];
                        a[sort] = temp;
                    }
                }
            }

            foreach (var item in a)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();
            Console.WriteLine("--------------");
            int count = 0;
            int t = a[0];

            foreach (var item in a)
            {
                if (t == item)
                {
                    count++;
                }
                else
                {
                    Console.WriteLine($"{t}: {count}");
                    count = 1;
                    t = item;
                }


            }
            Console.ReadKey();

        }
    }
}
