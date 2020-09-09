using System;
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
        IQueryable<TEntity> DetAll();
        void Remove(TEntity item);
    }
}
