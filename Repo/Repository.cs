using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repo
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private EShopDbContext context;
        private DbSet<T> entities;
        public Repository(EShopDbContext db)
        {
            this.context = db;
            entities = db.Set<T>();
        }
        public void Add(T entity)
        {
            if (entity == null)
            {
                throw new Exception("entity is null");
            }
            context.Add(entity);
            context.SaveChanges();
        }

        public T Get(Guid Id)
        {
            return entities.FirstOrDefault(p=>p.GetType().GetProperty("Id").GetValue(p).ToString() == Id.ToString());
        }

        public IEnumerable<T> GetAll()
        {
            return entities.ToList();
        }

        public void Remove(T entity)
        {
            if(entity == null)
            {
                throw new Exception("entity is null");
            }
            context.Remove(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            if (entity == null)
            {
                throw new Exception("entity is null");
            }
            context.SaveChanges();
        }
    }
}
