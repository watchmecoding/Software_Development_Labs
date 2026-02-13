using System.Drawing;
using System.Windows.Forms;

namespace Laba9
{
    partial class Form2
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

        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.Cover_textBox = new System.Windows.Forms.TextBox();
            this.Year_textBox = new System.Windows.Forms.TextBox();
            this.Delivery_textBox = new System.Windows.Forms.TextBox();
            this.Cost_textBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.ID_Label = new System.Windows.Forms.Label();
            this.Book_Name_TextBox = new System.Windows.Forms.TextBox();
            this.Author_comboBox = new System.Windows.Forms.ComboBox();
            this.Publisher_comboBox = new System.Windows.Forms.ComboBox();
            this.Genre_comboBox = new System.Windows.Forms.ComboBox();
            this.Supplier_comboBox = new System.Windows.Forms.ComboBox();
            this.Add_Button = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 10;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.tableLayoutPanel1.Controls.Add(this.Cover_textBox, 9, 1);
            this.tableLayoutPanel1.Controls.Add(this.Year_textBox, 8, 1);
            this.tableLayoutPanel1.Controls.Add(this.Delivery_textBox, 7, 1);
            this.tableLayoutPanel1.Controls.Add(this.Cost_textBox, 6, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.label4, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.label5, 4, 0);
            this.tableLayoutPanel1.Controls.Add(this.label6, 5, 0);
            this.tableLayoutPanel1.Controls.Add(this.label7, 6, 0);
            this.tableLayoutPanel1.Controls.Add(this.label8, 7, 0);
            this.tableLayoutPanel1.Controls.Add(this.label9, 8, 0);
            this.tableLayoutPanel1.Controls.Add(this.label10, 9, 0);
            this.tableLayoutPanel1.Controls.Add(this.ID_Label, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.Book_Name_TextBox, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.Author_comboBox, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.Publisher_comboBox, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.Genre_comboBox, 4, 1);
            this.tableLayoutPanel1.Controls.Add(this.Supplier_comboBox, 5, 1);
            this.tableLayoutPanel1.Controls.Add(this.Add_Button, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1300, 82);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // Cover_textBox
            // 
            this.Cover_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cover_textBox.Location = new System.Drawing.Point(1173, 18);
            this.Cover_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cover_textBox.Name = "Cover_textBox";
            this.Cover_textBox.Size = new System.Drawing.Size(124, 22);
            this.Cover_textBox.TabIndex = 19;
            this.Cover_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Year_textBox
            // 
            this.Year_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Year_textBox.Location = new System.Drawing.Point(1043, 18);
            this.Year_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Year_textBox.Name = "Year_textBox";
            this.Year_textBox.Size = new System.Drawing.Size(124, 22);
            this.Year_textBox.TabIndex = 18;
            this.Year_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Delivery_textBox
            // 
            this.Delivery_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Delivery_textBox.Location = new System.Drawing.Point(913, 18);
            this.Delivery_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delivery_textBox.Name = "Delivery_textBox";
            this.Delivery_textBox.Size = new System.Drawing.Size(124, 22);
            this.Delivery_textBox.TabIndex = 17;
            this.Delivery_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Cost_textBox
            // 
            this.Cost_textBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Cost_textBox.Location = new System.Drawing.Point(783, 18);
            this.Cost_textBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Cost_textBox.Name = "Cost_textBox";
            this.Cost_textBox.Size = new System.Drawing.Size(124, 22);
            this.Cost_textBox.TabIndex = 16;
            this.Cost_textBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Book ID";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label2.Location = new System.Drawing.Point(133, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(124, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Book Title";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label3.Location = new System.Drawing.Point(263, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(124, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Author";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label4.Location = new System.Drawing.Point(393, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(124, 16);
            this.label4.TabIndex = 3;
            this.label4.Text = "Publisher";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label5.Location = new System.Drawing.Point(523, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 4;
            this.label5.Text = "Genre";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label6.Location = new System.Drawing.Point(653, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 5;
            this.label6.Text = "Supplier";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label7.Location = new System.Drawing.Point(783, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 16);
            this.label7.TabIndex = 6;
            this.label7.Text = "Cost";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label8.Location = new System.Drawing.Point(913, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(124, 16);
            this.label8.TabIndex = 7;
            this.label8.Text = "Delivery value";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label9.Location = new System.Drawing.Point(1043, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(124, 16);
            this.label9.TabIndex = 8;
            this.label9.Text = "Release year";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Dock = System.Windows.Forms.DockStyle.Fill;
            this.label10.Location = new System.Drawing.Point(1173, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(124, 16);
            this.label10.TabIndex = 9;
            this.label10.Text = "Book cover";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ID_Label
            // 
            this.ID_Label.AutoSize = true;
            this.ID_Label.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ID_Label.Location = new System.Drawing.Point(3, 16);
            this.ID_Label.Name = "ID_Label";
            this.ID_Label.Size = new System.Drawing.Size(124, 28);
            this.ID_Label.TabIndex = 10;
            this.ID_Label.Text = "Insert ID here";
            this.ID_Label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Book_Name_TextBox
            // 
            this.Book_Name_TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Book_Name_TextBox.Location = new System.Drawing.Point(133, 18);
            this.Book_Name_TextBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Book_Name_TextBox.Name = "Book_Name_TextBox";
            this.Book_Name_TextBox.Size = new System.Drawing.Size(124, 22);
            this.Book_Name_TextBox.TabIndex = 11;
            this.Book_Name_TextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Author_comboBox
            // 
            this.Author_comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Author_comboBox.FormattingEnabled = true;
            this.Author_comboBox.Location = new System.Drawing.Point(263, 18);
            this.Author_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Author_comboBox.Name = "Author_comboBox";
            this.Author_comboBox.Size = new System.Drawing.Size(124, 24);
            this.Author_comboBox.TabIndex = 12;
            // 
            // Publisher_comboBox
            // 
            this.Publisher_comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Publisher_comboBox.FormattingEnabled = true;
            this.Publisher_comboBox.Location = new System.Drawing.Point(393, 18);
            this.Publisher_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Publisher_comboBox.Name = "Publisher_comboBox";
            this.Publisher_comboBox.Size = new System.Drawing.Size(124, 24);
            this.Publisher_comboBox.TabIndex = 13;
            // 
            // Genre_comboBox
            // 
            this.Genre_comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Genre_comboBox.FormattingEnabled = true;
            this.Genre_comboBox.Location = new System.Drawing.Point(523, 18);
            this.Genre_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Genre_comboBox.Name = "Genre_comboBox";
            this.Genre_comboBox.Size = new System.Drawing.Size(124, 24);
            this.Genre_comboBox.TabIndex = 14;
            // 
            // Supplier_comboBox
            // 
            this.Supplier_comboBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Supplier_comboBox.FormattingEnabled = true;
            this.Supplier_comboBox.Location = new System.Drawing.Point(653, 18);
            this.Supplier_comboBox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Supplier_comboBox.Name = "Supplier_comboBox";
            this.Supplier_comboBox.Size = new System.Drawing.Size(124, 24);
            this.Supplier_comboBox.TabIndex = 15;
            // 
            // Add_Button
            // 
            this.Add_Button.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Add_Button.Location = new System.Drawing.Point(3, 46);
            this.Add_Button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add_Button.Name = "Add_Button";
            this.Add_Button.Size = new System.Drawing.Size(124, 41);
            this.Add_Button.TabIndex = 20;
            this.Add_Button.Text = "Add";
            this.Add_Button.UseVisualStyleBackColor = true;
            this.Add_Button.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 82);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form2";
            this.Text = "Add book";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Label label9;
        private Label label10;
        private TextBox Cover_textBox;
        private TextBox Year_textBox;
        private TextBox Delivery_textBox;
        private TextBox Cost_textBox;
        private Label ID_Label;
        private TextBox Book_Name_TextBox;
        private ComboBox Author_comboBox;
        private ComboBox Publisher_comboBox;
        private ComboBox Genre_comboBox;
        private ComboBox Supplier_comboBox;
        private Button Add_Button;
    }
}