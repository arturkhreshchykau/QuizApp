using QuizApp.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Logic.Interfaces
{
    interface ICategoryHelper
    {
        void AddCategory(CategoryModel categoryModel);
        bool DeleteCategory(CategoryModel categoryModel);
        List<CategoryModel> GetAllCategories(CategoryModel categoryModel);
        bool Exist(CategoryModel categoryModel);
    }
}
