
using DataLayer.EmployeeRepo;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceLayer.UnitOfWork
{
    public interface IUnitOfWork
    {
        void Commit();
        IEmployeeRepo EmployeeRepo { get; }
    }
}
