using AjaxLib;
using AjaxLib.Interface;
using AjaxLib.Repository;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxProj.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepo repo;
        public HomeController ()
        {
            repo = new DEmployeeRepo(new AppDbContext());
        }
       
        public ActionResult Index()
        {
            return View();
        }

       
        public ActionResult AllEmployees()
        {
            var list = repo.GetAll();
            
            return PartialView("_Employees",list);
        }

        public ActionResult Bottom3EmpSalary() 
        {
            var list = repo.GetButtom3();

            return PartialView("_Employees", list);
        }

        public ActionResult Top3EmpSalary() 
        {
            var list = repo.GetTop3();

            return PartialView("_Employees", list);
        }
    }
}