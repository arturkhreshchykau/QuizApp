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
        private IGenericRepository<Category> _categoryRepository;

        public CategoryService()
        {
            _categoryRepository = new GenericRepository<Category>();
        }

        public bool Add(CategoryModel item)
        {
            bool added;
            if (item != null)
            {
                Category category = new Category()
                {
                    CategoryID = item.CategoryId,
                    ParentCategoryID = item.ParentCategoryId,
                    CategoryName = item.CategoryName
                };

                _categoryRepository.Add(category);
                added = true;
            }
            else
            {
                added = false;
            }
            return added;
        }

        public bool Delete(int id)
        {
            bool deleted;
            if (id > 0)
            {
                _categoryRepository.Delete(id);
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
                Category user = _categoryRepository.GetById(id);
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
            return _categoryRepository.GetAll()
                .Select(category => new CategoryModel(){ CategoryId = category.CategoryID, CategoryName = category.CategoryName, ParentCategoryId = category.ParentCategoryID})
                .AsEnumerable();
        }

        public List<CategoryModel> GetSubCategories(int id)
        {
            return GetAll().Where(x => x.ParentCategoryId == id).ToList();
        }

        public void DeleteSelectedSubList(int id)
        {
            var subCategories = GetSubCategories(id);
            //* delete all topics
            foreach (var topic in subCategories)
            {
                Delete(topic.CategoryId);
            }
            //* delete current subCategory
            Delete(id);
        }
    }
}
