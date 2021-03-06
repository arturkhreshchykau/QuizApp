﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Data.Repositories.Interfaces
{
    public interface IGenericRepository<TEntity> where TEntity : class
    {
        void Add(TEntity item);
        TEntity GetById(int id);
        void Update(TEntity item);
        IQueryable<TEntity> GetAll();
        void Delete(int id);
    }
}
