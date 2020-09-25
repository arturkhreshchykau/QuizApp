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
        private readonly int UserID;
        public MainForm(int UserId)
        {
            InitializeComponent();
            DisplayAllTest();
            this.UserID = UserId;
        }

        private void txt_addNew_Click(object sender, EventArgs e)
        {
            try
            {
                NewTestForm newTest = new NewTestForm(UserID);
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
                    NewTestForm testForm = new NewTestForm(UserID);
                    var test = (TestModel)lv_testList.SelectedItems[0].Tag;
                    testForm.TestID = test.TestID;

                    var allCategory = categoryService.GetAll();
                    testForm.txt_testName.Text = test.TestName;
                    testForm.txt_timer.Text = test.Timer.ToString();

                    CategoryModel topic = allCategory.Where(x => x.CategoryId == test.CategoryID).Single();
                    CategoryModel subCategory = allCategory.Where(x => x.CategoryId == topic.ParentCategoryId).SingleOrDefault();

                    string categoryName = string.Empty;
                    if (subCategory != null)
                    {
                        CategoryModel category = allCategory.Where(x => x.CategoryId == subCategory.ParentCategoryId).SingleOrDefault();
                        categoryName = category != null ? category.CategoryName : string.Empty;
                    }

                    string[] categoryList = new string[] { categoryName, subCategory?.CategoryName, topic.CategoryName };
                    DisplayCategory(testForm, categoryList, test.isLiveCheck);
                    
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

        private void DisplayCategory(NewTestForm testForm, string[] categoryList, bool isLiveCheck)
        {
            //* display category
            foreach (var item in categoryList)
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
            };

            //* display radiobuttons
            if (isLiveCheck)
            {
                testForm.rbtn_no.Checked = true;
            }
            else
            {
                testForm.rbtn_yes.Checked = true;
            }

            testForm.btn_createTest.Text = "Update";
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
                QuestionService questionService = new QuestionService();
                var questionList = questionService.GetAll().Where(x => x.TestID == test.TestID).ToList();
                AnswerService answerService = new AnswerService();

                foreach (var question in questionList)
                {
                    var answerList = answerService.GetAll().Where(x => x.QuestionID == question.QuestionID).ToList();
                    foreach (var answer in answerList)
                    {
                        answerService.Delete(answer.AnswerID);
                    }

                    questionService.Delete(question.QuestionID);
                }
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
                    QuestionListForm questionListForm = new QuestionListForm(test.TestID, test.TestName); 
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

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (lv_testList.SelectedItems.Count > 0)
                {
                    var test = (TestModel)lv_testList.SelectedItems[0].Tag;
                    QuestionService questionService = new QuestionService();
                    var questionList = questionService.GetAll().Where(x => x.TestID == test.TestID).ToList();
                    if (questionList.Count == 0)
                    {
                        MessageBox.Show("There are no questions in this test.", "Error");
                    }
                    else
                    {
                        QuizForm quizForm = new QuizForm(test, questionList, UserID);
                        quizForm.ShowDialog();
                    }
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

        private void btn_statistic_Click(object sender, EventArgs e)
        {
            try
            {
                StatisticForm statisticForm = new StatisticForm();
                statisticForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
