﻿namespace BlueBudget_DB
{
    partial class budget
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
            this.Categories_listbox = new System.Windows.Forms.ListBox();
            this.Back_btn = new System.Windows.Forms.Button();
            this.budget_label = new System.Windows.Forms.Label();
            this.Save_btn = new System.Windows.Forms.Button();
            this.cat_listbox_label = new System.Windows.Forms.Label();
            this.Newsubcategory_btn = new System.Windows.Forms.Button();
            this.Newcategory_btn = new System.Windows.Forms.Button();
            this.Subcategory_textBox = new System.Windows.Forms.TextBox();
            this.Category_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Type_comboBox = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Budgets_listBox = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.StartMonth_comboBox = new System.Windows.Forms.ComboBox();
            this.EndMonth_comboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.StartYear_numericBox = new System.Windows.Forms.NumericUpDown();
            this.EndYear_numericBox = new System.Windows.Forms.NumericUpDown();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.Notifications = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Budget_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.StartYear_numericBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndYear_numericBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Categories_listbox
            // 
            this.Categories_listbox.FormattingEnabled = true;
            this.Categories_listbox.Location = new System.Drawing.Point(30, 82);
            this.Categories_listbox.Margin = new System.Windows.Forms.Padding(2);
            this.Categories_listbox.Name = "Categories_listbox";
            this.Categories_listbox.Size = new System.Drawing.Size(204, 186);
            this.Categories_listbox.TabIndex = 38;
            this.Categories_listbox.SelectedIndexChanged += new System.EventHandler(this.Categories_listbox_SelectedIndexChanged);
            // 
            // Back_btn
            // 
            this.Back_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back_btn.Location = new System.Drawing.Point(571, 397);
            this.Back_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Back_btn.Name = "Back_btn";
            this.Back_btn.Size = new System.Drawing.Size(64, 24);
            this.Back_btn.TabIndex = 37;
            this.Back_btn.Text = "back";
            this.Back_btn.UseVisualStyleBackColor = true;
            this.Back_btn.Click += new System.EventHandler(this.Back_btn_Click);
            // 
            // budget_label
            // 
            this.budget_label.AutoSize = true;
            this.budget_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.budget_label.Location = new System.Drawing.Point(251, 9);
            this.budget_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.budget_label.Name = "budget_label";
            this.budget_label.Size = new System.Drawing.Size(109, 26);
            this.budget_label.TabIndex = 26;
            this.budget_label.Text = "BUDGET";
            // 
            // Save_btn
            // 
            this.Save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Save_btn.Location = new System.Drawing.Point(480, 397);
            this.Save_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Save_btn.Name = "Save_btn";
            this.Save_btn.Size = new System.Drawing.Size(64, 24);
            this.Save_btn.TabIndex = 24;
            this.Save_btn.Text = "save";
            this.Save_btn.UseVisualStyleBackColor = true;
            this.Save_btn.Click += new System.EventHandler(this.Save_btn_Click);
            // 
            // cat_listbox_label
            // 
            this.cat_listbox_label.AutoSize = true;
            this.cat_listbox_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cat_listbox_label.Location = new System.Drawing.Point(27, 67);
            this.cat_listbox_label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.cat_listbox_label.Name = "cat_listbox_label";
            this.cat_listbox_label.Size = new System.Drawing.Size(57, 13);
            this.cat_listbox_label.TabIndex = 39;
            this.cat_listbox_label.Text = "Categories";
            // 
            // Newsubcategory_btn
            // 
            this.Newsubcategory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Newsubcategory_btn.Location = new System.Drawing.Point(134, 272);
            this.Newsubcategory_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Newsubcategory_btn.Name = "Newsubcategory_btn";
            this.Newsubcategory_btn.Size = new System.Drawing.Size(100, 47);
            this.Newsubcategory_btn.TabIndex = 40;
            this.Newsubcategory_btn.Text = "New Sub-category";
            this.Newsubcategory_btn.UseVisualStyleBackColor = true;
            this.Newsubcategory_btn.Click += new System.EventHandler(this.Newsubcategory_btn_Click);
            // 
            // Newcategory_btn
            // 
            this.Newcategory_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Newcategory_btn.Location = new System.Drawing.Point(30, 272);
            this.Newcategory_btn.Margin = new System.Windows.Forms.Padding(2);
            this.Newcategory_btn.Name = "Newcategory_btn";
            this.Newcategory_btn.Size = new System.Drawing.Size(100, 47);
            this.Newcategory_btn.TabIndex = 41;
            this.Newcategory_btn.Text = "New Category";
            this.Newcategory_btn.UseVisualStyleBackColor = true;
            this.Newcategory_btn.Click += new System.EventHandler(this.Newcategory_btn_Click);
            // 
            // Subcategory_textBox
            // 
            this.Subcategory_textBox.Location = new System.Drawing.Point(514, 132);
            this.Subcategory_textBox.Name = "Subcategory_textBox";
            this.Subcategory_textBox.ReadOnly = true;
            this.Subcategory_textBox.Size = new System.Drawing.Size(121, 20);
            this.Subcategory_textBox.TabIndex = 46;
            // 
            // Category_textBox
            // 
            this.Category_textBox.Location = new System.Drawing.Point(514, 86);
            this.Category_textBox.Name = "Category_textBox";
            this.Category_textBox.ReadOnly = true;
            this.Category_textBox.Size = new System.Drawing.Size(121, 20);
            this.Category_textBox.TabIndex = 47;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(459, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 48;
            this.label1.Text = "Category";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(438, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 13);
            this.label2.TabIndex = 49;
            this.label2.Text = "Sub-category";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(467, 263);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Budget";
            // 
            // Type_comboBox
            // 
            this.Type_comboBox.Enabled = false;
            this.Type_comboBox.FormattingEnabled = true;
            this.Type_comboBox.Location = new System.Drawing.Point(514, 175);
            this.Type_comboBox.Name = "Type_comboBox";
            this.Type_comboBox.Size = new System.Drawing.Size(121, 21);
            this.Type_comboBox.TabIndex = 52;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(477, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 53;
            this.label5.Text = "Type";
            // 
            // Budgets_listBox
            // 
            this.Budgets_listBox.FormattingEnabled = true;
            this.Budgets_listBox.Location = new System.Drawing.Point(238, 82);
            this.Budgets_listBox.Margin = new System.Windows.Forms.Padding(2);
            this.Budgets_listBox.Name = "Budgets_listBox";
            this.Budgets_listBox.Size = new System.Drawing.Size(122, 186);
            this.Budgets_listBox.TabIndex = 54;
            this.Budgets_listBox.SelectedIndexChanged += new System.EventHandler(this.Budgets_listBox_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(235, 67);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 13);
            this.label6.TabIndex = 55;
            this.label6.Text = "Budgets";
            // 
            // StartMonth_comboBox
            // 
            this.StartMonth_comboBox.FormattingEnabled = true;
            this.StartMonth_comboBox.Location = new System.Drawing.Point(462, 299);
            this.StartMonth_comboBox.Name = "StartMonth_comboBox";
            this.StartMonth_comboBox.Size = new System.Drawing.Size(81, 21);
            this.StartMonth_comboBox.TabIndex = 56;
            // 
            // EndMonth_comboBox
            // 
            this.EndMonth_comboBox.FormattingEnabled = true;
            this.EndMonth_comboBox.Location = new System.Drawing.Point(462, 326);
            this.EndMonth_comboBox.Name = "EndMonth_comboBox";
            this.EndMonth_comboBox.Size = new System.Drawing.Size(81, 21);
            this.EndMonth_comboBox.TabIndex = 59;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(429, 299);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 60;
            this.label4.Text = "start";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(431, 326);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(25, 13);
            this.label7.TabIndex = 61;
            this.label7.Text = "end";
            // 
            // StartYear_numericBox
            // 
            this.StartYear_numericBox.Location = new System.Drawing.Point(554, 299);
            this.StartYear_numericBox.Name = "StartYear_numericBox";
            this.StartYear_numericBox.Size = new System.Drawing.Size(81, 20);
            this.StartYear_numericBox.TabIndex = 62;
            // 
            // EndYear_numericBox
            // 
            this.EndYear_numericBox.Location = new System.Drawing.Point(554, 326);
            this.EndYear_numericBox.Name = "EndYear_numericBox";
            this.EndYear_numericBox.Size = new System.Drawing.Size(81, 20);
            this.EndYear_numericBox.TabIndex = 63;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(-308, 22);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(204, 77);
            this.richTextBox1.TabIndex = 64;
            this.richTextBox1.Text = "";
            // 
            // Notifications
            // 
            this.Notifications.Location = new System.Drawing.Point(30, 353);
            this.Notifications.Name = "Notifications";
            this.Notifications.Size = new System.Drawing.Size(204, 68);
            this.Notifications.TabIndex = 65;
            this.Notifications.Text = "";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 337);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 13);
            this.label8.TabIndex = 66;
            this.label8.Text = "Notifications";
            // 
            // Budget_textBox
            // 
            this.Budget_textBox.Location = new System.Drawing.Point(514, 263);
            this.Budget_textBox.Name = "Budget_textBox";
            this.Budget_textBox.Size = new System.Drawing.Size(121, 20);
            this.Budget_textBox.TabIndex = 67;
            // 
            // budget
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(673, 433);
            this.Controls.Add(this.Budget_textBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.Notifications);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.EndYear_numericBox);
            this.Controls.Add(this.StartYear_numericBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.EndMonth_comboBox);
            this.Controls.Add(this.StartMonth_comboBox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Budgets_listBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Type_comboBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Category_textBox);
            this.Controls.Add(this.Subcategory_textBox);
            this.Controls.Add(this.Newcategory_btn);
            this.Controls.Add(this.Newsubcategory_btn);
            this.Controls.Add(this.cat_listbox_label);
            this.Controls.Add(this.Categories_listbox);
            this.Controls.Add(this.Back_btn);
            this.Controls.Add(this.budget_label);
            this.Controls.Add(this.Save_btn);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "budget";
            this.Text = "budget";
            this.Load += new System.EventHandler(this.budget_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StartYear_numericBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndYear_numericBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox Categories_listbox;
        private System.Windows.Forms.Button Back_btn;
        private System.Windows.Forms.Label budget_label;
        private System.Windows.Forms.Button Save_btn;
        private System.Windows.Forms.Label cat_listbox_label;
        private System.Windows.Forms.Button Newsubcategory_btn;
        private System.Windows.Forms.Button Newcategory_btn;
        private System.Windows.Forms.TextBox Subcategory_textBox;
        private System.Windows.Forms.TextBox Category_textBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox Type_comboBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox Budgets_listBox;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox StartMonth_comboBox;
        private System.Windows.Forms.ComboBox EndMonth_comboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown StartYear_numericBox;
        private System.Windows.Forms.NumericUpDown EndYear_numericBox;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox Notifications;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox Budget_textBox;
    }
}