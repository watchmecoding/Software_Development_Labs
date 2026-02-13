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
using System.Reflection;
using System.Data.Common;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.Configuration;

namespace Laba9
{
    public partial class Form1 : Form
    {
        string connectionString = ConfigurationManager.ConnectionStrings["Laba9.Properties.Settings.TRPZ_RenamedConnectionString"].ConnectionString;
        SqlDataAdapter adapter = new SqlDataAdapter();
        public DataSet ds = new DataSet();


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'tRPZ_RenamedDataSet1.Full_Book_Info' table. You can move, or remove it, as needed.
            this.full_Book_InfoTableAdapter.Fill(this.tRPZ_RenamedDataSet1.Full_Book_Info);
            // TODO: This line of code loads data into the 'tRPZ_RenamedDataSet.Author' table. You can move, or remove it, as needed.
            this.authorTableAdapter.Fill(this.tRPZ_RenamedDataSet.Author);
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView3.AllowUserToAddRows = false;

        }

        private void Add_Button_Click(object sender, EventArgs e)
        {
            Form2 AddForm = new Form2(this, FindAvailableIndex());
            AddForm.Text = "Add book";
            AddForm.ShowDialog();
        }

        private void Remove_Button_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                using (SqlConnection _con = new SqlConnection(connectionString))
                using (SqlCommand _cmdDelete = new SqlCommand("RemoveFromBookById", _con))
                {
                    _cmdDelete.CommandType = CommandType.StoredProcedure;

                    _cmdDelete.Parameters.Add("@Book_ID", SqlDbType.Int);
                    _cmdDelete.Parameters["@Book_ID"].Value = int.Parse(row.Cells["Book_ID"].Value.ToString());

                    _con.Open();
                    _cmdDelete.ExecuteNonQuery();
                    _con.Close();
                }
                dataGridView1.Rows.Remove(row);
            }
        }

        private void Save_Button_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 1)
            {
                Form2 AddForm = new Form2(this, dataGridView1.SelectedRows[0].Index + 1);
                AddForm.Text = "Edit book";
                AddForm.ShowDialog();
            }
        }
        private int FindAvailableIndex()
        {
            int SmallestMissingIndex = 1;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            
                // Check if the value in the "Book ID" column can be converted to an int
                if (row.Cells["Book_ID"].Value.ToString() != null && int.TryParse(row.Cells["Book_ID"].Value.ToString(), out int bookIdInRow))
                {
                    if (bookIdInRow == SmallestMissingIndex)
                    {
                        SmallestMissingIndex++;
                    }
                    else
                    {
                        return SmallestMissingIndex;
                    }
                }
            }
            return SmallestMissingIndex;
            
            //return dataGridView1.RowCount;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataContext db = new DataContext(connectionString);
            var GetNameFromOrders = from purchase in db.GetTable<Purchase>()
                                    join book in db.GetTable<Book>() on purchase.Book_Id equals book.Book_Id
                                    join genre in db.GetTable<Genre>() on book.Genre_ID equals genre.Genre_Id
                                    group book by new { book.Book_Name, genre.Genre_Name, purchase.Quantity, genre.Genre_Id } into grouped
                                    let averageOrdersPerBook = grouped.Select(g => g).Count() / (double)grouped.Count()
                                    let averageOrdersPerGenre = grouped.Where(o => o.Genre_ID == grouped.Key.Genre_Id).Count() / (double)grouped.Count()
                                    where averageOrdersPerBook >= averageOrdersPerGenre
                                    select new
                                    {
                                        BookTitle = grouped.Key.Book_Name,
                                        AverageOrdersPerBook = averageOrdersPerBook,
                                        BookGenre = grouped.Key.Genre_Name,
                                        AverageOrdersPerGenre = averageOrdersPerGenre
                                    };
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                DataSet dataSet = new DataSet();
                adapter = new SqlDataAdapter(GetNameFromOrders.ToString(), connection);

                adapter.Fill(dataSet);

                dataGridView3.DataSource = dataSet.Tables[0];
                //Делаем недоступным столбец id для изменения
            }
        }
    }
}




[Table(Name = "Purchase")]
public class Purchase
{
    [Column(Name = "Order_ID", IsPrimaryKey = true, IsDbGenerated = true)]
    public int Purchase_Id { get; set; }
    [Column(Name = "Book_ID")]
    public int Book_Id { get; set; }
    [Column(Name = "Quantity")]
    public int Quantity { get; set; }
    [Column(Name = "Order_Date")]
    public DateTime Order_Date { get; set; }
}
[Table(Name = "Genre")]
public class Genre
{
    [Column(Name = "Genre_ID", IsPrimaryKey = true, IsDbGenerated = true)]
    public int Genre_Id { get; set; }
    [Column(Name = "Genre_Name")]
    public string Genre_Name { get; set; }
}


[Table(Name = "Book")]
public class Book
{
    [Column(Name = "Book_ID", IsPrimaryKey = true, IsDbGenerated = true)]
    public int Book_Id { get; set; }
    [Column(Name = "Publisher_ID")]
    public int Publisher_ID { get; set; }
    [Column(Name = "Author_ID")]
    public int Author_ID { get; set; }
    [Column(Name = "Genre_ID")]
    public int Genre_ID { get; set; }
    [Column(Name = "Supplier_ID")]
    public int Supplier_ID { get; set; }
    [Column(Name = "Book_Name")]
    public string Book_Name { get; set; }
    [Column(Name = "Cost")]
    public decimal Cost { get; set; }
    [Column(Name = "Delivery_Value")]
    public decimal Delivery_Value { get; set; }
    [Column(Name = "Release_Year")]
    public int Release_Year { get; set; }
    [Column(Name = "Book_Cover")]
    public string Book_Cover { get; set; }
}