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
    public partial class AuthenticationForm : Form
    {
        public AuthenticationForm()
        {
            InitializeComponent();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void lbl_creatNewAccount_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                this.Hide();
                NewAccountForm newAccount = new NewAccountForm();
                newAccount.authentication = this;
                newAccount.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            try
            {
                Account account = new Account()
                {
                    UserName = txt_name.Text,
                    UserPassword = txt_password.Text
                };

                if (txt_name.Text != "" && txt_password.Text != "" && LogicHelper.Login(account))
                {
                    this.Hide();
                    StartForm startForm = new StartForm();
                    startForm.Closed += (s, args) => this.Close();
                    startForm.Show();
                }
                else
                {
                    txt_name.Text = "";
                    txt_password.Text = "";
                    MessageBox.Show("Invalid name or password.", "Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, ex.GetType().ToString());
            }
        }
    }
}
