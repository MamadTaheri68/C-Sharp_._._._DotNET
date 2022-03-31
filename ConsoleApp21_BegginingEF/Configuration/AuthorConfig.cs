using System;
using System.Data.Entity.ModelConfiguration;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ConsoleApp21_BegginingEF.Entities;

namespace ConsoleApp21_BegginingEF.Configuration
{
    public class AuthorConfig:EntityTypeConfiguration<Author>
    {
        public AuthorConfig()
        {
            //
        }
    }
}
