using DataLayer.GenericRepository;
using DBCoreLayer.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataLayer.EmployeeRepo
{
    public class EmployeeRepo : Repository<Employees>, IEmployeeRepo
    {
        public EmployeeRepo(MVCEFCoreContext context) : base(context)
        {
        }
    }
}
