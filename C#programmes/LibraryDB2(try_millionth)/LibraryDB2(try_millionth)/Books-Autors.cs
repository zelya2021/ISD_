using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LibraryDB2_try_millionth_
{
    public partial class Books_Autors : Form
    {
        int selectedrow;
        List<string[]> data;
        const string str = @"Data Source=DESKTOP-86QGR3F;Initial Catalog=LibraryFinal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlConnection = new SqlConnection(str);
        DataSet dataSet = new DataSet();
        SqlCommand cmd;
        public Books_Autors()
        {
            InitializeComponent();
            Show_table();
            InsertINTO_DUD_BooksBA();
            InsertINTO_DUD_AutorsBA();
        }
        private void InsertINTO_DUD_BooksBA()
        {
            sqlConnection.Open();
            Console.WriteLine("Connection open");
            //Выборка данных их БД
            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT Name FROM Books",
                Connection = sqlConnection
            };

            //Выполнение запроса к БД
            SqlDataReader reader = command.ExecuteReader();

            //Если есть данные в выборке
            if (reader.HasRows)
            {
                //перебор результата выборки
                while (reader.Read())
                {
                    object Lastname = reader.GetValue(0);
                    //DomainUpDown.DomainUpDownItemCollection collection = this.DUD_BooksBA.Items;
                    //collection.Add(Lastname);
                    CB_BooksBA.Items.Add(Lastname);
                }
            }
            sqlConnection.Close();
        }
        private void InsertINTO_DUD_AutorsBA()
        {
            sqlConnection.Open();
            Console.WriteLine("Connection open");
            //Выборка данных их БД
            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT Lastname FROM Autors",
                Connection = sqlConnection
            };

            //Выполнение запроса к БД
            SqlDataReader reader = command.ExecuteReader();

            //Если есть данные в выборке
            if (reader.HasRows)
            {
                //перебор результата выборки
                while (reader.Read())
                {
                    object Lastname = reader.GetValue(0);
                    CB_AutorsBA.Items.Add(Lastname);
                }
            }
            sqlConnection.Close();
        }
        private void Show_table()
        {
            sqlConnection.Open();
            // "SELECT  Books.id,Books.name, Editions.Name FROM Books INNER JOIN Editions ON Books.edition_id = Editions.id";
            string query = "SELECT  Books_Autors.id, Autors.Lastname, Books.Name FROM Books_Autors " +
                "INNER JOIN Autors ON Books_Autors.autor_id = Autors.id " +
                "INNER JOIN Books ON Books_Autors.books_id = Books.id";
            SqlCommand command = new SqlCommand(query, sqlConnection);

            SqlDataReader reader = command.ExecuteReader();

            data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][0] = reader[0].ToString();
            }
            reader.Close();

            sqlConnection.Close();

            foreach (string[] s in data)
                DG_Books_Autors.Rows.Add(s);
        }
        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"INSERT INTO Books_Autors (autor_id,books_id) " +
                     $"VALUES('{CB_AutorsBA.SelectedIndex + 1}','{CB_BooksBA.SelectedIndex + 1}')",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();

            sqlConnection.Close();
            DG_Books_Autors.Rows.Clear();
            Show_table();
        }
        private void Btn_Update_Click(object sender, EventArgs e)
            {
                DataGridViewRow row = DG_Books_Autors.Rows[selectedrow];
                row.Cells[0].Value = label1.Text;
                row.Cells[1].Value = CB_AutorsBA.SelectedItem;
                row.Cells[2].Value = CB_BooksBA.SelectedItem;

                sqlConnection.Open();
                SqlCommand command = new SqlCommand
                {
                    CommandText = $"UPDATE Books_Autors SET autor_id = '{CB_AutorsBA.SelectedIndex + 1}', books_id='{CB_BooksBA.SelectedIndex + 1}'  WHERE id='{label1.Text}'",
                    Connection = sqlConnection
                };
            ;
                command.ExecuteNonQuery();
                sqlConnection.Close();
            label1.Text = "";
            }

        private void DG_Books_Autors_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow row = DG_Books_Autors.Rows[selectedrow];
            label1.Text = row.Cells[0].Value.ToString();
            //CB_AutorsBA.SelectedText = row.Cells[1].Value.ToString();
            //CB_BooksBA.SelectedText = row.Cells[2].Value.ToString();

        }

        private void Btn_Delete_Click_1(object sender, EventArgs e)
        {
            int rowindex = DG_Books_Autors.CurrentCell.RowIndex;
            DG_Books_Autors.Rows.RemoveAt(rowindex);

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"DELETE FROM Books_Autors WHERE id='{label1.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }
    }
}

    

