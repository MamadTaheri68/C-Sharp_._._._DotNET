using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp13_Exceptions
{
    public class CustomException:Exception
    {

    }
    class Program
    {
        static void Main(string[] args)
        {
            //try
            //{
            //    CreateEx();
            //}
            ////catch (FileNotFoundException ex)
            ////{
            ////    Console.Write("An FileNotFoundException Exception happened");
            ////}
            ////catch(FieldAccessException ex)
            ////{
            ////    Console.Write("An FieldAccessException Exception happened");
            ////}
            //catch (Exception ex)
            //{
            //    //ex.Data.Add("FileName", "adfldkkdshf");

            //    Console.Write("An Unknown Exception happened");
            //}

            string input = Console.ReadLine();

            try
            {
                CreateEx();
            }
            catch (Exception) when(input == "Mamad")
            {
                Console.WriteLine("Mamad");
            }
            catch (Exception) when (input == "ali")
            {
                Console.WriteLine("ali");
            }
            catch (Exception)
            {
                Console.WriteLine("Exception");
            }
            finally
            {
                Console.WriteLine("finally");
            }


            Console.ReadLine();
        }

        static void CreateEx()
        {
            try
            {
                CreateEx2();
            }
            catch (Exception ex)
            {

                throw new Exception("",ex);
            }
        }

        private static void CreateEx2()
        {
            throw new NotImplementedException();
        }
    }
}
