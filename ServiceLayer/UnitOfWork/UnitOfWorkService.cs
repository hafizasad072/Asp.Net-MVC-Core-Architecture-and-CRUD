using DataLayer.Employee;
using DB.Core.Models;

namespace ServiceLayer.UnitOfWork
{
    public class UnitOfWorkService : IUnitOfWorkService
    {
        private IEmployeeRepo employeeRepo { get; set; }



        public MVCEFCoreContext _dbContext;
        public UnitOfWorkService(MVCEFCoreContext context)
        {
            _dbContext = context;
        }
        public IEmployeeRepo EmployeeRepo => employeeRepo == null ? new EmployeeRepo(_dbContext) : employeeRepo;
        //public T GetRepository<T>() where T : class
        //{
        //    var result = (T)Activator.CreateInstance(typeof(T), _dbContext);
        //    if (result != null)
        //    {
        //        return result;
        //    }
        //    return null;
        //}

        public int Commit()
        {
            return _dbContext.SaveChanges();
        }
    }
}
