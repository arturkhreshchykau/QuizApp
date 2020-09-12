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
        bool Delete(T item);
        T Get(int id);
        IEnumerable<T> GetAll();
    }
}
