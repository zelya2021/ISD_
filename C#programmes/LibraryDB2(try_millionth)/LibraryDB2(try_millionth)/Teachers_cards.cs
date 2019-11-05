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
    public partial class Teachers_cards : Form
    {
        int selectedrow;
        const string str = @"Data Source=DESKTOP-86QGR3F;Initial Catalog=LibraryFinal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlConnection = new SqlConnection(str);
        DataSet dataSet = new DataSet();
        SqlCommand cmd;
        public Teachers_cards()
        {
            InitializeComponent();
            Show_table();
            InsertINTO_cb_Books();
            InsertINTO_cbTecher();
            InsertINTO_cb_library_employees();
        }
        private void Show_table()
        {
            sqlConnection.Open();

            string query = "SELECT  Teachers_cards.id, Teachers_cards.data_receiving, Teachers_cards.data_return, Books.Name, Teachers.lastname, library_employees.lastname  FROM Teachers_cards " +
                "INNER JOIN Books ON Teachers_cards.book_id = Books.id " +
                "INNER JOIN Teachers ON Teachers_cards.teacher_id = Teachers.id " +
                "INNER JOIN library_employees ON Teachers_cards.library_employees_id = library_employees.id ";
            SqlCommand command = new SqlCommand(query, sqlConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[6]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][2] = reader[2].ToString();
                data[data.Count - 1][3] = reader[3].ToString();
                data[data.Count - 1][4] = reader[4].ToString();
                data[data.Count - 1][5] = reader[5].ToString();
            }
            reader.Close();

            sqlConnection.Close();

            foreach (string[] s in data)
                DG_TeachersCars.Rows.Add(s);
        }
        private void InsertINTO_cb_Books()
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
                    cb_Book.Items.Add(Lastname);
                }
            }
            sqlConnection.Close();
        }
        private void InsertINTO_cbTecher()
        {
            sqlConnection.Open();
            Console.WriteLine("Connection open");
            //Выборка данных их БД
            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT lastname FROM Teachers",
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
                    cbTecher.Items.Add(Lastname);
                }
            }
            sqlConnection.Close();
        }
        private void InsertINTO_cb_library_employees()
        {
            sqlConnection.Open();
            Console.WriteLine("Connection open");
            //Выборка данных их БД
            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT lastname FROM library_employees",
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
                    cb_library_employees.Items.Add(Lastname);
                }
            }
            sqlConnection.Close();
        }
        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if ( tb_data_receiving.Text == "" || tb_data_return.Text == "")
            {
                MessageBox.Show("Please enter values!");
            }
            else
            {
                SqlCommand command = new SqlCommand
                {
                    CommandText = $"INSERT INTO Teachers_cards (data_receiving,data_return,book_id,teacher_id,library_employees_id) " +
                   $"VALUES('{tb_data_return.Text}','{tb_data_receiving.Text}','{cb_Book.SelectedIndex + 1}','{cbTecher.SelectedIndex + 1}','{cb_library_employees.SelectedIndex + 1}')",
                    Connection = sqlConnection
                };
                command.ExecuteNonQuery();
            }
            sqlConnection.Close();
            DG_TeachersCars.Rows.Clear();
            Show_table();
        }

        private void DG_TeachersCars_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow row = DG_TeachersCars.Rows[selectedrow];
            label1.Text = row.Cells[0].Value.ToString();
            tb_data_receiving.Text = row.Cells[1].Value.ToString();
            tb_data_return.Text = row.Cells[2].Value.ToString();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DG_TeachersCars.Rows[selectedrow];
            row.Cells[0].Value = label1.Text;
            row.Cells[1].Value = tb_data_receiving.Text;
            row.Cells[2].Value = tb_data_return.Text;

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"UPDATE Teachers_cards SET data_receiving = '{tb_data_receiving.Text}', data_return = '{tb_data_return.Text}', book_id='{cb_Book.SelectedIndex + 1}',teacher_id='{cbTecher.SelectedIndex + 1}',library_employees_id='{cb_library_employees.SelectedIndex + 1}'  WHERE id='{label1.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
            label1.Text = "";
            tb_data_receiving.Clear();
            tb_data_return.Clear();
            DG_TeachersCars.Rows.Clear();
            Show_table();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int rowindex = DG_TeachersCars.CurrentCell.RowIndex;
            DG_TeachersCars.Rows.RemoveAt(rowindex);

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"DELETE FROM Teachers_cards WHERE id='{label1.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
            label1.Text = "";
            tb_data_receiving.Clear();
            tb_data_return.Clear();
        }
    }
}
