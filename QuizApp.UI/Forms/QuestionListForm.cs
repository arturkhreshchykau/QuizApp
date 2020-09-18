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
    public partial class QuestionListForm : Form
    {
        private readonly int testID;

        public QuestionListForm(int testID, string testName)
        {
            InitializeComponent();
            this.testID = testID;
            lbl_tableTitle.Text += " " + testName;
            DisplayQuestions();
        }

        private void DisplayQuestions()
        {
            lv_questionList.Items.Clear();
            QuestionService questionService = new QuestionService();
            var questionsList = questionService.GetAll().Where(x => x.TestID == testID).ToList();
            AnswerService answerService = new AnswerService();
            var answersList = answerService.GetAll();
            foreach (var question in questionsList)
            {
                List<AnswerModel> answer = answersList.Where(x => x.QuestionID == question.QuestionID).ToList();
                var row = new string[5];

                if (answer != null && answer.Count != 1)
                {
                    row = new string[] { question.QuestionName, answer[0].AnswerText, answer[1].AnswerText, answer[2].AnswerText, answer[3].AnswerText };
                }
                else
                {
                    row = new string[] { question.QuestionName, answer[0].AnswerText, string.Empty, string.Empty, string.Empty };
                }

                ListViewItem listView = new ListViewItem(row);
                listView.Tag = question;
                lv_questionList.Items.Add(listView);
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            try
            {
                int questionId = 0;
                NewQuestionForm questionForm = new NewQuestionForm(testID, questionId);
                questionForm.ShowDialog();
                DisplayQuestions();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btn_editQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                if (lv_questionList.SelectedItems.Count > 0)
                {
                    var question = (QuestionModel)lv_questionList.SelectedItems[0].Tag;
                    NewQuestionForm newQuestionForm = new NewQuestionForm(testID, question.QuestionID);
                    newQuestionForm.rbtn_yes.Checked = question.isOpen == true ? true : false;
                    newQuestionForm.rbtn_yes.Visible = false;
                    newQuestionForm.rbtn_no.Visible = false;
                    newQuestionForm.lbl_isOpen.Visible = false;
                    newQuestionForm.btn_save.Text = "Update";

                    AnswerService answerService = new AnswerService();
                    var allAnswer = answerService.GetAll();
                    newQuestionForm.txt_correctAnswer.Text = allAnswer.Where(x => x.QuestionID == question.QuestionID && x.isCorrect == true).Single().AnswerText;
                    newQuestionForm.txt_question.Text = question.QuestionName;

                    if (question.isOpen)
                    {
                        newQuestionForm.txt_secondAnswer.Visible = false;
                        newQuestionForm.txt_thirdAnswer.Visible = false;
                        newQuestionForm.txt_fourthAnswer.Visible = false;
                    }
                    else
                    {
                        var wrongAnswers = allAnswer.Where(x => x.QuestionID == question.QuestionID && x.isCorrect == false).ToList();
                        newQuestionForm.txt_secondAnswer.Text = wrongAnswers[0].AnswerText;
                        newQuestionForm.txt_thirdAnswer.Text = wrongAnswers[1].AnswerText;
                        newQuestionForm.txt_fourthAnswer.Text = wrongAnswers[2].AnswerText;
                    }

                    newQuestionForm.ShowDialog();
                    DisplayQuestions();
                }
                else
                {
                    MessageBox.Show("Please select a question", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btn_delete_Click(object sender, EventArgs e)
        {
            if (lv_questionList.SelectedItems.Count > 0)
            {
                QuestionService questionService = new QuestionService();
                AnswerService answerService = new AnswerService();
                var question = (QuestionModel)lv_questionList.SelectedItems[0].Tag;
                var answers = answerService.GetAll().Where(x => x.QuestionID == question.QuestionID).ToList();

                foreach (var answer in answers)
                {
                    answerService.Delete(answer.AnswerID);
                }

                questionService.Delete(question.QuestionID);
                MessageBox.Show("The question was deleted", "Success");
                DisplayQuestions();
            }
            else
            {
                MessageBox.Show("Please select a question", "Error");
            }
        }
    }
}
