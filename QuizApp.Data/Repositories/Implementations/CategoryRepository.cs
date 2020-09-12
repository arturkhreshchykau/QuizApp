using QuizApp.Data.App_Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Logic.Repository
{
    public class CategoryRepository
    {
        //private readonly QuizDBEntities _quizDB;

        //public CategoryRepository()
        //{
        //    _quizDB = new QuizDBEntities();
        //}

        //public void AddCategory(CategoryModel categoryModel)
        //{
        //    Category category = new Category()
        //    {
        //        CategoryName = categoryModel.CategoryName
        //    };
        //    _quizDB.Categories.Add(category);
        //    _quizDB.SaveChanges();
        //}

        //public void DeleteCategory(int id)
        //{
        //    var res = _quizDB.Categories.FirstOrDefault(x => x.CategoryID == id);
        //    _quizDB.Categories.Remove(res);
        //    _quizDB.SaveChanges();
        //}

        //public bool Exist(CategoryModel categoryModel)
        //{
        //    bool exist = false;
        //    var res = _quizDB.Categories
        //            .Where(x => x.CategoryName == categoryModel.CategoryName)
        //            .SingleOrDefault();
        //    if (res != null)
        //    {
        //        exist = true;
        //    }
        //    return exist;
        //}

        //public List<CategoryModel> GetAllCategories(CategoryModel categoryModel)
        //{
        //    var categories = _quizDB.Categories
        //                    .Where(x => x.ParentCategoryID == null)
        //                    .ToList();
        //    List<CategoryModel> categoryList = new List<CategoryModel>();
        //    foreach (var category in categories)
        //    {
        //        categoryList.Add(new CategoryModel()
        //        {
        //            CategoryId = category.CategoryID,
        //            CategoryName = category.CategoryName
        //        });
        //    }

        //    return categoryList;
        //}
        //public bool Add(CategoryModel item)
        //{
        //    throw new NotImplementedException();
        //}

        //public bool Delete(CategoryModel item)
        //{
        //    throw new NotImplementedException();
        //}

        //public CategoryModel Get(CategoryModel item)
        //{
        //    throw new NotImplementedException();
        //}

        //public IEnumerable<CategoryModel> GetAll()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
