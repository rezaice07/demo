using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HR.Web.Models;
using HR.Web.ViewModels;

namespace HR.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly HRContext db;

        public HomeController(HRContext db)
        {
            this.db = db;
        }       


        public IActionResult Index()
        {            
            var employees = db.Employees.ToList();

            var model = new EmployeeListViewModel {
                Employees= employees
            };

            return View(model);
        }

        public IActionResult Add()
        {
            var model = new Employee();

            return View(model);
        }

        [HttpPost]
        public IActionResult Add(Employee model)
        {
            db.Employees.Add(model);
            db.SaveChanges();

            return Redirect("/home/index");
        }

        [HttpGet]
        public IActionResult Remove(int id)
        {
           var removeEmployee =  db.Employees.FirstOrDefault(f=>f.id==id);
            db.Employees.Remove(removeEmployee);
            db.SaveChanges();

            return Redirect("/home/index");
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
