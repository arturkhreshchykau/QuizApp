namespace QuizApp.UI.Forms
{
    partial class NewTestForm
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
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_testName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.btn_createTest = new System.Windows.Forms.Button();
            this.lbl_category = new System.Windows.Forms.Label();
            this.lbl_subCategory = new System.Windows.Forms.Label();
            this.lbl_topic = new System.Windows.Forms.Label();
            this.cbo_category = new System.Windows.Forms.ComboBox();
            this.cbo_subcategory = new System.Windows.Forms.ComboBox();
            this.cbo_topic = new System.Windows.Forms.ComboBox();
            this.lbl_timer = new System.Windows.Forms.Label();
            this.txt_timer = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.rbtn_yes = new System.Windows.Forms.RadioButton();
            this.rbtn_no = new System.Windows.Forms.RadioButton();
            this.label8 = new System.Windows.Forms.Label();
            this.lbl_addCategory = new System.Windows.Forms.LinkLabel();
            this.label10 = new System.Windows.Forms.Label();
            this.lbl_deleteCategory = new System.Windows.Forms.LinkLabel();
            this.lbl_deleteSubCategory = new System.Windows.Forms.LinkLabel();
            this.label11 = new System.Windows.Forms.Label();
            this.lbl_addSubCategory = new System.Windows.Forms.LinkLabel();
            this.lbl_deleteTopic = new System.Windows.Forms.LinkLabel();
            this.label12 = new System.Windows.Forms.Label();
            this.lbl_addTopic = new System.Windows.Forms.LinkLabel();
            this.SuspendLayout();
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.Location = new System.Drawing.Point(39, 73);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(38, 13);
            this.lbl_name.TabIndex = 0;
            this.lbl_name.Text = "Name:";
            // 
            // txt_testName
            // 
            this.txt_testName.Location = new System.Drawing.Point(131, 70);
            this.txt_testName.Name = "txt_testName";
            this.txt_testName.Size = new System.Drawing.Size(100, 20);
            this.txt_testName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(140, 20);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 22);
            this.label2.TabIndex = 2;
            this.label2.Text = "New Test";
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(153, 341);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(79, 31);
            this.btn_cancel.TabIndex = 3;
            this.btn_cancel.Text = "Cancel";
            this.btn_cancel.UseVisualStyleBackColor = true;
            this.btn_cancel.Click += new System.EventHandler(this.btn_cancel_Click);
            // 
            // btn_createTest
            // 
            this.btn_createTest.Location = new System.Drawing.Point(249, 341);
            this.btn_createTest.Name = "btn_createTest";
            this.btn_createTest.Size = new System.Drawing.Size(81, 31);
            this.btn_createTest.TabIndex = 4;
            this.btn_createTest.Text = "Create";
            this.btn_createTest.UseVisualStyleBackColor = true;
            this.btn_createTest.Click += new System.EventHandler(this.btn_createTest_Click);
            // 
            // lbl_category
            // 
            this.lbl_category.AutoSize = true;
            this.lbl_category.Location = new System.Drawing.Point(39, 114);
            this.lbl_category.Name = "lbl_category";
            this.lbl_category.Size = new System.Drawing.Size(52, 13);
            this.lbl_category.TabIndex = 5;
            this.lbl_category.Text = "Category:";
            // 
            // lbl_subCategory
            // 
            this.lbl_subCategory.AutoSize = true;
            this.lbl_subCategory.Location = new System.Drawing.Point(39, 155);
            this.lbl_subCategory.Name = "lbl_subCategory";
            this.lbl_subCategory.Size = new System.Drawing.Size(71, 13);
            this.lbl_subCategory.TabIndex = 6;
            this.lbl_subCategory.Text = "SubCategory:";
            // 
            // lbl_topic
            // 
            this.lbl_topic.AutoSize = true;
            this.lbl_topic.Location = new System.Drawing.Point(39, 196);
            this.lbl_topic.Name = "lbl_topic";
            this.lbl_topic.Size = new System.Drawing.Size(37, 13);
            this.lbl_topic.TabIndex = 7;
            this.lbl_topic.Text = "Topic:";
            // 
            // cbo_category
            // 
            this.cbo_category.FormattingEnabled = true;
            this.cbo_category.Location = new System.Drawing.Point(131, 111);
            this.cbo_category.Name = "cbo_category";
            this.cbo_category.Size = new System.Drawing.Size(121, 21);
            this.cbo_category.TabIndex = 8;
            this.cbo_category.SelectedIndexChanged += new System.EventHandler(this.cbo_category_SelectedIndexChanged);
            // 
            // cbo_subcategory
            // 
            this.cbo_subcategory.FormattingEnabled = true;
            this.cbo_subcategory.Location = new System.Drawing.Point(131, 152);
            this.cbo_subcategory.Name = "cbo_subcategory";
            this.cbo_subcategory.Size = new System.Drawing.Size(121, 21);
            this.cbo_subcategory.TabIndex = 9;
            this.cbo_subcategory.SelectedIndexChanged += new System.EventHandler(this.cbo_subcategory_SelectedIndexChanged);
            // 
            // cbo_topic
            // 
            this.cbo_topic.FormattingEnabled = true;
            this.cbo_topic.Location = new System.Drawing.Point(131, 193);
            this.cbo_topic.Name = "cbo_topic";
            this.cbo_topic.Size = new System.Drawing.Size(121, 21);
            this.cbo_topic.TabIndex = 10;
            // 
            // lbl_timer
            // 
            this.lbl_timer.AutoSize = true;
            this.lbl_timer.Location = new System.Drawing.Point(39, 242);
            this.lbl_timer.Name = "lbl_timer";
            this.lbl_timer.Size = new System.Drawing.Size(36, 13);
            this.lbl_timer.TabIndex = 11;
            this.lbl_timer.Text = "Timer:";
            // 
            // txt_timer
            // 
            this.txt_timer.Location = new System.Drawing.Point(131, 239);
            this.txt_timer.Name = "txt_timer";
            this.txt_timer.Size = new System.Drawing.Size(40, 20);
            this.txt_timer.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(21, 285);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Check questions after the test?";
            // 
            // rbtn_yes
            // 
            this.rbtn_yes.AutoSize = true;
            this.rbtn_yes.Checked = true;
            this.rbtn_yes.Location = new System.Drawing.Point(183, 285);
            this.rbtn_yes.Name = "rbtn_yes";
            this.rbtn_yes.Size = new System.Drawing.Size(43, 17);
            this.rbtn_yes.TabIndex = 14;
            this.rbtn_yes.TabStop = true;
            this.rbtn_yes.Text = "Yes";
            this.rbtn_yes.UseVisualStyleBackColor = true;
            // 
            // rbtn_no
            // 
            this.rbtn_no.AutoSize = true;
            this.rbtn_no.Location = new System.Drawing.Point(232, 285);
            this.rbtn_no.Name = "rbtn_no";
            this.rbtn_no.Size = new System.Drawing.Size(39, 17);
            this.rbtn_no.TabIndex = 15;
            this.rbtn_no.TabStop = true;
            this.rbtn_no.Text = "No";
            this.rbtn_no.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(178, 246);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(43, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "minutes";
            // 
            // lbl_addCategory
            // 
            this.lbl_addCategory.AutoSize = true;
            this.lbl_addCategory.Location = new System.Drawing.Point(276, 114);
            this.lbl_addCategory.Name = "lbl_addCategory";
            this.lbl_addCategory.Size = new System.Drawing.Size(25, 13);
            this.lbl_addCategory.TabIndex = 22;
            this.lbl_addCategory.TabStop = true;
            this.lbl_addCategory.Text = "add";
            this.lbl_addCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_addCategory_LinkClicked);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(298, 114);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(12, 13);
            this.label10.TabIndex = 25;
            this.label10.Text = "/";
            // 
            // lbl_deleteCategory
            // 
            this.lbl_deleteCategory.AutoSize = true;
            this.lbl_deleteCategory.Location = new System.Drawing.Point(307, 114);
            this.lbl_deleteCategory.Name = "lbl_deleteCategory";
            this.lbl_deleteCategory.Size = new System.Drawing.Size(36, 13);
            this.lbl_deleteCategory.TabIndex = 26;
            this.lbl_deleteCategory.TabStop = true;
            this.lbl_deleteCategory.Text = "delete";
            this.lbl_deleteCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_deleteCategory_LinkClicked);
            // 
            // lbl_deleteSubCategory
            // 
            this.lbl_deleteSubCategory.AutoSize = true;
            this.lbl_deleteSubCategory.Location = new System.Drawing.Point(307, 155);
            this.lbl_deleteSubCategory.Name = "lbl_deleteSubCategory";
            this.lbl_deleteSubCategory.Size = new System.Drawing.Size(36, 13);
            this.lbl_deleteSubCategory.TabIndex = 29;
            this.lbl_deleteSubCategory.TabStop = true;
            this.lbl_deleteSubCategory.Text = "delete";
            this.lbl_deleteSubCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_deleteSubCategory_LinkClicked);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(298, 155);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(12, 13);
            this.label11.TabIndex = 28;
            this.label11.Text = "/";
            // 
            // lbl_addSubCategory
            // 
            this.lbl_addSubCategory.AutoSize = true;
            this.lbl_addSubCategory.Location = new System.Drawing.Point(276, 155);
            this.lbl_addSubCategory.Name = "lbl_addSubCategory";
            this.lbl_addSubCategory.Size = new System.Drawing.Size(25, 13);
            this.lbl_addSubCategory.TabIndex = 27;
            this.lbl_addSubCategory.TabStop = true;
            this.lbl_addSubCategory.Text = "add";
            this.lbl_addSubCategory.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_addSubCategory_LinkClicked);
            // 
            // lbl_deleteTopic
            // 
            this.lbl_deleteTopic.AutoSize = true;
            this.lbl_deleteTopic.Location = new System.Drawing.Point(307, 196);
            this.lbl_deleteTopic.Name = "lbl_deleteTopic";
            this.lbl_deleteTopic.Size = new System.Drawing.Size(36, 13);
            this.lbl_deleteTopic.TabIndex = 32;
            this.lbl_deleteTopic.TabStop = true;
            this.lbl_deleteTopic.Text = "delete";
            this.lbl_deleteTopic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_deleteTopic_LinkClicked);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(298, 196);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(12, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "/";
            // 
            // lbl_addTopic
            // 
            this.lbl_addTopic.AutoSize = true;
            this.lbl_addTopic.Location = new System.Drawing.Point(276, 196);
            this.lbl_addTopic.Name = "lbl_addTopic";
            this.lbl_addTopic.Size = new System.Drawing.Size(25, 13);
            this.lbl_addTopic.TabIndex = 30;
            this.lbl_addTopic.TabStop = true;
            this.lbl_addTopic.Text = "add";
            this.lbl_addTopic.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lbl_addTopic_LinkClicked);
            // 
            // NewTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(379, 397);
            this.Controls.Add(this.lbl_deleteTopic);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbl_addTopic);
            this.Controls.Add(this.lbl_deleteSubCategory);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.lbl_addSubCategory);
            this.Controls.Add(this.lbl_deleteCategory);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lbl_addCategory);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.rbtn_no);
            this.Controls.Add(this.rbtn_yes);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_timer);
            this.Controls.Add(this.lbl_timer);
            this.Controls.Add(this.cbo_topic);
            this.Controls.Add(this.cbo_subcategory);
            this.Controls.Add(this.cbo_category);
            this.Controls.Add(this.lbl_topic);
            this.Controls.Add(this.lbl_subCategory);
            this.Controls.Add(this.lbl_category);
            this.Controls.Add(this.btn_createTest);
            this.Controls.Add(this.btn_cancel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_testName);
            this.Controls.Add(this.lbl_name);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "NewTestForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "New Test";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_cancel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.LinkLabel lbl_addCategory;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.LinkLabel lbl_deleteCategory;
        private System.Windows.Forms.LinkLabel lbl_deleteSubCategory;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.LinkLabel lbl_addSubCategory;
        private System.Windows.Forms.LinkLabel lbl_deleteTopic;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.LinkLabel lbl_addTopic;
        public System.Windows.Forms.TextBox txt_testName;
        public System.Windows.Forms.ComboBox cbo_category;
        public System.Windows.Forms.ComboBox cbo_subcategory;
        public System.Windows.Forms.ComboBox cbo_topic;
        public System.Windows.Forms.TextBox txt_timer;
        public System.Windows.Forms.RadioButton rbtn_yes;
        public System.Windows.Forms.RadioButton rbtn_no;
        public System.Windows.Forms.Label lbl_name;
        public System.Windows.Forms.Label lbl_category;
        public System.Windows.Forms.Label lbl_subCategory;
        public System.Windows.Forms.Label lbl_topic;
        public System.Windows.Forms.Label lbl_timer;
        public System.Windows.Forms.Button btn_createTest;
    }
}