namespace QuizApp.UI.Forms
{
    partial class StatisticForm
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
            this.lv_statistic = new System.Windows.Forms.ListView();
            this.ch_name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_testName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_percent = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_date = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lbl_userStatistic = new System.Windows.Forms.LinkLabel();
            this.lbl_categoryStatistic = new System.Windows.Forms.LinkLabel();
            this.btn_exit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(239, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Statistic";
            // 
            // lv_statistic
            // 
            this.lv_statistic.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_name,
            this.ch_testName,
            this.ch_percent,
            this.ch_date});
            this.lv_statistic.FullRowSelect = true;
            this.lv_statistic.GridLines = true;
            this.lv_statistic.HideSelection = false;
            this.lv_statistic.Location = new System.Drawing.Point(41, 129);
            this.lv_statistic.MultiSelect = false;
            this.lv_statistic.Name = "lv_statistic";
            this.lv_statistic.Size = new System.Drawing.Size(516, 255);
            this.lv_statistic.TabIndex = 1;
            this.lv_statistic.UseCompatibleStateImageBehavior = false;
            this.lv_statistic.View = System.Windows.Forms.View.Details;
            // 
            // ch_name
            // 
            this.ch_name.Text = "Name";
            this.ch_name.Width = 150;
            // 
            // ch_testName
            // 
            this.ch_testName.Text = "Test Name";
            this.ch_testName.Width = 150;
            // 
            // ch_percent
            // 
            this.ch_percent.Text = "Percent";
            // 
            // ch_date
            // 
            this.ch_date.Text = "Passed";
            this.ch_date.Width = 150;
            // 
            // lbl_userStatistic
            // 
            this.lbl_userStatistic.AutoSize = true;
            this.lbl_userStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_userStatistic.Location = new System.Drawing.Point(80, 81);
            this.lbl_userStatistic.Name = "lbl_userStatistic";
            this.lbl_userStatistic.Size = new System.Drawing.Size(96, 17);
            this.lbl_userStatistic.TabIndex = 2;
            this.lbl_userStatistic.TabStop = true;
            this.lbl_userStatistic.Text = "User statistics";
            this.lbl_userStatistic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // lbl_categoryStatistic
            // 
            this.lbl_categoryStatistic.AutoSize = true;
            this.lbl_categoryStatistic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_categoryStatistic.Location = new System.Drawing.Point(385, 81);
            this.lbl_categoryStatistic.Name = "lbl_categoryStatistic";
            this.lbl_categoryStatistic.Size = new System.Drawing.Size(123, 17);
            this.lbl_categoryStatistic.TabIndex = 3;
            this.lbl_categoryStatistic.TabStop = true;
            this.lbl_categoryStatistic.Text = "Category statistics";
            this.lbl_categoryStatistic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.LinkClicked);
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(46, 415);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(79, 33);
            this.btn_exit.TabIndex = 4;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // StatisticForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(597, 488);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.lbl_categoryStatistic);
            this.Controls.Add(this.lbl_userStatistic);
            this.Controls.Add(this.lv_statistic);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "StatisticForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Statistic";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListView lv_statistic;
        private System.Windows.Forms.LinkLabel lbl_userStatistic;
        private System.Windows.Forms.LinkLabel lbl_categoryStatistic;
        private System.Windows.Forms.ColumnHeader ch_name;
        private System.Windows.Forms.ColumnHeader ch_testName;
        private System.Windows.Forms.ColumnHeader ch_percent;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.ColumnHeader ch_date;
    }
}