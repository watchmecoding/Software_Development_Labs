using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Lab8Ind
{
    public partial class Form1 : Form
    {
        string connectionString;
        int Mark, Class, Provider;
        int allInstruments;
        int currentInstrument = 0;
        public Form1()
        {
            InitializeComponent();
            SqlConnectionStringBuilder connectionStringBuilder = new SqlConnectionStringBuilder();
            connectionStringBuilder["Data Source"] = @"R3SU";
            connectionStringBuilder["Initial Catalog"] = "Music_Store";
            connectionStringBuilder["Integrated Security"] = true;
            connectionString = connectionStringBuilder.ConnectionString;
            GuitarAmount();
            SetInstruments(0);
        }

        public void SetInstruments(int index)
        {
            int mark = 0, clas = 0, provider = 0;
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT * FROM Instrument";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    int i = 0;                    
                    while (reader.Read())
                    {
                        if (i == index)
                        {

                            int id = reader.GetInt32(0);
                            int year = reader.GetInt32(2);
                            string name = reader.GetString(4);
                            string description = reader.GetString(5);
                            decimal price = reader.GetDecimal(6);
                            DateTime date = reader.GetDateTime(8);
                            mark = reader.GetInt32(1);
                            clas = reader.GetInt32(3);
                            provider = reader.GetInt32(7);
                            
                            TBID.Text = id.ToString();
                            TBYear.Text = year.ToString();
                            TBName.Text = name.ToString();
                            TBState.Text = description.ToString();
                            TBPrice.Text = price.ToString();
                            TBDate.Text = date.ToString();
                            break;
                        }
                        else i++;                        
                    }
                    currentInstrument = i;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Не вийшло зчитати з БД." + e.Message);
                }
                SetMark(mark - 1);
                SetClass(clas - 1);
                SetProvider(provider - 1);
                Mark = mark;
                Class = clas;
                Provider = provider;
            }
        }

        public void SetMark(int index)
        {
            CBMark.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT Name FROM Mark"; 
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        CBMark.Items.Add(reader.GetString(0));
                    }
                    CBMark.SelectedIndex = index;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Не вийшло зчитати з БД." + e.Message);
                }
            }
        }
        public void SetClass(int index)
        {
            CBClass.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT Name FROM Class";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        CBClass.Items.Add(reader.GetString(0));
                    }
                    CBClass.SelectedIndex = index;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Не вийшло зчитати з БД." + e.Message);
                }
            }
        }

        /*public int GetMark(string name)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT Name FROM Class";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        CBClass.Items.Add(reader.GetString(0));
                    }
                    CBClass.SelectedIndex = index;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Не вийшло зчитати з БД." + e.Message);
                }
            }
            return 1;
        }*/

        public void SetProvider(int index)
        {
            CBProvider.Items.Clear();
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT Name FROM Provider";
                    SqlCommand command = new SqlCommand(sql, connection);
                    SqlDataReader reader = command.ExecuteReader();
                    while (reader.Read())
                    {
                        CBProvider.Items.Add(reader.GetString(0));
                    }
                    CBProvider.SelectedIndex = index;
                }
                catch (Exception e)
                {
                    MessageBox.Show("Не вийшло зчитати з БД." + e.Message);
                }
            }
        }

        public void GuitarAmount()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string amount = "SELECT COUNT(*) FROM Instrument";
                    SqlCommand comm = new SqlCommand(amount, connection);
                    allInstruments = Convert.ToInt32(comm.ExecuteScalar());
                }
                catch (Exception e)
                {
                    MessageBox.Show("Не вийшло зчитати з БД." + e.Message);
                }
            }
        }     

        private void ButtonLeft_Click(object sender, EventArgs e)
        {
           // int id = Convert.ToInt32(TBID.Text) - 1;            
            if (currentInstrument == 0) currentInstrument = allInstruments - 1;
            else currentInstrument--;
            SetInstruments(currentInstrument);
        }

        private void ButtonChange_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    //command.CommandText = @"INSERT INTO Instrument VALUES (@MarkID, @ManufactureYear, @ClassID,
                    //@Name, @Characteristics, @Price, @ProviderID, @ProviderDate)";
                    command.CommandText = @"UPDATE Instrument SET MarkID = @MarkID, ManufactureYear = @ManufactureYear, 
                        ClassID = @ClassID, Name = @Name, Characteristics = @Characteristics, Price = @Price, 
                        ProviderID = @ProviderID, ProvideDate = @ProvideDate WHERE InstrumentID = @InstrumentID";
                    command.Parameters.Add("@InstrumentID", SqlDbType.Int);
                    command.Parameters.Add("@MarkID", SqlDbType.Int);
                    command.Parameters.Add("@ManufactureYear", SqlDbType.Int);
                    command.Parameters.Add("@ClassID", SqlDbType.Int);
                    command.Parameters.Add("@Name", SqlDbType.NVarChar, 250);
                    command.Parameters.Add("@Characteristics", SqlDbType.NVarChar, 250);
                    command.Parameters.Add("@Price", SqlDbType.Decimal, 18);
                    command.Parameters.Add("@ProviderID", SqlDbType.Int);
                    command.Parameters.Add("@ProvideDate", SqlDbType.Date);

                    command.Parameters["@InstrumentID"].Value = TBID.Text;
                    command.Parameters["@MarkID"].Value = Mark;
                    command.Parameters["@ManufactureYear"].Value = TBYear.Text;
                    command.Parameters["@ClassID"].Value = Class;
                    command.Parameters["@Name"].Value = TBName.Text;
                    command.Parameters["@Characteristics"].Value = TBState.Text;
                    command.Parameters["@Price"].Value = TBPrice.Text;
                    command.Parameters["@ProviderID"].Value = Provider;
                    command.Parameters["@ProvideDate"].Value = TBDate.Text;
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вийшло змінити в БД");
                }
            }
        }

        private void ButtonDelete_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlTransaction transaction = connection.BeginTransaction();
                SqlCommand command = new SqlCommand();
                command.Transaction = transaction;
                try
                {                   
                    command.Connection = connection;
                    command.CommandText = @"DELETE Instrument WHERE InstrumentID = @InstrumentID";
                    command.Parameters.Add("@InstrumentID", SqlDbType.Int);

                    command.Parameters["@InstrumentID"].Value = TBID.Text;
                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вийшло видалити з БД." + ex.Message);
                    transaction.Rollback();
                }
                GuitarAmount();
                SetInstruments(allInstruments - 1);
            }
        }

        private void ButtonNumber_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    string sql = @"SELECT Count(*) FROM(SELECT InstrumentID as i, Amount as a, SellDate as s FROM Cheque WHERE Amount > 1 and InstrumentID = @InstrumentID) as p";
                    SqlCommand command = new SqlCommand(sql, connection);
                    command.Parameters.Add("@InstrumentID", SqlDbType.Int);
                    command.Parameters["@InstrumentID"].Value = TBID.Text;
                    MessageBox.Show($"Кількість чеків: {command.ExecuteScalar()}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вийшло повернути значення." + ex.Message);
                }
            }
        }

        private void ButtonProcedure_Click(object sender, EventArgs e)
        {
            string sqlExpression = "ShowMarks";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(sqlExpression, connection);
                    MessageBox.Show($"Кількість марок: {command.ExecuteScalar()}");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вийшло запустити процедуру." + ex.Message);
                }
            }
        }

        private void w(object sender, FormClosedEventArgs e)
        {

        }

        private void ButtonRight_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(TBID.Text) - 1;
            if (currentInstrument == allInstruments - 1) currentInstrument = 0;
            else currentInstrument++;
            SetInstruments(currentInstrument);
        }

        private void ButtonAdd_Click(object sender, EventArgs e)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand();
                    command.Connection = connection;
                    command.CommandText = @"INSERT INTO Instrument VALUES (@MarkID, @ManufactureYear, @ClassID,
                    @Name, @Characteristics, @Price, @ProviderID, @ProvideDate)";
                    command.Parameters.Add("@MarkID", SqlDbType.Int);
                    command.Parameters.Add("@ManufactureYear", SqlDbType.Int);
                    command.Parameters.Add("@ClassID", SqlDbType.Int);
                    command.Parameters.Add("@Name", SqlDbType.NVarChar, 250);
                    command.Parameters.Add("@Characteristics", SqlDbType.NVarChar, 250);
                    command.Parameters.Add("@Price", SqlDbType.Decimal, 18);
                    command.Parameters.Add("@ProviderID", SqlDbType.Int);
                    command.Parameters.Add("@ProvideDate", SqlDbType.Date);

                    command.Parameters["@MarkID"].Value = Mark;
                    command.Parameters["@ManufactureYear"].Value = TBYear.Text;
                    command.Parameters["@ClassID"].Value = Class;
                    command.Parameters["@Name"].Value = TBName.Text;
                    command.Parameters["@Characteristics"].Value = TBState.Text;
                    command.Parameters["@Price"].Value = TBPrice.Text;
                    command.Parameters["@ProviderID"].Value = Provider;
                    command.Parameters["@ProvideDate"].Value = TBDate.Text;                        
                    command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не вийшло додати в БД");
                }
                GuitarAmount();
                SetInstruments(allInstruments - 1);
            }
        }
    }
}
