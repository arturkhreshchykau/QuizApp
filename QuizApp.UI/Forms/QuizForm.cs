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
    public partial class QuizForm : Form
    {
        private readonly int testID;
        private readonly int minutes;
        private readonly List<QuestionModel> questionList;
        private readonly bool isOpen;
        private int сorrect = 0;
        private string correctAnswer;
        private int quantity;

        public QuizForm(TestModel testModel)
        {
            InitializeComponent();

            testID = testModel.TestID;
            label1.Text = "Test: " + testModel.TestName;
            if (testModel.Timer == null)
            {
                lbl_hour.Visible = false;
                lbl_minute.Visible = false;
                lbl_second.Visible = false;
            }
            else
            {
                minutes = (int)testModel.Timer;
            }

            isOpen = testModel.isLiveCheck;
            
            //timer1.Start();
            QuestionService questionService = new QuestionService();
            questionList = questionService.GetAll().Where(x => x.TestID == testID).ToList();
            quantity = questionList.Count;
            DisplayQuestion();
        }

        private void DisplayQuestion()
        {
            Random rnd = new Random();
            var index = rnd.Next(questionList.Count);
            QuestionModel question = questionList[index];
            txt_questionName.Text = "Question: " + question.QuestionName;
            AnswerService answerService = new AnswerService();
            var allAnswer = answerService.GetAll();
            correctAnswer = allAnswer.Where(x => x.QuestionID == question.QuestionID && x.isCorrect == true).Single().AnswerText;
            var answerList = allAnswer.Where(x => x.QuestionID == question.QuestionID).ToList();

            if (question.isOpen)
            {
                txt_answer.Text = string.Empty;
                txt_answer.Visible = true;
                rbn_firstAnswer.Visible = false;
                rbn_secondAnswer.Visible = false;
                rbn_thirdAnswer.Visible = false;
                rbn_fourthAnswer.Visible = false;
                label3.Visible = false;
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
            }
            else
            {
                txt_answer.Visible = false;
                rbn_firstAnswer.Visible = true;
                rbn_secondAnswer.Visible = true;
                rbn_thirdAnswer.Visible = true;
                rbn_fourthAnswer.Visible = true;
                label3.Visible = true;
                label4.Visible = true;
                label5.Visible = true;
                label6.Visible = true;

                DisplayAnswer(answerList);
            }

            questionList.Remove(question);
        }

        private void DisplayAnswer(List<AnswerModel> answerList)
        {
            Random rnd = new Random();
            List<int> listIndex = new List<int>();
            int index;
            for (int i = 0; i < 4; i++)
            {
                do
                {
                    index = rnd.Next(0, 4);
                } while (listIndex.Contains(index));
                listIndex.Add(index);
            }

            rbn_firstAnswer.Text = answerList[listIndex[0]].AnswerText;
            rbn_secondAnswer.Text = answerList[listIndex[1]].AnswerText;
            rbn_thirdAnswer.Text = answerList[listIndex[2]].AnswerText;
            rbn_fourthAnswer.Text = answerList[listIndex[3]].AnswerText;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            int seconds = 60;
            int hours, min;
            if (minutes > 60)
            {
                double intHour = minutes / 60;
                hours = (int)Math.Round(intHour);
                min = minutes - hours * 60;
            }
            else
            {
                min = minutes;
                hours = 0;
            }

            lbl_hour.Text = hours.ToString();
            lbl_minute.Text = min.ToString();
            lbl_second.Text = seconds.ToString();

            seconds--;
            if (seconds == 0)
            {
                min--;
                seconds = 60;
            }

            if (min == 0)
            {
                hours--;
            }

            if (seconds == 0 && min == 0 && hours == 0)
            {
                timer1.Stop();
                MessageBox.Show("Time is up.");
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_next_Click(object sender, EventArgs e)
        {
            if (CheckFields())
            {
                string answer;
                string title;
                if (CheckAnswer())
                {
                    сorrect++;
                    answer = "Congratulation!";
                    title = "Correct !!!";
                }
                else
                {
                    answer = "Correct answer is " + correctAnswer;
                    title = "Wrong !!!";
                }

                if (isOpen)
                {
                    MessageBox.Show(answer, title);
                }

                if (questionList.Count == 0)
                {
                    //* TODO: add method for the statistic

                    int percent = (int)Math.Round((double)(100 * сorrect) / quantity);
                    MessageBox.Show("There is(are) " + сorrect.ToString() + " correct answer(s) from " + quantity + " questions. It`s a " + percent + "%","The test is finished!");
                    Close();
                }
                else
                {
                    DisplayQuestion();
                }
            }
            else
            {
                MessageBox.Show("Please select the answer!");
            }
        }

        private bool CheckFields()
        {
            bool filled = false;
            if (txt_answer.Visible)
            {
                if (txt_answer.Text != string.Empty)
                    filled = true;
            }
            else
            {
                if (rbn_firstAnswer.Checked || rbn_secondAnswer.Checked || rbn_thirdAnswer.Checked || rbn_fourthAnswer.Checked)
                    filled = true;
            }
            return filled; 
        }

        private bool CheckAnswer()
        {
            bool correct = false;
            var checkedAnswer = this.Controls.OfType<RadioButton>().FirstOrDefault(r => r.Checked);

            if (txt_answer.Visible)
            {
                if (txt_answer.Text == correctAnswer)
                    correct = true;
            }
            else
            {
                if (checkedAnswer.Text == correctAnswer)
                    correct = true;
            }

            return correct;
        }
    }
}
