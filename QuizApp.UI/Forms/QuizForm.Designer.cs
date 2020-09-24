namespace QuizApp.UI.Forms
{
    partial class QuizForm
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btn_next = new System.Windows.Forms.Button();
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_minute = new System.Windows.Forms.Label();
            this.lbl_second = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txt_questionName = new System.Windows.Forms.TextBox();
            this.rbn_firstAnswer = new System.Windows.Forms.RadioButton();
            this.rbn_secondAnswer = new System.Windows.Forms.RadioButton();
            this.rbn_thirdAnswer = new System.Windows.Forms.RadioButton();
            this.rbn_fourthAnswer = new System.Windows.Forms.RadioButton();
            this.txt_answer = new System.Windows.Forms.TextBox();
            this.lbl_min = new System.Windows.Forms.Label();
            this.lbl_sec = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(288, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "label1";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(101, 221);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(16, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "1.";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(101, 324);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(16, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "2.";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(373, 221);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "3.";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(373, 324);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(16, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "4.";
            // 
            // btn_next
            // 
            this.btn_next.Location = new System.Drawing.Point(497, 395);
            this.btn_next.Name = "btn_next";
            this.btn_next.Size = new System.Drawing.Size(84, 37);
            this.btn_next.TabIndex = 14;
            this.btn_next.Text = "Next";
            this.btn_next.UseVisualStyleBackColor = true;
            this.btn_next.Click += new System.EventHandler(this.btn_next_Click);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(383, 395);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(84, 37);
            this.btn_exit.TabIndex = 15;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_minute
            // 
            this.lbl_minute.AutoSize = true;
            this.lbl_minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_minute.Location = new System.Drawing.Point(543, 18);
            this.lbl_minute.Name = "lbl_minute";
            this.lbl_minute.Size = new System.Drawing.Size(17, 17);
            this.lbl_minute.TabIndex = 17;
            this.lbl_minute.Text = "0";
            // 
            // lbl_second
            // 
            this.lbl_second.AutoSize = true;
            this.lbl_second.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_second.Location = new System.Drawing.Point(591, 18);
            this.lbl_second.Name = "lbl_second";
            this.lbl_second.Size = new System.Drawing.Size(17, 17);
            this.lbl_second.TabIndex = 18;
            this.lbl_second.Text = "0";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // txt_questionName
            // 
            this.txt_questionName.Location = new System.Drawing.Point(81, 74);
            this.txt_questionName.Multiline = true;
            this.txt_questionName.Name = "txt_questionName";
            this.txt_questionName.ReadOnly = true;
            this.txt_questionName.Size = new System.Drawing.Size(521, 85);
            this.txt_questionName.TabIndex = 19;
            // 
            // rbn_firstAnswer
            // 
            this.rbn_firstAnswer.AutoSize = true;
            this.rbn_firstAnswer.Location = new System.Drawing.Point(125, 221);
            this.rbn_firstAnswer.Name = "rbn_firstAnswer";
            this.rbn_firstAnswer.Size = new System.Drawing.Size(14, 13);
            this.rbn_firstAnswer.TabIndex = 21;
            this.rbn_firstAnswer.TabStop = true;
            this.rbn_firstAnswer.UseVisualStyleBackColor = true;
            // 
            // rbn_secondAnswer
            // 
            this.rbn_secondAnswer.AutoSize = true;
            this.rbn_secondAnswer.Location = new System.Drawing.Point(125, 324);
            this.rbn_secondAnswer.Name = "rbn_secondAnswer";
            this.rbn_secondAnswer.Size = new System.Drawing.Size(14, 13);
            this.rbn_secondAnswer.TabIndex = 22;
            this.rbn_secondAnswer.TabStop = true;
            this.rbn_secondAnswer.UseVisualStyleBackColor = true;
            // 
            // rbn_thirdAnswer
            // 
            this.rbn_thirdAnswer.AutoSize = true;
            this.rbn_thirdAnswer.Location = new System.Drawing.Point(397, 221);
            this.rbn_thirdAnswer.Name = "rbn_thirdAnswer";
            this.rbn_thirdAnswer.Size = new System.Drawing.Size(14, 13);
            this.rbn_thirdAnswer.TabIndex = 23;
            this.rbn_thirdAnswer.TabStop = true;
            this.rbn_thirdAnswer.UseVisualStyleBackColor = true;
            // 
            // rbn_fourthAnswer
            // 
            this.rbn_fourthAnswer.AutoSize = true;
            this.rbn_fourthAnswer.Location = new System.Drawing.Point(397, 324);
            this.rbn_fourthAnswer.Name = "rbn_fourthAnswer";
            this.rbn_fourthAnswer.Size = new System.Drawing.Size(14, 13);
            this.rbn_fourthAnswer.TabIndex = 24;
            this.rbn_fourthAnswer.TabStop = true;
            this.rbn_fourthAnswer.UseVisualStyleBackColor = true;
            // 
            // txt_answer
            // 
            this.txt_answer.Location = new System.Drawing.Point(81, 237);
            this.txt_answer.Multiline = true;
            this.txt_answer.Name = "txt_answer";
            this.txt_answer.Size = new System.Drawing.Size(527, 79);
            this.txt_answer.TabIndex = 25;
            this.txt_answer.Visible = false;
            // 
            // lbl_min
            // 
            this.lbl_min.AutoSize = true;
            this.lbl_min.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_min.Location = new System.Drawing.Point(566, 18);
            this.lbl_min.Name = "lbl_min";
            this.lbl_min.Size = new System.Drawing.Size(28, 15);
            this.lbl_min.TabIndex = 26;
            this.lbl_min.Text = "min";
            // 
            // lbl_sec
            // 
            this.lbl_sec.AutoSize = true;
            this.lbl_sec.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sec.Location = new System.Drawing.Point(614, 18);
            this.lbl_sec.Name = "lbl_sec";
            this.lbl_sec.Size = new System.Drawing.Size(26, 15);
            this.lbl_sec.TabIndex = 27;
            this.lbl_sec.Text = "sec";
            // 
            // QuizForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 466);
            this.Controls.Add(this.lbl_sec);
            this.Controls.Add(this.lbl_min);
            this.Controls.Add(this.txt_answer);
            this.Controls.Add(this.rbn_fourthAnswer);
            this.Controls.Add(this.rbn_thirdAnswer);
            this.Controls.Add(this.rbn_secondAnswer);
            this.Controls.Add(this.rbn_firstAnswer);
            this.Controls.Add(this.txt_questionName);
            this.Controls.Add(this.lbl_second);
            this.Controls.Add(this.lbl_minute);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.btn_next);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QuizForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quiz";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btn_next;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_minute;
        private System.Windows.Forms.Label lbl_second;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txt_questionName;
        private System.Windows.Forms.RadioButton rbn_firstAnswer;
        private System.Windows.Forms.RadioButton rbn_secondAnswer;
        private System.Windows.Forms.RadioButton rbn_thirdAnswer;
        private System.Windows.Forms.RadioButton rbn_fourthAnswer;
        private System.Windows.Forms.TextBox txt_answer;
        private System.Windows.Forms.Label lbl_min;
        private System.Windows.Forms.Label lbl_sec;
    }
}