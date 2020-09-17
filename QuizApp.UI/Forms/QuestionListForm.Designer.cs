namespace QuizApp.UI.Forms
{
    partial class QuestionListForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.lv_questionList = new System.Windows.Forms.ListView();
            this.ch_questionName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_answer1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_answer2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_asnwer3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_asnwer4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_addNew = new System.Windows.Forms.Button();
            this.btn_editQuestion = new System.Windows.Forms.Button();
            this.btn_close = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(153, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(104, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Questions for";
            // 
            // lv_questionList
            // 
            this.lv_questionList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_questionName,
            this.ch_answer1,
            this.ch_answer2,
            this.ch_asnwer3,
            this.ch_asnwer4});
            this.lv_questionList.GridLines = true;
            this.lv_questionList.HideSelection = false;
            this.lv_questionList.Location = new System.Drawing.Point(28, 82);
            this.lv_questionList.MultiSelect = false;
            this.lv_questionList.Name = "lv_questionList";
            this.lv_questionList.Size = new System.Drawing.Size(807, 301);
            this.lv_questionList.TabIndex = 1;
            this.lv_questionList.UseCompatibleStateImageBehavior = false;
            this.lv_questionList.View = System.Windows.Forms.View.Details;
            // 
            // ch_questionName
            // 
            this.ch_questionName.Text = "Questions";
            this.ch_questionName.Width = 200;
            // 
            // ch_answer1
            // 
            this.ch_answer1.Text = "Answer1";
            this.ch_answer1.Width = 150;
            // 
            // ch_answer2
            // 
            this.ch_answer2.Text = "Answer2";
            this.ch_answer2.Width = 150;
            // 
            // ch_asnwer3
            // 
            this.ch_asnwer3.Text = "Answer3";
            this.ch_asnwer3.Width = 150;
            // 
            // ch_asnwer4
            // 
            this.ch_asnwer4.Text = "Answer4";
            this.ch_asnwer4.Width = 150;
            // 
            // btn_addNew
            // 
            this.btn_addNew.Location = new System.Drawing.Point(516, 434);
            this.btn_addNew.Name = "btn_addNew";
            this.btn_addNew.Size = new System.Drawing.Size(87, 30);
            this.btn_addNew.TabIndex = 2;
            this.btn_addNew.Text = "Add New";
            this.btn_addNew.UseVisualStyleBackColor = true;
            this.btn_addNew.Click += new System.EventHandler(this.btn_addNew_Click);
            // 
            // btn_editQuestion
            // 
            this.btn_editQuestion.Location = new System.Drawing.Point(632, 434);
            this.btn_editQuestion.Name = "btn_editQuestion";
            this.btn_editQuestion.Size = new System.Drawing.Size(87, 30);
            this.btn_editQuestion.TabIndex = 3;
            this.btn_editQuestion.Text = "Edit";
            this.btn_editQuestion.UseVisualStyleBackColor = true;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(38, 434);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(87, 30);
            this.btn_close.TabIndex = 4;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // QuestionListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(865, 494);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_editQuestion);
            this.Controls.Add(this.btn_addNew);
            this.Controls.Add(this.lv_questionList);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "QuestionListForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Questions";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_questionList;
        private System.Windows.Forms.ColumnHeader ch_questionName;
        private System.Windows.Forms.ColumnHeader ch_answer1;
        private System.Windows.Forms.ColumnHeader ch_answer2;
        private System.Windows.Forms.ColumnHeader ch_asnwer3;
        private System.Windows.Forms.ColumnHeader ch_asnwer4;
        private System.Windows.Forms.Button btn_addNew;
        private System.Windows.Forms.Button btn_editQuestion;
        private System.Windows.Forms.Button btn_close;
    }
}