using System;
using System.Collections.Generic;
using System.Text;
using EmptyProject.Database.DbModels;
using Microsoft.EntityFrameworkCore;

namespace EmptyProject.Database
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        { }

        public DbSet<Blog> Blogs { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Ignore<BaseModel>();
        }
    }
}
