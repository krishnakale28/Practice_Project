using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxLib.Models
{
    [Table("tbl_AjaxEmp")]
    public class Employee
    {
        [Key]
        public long id {  get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public int age { get; set; }    
        public int salary { get; set; }
    }
}
