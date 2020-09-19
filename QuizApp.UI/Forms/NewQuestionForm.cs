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
        private readonly int questionID;
        public NewQuestionForm(int testId, int questionId)
        {
            InitializeComponent();
            testID = testId;
            questionID = questionId;
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
                SaveUpdateClosedQuestion(questionModel, questionService, answerModel, answerService);
            }
            else
            {
                SaveUpdateOpenQuestion(questionModel, questionService, answerModel, answerService);
            }
        }

        private void SaveUpdateOpenQuestion(QuestionModel questionModel, QuestionService questionService, AnswerModel answerModel, AnswerService answerService)
        {
            if (!string.IsNullOrEmpty(txt_question.Text) && !string.IsNullOrEmpty(txt_correctAnswer.Text))
            {
                answerModel.AnswerText = txt_correctAnswer.Text;

                if (btn_save.Text == "Update")
                {
                    //* updating a question
                    questionModel.isOpen = true;
                    questionModel.QuestionID = questionID;
                    questionService.Update(questionModel);

                    //* updating a correct answer
                    answerModel.QuestionID = questionID;
                    answerModel.isCorrect = true;
                    answerModel.AnswerID = answerService.GetAll().Where(x => x.QuestionID == questionID && x.isCorrect == true).Single().AnswerID;
                    answerService.Update(answerModel);

                    MessageBox.Show("Updated successfully!", "Done");
                    this.Close();
                }
                else
                {
                    //* add a new question
                    questionModel.isOpen = true;
                    questionService.Add(questionModel);

                    //* add a new answer
                    answerModel.isCorrect = true;
                    answerModel.QuestionID = questionService.GetAll().OrderByDescending(x => x.QuestionID).First().QuestionID;
                    answerService.Add(answerModel);

                    MessageBox.Show("Added successfully!", "Done");
                    txt_correctAnswer.Text = string.Empty;
                    txt_question.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please fill in all fields.", "Error");
            }
        }

        private void SaveUpdateClosedQuestion(QuestionModel questionModel, QuestionService questionService, AnswerModel answerModel, AnswerService answerService)
        {
            if (!string.IsNullOrEmpty(txt_question.Text)
                   && !string.IsNullOrEmpty(txt_correctAnswer.Text) && !string.IsNullOrEmpty(txt_secondAnswer.Text)
                   && !string.IsNullOrEmpty(txt_thirdAnswer.Text) && !string.IsNullOrEmpty(txt_fourthAnswer.Text)
                   && !CheckDuplicates())
            {
                if (btn_save.Text == "Update")
                {
                    //* updating a question
                    questionModel.isOpen = false;
                    questionModel.QuestionID = questionID;
                    questionService.Update(questionModel);

                    //* updating answers
                    var allAnswer = answerService.GetAll().Where(x => x.QuestionID == questionID).ToList();
                    int index = 0;
                    foreach (var answer in allAnswer)
                    {
                        if (answer.isCorrect)
                        {
                            answerModel.isCorrect = true;
                            answerModel.QuestionID = questionID;
                            answerModel.AnswerID = answer.AnswerID;
                            answerModel.AnswerText = txt_correctAnswer.Text;
                            answerService.Update(answerModel);
                        }
                        else
                        {
                            string[] answerText = new string[] { txt_secondAnswer.Text, txt_thirdAnswer.Text, txt_fourthAnswer.Text };
                            answerModel.AnswerID = answer.AnswerID;
                            answerModel.isCorrect = false;
                            answerModel.QuestionID = questionID;
                            answerModel.AnswerText = answerText[index];
                            answerService.Update(answerModel);
                            index++;
                        }
                    }

                    MessageBox.Show("Updated successfully!", "Done");
                    this.Close();
                }
                else
                {
                    //* adding a question
                    questionModel.isOpen = false;
                    questionService.Add(questionModel);

                    //* adding answers
                    answerModel.QuestionID = questionService.GetAll().OrderByDescending(x => x.QuestionID).First().QuestionID;
                    string[] answerText = new string[] { txt_correctAnswer.Text, txt_secondAnswer.Text, txt_thirdAnswer.Text, txt_fourthAnswer.Text };

                    foreach (var item in answerText)
                    {
                        if (item == txt_correctAnswer.Text)
                        {
                            answerModel.isCorrect = true;
                            answerModel.AnswerText = item;
                            answerService.Add(answerModel);
                        }
                        else
                        {
                            answerModel.isCorrect = false;
                            answerModel.AnswerText = item;
                            answerService.Add(answerModel);
                        }
                    }

                    MessageBox.Show("Added successfully!", "Done");
                    txt_question.Text = string.Empty;
                    txt_correctAnswer.Text = string.Empty;
                    txt_secondAnswer.Text = string.Empty;
                    txt_thirdAnswer.Text = string.Empty;
                    txt_fourthAnswer.Text = string.Empty;
                }
            }
            else
            {
                MessageBox.Show("Please fill in all the fields without duplicating the answer.", "Error");
            }
        }

        private bool CheckDuplicates()
        {
            bool duplicated = false;
            string[] answer = { txt_correctAnswer.Text, txt_secondAnswer.Text, txt_thirdAnswer.Text, txt_fourthAnswer.Text };

            if (answer.Length != answer.Distinct().Count())
            {
                duplicated = true;
            }

            return duplicated;
        }
    }
}
