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
    public partial class NewQuestionForm : Form
    {
        private readonly int testID;
        public NewQuestionForm(int id)
        {
            InitializeComponent();
            testID = id;
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rbtn_no_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_no.Checked)
            {
                lbl_labelAnswer.Visible = true;
                lbl_correctAnswer.Visible = true;
                txt_correctAnswer.Visible = true;
                txt_secondAnswer.Visible = true;
                txt_thirdAnswer.Visible = true;
                txt_fourthAnswer.Visible = true;
            }
        }

        private void rbtn_yes_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_yes.Checked)
            {
                lbl_labelAnswer.Visible = false;
                lbl_correctAnswer.Visible = false;
                txt_correctAnswer.Visible = false;
                txt_secondAnswer.Visible = false;
                txt_thirdAnswer.Visible = false;
                txt_fourthAnswer.Visible = false;                
            }
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            QuestionService questionService = new QuestionService();
            QuestionModel questionModel = new QuestionModel();
            AnswerModel answerModel = new AnswerModel();
            AnswerService answerService = new AnswerService();

            questionModel.QuestionName = txt_question.Text;
            questionModel.TestID = testID;

            if (rbtn_no.Checked)
            {
                if (!string.IsNullOrEmpty(txt_question.Text)
                && !string.IsNullOrEmpty(txt_correctAnswer.Text) && !string.IsNullOrEmpty(txt_secondAnswer.Text)
                && !string.IsNullOrEmpty(txt_thirdAnswer.Text) && !string.IsNullOrEmpty(txt_fourthAnswer.Text))
                {
                    questionModel.isOpen = false;
                    questionService.Add(questionModel);

                    int questionID = questionService.GetAll().Where(x => x.TestID == testID && x.QuestionName == txt_question.Text).Single().QuestionID;
                    answerModel.QuestionID = questionID;
                    foreach (var answer in new string[] { txt_correctAnswer.Text, txt_secondAnswer.Text, txt_thirdAnswer.Text, txt_fourthAnswer.Text })
                    {
                        answerModel.AnswerText = answer;
                        answerModel.isCorrect = answer == txt_correctAnswer.Text ? true : false;
                        answerService.Add(answerModel);
                    }

                    txt_question.Text = string.Empty;
                    txt_correctAnswer.Text = string.Empty;
                    txt_secondAnswer.Text = string.Empty;
                    txt_thirdAnswer.Text = string.Empty;
                    txt_fourthAnswer.Text = string.Empty;

                    MessageBox.Show("Added successfully!", "Done");
                }
                else
                {
                    MessageBox.Show("Please fill in all fields.", "Error");
                }
                
            }
            else
            {
                if (!string.IsNullOrEmpty(txt_question.Text))
                {
                    questionModel.isOpen = true;
                    questionService.Add(questionModel);
                    txt_question.Text = string.Empty;

                    MessageBox.Show("Added successfully!", "Done");
                }
                else
                {
                    MessageBox.Show("Please fill in the question.", "Error");
                }
            }
        }
    }
}
