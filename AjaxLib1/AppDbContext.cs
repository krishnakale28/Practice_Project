using AjaxLib1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxLib1
{
    public class AppDbContext : DbContext
    {
        public AppDbContext() : base("dbcs")
        {
            Database.SetInitializer<AppDbContext>(null);
        }
        public DbSet<Employee1> employees { get; set; }
    }
}
