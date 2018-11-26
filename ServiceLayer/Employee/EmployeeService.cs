using DataLayer.Employee;
using DB.Core.Models;
using ServiceLayer.UnitOfWork;

namespace ServiceLayer.Employee
{
    public class EmployeeService : IEmployeeService
    {
        private IUnitOfWorkService _uow;
        public EmployeeService(IUnitOfWorkService uow)
        {
            _uow = uow;
        }

        public bool CreateEmployee(Employees data)
        {
            _uow.EmployeeRepo.Insert(data);
            _uow.Commit();
            return true;
        }
    }
}
