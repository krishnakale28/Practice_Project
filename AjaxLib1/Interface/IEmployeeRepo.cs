using AjaxLib1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxLib1.Interface
{
    public interface IEmployeeRepo
    {
        IEnumerable<Employee1> GetAllEmp(int num);
    }
}
