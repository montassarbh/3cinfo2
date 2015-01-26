﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Gambling.Data.Contracts
{
    interface IRepository<T> : IDisposable where T:class
    {
        void Add(T entity);
        void Delete(T entity);
        void Delete(Expression<Func<T, bool>> where);
        void Update(T entity);
        T GetById(int id);
        T GetById(string id);
        T GetById(Guid id);

        ICollection<T> GetAll();
        ICollection<T> GetMany(Expression<Func<T, bool>> where);
        T Get(Expression<Func<T, bool>> where);


    }
}
