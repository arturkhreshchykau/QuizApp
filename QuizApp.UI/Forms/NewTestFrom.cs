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
    public partial class NewTestFrom : Form
    {
        private List<CategoryModel> categoryList;
        private List<CategoryModel> subCategoryList;
        private List<CategoryModel> topicList;

        public NewTestFrom()
        {
            InitializeComponent();
            DisplayCategory();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormVerification())
                {
                    NewQuestionForm newQuestion = new NewQuestionForm();
                    newQuestion.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please fill in the required fields", "Error");                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private bool FormVerification()
        {
            bool filled = true;
            if (string.IsNullOrEmpty(txt_name.Text) || (!rbtn_yes.Checked && !rbtn_no.Checked) || string.IsNullOrEmpty(cbo_category.Text))
                filled = false;
            return filled;
        }

        private void lbl_addCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try 
            { 
                AddCategory(new ArrayList() { null, cbo_category.Text, "Category" });
                categoryList.Clear();
                DisplayCategory();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void AddCategory(ArrayList list)
        {
            CategoryService categoryService = new CategoryService();
            CategoryModel categoryModel = new CategoryModel();
            categoryModel.CategoryName = (string)list[1];
            categoryModel.ParentCategoryId = (int?)list[0];

            if (!string.IsNullOrEmpty(categoryModel.CategoryName) && !categoryService.Exist(categoryModel))
            {
                categoryService.Add(categoryModel);
                MessageBox.Show("Added successfully!");
            }
            else
            {
                MessageBox.Show($"This {(string)list[2]} already exists, or this field is empty!!!", "Error");
            }
        }

        private void DisplayCategory()
        {
            CategoryService categoryService = new CategoryService();
            categoryList = categoryService.GetAllCategory();
            cbo_category.ValueMember = "CategoryId";
            cbo_category.DisplayMember = "CategoryName";
            cbo_category.DataSource = categoryList;
            cbo_category.SelectedIndex = -1;
        }

        private void DisplaySubCategory(int id)
        {
            CategoryService categoryService = new CategoryService();
            subCategoryList = categoryService.GetSubCategories(id);
            cbo_subcategory.ValueMember = "CategoryId";
            cbo_subcategory.DisplayMember = "CategoryName";
            cbo_subcategory.DataSource = subCategoryList;
            cbo_subcategory.SelectedIndex = -1;
        }

        private void DisplayTopic(int id)
        {
            CategoryService categoryService = new CategoryService();
            topicList = categoryService.GetSubCategories(id);
            cbo_topic.ValueMember = "CategoryId";
            cbo_topic.DisplayMember = "CategoryName";
            cbo_topic.DataSource = topicList;
            cbo_topic.SelectedIndex = -1;
        }

        private void lbl_deleteCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int id = Convert.ToInt32(cbo_category.SelectedValue);
            DeleteCategory(id, cbo_category.Text);
            DisplayCategory();
        }

        private void lbl_deleteSubCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int id = Convert.ToInt32(cbo_subcategory.SelectedValue);
            DeleteCategory(id, cbo_subcategory.Text);
            subCategoryList.Clear();
        }

        private void lbl_deleteTopic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            int id = Convert.ToInt32(cbo_topic.SelectedValue);
            DeleteCategory(id, cbo_topic.Text);
            topicList.Clear();
        }

        private void DeleteCategory(int id, string category)
        {
            try
            {
                if (!string.IsNullOrEmpty(category))
                {
                    CategoryService categoryService = new CategoryService();
                    categoryService.Delete(categoryService.Get(id));
                    MessageBox.Show("Deleted successfully");
                }
                else
                {
                    MessageBox.Show("Please select the Category for deleting!", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void lbl_addSubCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(cbo_subcategory.Text))
            {
                AddCategory(new ArrayList() { Convert.ToInt32(cbo_category.SelectedValue), cbo_subcategory.Text, "SubCategory" });
                subCategoryList.Clear();
                DisplaySubCategory(Convert.ToInt32(cbo_category.SelectedValue));
            }
            else
            {
                MessageBox.Show("This SubCategory already exists, or this field is empty!!!", "Error");
            }
        }

        private void lbl_addTopic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (!string.IsNullOrEmpty(cbo_subcategory.Text) && !string.IsNullOrEmpty(cbo_topic.Text))
            {
                AddCategory(new ArrayList() { Convert.ToInt32(cbo_subcategory.SelectedValue), cbo_topic.Text, "Topic" });
                topicList.Clear();
                DisplayTopic(Convert.ToInt32(cbo_subcategory.SelectedValue));
            }
            else
            {
                MessageBox.Show("This Topic already exists, or fields are empty!!!", "Error");
                cbo_topic.Text = string.Empty;
            }
        }

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
    }
}
