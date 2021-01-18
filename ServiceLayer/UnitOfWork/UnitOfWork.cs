using System;
using System.Collections.Generic;
using System.Text;
using DataLayer.EmployeeRepo;
using DBCoreLayer.Models;
using ServiceLayer.Employee;

namespace ServiceLayer.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private IEmployeeRepo _employeeRepo { get; set; }
        public UnitOfWork(IEmployeeRepo employeeRepo, MVCEFCoreContext db)
        {
            _employeeRepo = employeeRepo;
            _db = db;
        }

        public IEmployeeRepo EmployeeRepo => _employeeRepo;       
        private MVCEFCoreContext _db { get; set; }

        public void Commit()
        {
            _db.SaveChanges();
        }
    }
}
