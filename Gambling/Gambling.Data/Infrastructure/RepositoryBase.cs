using Gambling.Data.Contracts;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Data.Infrastructure
{
   public abstract class RepositoryBase<T> :Disposable,IRepository<T> where T:class
    {
       GamblingContext dbContext;
       DbSet<T> dbSet;
       DatabaseFactory dbFactory;
       public RepositoryBase(DatabaseFactory db)
       {
           dbFactory = db;
           dbContext = dbFactory.Get();
           dbSet = dbContext.Set<T>();
       }

        public virtual void Add(T entity)
        {
            dbSet.Add(entity);

        }

        public virtual void Delete(T entity)
        {
            dbSet.Remove(entity);
        }

        public virtual void Delete(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            var tobeDeleted = dbSet.Where(where);
            foreach (T entity in tobeDeleted)
                dbSet.Remove(entity);

        }

        public virtual void Update(T entity)
        {
            dbSet.Attach(entity);
            dbContext.Entry(entity).State = EntityState.Modified;
        }

        public virtual T GetById(int id)
        {
            return dbSet.Find(id);
            
        }

        public virtual T GetById(string id)
        {
            return dbSet.Find(id);
        }

        public virtual T GetById(Guid id)
        {
            return dbSet.Find(id);
        }

        public virtual ICollection<T> GetAll()
        {
            return dbSet.ToList();
        }

        public virtual ICollection<T> GetMany(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).ToList();
        }

        public virtual T Get(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            return dbSet.Where(where).FirstOrDefault();
        }

    }
}
