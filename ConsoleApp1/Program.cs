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
            PersonTester(new Student1());
        } 
        private static void PersonTester(IPerson person)
        {
            if(person is Teacher1)
            {
                Teacher1 t = person as Teacher1;
            }
            else if (person is Student1)
            {
                Student1 s = person as Student1;
            }
            
        }
}
