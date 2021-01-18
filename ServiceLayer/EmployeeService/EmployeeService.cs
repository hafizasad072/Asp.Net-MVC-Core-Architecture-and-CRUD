using System;
using System.Collections.Generic;
using System.Text;
using DBCoreLayer.Models;
using ServiceLayer.HelperModel;
using ServiceLayer.UnitOfWork;
using Util;

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
            Employees e = CoreMapper.MapObject<HMEmployee, Employees>(Emp);
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
