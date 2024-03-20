using AjaxLib1.Interface;
using AjaxLib1.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxLib1.Repository
{ 
    public class DEmployeeRepo : IEmployeeRepo
    {
        private readonly AppDbContext context;
        public DEmployeeRepo(AppDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Employee1> GetAllEmp(int num)
        {
            var list = context.employees.ToList().Take(num);

            return list;
        }
    }
}
