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
    public partial class TestResultForm : Form
    {
        private readonly int testID;
        private readonly int userID;

        public TestResultForm(int testId, int userId)
        {
            InitializeComponent();

            this.testID = testId;
            this.userID = userId;

            DisplayAnswer();
        }

        private void DisplayAnswer()
        {
            lv_testResult.Items.Clear();
            QuestionService questionService = new QuestionService();
            List<QuestionModel> questionList = questionService.GetAll().Where(x => x.TestID == testID).ToList();
            AnswerService answerService = new AnswerService();
            List<AnswerModel> answerList = answerService.GetAll().ToList();
            UserService userService = new UserService();
            lbl_userName.Text = userService.Get(userID).Name;
            StatisticService statisticService = new StatisticService();
            int correct = statisticService.GetAll().Where(x => x.TestID == testID && x.UserID == userID).ToList().OrderByDescending(x => x.StatisticID).First().CorrectAnswer;

            lbl_result.Text += Math.Round((double)(100 * correct) / questionList.Count).ToString() + "%";

            foreach (var question in questionList)
            {
                string correctAnswer = answerList.Where(x => x.QuestionID == question.QuestionID && x.isCorrect == true).Single().AnswerText;
                var row = new string[] { question.QuestionName, correctAnswer };
                ListViewItem listView = new ListViewItem(row);
                listView.Tag = question;
                lv_testResult.Items.Add(listView);
            }
        }

        private void btn_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
