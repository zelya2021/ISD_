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
    public partial class Books : Form
    {
        int selectedrow;
        const string str = @"Data Source=DESKTOP-86QGR3F;Initial Catalog=LibraryFinal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlConnection = new SqlConnection(str);
        DataSet dataSet = new DataSet();
        SqlCommand cmd;
        SqlDataAdapter dataAdapter;
        DataTable dataTable;
        public Books()
        {
            InitializeComponent();
            Show_table();
            InsertINTO_DUD_Editions();
        }
        private void Show_table()
        {
            sqlConnection.Open();

            string query = "SELECT  Books.id,Books.name, Editions.Name FROM Books INNER JOIN Editions ON Books.edition_id = Editions.id";
            SqlCommand command = new SqlCommand(query, sqlConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[3]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
            }
            reader.Close();

            sqlConnection.Close();

            foreach (string[] s in data)
                DG_Books.Rows.Add(s);
        }
        private void InsertINTO_DUD_Editions()
        {
            sqlConnection.Open();
            Console.WriteLine("Connection open");
            //Выборка данных их БД
            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT Name FROM Editions",
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
                    DomainUpDown.DomainUpDownItemCollection collection = this.DUD_Editions.Items;
                    collection.Add(Lastname);
                }
            }
            sqlConnection.Close();
        }
        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (textBox2.Text == "")
            {
                MessageBox.Show("Please enter values!");
            }
            else
            {
                //lastname
                cmd = new SqlCommand($"SELECT *FROM Books WHERE Name='{textBox2.Text}'", sqlConnection);
                SqlDataAdapter dataAdapter2 = new SqlDataAdapter(cmd);
                dataAdapter2.Fill(dataSet);

                int i = dataSet.Tables[0].Rows.Count;
                if (i > 0)
                {
                    MessageBox.Show($"Already exists");
                    dataSet.Clear();
                }
                else
                {
                    SqlCommand command = new SqlCommand
                    {
                        CommandText = $"INSERT INTO Books (Name,edition_id) " +
                       $"VALUES('{textBox2.Text}','{DUD_Editions.SelectedIndex + 1}')",
                        Connection = sqlConnection
                    };
                    command.ExecuteNonQuery();
                }
                sqlConnection.Close();
                DG_Books.Rows.Clear();
                Show_table();
            }
        }
        private void Btn_Update_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DG_Books.Rows[selectedrow];
            row.Cells[0].Value = label3.Text;
            row.Cells[1].Value = textBox2.Text;

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"UPDATE Books SET Name = '{textBox2.Text}', edition_id='{DUD_Editions.SelectedIndex + 1}'  WHERE id='{label3.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
            textBox2.Clear();
            label3.Text = "";
            DG_Books.Rows.Clear();
            Show_table();
        }
        private void DG_Books_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow row = DG_Books.Rows[selectedrow];
            label3.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int rowindex = DG_Books.CurrentCell.RowIndex;
            DG_Books.Rows.RemoveAt(rowindex);

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"DELETE FROM Books WHERE id='{label3.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
            textBox2.Clear();
            label3.Text = "";
        }
    }
}
