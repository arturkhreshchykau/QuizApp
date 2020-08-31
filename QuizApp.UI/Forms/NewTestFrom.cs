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
    public partial class NewTestFrom : Form
    {
        public NewTestFrom()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_addQuestion_Click(object sender, EventArgs e)
        {
            try
            {
                if (FormVerification())
                {
                    NewQuestionForm newQuestion = new NewQuestionForm();
                    newQuestion.ShowDialog();
                }
                else
                {
                    MessageBox.Show("Please fill in the required fields", "Error");                        
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private bool FormVerification()
        {
            bool filled = true;
            if (txt_name.Text == "" || (!rbtn_yes.Checked && !rbtn_no.Checked))
                filled = false;
            return filled;
        }
    }
}
