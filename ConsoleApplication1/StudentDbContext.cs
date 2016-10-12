using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class StudentDbContext : DbContext
    {
        public StudentDbContext() : base("ConnString")
        {
        }

        public DbSet<Student> Students { get; set; }
    }
}
