namespace Laba_7_TRPZ
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Main = new TabControl();
            MainPage = new TabPage();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            NameTextBox = new TextBox();
            AgeTextBox = new TextBox();
            GenderTextBox = new TextBox();
            HabitatTextBox = new TextBox();
            Base1 = new TextBox();
            Base2 = new TextBox();
            Base3 = new TextBox();
            Base4 = new TextBox();
            Unique1 = new TextBox();
            Unique2 = new TextBox();
            Unique3 = new TextBox();
            Unique4 = new TextBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            UnitPage = new TabPage();
            splitContainer3 = new SplitContainer();
            RichTextBox1 = new RichTextBox();
            OutsideShow = new Button();
            Main.SuspendLayout();
            MainPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            UnitPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            SuspendLayout();
            // 
            // Main
            // 
            Main.Controls.Add(MainPage);
            Main.Controls.Add(UnitPage);
            Main.Dock = DockStyle.Fill;
            Main.Location = new Point(0, 0);
            Main.Margin = new Padding(3, 2, 3, 2);
            Main.Name = "Main";
            Main.SelectedIndex = 0;
            Main.Size = new Size(998, 429);
            Main.TabIndex = 31;
            // 
            // MainPage
            // 
            MainPage.Controls.Add(splitContainer1);
            MainPage.Location = new Point(4, 24);
            MainPage.Margin = new Padding(3, 2, 3, 2);
            MainPage.Name = "MainPage";
            MainPage.Size = new Size(990, 401);
            MainPage.TabIndex = 2;
            MainPage.Text = "Test";
            MainPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Margin = new Padding(3, 2, 3, 2);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(tableLayoutPanel2);
            splitContainer1.Size = new Size(990, 401);
            splitContainer1.SplitterDistance = 247;
            splitContainer1.TabIndex = 0;
            // 
            // splitContainer2
            // 
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Margin = new Padding(3, 2, 3, 2);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(button2);
            splitContainer2.Size = new Size(247, 401);
            splitContainer2.SplitterDistance = 182;
            splitContainer2.TabIndex = 0;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(NameTextBox, 0, 1);
            tableLayoutPanel1.Controls.Add(AgeTextBox, 0, 2);
            tableLayoutPanel1.Controls.Add(GenderTextBox, 0, 3);
            tableLayoutPanel1.Controls.Add(HabitatTextBox, 0, 4);
            tableLayoutPanel1.Controls.Add(Base1, 0, 5);
            tableLayoutPanel1.Controls.Add(Base2, 0, 6);
            tableLayoutPanel1.Controls.Add(Base3, 0, 7);
            tableLayoutPanel1.Controls.Add(Base4, 0, 8);
            tableLayoutPanel1.Controls.Add(Unique1, 0, 9);
            tableLayoutPanel1.Controls.Add(Unique2, 0, 10);
            tableLayoutPanel1.Controls.Add(Unique3, 0, 11);
            tableLayoutPanel1.Controls.Add(Unique4, 0, 12);
            tableLayoutPanel1.Controls.Add(comboBox1, 0, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.Padding = new Padding(18, 15, 18, 15);
            tableLayoutPanel1.RowCount = 13;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.692308F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.69230843F));
            tableLayoutPanel1.Size = new Size(182, 401);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // NameTextBox
            // 
            NameTextBox.Dock = DockStyle.Fill;
            NameTextBox.Location = new Point(21, 45);
            NameTextBox.Margin = new Padding(3, 2, 3, 2);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(140, 23);
            NameTextBox.TabIndex = 56;
            // 
            // AgeTextBox
            // 
            AgeTextBox.Dock = DockStyle.Fill;
            AgeTextBox.Location = new Point(21, 73);
            AgeTextBox.Margin = new Padding(3, 2, 3, 2);
            AgeTextBox.Name = "AgeTextBox";
            AgeTextBox.Size = new Size(140, 23);
            AgeTextBox.TabIndex = 55;
            // 
            // GenderTextBox
            // 
            GenderTextBox.Dock = DockStyle.Fill;
            GenderTextBox.Location = new Point(21, 101);
            GenderTextBox.Margin = new Padding(3, 2, 3, 2);
            GenderTextBox.Name = "GenderTextBox";
            GenderTextBox.Size = new Size(140, 23);
            GenderTextBox.TabIndex = 54;
            // 
            // HabitatTextBox
            // 
            HabitatTextBox.Dock = DockStyle.Fill;
            HabitatTextBox.Location = new Point(21, 129);
            HabitatTextBox.Margin = new Padding(3, 2, 3, 2);
            HabitatTextBox.Name = "HabitatTextBox";
            HabitatTextBox.Size = new Size(140, 23);
            HabitatTextBox.TabIndex = 53;
            // 
            // Base1
            // 
            Base1.Dock = DockStyle.Fill;
            Base1.Location = new Point(21, 157);
            Base1.Margin = new Padding(3, 2, 3, 2);
            Base1.Name = "Base1";
            Base1.Size = new Size(140, 23);
            Base1.TabIndex = 52;
            // 
            // Base2
            // 
            Base2.Dock = DockStyle.Fill;
            Base2.Location = new Point(21, 185);
            Base2.Margin = new Padding(3, 2, 3, 2);
            Base2.Name = "Base2";
            Base2.Size = new Size(140, 23);
            Base2.TabIndex = 51;
            // 
            // Base3
            // 
            Base3.Dock = DockStyle.Fill;
            Base3.Location = new Point(21, 213);
            Base3.Margin = new Padding(3, 2, 3, 2);
            Base3.Name = "Base3";
            Base3.Size = new Size(140, 23);
            Base3.TabIndex = 50;
            // 
            // Base4
            // 
            Base4.Dock = DockStyle.Fill;
            Base4.Location = new Point(21, 241);
            Base4.Margin = new Padding(3, 2, 3, 2);
            Base4.Name = "Base4";
            Base4.Size = new Size(140, 23);
            Base4.TabIndex = 49;
            // 
            // Unique1
            // 
            Unique1.Dock = DockStyle.Fill;
            Unique1.Location = new Point(21, 269);
            Unique1.Margin = new Padding(3, 2, 3, 2);
            Unique1.Name = "Unique1";
            Unique1.Size = new Size(140, 23);
            Unique1.TabIndex = 48;
            // 
            // Unique2
            // 
            Unique2.Dock = DockStyle.Fill;
            Unique2.Location = new Point(21, 297);
            Unique2.Margin = new Padding(3, 2, 3, 2);
            Unique2.Name = "Unique2";
            Unique2.Size = new Size(140, 23);
            Unique2.TabIndex = 47;
            // 
            // Unique3
            // 
            Unique3.Dock = DockStyle.Fill;
            Unique3.Location = new Point(21, 325);
            Unique3.Margin = new Padding(3, 2, 3, 2);
            Unique3.Name = "Unique3";
            Unique3.Size = new Size(140, 23);
            Unique3.TabIndex = 46;
            // 
            // Unique4
            // 
            Unique4.Dock = DockStyle.Fill;
            Unique4.Location = new Point(21, 353);
            Unique4.Margin = new Padding(3, 2, 3, 2);
            Unique4.Name = "Unique4";
            Unique4.Size = new Size(140, 23);
            Unique4.TabIndex = 57;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "BlueTit", "Lion", "Dolphin" });
            comboBox1.Location = new Point(21, 17);
            comboBox1.Margin = new Padding(3, 2, 3, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(140, 23);
            comboBox1.TabIndex = 45;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Location = new Point(0, 0);
            button2.Margin = new Padding(3, 2, 3, 2);
            button2.Name = "button2";
            button2.Padding = new Padding(18, 15, 18, 15);
            button2.Size = new Size(61, 401);
            button2.TabIndex = 36;
            button2.Text = "Create animal";
            button2.UseVisualStyleBackColor = true;
            button2.Click += CreateAnimalButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 18F));
            tableLayoutPanel2.Controls.Add(button1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Top;
            tableLayoutPanel2.Location = new Point(0, 0);
            tableLayoutPanel2.Margin = new Padding(3, 2, 3, 2);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 56F));
            tableLayoutPanel2.Size = new Size(739, 56);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Location = new Point(3, 2);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(733, 52);
            button1.TabIndex = 62;
            button1.Text = "Save animal collection";
            button1.UseVisualStyleBackColor = true;
            button1.Click += SaveButton_Click;
            // 
            // UnitPage
            // 
            UnitPage.Controls.Add(splitContainer3);
            UnitPage.Location = new Point(4, 24);
            UnitPage.Margin = new Padding(3, 2, 3, 2);
            UnitPage.Name = "UnitPage";
            UnitPage.Padding = new Padding(3, 2, 3, 2);
            UnitPage.Size = new Size(990, 401);
            UnitPage.TabIndex = 1;
            UnitPage.Text = "Unit tab";
            UnitPage.UseVisualStyleBackColor = true;
            // 
            // splitContainer3
            // 
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(3, 2);
            splitContainer3.Margin = new Padding(3, 2, 3, 2);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(RichTextBox1);
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(OutsideShow);
            splitContainer3.Size = new Size(984, 397);
            splitContainer3.SplitterDistance = 728;
            splitContainer3.TabIndex = 1;
            // 
            // RichTextBox1
            // 
            RichTextBox1.Dock = DockStyle.Fill;
            RichTextBox1.Location = new Point(0, 0);
            RichTextBox1.Margin = new Padding(3, 2, 3, 2);
            RichTextBox1.Name = "RichTextBox1";
            RichTextBox1.Size = new Size(728, 397);
            RichTextBox1.TabIndex = 0;
            RichTextBox1.Text = "";
            // 
            // OutsideShow
            // 
            OutsideShow.Dock = DockStyle.Fill;
            OutsideShow.Location = new Point(0, 0);
            OutsideShow.Margin = new Padding(3, 2, 3, 2);
            OutsideShow.Name = "OutsideShow";
            OutsideShow.Size = new Size(252, 397);
            OutsideShow.TabIndex = 1;
            OutsideShow.Text = "Show in another window";
            OutsideShow.UseVisualStyleBackColor = true;
            OutsideShow.Click += OutsideShow_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSize = true;
            ClientSize = new Size(998, 429);
            Controls.Add(Main);
            Margin = new Padding(3, 2, 3, 2);
            Name = "Form1";
            Text = "Laba 7";
            Main.ResumeLayout(false);
            MainPage.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            UnitPage.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private TabControl Main;
        private TabPage UnitPage;
        private TabPage MainPage;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel1;
        private TextBox NameTextBox;
        private TextBox AgeTextBox;
        private TextBox GenderTextBox;
        private TextBox HabitatTextBox;
        private TextBox Base1;
        private TextBox Base2;
        private TextBox Base3;
        private TextBox Base4;
        private TextBox Unique1;
        private TextBox Unique2;
        private TextBox Unique3;
        private TextBox Unique4;
        private ComboBox comboBox1;
        private Button button2;
        private TableLayoutPanel tableLayoutPanel2;
        private SplitContainer splitContainer3;
        private RichTextBox RichTextBox1;
        private Button OutsideShow;
        private Button button1;
    }
}