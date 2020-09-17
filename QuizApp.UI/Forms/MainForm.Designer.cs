namespace QuizApp.UI.Forms
{
    partial class MainForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.btn_edit = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.txt_addNew = new System.Windows.Forms.Button();
            this.lv_testList = new System.Windows.Forms.ListView();
            this.ch_testName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_categoryName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_timer = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ch_isLiveCheck = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btn_close = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "The available tests.";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(470, 85);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(103, 37);
            this.button1.TabIndex = 2;
            this.button1.Text = "Pass Test";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(470, 140);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(103, 37);
            this.btn_edit.TabIndex = 3;
            this.btn_edit.Text = "Edit Test";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(470, 197);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(103, 37);
            this.button3.TabIndex = 4;
            this.button3.Text = "Delete Test";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // txt_addNew
            // 
            this.txt_addNew.Location = new System.Drawing.Point(470, 253);
            this.txt_addNew.Name = "txt_addNew";
            this.txt_addNew.Size = new System.Drawing.Size(103, 37);
            this.txt_addNew.TabIndex = 5;
            this.txt_addNew.Text = "Add New Test";
            this.txt_addNew.UseVisualStyleBackColor = true;
            this.txt_addNew.Click += new System.EventHandler(this.txt_addNew_Click);
            // 
            // lv_testList
            // 
            this.lv_testList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ch_testName,
            this.ch_categoryName,
            this.ch_timer,
            this.ch_isLiveCheck});
            this.lv_testList.FullRowSelect = true;
            this.lv_testList.GridLines = true;
            this.lv_testList.HideSelection = false;
            this.lv_testList.Location = new System.Drawing.Point(22, 85);
            this.lv_testList.MultiSelect = false;
            this.lv_testList.Name = "lv_testList";
            this.lv_testList.Size = new System.Drawing.Size(415, 301);
            this.lv_testList.TabIndex = 6;
            this.lv_testList.UseCompatibleStateImageBehavior = false;
            this.lv_testList.View = System.Windows.Forms.View.Details;
            // 
            // ch_testName
            // 
            this.ch_testName.Text = "Name";
            this.ch_testName.Width = 90;
            // 
            // ch_categoryName
            // 
            this.ch_categoryName.Text = "Category/SubCategory/Topic";
            this.ch_categoryName.Width = 160;
            // 
            // ch_timer
            // 
            this.ch_timer.Text = "Timer";
            // 
            // ch_isLiveCheck
            // 
            this.ch_isLiveCheck.Text = "Instantly checking";
            this.ch_isLiveCheck.Width = 100;
            // 
            // btn_close
            // 
            this.btn_close.Location = new System.Drawing.Point(32, 463);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(75, 23);
            this.btn_close.TabIndex = 7;
            this.btn_close.Text = "Close";
            this.btn_close.UseVisualStyleBackColor = true;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(470, 309);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(103, 37);
            this.button2.TabIndex = 8;
            this.button2.Text = "Show Questions";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(604, 508);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.lv_testList);
            this.Controls.Add(this.txt_addNew);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_edit;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button txt_addNew;
        private System.Windows.Forms.ListView lv_testList;
        private System.Windows.Forms.ColumnHeader ch_testName;
        private System.Windows.Forms.ColumnHeader ch_categoryName;
        private System.Windows.Forms.ColumnHeader ch_timer;
        private System.Windows.Forms.ColumnHeader ch_isLiveCheck;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button button2;
    }
}