using QuizApp.Logic.Models;
using QuizApp.Logic.Repository;
using System;
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
            if (string.IsNullOrEmpty(txt_name.Text) || (!rbtn_yes.Checked && !rbtn_no.Checked))
                filled = false;
            return filled;
        }

        private void lbl_addCategory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                CategoryModel categoryModel = new CategoryModel();
                categoryModel.CategoryName = cbo_category.Text;
                
                CategoryHelper categoryHelper = new CategoryHelper();

                if (!string.IsNullOrEmpty(categoryModel.CategoryName) && !categoryHelper.Exist(categoryModel))
                {
                    categoryHelper.AddCategory(categoryModel);
                    categoryList.Clear();
                    DisplayCategory();
                }
                else
                {
                    MessageBox.Show("This category already exists, or this field is empty!!!", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayCategory()
        {
            try
            {
                CategoryHelper categoryHelper = new CategoryHelper();
                CategoryModel categoryModel = new CategoryModel();
                categoryList = categoryHelper.GetAllCategories(categoryModel);
                cbo_category.ValueMember = "CategoryId";
                cbo_category.DisplayMember = "CategoryName";
                cbo_category.DataSource = categoryList;
                cbo_category.SelectedIndex = -1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
