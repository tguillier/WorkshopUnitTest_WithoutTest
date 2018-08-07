﻿using Mocking.Domain.Entities;
using System.Collections.Generic;

namespace Mocking.Domain.Interfaces
{
    public interface IRepository<T> where T : BaseEntity
    {
        T GetById(int id);
        IEnumerable<T> ListAll();
        T Add(T entity);
        void Update(T entity);
        void Delete(T entity);
    }
}
