namespace QuizApp.UI.Forms
{
    partial class TestResultForm
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
            this.lv_testResult = new System.Windows.Forms.ListView();
            this.ch_question = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_answer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_userName = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            this.btn_ok = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lv_testResult
            // 
            this.lv_testResult.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_question,
            this.ch_answer});
            this.lv_testResult.GridLines = true;
            this.lv_testResult.HideSelection = false;
            this.lv_testResult.Location = new System.Drawing.Point(48, 82);
            this.lv_testResult.Name = "lv_testResult";
            this.lv_testResult.Size = new System.Drawing.Size(505, 215);
            this.lv_testResult.TabIndex = 0;
            this.lv_testResult.UseCompatibleStateImageBehavior = false;
            this.lv_testResult.View = System.Windows.Forms.View.Details;
            // 
            // ch_question
            // 
            this.ch_question.Text = "Question";
            this.ch_question.Width = 250;
            // 
            // ch_answer
            // 
            this.ch_answer.Text = "Correct Answers";
            this.ch_answer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.ch_answer.Width = 250;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(257, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 22);
            this.label1.TabIndex = 1;
            this.label1.Text = "Answers";
            // 
            // lbl_userName
            // 
            this.lbl_userName.AutoSize = true;
            this.lbl_userName.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userName.Location = new System.Drawing.Point(186, 332);
            this.lbl_userName.Name = "lbl_userName";
            this.lbl_userName.Size = new System.Drawing.Size(0, 22);
            this.lbl_userName.TabIndex = 2;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.Location = new System.Drawing.Point(209, 332);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(127, 22);
            this.lbl_result.TabIndex = 3;
            this.lbl_result.Text = ", your result is ";
            // 
            // btn_ok
            // 
            this.btn_ok.Location = new System.Drawing.Point(231, 386);
            this.btn_ok.Name = "btn_ok";
            this.btn_ok.Size = new System.Drawing.Size(86, 34);
            this.btn_ok.TabIndex = 4;
            this.btn_ok.Text = "Ok";
            this.btn_ok.UseVisualStyleBackColor = true;
            this.btn_ok.Click += new System.EventHandler(this.btn_ok_Click);
            // 
            // TestResultForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 453);
            this.Controls.Add(this.btn_ok);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_userName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lv_testResult);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "TestResultForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Result";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lv_testResult;
        private System.Windows.Forms.ColumnHeader ch_question;
        private System.Windows.Forms.ColumnHeader ch_answer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_userName;
        private System.Windows.Forms.Label lbl_result;
        private System.Windows.Forms.Button btn_ok;
    }
}