using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Logic.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
    }

    public class SubCategoryModel : CategoryModel
    {
        public int SubCategoryId { get; set; }
        public string SubcategoryName { get; set; }
    }

    public class Topic : SubCategoryModel
    {
        public int TopicID { get; set; }
        public string TopicName { get; set; }
    }
}
