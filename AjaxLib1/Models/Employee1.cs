using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxLib1.Models
{
    [Table("tbl_AjaxEmp1")]
    public class Employee1
    {
        public long id { get; set; }
        public string name { get; set; }
        public string gender { get; set; }
        public string city { get; set; }
        public string destination { get; set; }
        public decimal salary { get; set; }

    }
}
