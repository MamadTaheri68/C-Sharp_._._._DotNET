using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp14_ADO
{
    class Program
    {
        static void Main(string[] args)
        {
            //AddNewKeyWord();
            //DeleteKeyWord();
            //ReadAllKeyWord();
            ReadKeyWordCount();
        }

        private static void AddNewKeyWord()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Data Source=.;Initial Catalog=NikamoozAdo;Integrated Security=SSPI;";
            cnn.Open();
            var connectionState = cnn.State;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            string title = Console.ReadLine();
            cmd.CommandText = "INSERT INTO Keywords " +
                "(Title ,InsertBy ,UpdateBy ,InsertDate ,UpdateDate) VALUES('" +
                title + "',1,1,'" + DateTime.Now.Date + "','" + DateTime.Now.Date + "')";
            int result = cmd.ExecuteNonQuery();
            Console.WriteLine(result == 1);
            Console.ReadLine();
        }
        private static void DeleteKeyWordClearText()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Data Source=.;Initial Catalog=NikamoozAdo;Integrated Security=SSPI;";
            cnn.Open();
            var connectionState = cnn.State;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            string id = Console.ReadLine();
            cmd.CommandText = "DELETE FROM Keywords where id=@id";
            SqlParameter param = new SqlParameter
            {
                ParameterName = "@id",
                Value = id
            };
            cmd.Parameters.Add(param);
            int result = cmd.ExecuteNonQuery();
            Console.WriteLine(result == 1);
            Console.ReadLine();
        }
        private static void DeleteKeyWord()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Data Source=.;Initial Catalog=NikamoozAdo;Integrated Security=SSPI;";
            cnn.Open();
            var connectionState = cnn.State;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            string id = Console.ReadLine();
            cmd.CommandText = "Keywords_Delete";
            cmd.CommandType = System.Data.CommandType.StoredProcedure;
            SqlParameter param = new SqlParameter
            {
                ParameterName = "@id",
                Value = id
            };
            cmd.Parameters.Add(param);
            int result = cmd.ExecuteNonQuery();
            Console.WriteLine(result == 1);
            Console.ReadLine();
        }
        private static void ReadAllKeyWord()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Data Source=.;Initial Catalog=NikamoozAdo;Integrated Security=SSPI;";
            cnn.Open();
            var connectionState = cnn.State;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT * from Keywords";

            var result = cmd.ExecuteReader();
            while (result.Read())
            {
                Console.WriteLine($"{result["Id"]}, {result["Title"]}");
            }
             
            Console.ReadLine();
        }
        private static void ReadKeyWordCount()
        {
            SqlConnection cnn = new SqlConnection();
            cnn.ConnectionString = "Data Source=.;Initial Catalog=NikamoozAdo;Integrated Security=SSPI;";
            cnn.Open();
            var connectionState = cnn.State;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = cnn;
            cmd.CommandText = "SELECT count(*) from Keywords";

            var result = cmd.ExecuteScalar();
            Console.WriteLine($"Total count = {result}");
           

            Console.ReadLine();
        }
    }
}
