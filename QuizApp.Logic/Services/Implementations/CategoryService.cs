using QuizApp.Data.App_Data;
using QuizApp.Data.Repositories.Implementations;
using QuizApp.Data.Repositories.Interfaces;
using QuizApp.Logic.Models;
using QuizApp.Logic.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Logic.Services.Implementations
{
    public class CategoryService : ICategoryService
    {
        private IGenericRepository<Category> _categoryService;

        public CategoryService()
        {
            _categoryService = new GenericRepository<Category>();
        }

        public bool Add(CategoryModel item)
        {
            bool added;
            if (item != null)
            {
                _categoryService.Add(Mapping(item));
                added = true;
            }
            else
            {
                added = false;
            }
            return added;
        }

        public bool Delete(CategoryModel item)
        {
            bool deleted;
            if (item != null)
            {
                _categoryService.Delete(Mapping(item));
                deleted = true;
            }
            else
            {
                deleted = false;
            }
            return deleted;
        }

        public CategoryModel Get(int id)
        {
            if (id < 1)
            {
                return null;
            }
            else
            {
                Category user = _categoryService.GetById(id);
                return new CategoryModel()
                {
                    CategoryId = user.CategoryID,
                    ParentCategoryId = user.ParentCategoryID,
                    CategoryName = user.CategoryName
                };
            }
        }

        public IEnumerable<CategoryModel> GetAll()
        {
            return _categoryService.GetAll()
                .Select(category => new CategoryModel(){ CategoryId = category.CategoryID, CategoryName = category.CategoryName, ParentCategoryId = category.ParentCategoryID})
                .AsEnumerable();
        }

        public List<CategoryModel> GetAllCategory()
        {
            return GetAll().Where(x => x.ParentCategoryId == null).ToList();
        }

        public List<CategoryModel> GetSubCategories(int id)
        {
            return GetAll().Where(x => x.ParentCategoryId == id).ToList();
        }

        public bool Exist(CategoryModel item)
        {
            var user = GetAll().Where(x => x.CategoryName == item.CategoryName).SingleOrDefault();
            bool exist = false;
            if (user != null)
                exist = true;

            return exist;
        }

        private Category Mapping(CategoryModel item)
        {
            return new Category()
            {
                CategoryID = item.CategoryId,
                ParentCategoryID = item.ParentCategoryId,
                CategoryName = item.CategoryName
            };
        }
    }
}
