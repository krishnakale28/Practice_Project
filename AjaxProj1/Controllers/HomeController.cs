using AjaxLib1.Interface;
using AjaxLib1.Repository;
using AjaxLib1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AjaxLib1.Models;

namespace AjaxProj1.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmployeeRepo repo;
        public HomeController()
        {
            repo = new DEmployeeRepo(new AppDbContext());
        }
        public ActionResult Index()
        {
            int num = 5;
            Session["Data"] = num;
            var list = repo.GetAllEmp(num);

            return PartialView("_EmpData", list);
        }

        [HttpPost]
        public ActionResult Index(Employee1 emp)
        {
            int rows = Convert.ToInt32(Session["Data"])+5;
            var list = repo.GetAllEmp(rows);
            Session["Data"] = rows;

            return PartialView("_EmpData", list);
        }
    }
}