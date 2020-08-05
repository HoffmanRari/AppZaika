using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using T_Zaika.Domain.Entities;

namespace T_Zaika.Business.Operations
{
    public interface IOperations<T> where T : EntityBase
    {
        IEnumerable<T> GetAll();
        T GetByKey(long key);
        void AddOrUpdate(T entityObj);
        void Delete(T entityObj);
        void Remove(T entity);
        T Find(Expression<Func<T, bool>> condition);
        IQueryable<T> FindAll(Expression<Func<T, bool>> condition = null);
        void AddRange(List<T> entityObj);
        void DeleteRange(IQueryable<T> entityObj);
        void Update(T entityObj);
        void SaveChanges();
    }
}
