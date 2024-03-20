using LibPractice1.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibPractice1
{
    public class MyDbContex : DbContext
    {
        public MyDbContex(): base("dbcs")
        {

        }

        public DbSet<Student> Students { get; set; }
    }
}
