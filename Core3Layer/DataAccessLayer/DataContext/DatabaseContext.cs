using DataAccessLayer.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccessLayer.DataContext
{
    public class DatabaseContext : DbContext
    {
        public class OptionsBuild
        {
            public OptionsBuild()
            {
                settings = new AppConfiguration();
                optionsBuilder = new DbContextOptionsBuilder<DatabaseContext>();
                dbOptions = optionsBuilder.Options;
            }
            public DbContextOptionsBuilder<DatabaseContext> optionsBuilder { get; set; }
            public DbContextOptions<DatabaseContext> dbOptions { get; set; }
            private AppConfiguration settings { get; set; }
        }

        public static OptionsBuild ops = new OptionsBuild();
        public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
        {

        }
        public DbSet<Student> Student { get; set; }
        public DbSet<Technology> Technology { get; set; }
    }
}
