using QuizApp.Logic.Models;
using QuizApp.Logic.Services.Implementations;
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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            DisplayAllTest();
        }

        private void txt_addNew_Click(object sender, EventArgs e)
        {
            try
            {
                NewTestForm newTest = new NewTestForm();
                newTest.ShowDialog();
                DisplayAllTest();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            try
            {
                if (lv_testList.SelectedItems.Count > 0)
                {
                    CategoryService categoryService = new CategoryService();
                    NewTestForm testForm = new NewTestForm();
                    var test = (TestModel)lv_testList.SelectedItems[0].Tag;
                    testForm.TestID = test.TestID;

                    var allCategory = categoryService.GetAll();
                    testForm.txt_testName.Text = test.TestName;
                    testForm.txt_timer.Text = test.Timer.ToString();
                    if (test.isLiveCheck)
                    {
                        testForm.rbtn_no.Checked = true;
                    }
                    else
                    {
                        testForm.rbtn_yes.Checked = true;
                    }

                    testForm.btn_createTest.Text = "Update";

                    CategoryModel topic = allCategory.Where(x => x.CategoryId == test.CategoryID).Single();
                    CategoryModel subCategory = allCategory.Where(x => x.CategoryId == topic.ParentCategoryId).SingleOrDefault();
                    categoryService.GetSubCategories(topic.CategoryId);

                    string categoryName = string.Empty;
                    if (subCategory != null)
                    {
                        categoryService.GetSubCategories(subCategory.CategoryId);
                        CategoryModel category = allCategory.Where(x => x.CategoryId == subCategory.ParentCategoryId).SingleOrDefault();
                        categoryName = category != null ? category.CategoryName : string.Empty;
                    }

                    foreach (var item in new string[] { categoryName, subCategory.CategoryName, topic.CategoryName })
                    {
                        if (testForm.cbo_category.FindStringExact(item) != -1)
                        {
                            testForm.cbo_category.SelectedIndex = testForm.cbo_category.FindStringExact(item);
                        }
                        else if (testForm.cbo_subcategory.FindStringExact(item) != -1)
                        {
                            testForm.cbo_subcategory.SelectedIndex = testForm.cbo_subcategory.FindStringExact(item);
                        }
                        else
                        {
                            testForm.cbo_topic.SelectedIndex = testForm.cbo_topic.FindStringExact(item);
                        }
                    }

                    testForm.ShowDialog();
                    DisplayAllTest();
                }
                else
                {
                    MessageBox.Show("Please select a test", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void DisplayAllTest()
        {
            try
            {
                lv_testList.Items.Clear();
                TestService testService = new TestService();
                CategoryService categoryService = new CategoryService();
                var allCategory = categoryService.GetAll();
                var tests = testService.GetAll().ToList();
                foreach (var test in tests)
                {
                    var topic = allCategory.Where(x => x.CategoryId == test.CategoryID).Single();
                    var subCategory = allCategory.Where(x => x.CategoryId == topic.ParentCategoryId).SingleOrDefault();

                    CategoryModel category;
                    string subCategoryName = string.Empty;
                    string categoryName = string.Empty;

                    if (subCategory != null)
                    {
                        subCategoryName = subCategory.CategoryName;
                        category = allCategory.Where(x => x.CategoryId == subCategory.ParentCategoryId).SingleOrDefault();
                        categoryName = category != null ? category.CategoryName : string.Empty;
                    }

                    string timer = test.Timer == null ? string.Empty : test.Timer.ToString();
                    string instantlyChecking = test.isLiveCheck == true ? "Yes" : "No";

                    var row = new string[] { test.TestName, (categoryName + " " + subCategoryName + " " + topic.CategoryName).TrimStart(), timer, instantlyChecking };
                    ListViewItem listView = new ListViewItem(row);
                    listView.Tag = test;
                    lv_testList.Items.Add(listView);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (lv_testList.SelectedItems.Count > 0)
            {
                var test = (TestModel)lv_testList.SelectedItems[0].Tag;
                TestService testService = new TestService();
                testService.Delete(test.TestID);
                MessageBox.Show("The Test was deleted", "Success");
                DisplayAllTest();
            }
            else
            {
                MessageBox.Show("Please select a test", "Error");
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (lv_testList.SelectedItems.Count > 0)
                {
                    var test = (TestModel)lv_testList.SelectedItems[0].Tag;
                    QuestionListForm questionListForm = new QuestionListForm();
                    questionListForm.TestID = test.TestID;
                    questionListForm.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please select a test", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
