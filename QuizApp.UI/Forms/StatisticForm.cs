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
    public partial class StatisticForm : Form
    {
        public StatisticForm()
        {
            InitializeComponent();
        }

        private void LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lv_statistic.Items.Clear();
            StatisticService statisticService = new StatisticService();
            List<StatisticModel> statisticList = statisticService.GetAll().ToList();
            string text = (sender as LinkLabel).Text;

            foreach (var statistic in statisticList)
            {
                TestService testService = new TestService();
                string name, testName;
                if (text == "User statistics")
                {
                    UserService userService = new UserService();
                    testName = testService.Get(statistic.TestID).TestName;
                    name = userService.Get(statistic.UserID).Name;
                }
                else
                {
                    CategoryService categoryService = new CategoryService();
                    TestModel test = testService.Get(statistic.TestID);
                    name = categoryService.Get(test.CategoryID).CategoryName;
                    testName = test.TestName;
                }

                QuestionService questionService = new QuestionService();
                int count = questionService.GetAll().Where(x => x.TestID == statistic.TestID).ToList().Count;
                string percent = Math.Round((double)(100 * statistic.CorrectAnswer) / count).ToString();

                var row = new string[] { name, testName, percent + "%", statistic.Passed.ToString() };
                ListViewItem listView = new ListViewItem(row);
                listView.Tag = statistic;
                lv_statistic.Items.Add(listView);
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
