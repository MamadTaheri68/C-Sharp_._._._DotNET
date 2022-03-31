using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20_LinqToEntity
{
    public class PersonContext : DbContext
    {
        public PersonContext():base("cnn")
        {

        }
        public IDbSet<Person> Persons { get; set; }
    }
}
