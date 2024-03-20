using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AutoCrud.Models
{
    [Table("tbl_std")]
    public class Student
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }

        public string email { get; set; }

    }
}