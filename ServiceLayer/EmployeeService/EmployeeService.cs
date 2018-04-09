using System;
using System.Collections.Generic;
using System.Text;
using BO.HelperModel;
using ServiceLayer.UnitOfWork;

namespace ServiceLayer.Employee
{
    public class EmployeeService : IEmployeeService
    {
        public IUnitOfWork _uow;

        public EmployeeService(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public int AddEmployee(HMEmployee Emp)
        {
            DB.Core.Models.Employees e = new DB.Core.Models.Employees();
            e.EmpAge = 12;
            e.EmpCity = "LHR";
            e.EmpCountry = "Pak";
            e.EmpName = "Temp";

            _uow.EmployeeRepo.Insert(e);
            _uow.Commit();
            return Convert.ToInt32(e.StudentId);
        }

        public List<HMEmployee> EmployeeDetails(HMEmployee Emp)
        {
            throw new NotImplementedException();
        }
    }
}
