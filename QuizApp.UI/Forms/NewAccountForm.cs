using QuizApp.Logic;
using QuizApp.Logic.Models;
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
    public partial class NewAccountForm : Form
    {
        public Form authentication { get; set; }
        public NewAccountForm()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
            this.authentication.Show();
        }

        private void btn_create_Click(object sender, EventArgs e)
        {
            try
            {
                UserModel userModel = new UserModel()
                {
                    Name = txt_name.Text,
                    Password = txt_password.Text
                };

                UserRepository userHelper = new UserRepository();

                if (!string.IsNullOrEmpty(txt_name.Text) && !string.IsNullOrEmpty(txt_password.Text) && !userHelper.Exist(userModel))
                {
                    userHelper.Add(userModel);
                    this.Close();
                    MessageBox.Show("Created successfully.", "Success!!!");
                    this.authentication.Show();
                }
                else
                {
                    MessageBox.Show("An account with the current name already exists, or some fields are empty.", "Error");
                    txt_name.Text = string.Empty;
                    txt_password.Text = string.Empty;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
