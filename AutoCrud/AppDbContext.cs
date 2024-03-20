using AutoCrud.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AutoCrud
{
    public class AppDbContext : DbContext
    {
        public AppDbContext():base("dbcs") 
        {
            Database.SetInitializer<AppDbContext>(null);
        }
        public DbSet<Student>students { get; set; }
    }
}