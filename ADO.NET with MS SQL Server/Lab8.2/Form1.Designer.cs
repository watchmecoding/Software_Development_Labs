namespace Lab8Ind
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.TBID = new System.Windows.Forms.TextBox();
            this.TBName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonChange = new System.Windows.Forms.Button();
            this.ButtonLeft = new System.Windows.Forms.Button();
            this.ButtonRight = new System.Windows.Forms.Button();
            this.ButtonAdd = new System.Windows.Forms.Button();
            this.ButtonDelete = new System.Windows.Forms.Button();
            this.TBYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.CBMark = new System.Windows.Forms.ComboBox();
            this.CBClass = new System.Windows.Forms.ComboBox();
            this.TBState = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.CBProvider = new System.Windows.Forms.ComboBox();
            this.TBDate = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.TBPrice = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.ButtonNumber = new System.Windows.Forms.Button();
            this.ButtonProcedure = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(269, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(26, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // TBID
            // 
            this.TBID.Location = new System.Drawing.Point(140, 29);
            this.TBID.Name = "TBID";
            this.TBID.ReadOnly = true;
            this.TBID.Size = new System.Drawing.Size(112, 26);
            this.TBID.TabIndex = 1;
            // 
            // TBName
            // 
            this.TBName.Location = new System.Drawing.Point(140, 77);
            this.TBName.Name = "TBName";
            this.TBName.Size = new System.Drawing.Size(112, 26);
            this.TBName.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(269, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Назва";
            // 
            // ButtonChange
            // 
            this.ButtonChange.Location = new System.Drawing.Point(27, 88);
            this.ButtonChange.Name = "ButtonChange";
            this.ButtonChange.Size = new System.Drawing.Size(94, 43);
            this.ButtonChange.TabIndex = 4;
            this.ButtonChange.Text = "Change";
            this.ButtonChange.UseVisualStyleBackColor = true;
            this.ButtonChange.Click += new System.EventHandler(this.ButtonChange_Click);
            // 
            // ButtonLeft
            // 
            this.ButtonLeft.Location = new System.Drawing.Point(27, 205);
            this.ButtonLeft.Name = "ButtonLeft";
            this.ButtonLeft.Size = new System.Drawing.Size(94, 43);
            this.ButtonLeft.TabIndex = 5;
            this.ButtonLeft.Text = "<";
            this.ButtonLeft.UseVisualStyleBackColor = true;
            this.ButtonLeft.Click += new System.EventHandler(this.ButtonLeft_Click);
            // 
            // ButtonRight
            // 
            this.ButtonRight.Location = new System.Drawing.Point(30, 384);
            this.ButtonRight.Name = "ButtonRight";
            this.ButtonRight.Size = new System.Drawing.Size(94, 43);
            this.ButtonRight.TabIndex = 6;
            this.ButtonRight.Text = ">";
            this.ButtonRight.UseVisualStyleBackColor = true;
            this.ButtonRight.Click += new System.EventHandler(this.ButtonRight_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(27, 30);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(94, 43);
            this.ButtonAdd.TabIndex = 7;
            this.ButtonAdd.Text = "Add";
            this.ButtonAdd.UseVisualStyleBackColor = true;
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(27, 147);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(94, 43);
            this.ButtonDelete.TabIndex = 8;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.UseVisualStyleBackColor = true;
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // TBYear
            // 
            this.TBYear.Location = new System.Drawing.Point(140, 169);
            this.TBYear.Name = "TBYear";
            this.TBYear.Size = new System.Drawing.Size(112, 26);
            this.TBYear.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(269, 174);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 20);
            this.label3.TabIndex = 11;
            this.label3.Text = "Рік виготовлення";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(269, 129);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Марка";
            // 
            // CBMark
            // 
            this.CBMark.FormattingEnabled = true;
            this.CBMark.Location = new System.Drawing.Point(140, 123);
            this.CBMark.Name = "CBMark";
            this.CBMark.Size = new System.Drawing.Size(112, 28);
            this.CBMark.TabIndex = 13;
            // 
            // CBClass
            // 
            this.CBClass.FormattingEnabled = true;
            this.CBClass.Location = new System.Drawing.Point(140, 217);
            this.CBClass.Name = "CBClass";
            this.CBClass.Size = new System.Drawing.Size(112, 28);
            this.CBClass.TabIndex = 17;
            // 
            // TBState
            // 
            this.TBState.Location = new System.Drawing.Point(140, 263);
            this.TBState.Name = "TBState";
            this.TBState.Size = new System.Drawing.Size(112, 26);
            this.TBState.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(269, 267);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Характеристика";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(269, 221);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 20);
            this.label6.TabIndex = 14;
            this.label6.Text = "Клас";
            // 
            // CBProvider
            // 
            this.CBProvider.FormattingEnabled = true;
            this.CBProvider.Location = new System.Drawing.Point(140, 311);
            this.CBProvider.Name = "CBProvider";
            this.CBProvider.Size = new System.Drawing.Size(112, 28);
            this.CBProvider.TabIndex = 21;
            // 
            // TBDate
            // 
            this.TBDate.Location = new System.Drawing.Point(140, 357);
            this.TBDate.Name = "TBDate";
            this.TBDate.Size = new System.Drawing.Size(112, 26);
            this.TBDate.TabIndex = 20;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(269, 361);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(141, 20);
            this.label7.TabIndex = 19;
            this.label7.Text = "Дата постачання";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(269, 316);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 20);
            this.label8.TabIndex = 18;
            this.label8.Text = "Виготовник";
            // 
            // TBPrice
            // 
            this.TBPrice.Location = new System.Drawing.Point(140, 406);
            this.TBPrice.Name = "TBPrice";
            this.TBPrice.Size = new System.Drawing.Size(112, 26);
            this.TBPrice.TabIndex = 23;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(269, 409);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(42, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Ціна";
            // 
            // ButtonNumber
            // 
            this.ButtonNumber.Location = new System.Drawing.Point(30, 264);
            this.ButtonNumber.Name = "ButtonNumber";
            this.ButtonNumber.Size = new System.Drawing.Size(94, 43);
            this.ButtonNumber.TabIndex = 24;
            this.ButtonNumber.Text = "Cheques";
            this.ButtonNumber.UseVisualStyleBackColor = true;
            this.ButtonNumber.Click += new System.EventHandler(this.ButtonNumber_Click);
            // 
            // ButtonProcedure
            // 
            this.ButtonProcedure.Location = new System.Drawing.Point(30, 323);
            this.ButtonProcedure.Name = "ButtonProcedure";
            this.ButtonProcedure.Size = new System.Drawing.Size(94, 43);
            this.ButtonProcedure.TabIndex = 25;
            this.ButtonProcedure.Text = "Marks";
            this.ButtonProcedure.UseVisualStyleBackColor = true;
            this.ButtonProcedure.Click += new System.EventHandler(this.ButtonProcedure_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 461);
            this.Controls.Add(this.ButtonProcedure);
            this.Controls.Add(this.ButtonNumber);
            this.Controls.Add(this.TBPrice);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.CBProvider);
            this.Controls.Add(this.TBDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.CBClass);
            this.Controls.Add(this.TBState);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.CBMark);
            this.Controls.Add(this.TBYear);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonAdd);
            this.Controls.Add(this.ButtonRight);
            this.Controls.Add(this.ButtonLeft);
            this.Controls.Add(this.ButtonChange);
            this.Controls.Add(this.TBName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TBID);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Lab8";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.w);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox TBID;
        private System.Windows.Forms.TextBox TBName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonChange;
        private System.Windows.Forms.Button ButtonLeft;
        private System.Windows.Forms.Button ButtonRight;
        private System.Windows.Forms.Button ButtonAdd;
        private System.Windows.Forms.Button ButtonDelete;
        private System.Windows.Forms.TextBox TBYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox CBMark;
        private System.Windows.Forms.ComboBox CBClass;
        private System.Windows.Forms.TextBox TBState;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox CBProvider;
        private System.Windows.Forms.TextBox TBDate;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox TBPrice;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button ButtonNumber;
        private System.Windows.Forms.Button ButtonProcedure;
    }
}

