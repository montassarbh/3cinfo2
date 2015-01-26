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
       public RepositoryBase()
       {
           dbSet = dbContext.Set<T>();
       }

        public virtual void Add(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual void Delete(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public virtual void Update(T entity)
        {
            throw new NotImplementedException();
        }

        public virtual T GetById(int id)
        {
            throw new NotImplementedException();
        }

        public virtual T GetById(string id)
        {
            throw new NotImplementedException();
        }

        public virtual T GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public virtual ICollection<T> GetAll()
        {
            throw new NotImplementedException();
        }

        public virtual ICollection<T> GetMany(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }

        public virtual T Get(System.Linq.Expressions.Expression<Func<T, bool>> where)
        {
            throw new NotImplementedException();
        }
    }
}
