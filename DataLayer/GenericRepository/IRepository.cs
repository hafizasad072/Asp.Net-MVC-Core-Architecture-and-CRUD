using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.GenericRepository
{
    public interface IRepository<T> where T :class
    {
        T GetById(int id);

        IQueryable<T> GetAll();

        void Edit(T entity);

        void Insert(T entity);

        void Delete(T entity);
    }
}
