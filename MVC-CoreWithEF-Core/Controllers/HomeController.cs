using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using DB.Core.Models;
using Microsoft.AspNetCore.Mvc;
using MVC_CoreWithEF_Core.Models;
using MVCCoreWithEFCore.ExtensionMethods;
using ServiceLayer.Employee;

namespace MVC_CoreWithEF_Core.Controllers
{
    public class HomeController : Controller
    {
        //private IEmployeeService _employeeService { get; set; }
        //public HomeController(IEmployeeService employeeService)
        //{
        //    _employeeService = employeeService;
        //}
        public IActionResult Index()
        {
            //_employeeService.AddEmployee(null);
            //MVCEFCoreContext db = new MVCEFCoreContext();
            //HttpContext.Session.GetObject<dynamic>("CurrentUser");
            return View();//Json(db.Employees.ToList());
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
