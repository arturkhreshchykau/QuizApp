﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizApp.Logic.Models
{
    public class CategoryModel
    {
        public int CategoryId { get; set; }
        public int? ParentCategoryId { get; set; }
        public string CategoryName { get; set; }
    }
}
