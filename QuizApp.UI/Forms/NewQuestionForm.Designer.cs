namespace QuizApp.UI.Forms
{
    partial class NewQuestionForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_question = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_correctAnswer = new System.Windows.Forms.TextBox();
            this.txt_secondAnswer = new System.Windows.Forms.TextBox();
            this.txt_thirdAnswer = new System.Windows.Forms.TextBox();
            this.txt_fourthAnswer = new System.Windows.Forms.TextBox();
            this.lbl_correctAnswer = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_save = new System.Windows.Forms.Button();
            this.lbl_labelAnswer = new System.Windows.Forms.Label();
            this.rbtn_yes = new System.Windows.Forms.RadioButton();
            this.rbtn_no = new System.Windows.Forms.RadioButton();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_question
            // 
            this.txt_question.Location = new System.Drawing.Point(36, 84);
            this.txt_question.Multiline = true;
            this.txt_question.Name = "txt_question";
            this.txt_question.Size = new System.Drawing.Size(374, 78);
            this.txt_question.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Question:";
            // 
            // txt_correctAnswer
            // 
            this.txt_correctAnswer.Location = new System.Drawing.Point(153, 220);
            this.txt_correctAnswer.Name = "txt_correctAnswer";
            this.txt_correctAnswer.Size = new System.Drawing.Size(225, 20);
            this.txt_correctAnswer.TabIndex = 2;
            // 
            // txt_secondAnswer
            // 
            this.txt_secondAnswer.Location = new System.Drawing.Point(153, 263);
            this.txt_secondAnswer.Name = "txt_secondAnswer";
            this.txt_secondAnswer.Size = new System.Drawing.Size(225, 20);
            this.txt_secondAnswer.TabIndex = 3;
            // 
            // txt_thirdAnswer
            // 
            this.txt_thirdAnswer.Location = new System.Drawing.Point(153, 306);
            this.txt_thirdAnswer.Name = "txt_thirdAnswer";
            this.txt_thirdAnswer.Size = new System.Drawing.Size(225, 20);
            this.txt_thirdAnswer.TabIndex = 4;
            // 
            // txt_fourthAnswer
            // 
            this.txt_fourthAnswer.Location = new System.Drawing.Point(153, 349);
            this.txt_fourthAnswer.Name = "txt_fourthAnswer";
            this.txt_fourthAnswer.Size = new System.Drawing.Size(225, 20);
            this.txt_fourthAnswer.TabIndex = 5;
            // 
            // lbl_correctAnswer
            // 
            this.lbl_correctAnswer.AutoSize = true;
            this.lbl_correctAnswer.Location = new System.Drawing.Point(66, 224);
            this.lbl_correctAnswer.Name = "lbl_correctAnswer";
            this.lbl_correctAnswer.Size = new System.Drawing.Size(81, 13);
            this.lbl_correctAnswer.TabIndex = 6;
            this.lbl_correctAnswer.Text = "Correct answer:";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(191, 403);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(99, 36);
            this.btn_cancel.TabIndex = 8;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_save
            // 
            this.btn_save.Location = new System.Drawing.Point(311, 403);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(99, 36);
            this.btn_save.TabIndex = 9;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = true;
            // 
            // lbl_labelAnswer
            // 
            this.lbl_labelAnswer.AutoSize = true;
            this.lbl_labelAnswer.Location = new System.Drawing.Point(35, 184);
            this.lbl_labelAnswer.Name = "lbl_labelAnswer";
            this.lbl_labelAnswer.Size = new System.Drawing.Size(50, 13);
            this.lbl_labelAnswer.TabIndex = 10;
            this.lbl_labelAnswer.Text = "Answers:";
            // 
            // rbtn_yes
            // 
            this.rbtn_yes.AutoSize = true;
            this.rbtn_yes.Location = new System.Drawing.Point(104, 21);
            this.rbtn_yes.Name = "rbtn_yes";
            this.rbtn_yes.Size = new System.Drawing.Size(43, 17);
            this.rbtn_yes.TabIndex = 11;
            this.rbtn_yes.TabStop = true;
            this.rbtn_yes.Text = "Yes";
            this.rbtn_yes.UseVisualStyleBackColor = true;
            this.rbtn_yes.CheckedChanged += new System.EventHandler(this.rbtn_yes_CheckedChanged);
            // 
            // rbtn_no
            // 
            this.rbtn_no.AutoSize = true;
            this.rbtn_no.Checked = true;
            this.rbtn_no.Location = new System.Drawing.Point(153, 21);
            this.rbtn_no.Name = "rbtn_no";
            this.rbtn_no.Size = new System.Drawing.Size(39, 17);
            this.rbtn_no.TabIndex = 12;
            this.rbtn_no.TabStop = true;
            this.rbtn_no.Text = "No";
            this.rbtn_no.UseVisualStyleBackColor = true;
            this.rbtn_no.CheckedChanged += new System.EventHandler(this.rbtn_no_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Is Open? :";
            // 
            // NewQuestionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(447, 467);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.rbtn_no);
            this.Controls.Add(this.rbtn_yes);
            this.Controls.Add(this.lbl_labelAnswer);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.lbl_correctAnswer);
            this.Controls.Add(this.txt_fourthAnswer);
            this.Controls.Add(this.txt_thirdAnswer);
            this.Controls.Add(this.txt_secondAnswer);
            this.Controls.Add(this.txt_correctAnswer);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_question);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewQuestionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions & Answers";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_question;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_correctAnswer;
        private System.Windows.Forms.TextBox txt_secondAnswer;
        private System.Windows.Forms.TextBox txt_thirdAnswer;
        private System.Windows.Forms.TextBox txt_fourthAnswer;
        private System.Windows.Forms.Label lbl_correctAnswer;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Label lbl_labelAnswer;
        private System.Windows.Forms.RadioButton rbtn_yes;
        private System.Windows.Forms.RadioButton rbtn_no;
        private System.Windows.Forms.Label label2;
    }
}