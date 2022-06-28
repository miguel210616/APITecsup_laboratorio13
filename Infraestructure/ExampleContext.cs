using Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestructure
{
    public class ExampleContext : DbContext
    {
        public ExampleContext() : base("name=MyContextDB")
        {

        }

        public DbSet<Person> People { get; set; }

    }
}
