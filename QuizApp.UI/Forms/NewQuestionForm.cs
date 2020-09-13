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
        public NewQuestionForm()
        {
            InitializeComponent();
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
    }
}
