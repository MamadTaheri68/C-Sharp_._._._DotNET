using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2_SOLID
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
    public class PersonDB
    {
        private readonly ILogger _logger;
        public PersonDB(ILogger logger)
        {
            _logger = logger;
        }
        public Person Get(int id)
        {
            try
            {
                //Read Person From DB
                return new Person();
            }
            catch (Exception ex)
            {
                _logger.Log(ex.Message);
               
            }
            return null;
        }
    }
    public class DBLogger: ILogger
    {
        public void Log(string Message)
        {
            //Write To DB
        }
    }
    public class FileLogger : ILogger
    {
        public void Log(string Message)
        {
            //System.IO.File.WriteAllText(@"c:\log.txt", Message);
        }
    }
    public interface ILogger
    {
        void Log(string message);
    }
    class Program
    {
        static void Main(string[] args)
        {
            PersonDB p1 = new PersonDB(new DBLogger());
            PersonDB p2 = new PersonDB(new FileLogger());

        }
    }
}
