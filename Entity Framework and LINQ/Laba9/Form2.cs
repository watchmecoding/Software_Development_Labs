using System.Windows.Forms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using System.Configuration;


namespace Laba9
{
    public partial class Form2 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Laba9.Properties.Settings.TRPZ_RenamedConnectionString"].ConnectionString;
        string Test_sql = "SELECT * FROM Full_Book_Info";
        Form1 MainForm;


        public Form2(Form1 form1, int index)
        {
            MainForm = form1;
            InitializeComponent();
            ID_Label.Text = index.ToString();
            GetElementsFromGenre();
            GetElementsFromPublisher();
            GetElementsFromAuthor();
            GetElementsFromSupplier();
            GetElementsFromBook();
        }

        public void GetElementsFromBook()
        {
            DataContext db = new DataContext(connectionString);
            var GetNameFromGenre = from b in db.GetTable<Book>()
                                   where b.Book_Id == int.Parse(ID_Label.Text)
                                   select b;
            foreach (Book book in GetNameFromGenre)
            {
                ID_Label.Text = book.Book_Id.ToString();
                Add_Button.Text = "Save";
                Book_Name_TextBox.Text = book.Book_Name;
                Author_comboBox.SelectedIndex = book.Author_ID - 1;
                Publisher_comboBox.SelectedIndex = book.Publisher_ID - 1;
                Genre_comboBox.SelectedIndex = book.Genre_ID - 1;
                Supplier_comboBox.SelectedIndex = book.Supplier_ID - 1;
                Cost_textBox.Text = book.Cost.ToString();
                Delivery_textBox.Text = book.Delivery_Value.ToString();
                Year_textBox.Text = book.Release_Year.ToString();
                Cover_textBox.Text = book.Book_Cover;
                /*MessageBox.Show($"Book_ID: {book.Book_Id}, Publisher_ID: {book.Publisher_ID}, Author_ID: {book.Author_ID}, Genre_ID: {book.Genre_ID}" +
                                $"Supplier_ID: {book.Supplier_ID}, Book_Name: {book.Book_Name}, Cost: {book.Cost}, Delivery_Value: {book.Delivery_Value}" +
                                $"Release_Year: {book.Release_Year}, Book_Cover: {book.Book_Cover}");*/

            }
        }

        public void GetElementsFromGenre()
        {
            DataContext db = new DataContext(connectionString);
            var GetNameFromGenre = from b in db.GetTable<Genre>()
                                   select b;
            foreach (Genre g in GetNameFromGenre)
            {
                Genre_comboBox.Items.Add(g.Genre_Name);
            }
        }
        public void GetElementsFromAuthor()
        {
            DataContext db = new DataContext(connectionString);
            var GetNameFromGenre = from b in db.GetTable<Author>()
                                   select b;
            foreach (Author g in GetNameFromGenre)
            {
                Author_comboBox.Items.Add($"{g.Author_Name} {g.Author_Surname}");
            }
        }
        public void GetElementsFromPublisher()
        {
            DataContext db = new DataContext(connectionString);
            var GetNameFromGenre = from b in db.GetTable<Publisher>()
                                   select b;
            foreach (var g in GetNameFromGenre)
            {
                Publisher_comboBox.Items.Add(g.Publisher_Name);
            }
        }
        public void GetElementsFromSupplier()
        {
            DataContext db = new DataContext(connectionString);
            var GetNameFromGenre = from b in db.GetTable<Supplier>()
                                   select b;
            foreach (var g in GetNameFromGenre)
            {
                Supplier_comboBox.Items.Add(g.Supplier_Name);
            }
        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            object[] rowValues = new object[11];
            try
            {

                rowValues[0] = int.Parse(ID_Label.Text);
                rowValues[1] = Book_Name_TextBox.Text;
                rowValues[2] = Author_comboBox.SelectedItem;
                rowValues[3] = Publisher_comboBox.SelectedItem;
                rowValues[4] = Genre_comboBox.SelectedItem;
                rowValues[5] = Supplier_comboBox.SelectedItem;
                rowValues[6] = decimal.Parse(Cost_textBox.Text);
                rowValues[7] = decimal.Parse(Delivery_textBox.Text);
                rowValues[8] = decimal.Parse(Cost_textBox.Text) + decimal.Parse(Delivery_textBox.Text);
                rowValues[9] = int.Parse(Year_textBox.Text);
                rowValues[10] = Cover_textBox.Text;
            }
            catch (Exception k)
            {
                MessageBox.Show(k.Message, "Transaction error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (this.Text == "Add book")
            {
                using (SqlConnection _con = new SqlConnection(connectionString))
                using (SqlCommand AddBook = new SqlCommand("AddToBook", _con))
                {
                    try
                    {
                        AddBook.CommandType = CommandType.StoredProcedure;
                        AddBook.Parameters.Add("@Book_ID", SqlDbType.Int);
                        AddBook.Parameters["@Book_ID"].Value = int.Parse(ID_Label.Text);
                        AddBook.Parameters.Add("@Publisher_ID", SqlDbType.Int);
                        AddBook.Parameters["@Publisher_ID"].Value = Publisher_comboBox.SelectedIndex + 1;
                        AddBook.Parameters.Add("@Author_ID", SqlDbType.Int);
                        AddBook.Parameters["@Author_ID"].Value = Author_comboBox.SelectedIndex + 1;
                        AddBook.Parameters.Add("@Genre_ID", SqlDbType.Int);
                        AddBook.Parameters["@Genre_ID"].Value = Genre_comboBox.SelectedIndex + 1;
                        AddBook.Parameters.Add("@Supplier_ID", SqlDbType.Int);
                        AddBook.Parameters["@Supplier_ID"].Value = Supplier_comboBox.SelectedIndex + 1;
                        AddBook.Parameters.Add("@Book_Name", SqlDbType.VarChar, 50);
                        AddBook.Parameters["@Book_Name"].Value = Book_Name_TextBox.Text;
                        AddBook.Parameters.Add("@Cost", SqlDbType.Money);
                        AddBook.Parameters["@Cost"].Value = decimal.Parse(Cost_textBox.Text);
                        AddBook.Parameters.Add("@Delivery_Value", SqlDbType.Money);
                        AddBook.Parameters["@Delivery_Value"].Value = decimal.Parse(Delivery_textBox.Text);
                        AddBook.Parameters.Add("@Release_Year", SqlDbType.Int);
                        AddBook.Parameters["@Release_Year"].Value = int.Parse(Year_textBox.Text);
                        AddBook.Parameters.Add("@Book_cover", SqlDbType.VarChar, 100);
                        AddBook.Parameters["@Book_cover"].Value = Cover_textBox.Text;
                        _con.Open();
                        SqlTransaction transaction = _con.BeginTransaction();
                        AddBook.Transaction = transaction;
                        AddBook.ExecuteNonQuery();
                        transaction.Commit();
                        _con.Close();
                        //MainForm.dataGridView1.Rows.Add(newRow);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message, "Transaction error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            else if (this.Text == "Edit book")
            {
                using (SqlConnection _con = new SqlConnection(connectionString))
                using (SqlCommand AddBook = new SqlCommand("UpdateBook", _con))
                {
                    try
                    {
                        AddBook.CommandType = CommandType.StoredProcedure;
                        AddBook.Parameters.Add("@Book_ID", SqlDbType.Int);
                        AddBook.Parameters["@Book_ID"].Value = int.Parse(ID_Label.Text);
                        AddBook.Parameters.Add("@Publisher_ID", SqlDbType.Int);
                        AddBook.Parameters["@Publisher_ID"].Value = Publisher_comboBox.SelectedIndex + 1;
                        AddBook.Parameters.Add("@Author_ID", SqlDbType.Int);
                        AddBook.Parameters["@Author_ID"].Value = Author_comboBox.SelectedIndex + 1;
                        AddBook.Parameters.Add("@Genre_ID", SqlDbType.Int);
                        AddBook.Parameters["@Genre_ID"].Value = Genre_comboBox.SelectedIndex + 1;
                        AddBook.Parameters.Add("@Supplier_ID", SqlDbType.Int);
                        AddBook.Parameters["@Supplier_ID"].Value = Supplier_comboBox.SelectedIndex + 1;
                        AddBook.Parameters.Add("@Book_Name", SqlDbType.VarChar, 50);
                        AddBook.Parameters["@Book_Name"].Value = Book_Name_TextBox.Text;
                        AddBook.Parameters.Add("@Cost", SqlDbType.Money);
                        AddBook.Parameters["@Cost"].Value = decimal.Parse(Cost_textBox.Text);
                        AddBook.Parameters.Add("@Delivery_Value", SqlDbType.Money);
                        AddBook.Parameters["@Delivery_Value"].Value = decimal.Parse(Delivery_textBox.Text);
                        AddBook.Parameters.Add("@Release_Year", SqlDbType.Int);
                        AddBook.Parameters["@Release_Year"].Value = int.Parse(Year_textBox.Text);
                        AddBook.Parameters.Add("@Book_cover", SqlDbType.VarChar, 100);
                        AddBook.Parameters["@Book_cover"].Value = Cover_textBox.Text;
                        _con.Open();
                        SqlTransaction transaction = _con.BeginTransaction();
                        AddBook.Transaction = transaction;
                        AddBook.ExecuteNonQuery();
                        transaction.Commit();
                        _con.Close();
                        //MainForm.dataGridView1.Rows.RemoveAt(int.Parse(ID_Label.Text) - 1);
                        //MainForm.dataGridView1.Rows.Insert(int.Parse(ID_Label.Text) - 1, newRow);
                    }
                    catch (Exception a)
                    {
                        MessageBox.Show(a.Message, "Transaction error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }
            }
            ReloadDataGridView();
            this.Close();
        }
        
        void ReloadDataGridView()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter(Test_sql, connectionString);
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                MainForm.dataGridView1.DataSource = ds.Tables[0];
            }
        }
    }
}

[Table(Name = "Publisher")]
public class Publisher
{
    [Column(Name = "Publisher_ID", IsPrimaryKey = true, IsDbGenerated = true)]
    public int Publisher_Id { get; set; }
    [Column(Name = "Publisher_Name")]
    public string Publisher_Name { get; set; }
}
[Table(Name = "Author")]
public class Author
{
    [Column(Name = "Author_ID", IsPrimaryKey = true, IsDbGenerated = true)]
    public int Author_Id { get; set; }
    [Column(Name = "Author_Name")]
    public string Author_Name { get; set; }
    [Column(Name = "Author_Surname")]
    public string Author_Surname { get; set; }
}
[Table(Name = "Supplier")]
public class Supplier
{
    [Column(Name = "Supplier_ID", IsPrimaryKey = true, IsDbGenerated = true)]
    public int Supplier_Id { get; set; }
    [Column(Name = "Supplier_Name")]
    public string Supplier_Name { get; set; }
}

