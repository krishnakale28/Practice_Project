using AjaxLib.Interface;
using AjaxLib.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AjaxLib.Repository
{
    public class DEmployeeRepo : IEmployeeRepo
    {
        private readonly AppDbContext context;
        public DEmployeeRepo(AppDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Employee> GetAll()
        {
            var  list = context.employees.ToList();
            return list;
        }

        public IEnumerable<Employee> GetButtom3()
        {
            var list = context.employees.OrderBy(model => model.salary).Take(3).ToList();

            return list;
        }

        public IEnumerable<Employee> GetTop3()
        {
            var list = context.employees.OrderByDescending(model => model.salary).Take(3).ToList();

            return list;
        }
    }
}
