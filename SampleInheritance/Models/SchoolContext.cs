using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication5.Models
{
    public class SchoolContext : DbContext
    {
        public DbSet<Person> People { get; set; }
        public DbSet<Instructor> Insructors { get; set; }
        public DbSet<Student> Students { get; set; }

        public SchoolContext()
            : base("DefaultConnection")
        {

        }
    }
}
