using DB.Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataLayer.Repository
{
   public class GenericRepository<T> : IGenericRepository<T> where T : class
    {
        public MVCEFCoreContext context;
        public DbSet<T> dbset;
        public GenericRepository(MVCEFCoreContext context)
        {
            this.context = context;
            dbset = context.Set<T>();
        }

        public T GetById(int id)
        {
            return dbset.Find(id);
        }

        public T GetById(string id)
        {
            return dbset.Find(id);
        }
        public IQueryable<T> GetAll()
        {
            return dbset;
        }

        public void Insert(T entity)
        {
            dbset.Add(entity);
        }


        public void Edit(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
        }


        public void Delete(T entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
        }
        public bool ExecuteSQL(string query)
        {
            return context.Database.ExecuteSqlCommand(query) > 0;
        }
    }
}
