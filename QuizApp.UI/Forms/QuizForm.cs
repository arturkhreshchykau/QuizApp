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
        private readonly List<QuestionModel> _questionList;
        private readonly bool isOpen;
        private int сorrect = 0;
        private string correctAnswer;
        private int quantity;
        private int seconds = 59;
        private readonly int testID;
        private readonly int userID;

        public QuizForm(TestModel testModel, List<QuestionModel> questionList, int userId)
        {
            InitializeComponent();

            this.userID = userId;
            this.testID = testModel.TestID;
            label1.Text = "Test: " + testModel.TestName;
            if (testModel.Timer == null)
            {
                lbl_minute.Visible = false;
                lbl_second.Visible = false;
                lbl_min.Visible = false;
                lbl_sec.Visible = false;
            }
            else
            {
                lbl_minute.Text = ((int)testModel.Timer - 1).ToString();
                lbl_second.Text = "59";
            }

            timer1.Start();

            _questionList = questionList;
            isOpen = testModel.isLiveCheck;
            quantity = _questionList.Count;
            DisplayQuestion();            
        }

        private void DisplayQuestion()
        {
            Random rnd = new Random();
            var index = rnd.Next(_questionList.Count);
            QuestionModel question = _questionList[index];
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

            _questionList.Remove(question);
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
            int min = Convert.ToInt32(lbl_minute.Text);

            seconds--;

            if (seconds == -1)
            {
                min--;
                seconds = 59;
            }

            lbl_minute.Text = min.ToString();
            lbl_second.Text = seconds.ToString();

            if (seconds == 0 && min == 0)
            {
                timer1.Stop();
                int percent = (int)Math.Round((double)(100 * сorrect) / quantity);
                MessageBox.Show("There is(are) " + сorrect.ToString() + " correct answer(s) from " + quantity + " questions. It`s a " + percent + "%", "Time is up.");
                this.Close();
            }
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            timer1.Stop();
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

                if (_questionList.Count == 0)
                {
                    timer1.Stop();

                    StatisticService statisticService = new StatisticService();
                    StatisticModel statisticModel = new StatisticModel()
                    {
                        UserID = userID,
                        TestID = testID,
                        CorrectAnswer = сorrect,
                        QuestionsTotal = quantity,
                        Passed = DateTime.Now
                    };
                    statisticService.Add(statisticModel);

                    DisplayResult();
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

        private void DisplayResult()
        {
            try
            {
                int percent = (int)Math.Round((double)(100 * сorrect) / quantity);
                if (isOpen)
                {
                    MessageBox.Show("There is(are) " + сorrect.ToString() + " correct answer(s) from " + quantity + " questions. It`s a " + percent + "%", "The test is finished!");
                }
                else
                {
                    TestResultForm testResult = new TestResultForm(testID, userID);
                    testResult.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
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
