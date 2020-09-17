using QuizApp.Logic.Models;
using QuizApp.Logic.Services.Implementations;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp.UI.Forms
{
    public partial class NewTestForm : Form
    {
        private List<CategoryModel> categoryList;
        private List<CategoryModel> subCategoryList;
        private List<CategoryModel> topicList;
        public int TestID { get; set; }

        public NewTestForm()
        {
            InitializeComponent();
            DisplayCategory();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Adding Category/SubCategory/Topic
        private void lbl_addCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(cbo_category.Text))
            {
                AddCategory(new List<string>() { string.Empty, cbo_category.Text, "Category" });
                categoryList.Clear();
                DisplayCategory();
            }
            else
            {
                MessageBox.Show("This Category already exists, or this field is empty!!!", "Error");
            }
        }

        private void lbl_addSubCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(cbo_subcategory.Text) && cbo_category.SelectedIndex != -1)
            {
                AddCategory(new List<string>() { cbo_category.SelectedValue.ToString(), cbo_subcategory.Text, "SubCategory" });
                subCategoryList.Clear();
                DisplaySubCategory(Convert.ToInt32(cbo_category.SelectedValue));
            }
            else
            {
                MessageBox.Show("This SubCategory already exists or is empty, or Category is not selected!!!", "Error");
                cbo_subcategory.Text = string.Empty;
            }
        }

        private void lbl_addTopic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(cbo_topic.Text) && cbo_subcategory.SelectedIndex != -1 && cbo_category.SelectedIndex != -1)
            {
                AddCategory(new List<string>() { cbo_subcategory.SelectedValue.ToString(), cbo_topic.Text, "Topic" });
                topicList.Clear();
                DisplayTopic(Convert.ToInt32(cbo_subcategory.SelectedValue));
            }
            else
            {
                MessageBox.Show("This Topic already exists or is empty, or some of the fields are not selected!!!", "Error");
                cbo_topic.Text = string.Empty;
            }
        }

        private void AddCategory(List<string> list)
        {
            CategoryService categoryService = new CategoryService();
            CategoryModel categoryModel = new CategoryModel();
            categoryModel.CategoryName = list[1];
            if (list[0] == string.Empty)
            {
                categoryModel.ParentCategoryId = null;
            }
            else
            {
                categoryModel.ParentCategoryId = Convert.ToInt32(list[0]);
            }

            var category = categoryService.GetAll().Where(x => x.CategoryName == categoryModel.CategoryName).SingleOrDefault();

            if (category == null)
            {
                categoryService.Add(categoryModel);
                MessageBox.Show("Added successfully!", "Done");
            }
            else
            {
                MessageBox.Show($"This {list[2]} already exists.", "Error");
            }
        }
        #endregion

        #region Displaying Category/SubCategory/Topic 
        private void DisplayCategory()
        {
            CategoryService categoryService = new CategoryService();
            categoryList = categoryService.GetAll().Where(x => x.ParentCategoryId == null).ToList();
            cbo_category.ValueMember = "CategoryId";
            cbo_category.DisplayMember = "CategoryName";
            cbo_category.DataSource = categoryList;
            cbo_category.SelectedIndex = -1;
        }

        public void DisplaySubCategory(int id)
        {
            CategoryService categoryService = new CategoryService();
            subCategoryList = categoryService.GetSubCategories(id);
            cbo_subcategory.ValueMember = "CategoryId";
            cbo_subcategory.DisplayMember = "CategoryName";
            cbo_subcategory.DataSource = subCategoryList;
            cbo_subcategory.SelectedIndex = -1;
        }

        public void DisplayTopic(int id)
        {
            CategoryService categoryService = new CategoryService();
            topicList = categoryService.GetSubCategories(id);
            cbo_topic.ValueMember = "CategoryId";
            cbo_topic.DisplayMember = "CategoryName";
            cbo_topic.DataSource = topicList;
            cbo_topic.SelectedIndex = -1;
        }
        #endregion

        #region Deleting Category/SubCategory/Topic
        private void lbl_deleteCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cbo_category.SelectedIndex != -1)
            {
                int categoryID = Convert.ToInt32(cbo_category.SelectedValue);
                CategoryService categoryService = new CategoryService();

                var subCategoryList = categoryService.GetSubCategories(categoryID);
                
                //* delete all topics for the current Category
                foreach (var category in subCategoryList)
                {
                    categoryService.DeleteSelectedSubList(category.CategoryId);
                }

                //* delete all subcategories for the current Category
                categoryService.DeleteSelectedSubList(categoryID);

                MessageBox.Show("Deleted successfully");
                DisplayCategory();
                cbo_category.Text = string.Empty;
            }
            else
            {
                MessageBox.Show("Please select the Category for deleting!", "Error");
            }
        }

        private void lbl_deleteSubCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cbo_category.SelectedIndex != -1 && cbo_subcategory.SelectedIndex != -1)
            {
                int id = Convert.ToInt32(cbo_subcategory.SelectedValue);
                CategoryService categoryService = new CategoryService();
                categoryService.DeleteSelectedSubList(id);
                subCategoryList.Clear();
                MessageBox.Show("Deleted successfully");
                cbo_subcategory.Text = string.Empty;
                int categoryID = Convert.ToInt32(cbo_category.SelectedValue);
                DisplaySubCategory(categoryID);
            }
            else
            {
                MessageBox.Show("Please select the Category and SubCategory for deleting!", "Error");
            }
        }

        private void lbl_deleteTopic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (cbo_category.SelectedIndex != -1 && cbo_subcategory.SelectedIndex != -1 && cbo_topic.SelectedIndex != -1)
            {
                int id = Convert.ToInt32(cbo_topic.SelectedValue);
                CategoryService categoryService = new CategoryService();
                categoryService.Delete(id);
                topicList.Clear();
                MessageBox.Show("Deleted successfully");
                cbo_topic.Text = string.Empty;
                int subCategoryID = Convert.ToInt32(cbo_subcategory.SelectedValue);
                DisplayTopic(subCategoryID);
            }
            else
            {
                MessageBox.Show("Please select the Category, SubCategory or Topic for deleting!", "Error");
            }
        }
        #endregion 

        private void cbo_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplaySubCategory(Convert.ToInt32(cbo_category.SelectedValue));
            cbo_subcategory.Text = string.Empty;
            cbo_topic.Text = string.Empty;
        }

        private void cbo_subcategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayTopic(Convert.ToInt32(cbo_subcategory.SelectedValue));
            cbo_topic.Text = string.Empty;
        }

        private void btn_createTest_Click(object sender, EventArgs e)
        {
            if(!string.IsNullOrEmpty(txt_testName.Text) && cbo_category.SelectedIndex != -1)
            {
                int categoryID;
                if (cbo_topic.SelectedValue != null)
                {
                    categoryID = Convert.ToInt32(cbo_topic.SelectedValue);
                }
                else if (cbo_subcategory.SelectedValue != null)
                {
                    categoryID = Convert.ToInt32(cbo_subcategory.SelectedValue);
                }
                else
                {
                    categoryID = Convert.ToInt32(cbo_category.SelectedValue);
                }

                TestModel testModel = new TestModel()
                {
                    TestName = txt_testName.Text,
                    CategoryID = categoryID,
                    isLiveCheck = rbtn_no.Checked ? true : false,
                };

                if (txt_timer.Text == string.Empty || txt_timer.Text == "0")
                {
                    testModel.Timer = null;
                }
                else
                {
                    testModel.Timer = Convert.ToInt32(txt_timer.Text);
                }
                
                TestService testService = new TestService();
                if (btn_createTest.Text == "Update")
                {
                    testModel.TestID = TestID;

                    if (testService.Update(testModel))
                        MessageBox.Show("Updated successfully.", "Done");
                }
                else
                {
                    testService.Add(testModel);
                    MessageBox.Show("Created successfully.", "Done");
                }
                
                this.Close();
            }
            else
            {
                MessageBox.Show("Please name the test and select at least a category.", "Error");
            }
        }
    }
}
