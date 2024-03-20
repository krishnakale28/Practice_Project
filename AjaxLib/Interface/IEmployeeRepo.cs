using AjaxLib.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxLib.Interface
{
    public interface IEmployeeRepo
    {
        IEnumerable<Employee> GetAll();

        IEnumerable<Employee> GetTop3();
        IEnumerable<Employee> GetButtom3();
    }
}
