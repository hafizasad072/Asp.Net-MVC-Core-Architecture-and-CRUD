using ServiceLayer.HelperModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.Employee
{
   public interface IEmployeeService
    {
       int AddEmployee(HMEmployee Emp);
       List<HMEmployee> EmployeeDetails(HMEmployee Emp);

    }
}
