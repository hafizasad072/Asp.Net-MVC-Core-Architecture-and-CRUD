using DataLayer.GenericRepository;
using DBCoreLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.EmployeeRepo
{
    public interface IEmployeeRepo : IRepository<Employees>
    {
    }
}
