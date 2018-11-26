using DB.Core.Models;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Employee;

namespace MVC_CoreWithEF_Core.Controllers
{
    public class TestController : Controller
    {
        private IEmployeeService _employeeService;
        public TestController(IEmployeeService employeeService)
        {
            _employeeService = employeeService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult AddEmployee()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(Employees data)
        {
            bool added = _employeeService.CreateEmployee(data);
            return RedirectToAction("AddEmployee");
        }

    }
}