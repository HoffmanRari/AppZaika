using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using T_Zaika.Domain.Entities;

namespace T_Zaika.Business.Operations
{
    public class Operations<T> : IOperations<T> where T : EntityBase
    {
        public void AddOrUpdate(T entityObj)
        {
            throw new NotImplementedException();
        }

        public void AddRange(List<T> entityObj)
        {
            throw new NotImplementedException();
        }

        public void Delete(T entityObj)
        {
            throw new NotImplementedException();
        }

        public void DeleteRange(IQueryable<T> entityObj)
        {
            throw new NotImplementedException();
        }

        public T Find(Expression<Func<T, bool>> condition)
        {
            throw new NotImplementedException();
        }

        public IQueryable<T> FindAll(Expression<Func<T, bool>> condition = null)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public T GetByKey(long key)
        {
            throw new NotImplementedException();
        }

        public void Remove(T entity)
        {
            throw new NotImplementedException();
        }

        public void SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(T entityObj)
        {
            throw new NotImplementedException();
        }
    }
}
