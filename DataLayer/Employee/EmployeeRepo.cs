using DataLayer.Repository;
using DB.Core.Models;

namespace DataLayer.Employee
{
    public class EmployeeRepo : GenericRepository<Employees>, IEmployeeRepo
    {
        public EmployeeRepo(MVCEFCoreContext context) : base(context)
        { }
    }
}
