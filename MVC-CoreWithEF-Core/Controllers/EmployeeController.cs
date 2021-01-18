using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ServiceLayer.HelperModel;
using Microsoft.AspNetCore.Mvc;
using ServiceLayer.Employee;

namespace MVC_CoreWithEF_Core.Controllers
{
    public class EmployeeController : Controller
    {
        private IEmployeeService _employeeService { get; set; }
        public EmployeeController(IEmployeeService employeeService)
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
        public IActionResult AddEmployee(HMEmployee emp)
        {
            try
            {
                if (!ModelState.IsValid)
                    return View(emp);

                _employeeService.AddEmployee(emp);
                return View();
            }
            catch (Exception)
            {

                throw;
            }
           
            
        }
    }
}