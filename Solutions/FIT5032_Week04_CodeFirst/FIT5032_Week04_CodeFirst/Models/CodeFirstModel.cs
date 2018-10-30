using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace FIT5032_Week04_CodeFirst.Models
{
    public class DefaultDbContext : DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Unit> Units { get; set; }

        public DefaultDbContext()
            : base("FIT5032_ModelContainer")
        {
        }

        public static DefaultDbContext Create()
        {
            return new DefaultDbContext();
        }
    }

}