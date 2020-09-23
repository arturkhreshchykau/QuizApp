using QuizApp.Logic;
using QuizApp.UI.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuizApp.UI
{
    public partial class StartForm : Form
    {
        public StartForm(string Name)
        {
            InitializeComponent();
            lbl_welcome.Text += " " + Name + " !!!";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.Hide();
                MainForm mainForm = new MainForm();
                mainForm.Closed += (s, args) => this.Close();
                mainForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
