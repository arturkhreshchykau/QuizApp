using QuizApp.Logic.Models;
using QuizApp.Logic.Services.Implementations;
using QuizApp.Logic.Services.Interfaces;
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
        private readonly IUserService userService;
        private readonly IStatisticService statisticService;
        private readonly ITestService testService;
        private readonly IQuestionService questionService;
        private readonly ICategoryService categoryService;
        public StatisticForm()
        {
            InitializeComponent();
            userService = new UserService();
            statisticService = new StatisticService();
            testService = new TestService();
            questionService = new QuestionService();
            categoryService = new CategoryService();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_userStatistic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lv_statistic.Items.Clear();
            if (lv_statistic.Columns.Count < 4)
            {
                lv_statistic.Columns.Add("Passed", 150, HorizontalAlignment.Left);
                lv_statistic.Columns[2].Text = "Percent";
                lv_statistic.Columns[2].Width = 60;
            }

            List<StatisticModel> statisticList = statisticService.GetAll().ToList();

            foreach (var statistic in statisticList)
            {
                string testName = testService.Get(statistic.TestID).TestName;
                string name = userService.Get(statistic.UserID).Name;

                int count = questionService.GetAll().Where(x => x.TestID == statistic.TestID).ToList().Count;
                string percent = Math.Round((double)(100 * statistic.CorrectAnswer) / count).ToString();

                var row = new string[] { name, testName, percent + "%", statistic.Passed.ToString() };
                ListViewItem listView = new ListViewItem(row);
                listView.Tag = statistic;
                lv_statistic.Items.Add(listView);
            }
        }

        private void lbl_categoryStatistic_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            lv_statistic.Items.Clear();
            lv_statistic.Columns[0].Text = "Category Name";
            lv_statistic.Columns[2].Text = "Average Percent";
            lv_statistic.Columns[2].Width = 120;
            
            if (lv_statistic.Columns.Count == 4)
            {
                lv_statistic.Columns.Remove(lv_statistic.Columns[3]);
            }
            
            var allStatistic = statisticService.GetAll();
            List<StatisticModel> statisticList = allStatistic.GroupBy(x => x.TestID).Select(x => x.First()).ToList();

            foreach (var statistic in statisticList)
            {
                TestModel test = testService.Get(statistic.TestID);
                string name = categoryService.Get(test.CategoryID).CategoryName;

                List<StatisticModel> list = allStatistic.Where(x => x.TestID == statistic.TestID).ToList();

                int percents = 0;
                foreach (var item in list)
                {
                    percents += (int)Math.Round((double)item.CorrectAnswer * 100 / item.QuestionsTotal);
                }

                int averagePercent = (int)Math.Round((double)percents / list.Count);
                string[] row = new string[] { name, test.TestName, averagePercent.ToString() + "%" };
                ListViewItem listView = new ListViewItem(row);
                listView.Tag = statistic;
                lv_statistic.Items.Add(listView);
            }
        }
    }
}
