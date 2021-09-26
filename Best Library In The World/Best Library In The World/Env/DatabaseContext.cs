using Best_Library_In_The_World.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Best_Library_In_The_World.Env
{
    public class DatabaseContext : DbContext
    {

        public DatabaseContext()
        {
        }

        public DatabaseContext(DbContextOptions<DatabaseContext>options) : base(options) { }
        public DbSet<Author> author { get; set; }
        public DbSet<Book> book { get; set; }

    }

}

