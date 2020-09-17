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
        public int TestID { get; set; }
        public QuestionListForm()
        {
            InitializeComponent();
            DisplayQuestions();
        }

        private void DisplayQuestions()
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addNew_Click(object sender, EventArgs e)
        {
            try
            {
                NewQuestionForm questionForm = new NewQuestionForm(TestID);
                questionForm.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
