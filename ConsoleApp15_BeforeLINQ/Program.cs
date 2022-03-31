using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp15_BeforeLINQ
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Windows";
            DisplayFileWithouthLinq(path);
            Console.WriteLine("------------------------------");
            DisplayFileWithLinq(path);
            Console.ReadLine();
        }

        private static void DisplayFileWithLinq(string path)
        {
            var result = new DirectoryInfo(path).GetFiles().OrderByDescending(c => c.Length).Take(5);
            foreach (var file in result)
            {
                Console.WriteLine($"{file.Name} \t\t {file.Length}");
            }
        }

        private static void DisplayFileWithouthLinq(string path)
        {
            DirectoryInfo di = new DirectoryInfo(path);
            FileInfo[] fi = di.GetFiles();
            Array.Sort(fi, new FileInfoComparer());
            for (int i = 0; i < 5; i++)
            {
                var file = fi[i];
                Console.WriteLine($"{file.Name} \t\t {file.Length}");
            }
        }
    }
    public class FileInfoComparer : IComparer<FileInfo>
    {
        public int Compare(FileInfo x, FileInfo y)
        {
            int result = 0;
            if(x.Length < y.Length)
            {
                result = 1;
            }
            if (x.Length > y.Length)
            {
                result = -1;
            }
            return result;
        }
    }
}
