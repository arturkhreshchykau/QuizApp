using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Logic.Repositories.Interfaces
{
    public interface IRepository<T>
    {
        bool Add(T item);
        bool Delete(T item);
        T Get(T item);
        IEnumerable<T> GetAll();
    }
}
