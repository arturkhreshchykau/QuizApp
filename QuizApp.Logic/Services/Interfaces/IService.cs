using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Logic.Services.Interfaces
{
    public interface IService<T>
    {
        bool Add(T item);
        bool Delete(int id);
        T Get(int id);
        bool Update(T item);
        IEnumerable<T> GetAll();
    }
}
