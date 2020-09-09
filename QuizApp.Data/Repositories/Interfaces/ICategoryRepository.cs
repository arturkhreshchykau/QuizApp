using QuizApp.Logic.Models;
using QuizApp.Logic.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Logic.Interfaces
{
    interface ICategoryRepository : IRepository<CategoryModel>
    {
        //void AddCategory(CategoryModel categoryModel);
        //void DeleteCategory(int id);
        //List<CategoryModel> GetAllCategories(CategoryModel categoryModel);
        //bool Exist(CategoryModel categoryModel);
    }
}
