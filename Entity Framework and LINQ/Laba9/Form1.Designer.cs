namespace Laba9
{
    partial class Form1
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Book_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookTitleDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.authorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.publisherDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.genreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.supplierDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deliveryValueDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costWithDeliveryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.releaseYearDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookCoverDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fullBookInfoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRPZRenamedDataSet1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tRPZ_RenamedDataSet1 = new Laba9.TRPZ_RenamedDataSet1();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.AddButton = new System.Windows.Forms.Button();
            this.EditButton = new System.Windows.Forms.Button();
            this.RemoveButton = new System.Windows.Forms.Button();
            this.LinqButton = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.full_Book_InfoTableAdapter1 = new Laba9.TRPZ_RenamedDataSet1TableAdapters.Full_Book_InfoTableAdapter();
            this.full_Book_InfoTableAdapter = new Laba9.TRPZ_RenamedDataSet1TableAdapters.Full_Book_InfoTableAdapter();
            this.tRPZ_RenamedDataSet = new Laba9.TRPZ_RenamedDataSet1();
            this.authorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.authorTableAdapter = new Laba9.TRPZ_RenamedDataSet1TableAdapters.AuthorTableAdapter();
            this.tRPZRenamedDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fullBookInfoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullBookInfoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRPZRenamedDataSet1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRPZ_RenamedDataSet1)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRPZ_RenamedDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRPZRenamedDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullBookInfoBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1064, 428);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.splitContainer1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1056, 399);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Main table";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
            this.splitContainer1.Size = new System.Drawing.Size(1050, 393);
            this.splitContainer1.SplitterDistance = 316;
            this.splitContainer1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Book_ID,
            this.bookTitleDataGridViewTextBoxColumn,
            this.authorDataGridViewTextBoxColumn,
            this.publisherDataGridViewTextBoxColumn,
            this.genreDataGridViewTextBoxColumn,
            this.supplierDataGridViewTextBoxColumn,
            this.costDataGridViewTextBoxColumn,
            this.deliveryValueDataGridViewTextBoxColumn,
            this.costWithDeliveryDataGridViewTextBoxColumn,
            this.releaseYearDataGridViewTextBoxColumn,
            this.bookCoverDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.fullBookInfoBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1050, 316);
            this.dataGridView1.TabIndex = 0;
            // 
            // Book_ID
            // 
            this.Book_ID.DataPropertyName = "Book ID";
            this.Book_ID.HeaderText = "Book ID";
            this.Book_ID.MinimumWidth = 6;
            this.Book_ID.Name = "Book_ID";
            this.Book_ID.Width = 125;
            // 
            // bookTitleDataGridViewTextBoxColumn
            // 
            this.bookTitleDataGridViewTextBoxColumn.DataPropertyName = "Book title";
            this.bookTitleDataGridViewTextBoxColumn.HeaderText = "Book title";
            this.bookTitleDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookTitleDataGridViewTextBoxColumn.Name = "bookTitleDataGridViewTextBoxColumn";
            this.bookTitleDataGridViewTextBoxColumn.Width = 125;
            // 
            // authorDataGridViewTextBoxColumn
            // 
            this.authorDataGridViewTextBoxColumn.DataPropertyName = "Author";
            this.authorDataGridViewTextBoxColumn.HeaderText = "Author";
            this.authorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.authorDataGridViewTextBoxColumn.Name = "authorDataGridViewTextBoxColumn";
            this.authorDataGridViewTextBoxColumn.ReadOnly = true;
            this.authorDataGridViewTextBoxColumn.Width = 125;
            // 
            // publisherDataGridViewTextBoxColumn
            // 
            this.publisherDataGridViewTextBoxColumn.DataPropertyName = "Publisher";
            this.publisherDataGridViewTextBoxColumn.HeaderText = "Publisher";
            this.publisherDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.publisherDataGridViewTextBoxColumn.Name = "publisherDataGridViewTextBoxColumn";
            this.publisherDataGridViewTextBoxColumn.Width = 125;
            // 
            // genreDataGridViewTextBoxColumn
            // 
            this.genreDataGridViewTextBoxColumn.DataPropertyName = "Genre";
            this.genreDataGridViewTextBoxColumn.HeaderText = "Genre";
            this.genreDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.genreDataGridViewTextBoxColumn.Name = "genreDataGridViewTextBoxColumn";
            this.genreDataGridViewTextBoxColumn.Width = 125;
            // 
            // supplierDataGridViewTextBoxColumn
            // 
            this.supplierDataGridViewTextBoxColumn.DataPropertyName = "Supplier";
            this.supplierDataGridViewTextBoxColumn.HeaderText = "Supplier";
            this.supplierDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.supplierDataGridViewTextBoxColumn.Name = "supplierDataGridViewTextBoxColumn";
            this.supplierDataGridViewTextBoxColumn.Width = 125;
            // 
            // costDataGridViewTextBoxColumn
            // 
            this.costDataGridViewTextBoxColumn.DataPropertyName = "Cost";
            this.costDataGridViewTextBoxColumn.HeaderText = "Cost";
            this.costDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costDataGridViewTextBoxColumn.Name = "costDataGridViewTextBoxColumn";
            this.costDataGridViewTextBoxColumn.Width = 125;
            // 
            // deliveryValueDataGridViewTextBoxColumn
            // 
            this.deliveryValueDataGridViewTextBoxColumn.DataPropertyName = "Delivery value";
            this.deliveryValueDataGridViewTextBoxColumn.HeaderText = "Delivery value";
            this.deliveryValueDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.deliveryValueDataGridViewTextBoxColumn.Name = "deliveryValueDataGridViewTextBoxColumn";
            this.deliveryValueDataGridViewTextBoxColumn.Width = 125;
            // 
            // costWithDeliveryDataGridViewTextBoxColumn
            // 
            this.costWithDeliveryDataGridViewTextBoxColumn.DataPropertyName = "Cost with delivery";
            this.costWithDeliveryDataGridViewTextBoxColumn.HeaderText = "Cost with delivery";
            this.costWithDeliveryDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.costWithDeliveryDataGridViewTextBoxColumn.Name = "costWithDeliveryDataGridViewTextBoxColumn";
            this.costWithDeliveryDataGridViewTextBoxColumn.ReadOnly = true;
            this.costWithDeliveryDataGridViewTextBoxColumn.Width = 125;
            // 
            // releaseYearDataGridViewTextBoxColumn
            // 
            this.releaseYearDataGridViewTextBoxColumn.DataPropertyName = "Release year";
            this.releaseYearDataGridViewTextBoxColumn.HeaderText = "Release year";
            this.releaseYearDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.releaseYearDataGridViewTextBoxColumn.Name = "releaseYearDataGridViewTextBoxColumn";
            this.releaseYearDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookCoverDataGridViewTextBoxColumn
            // 
            this.bookCoverDataGridViewTextBoxColumn.DataPropertyName = "Book cover";
            this.bookCoverDataGridViewTextBoxColumn.HeaderText = "Book cover";
            this.bookCoverDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookCoverDataGridViewTextBoxColumn.Name = "bookCoverDataGridViewTextBoxColumn";
            this.bookCoverDataGridViewTextBoxColumn.Width = 125;
            // 
            // fullBookInfoBindingSource
            // 
            this.fullBookInfoBindingSource.DataMember = "Full_Book_Info";
            this.fullBookInfoBindingSource.DataSource = this.tRPZRenamedDataSet1BindingSource;
            // 
            // tRPZRenamedDataSet1BindingSource
            // 
            this.tRPZRenamedDataSet1BindingSource.DataSource = this.tRPZ_RenamedDataSet1;
            this.tRPZRenamedDataSet1BindingSource.Position = 0;
            // 
            // tRPZ_RenamedDataSet1
            // 
            this.tRPZ_RenamedDataSet1.DataSetName = "TRPZ_RenamedDataSet1";
            this.tRPZ_RenamedDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.AddButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.EditButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.RemoveButton, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.LinqButton, 3, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 73F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1050, 73);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // AddButton
            // 
            this.AddButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddButton.Location = new System.Drawing.Point(3, 3);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(256, 67);
            this.AddButton.TabIndex = 0;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.Add_Button_Click);
            // 
            // EditButton
            // 
            this.EditButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EditButton.Location = new System.Drawing.Point(265, 3);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(256, 67);
            this.EditButton.TabIndex = 1;
            this.EditButton.Text = "Edit";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // RemoveButton
            // 
            this.RemoveButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveButton.Location = new System.Drawing.Point(527, 3);
            this.RemoveButton.Name = "RemoveButton";
            this.RemoveButton.Size = new System.Drawing.Size(256, 67);
            this.RemoveButton.TabIndex = 2;
            this.RemoveButton.Text = "Remove";
            this.RemoveButton.UseVisualStyleBackColor = true;
            this.RemoveButton.Click += new System.EventHandler(this.Remove_Button_Click);
            // 
            // LinqButton
            // 
            this.LinqButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LinqButton.Location = new System.Drawing.Point(789, 3);
            this.LinqButton.Name = "LinqButton";
            this.LinqButton.Size = new System.Drawing.Size(258, 67);
            this.LinqButton.TabIndex = 3;
            this.LinqButton.Text = "Linq";
            this.LinqButton.UseVisualStyleBackColor = true;
            this.LinqButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView3);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1056, 399);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Linq table";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.Location = new System.Drawing.Point(3, 3);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 51;
            this.dataGridView3.RowTemplate.Height = 24;
            this.dataGridView3.Size = new System.Drawing.Size(1050, 393);
            this.dataGridView3.TabIndex = 0;
            // 
            // full_Book_InfoTableAdapter1
            // 
            this.full_Book_InfoTableAdapter1.ClearBeforeFill = true;
            // 
            // full_Book_InfoTableAdapter
            // 
            this.full_Book_InfoTableAdapter.ClearBeforeFill = true;
            // 
            // tRPZ_RenamedDataSet
            // 
            this.tRPZ_RenamedDataSet.DataSetName = "TRPZ_RenamedDataSet";
            this.tRPZ_RenamedDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // authorBindingSource
            // 
            this.authorBindingSource.DataMember = "Author";
            this.authorBindingSource.DataSource = this.tRPZ_RenamedDataSet;
            // 
            // authorTableAdapter
            // 
            this.authorTableAdapter.ClearBeforeFill = true;
            // 
            // tRPZRenamedDataSetBindingSource
            // 
            this.tRPZRenamedDataSetBindingSource.DataSource = this.tRPZ_RenamedDataSet;
            this.tRPZRenamedDataSetBindingSource.Position = 0;
            // 
            // fullBookInfoBindingSource1
            // 
            this.fullBookInfoBindingSource1.DataMember = "Full_Book_Info";
            this.fullBookInfoBindingSource1.DataSource = this.tRPZRenamedDataSet1BindingSource;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1064, 428);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Laba 9";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullBookInfoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRPZRenamedDataSet1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRPZ_RenamedDataSet1)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRPZ_RenamedDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.authorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tRPZRenamedDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullBookInfoBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Book_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookTitleDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn authorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn publisherDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn genreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn supplierDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deliveryValueDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn costWithDeliveryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn releaseYearDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookCoverDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource fullBookInfoBindingSource;
        private System.Windows.Forms.BindingSource tRPZRenamedDataSet1BindingSource;
        private TRPZ_RenamedDataSet1 tRPZ_RenamedDataSet1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.Button RemoveButton;
        private System.Windows.Forms.Button LinqButton;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private TRPZ_RenamedDataSet1TableAdapters.Full_Book_InfoTableAdapter full_Book_InfoTableAdapter1;
        private TRPZ_RenamedDataSet1TableAdapters.Full_Book_InfoTableAdapter full_Book_InfoTableAdapter;
        private TRPZ_RenamedDataSet1 tRPZ_RenamedDataSet;
        private System.Windows.Forms.BindingSource authorBindingSource;
        private TRPZ_RenamedDataSet1TableAdapters.AuthorTableAdapter authorTableAdapter;
        private System.Windows.Forms.BindingSource tRPZRenamedDataSetBindingSource;
        private System.Windows.Forms.BindingSource fullBookInfoBindingSource1;
    }
}

