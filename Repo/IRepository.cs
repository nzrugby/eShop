using System;
using System.Collections.Generic;
using System.Text;

namespace Repo
{
    public interface IRepository<T> where T: class
    {
        void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
        T Get(Guid Id);
        IEnumerable<T> GetAll();
    }
}
