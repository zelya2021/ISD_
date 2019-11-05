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
    public partial class Teachers : Form
    {
        int selectedrow;
        const string str = @"Data Source=DESKTOP-86QGR3F;Initial Catalog=LibraryFinal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlConnection = new SqlConnection(str);
        DataSet dataSet = new DataSet();
        SqlCommand cmd;
        public Teachers()
        {
            InitializeComponent();
            Show_table();
            InsertINTO_cb_Position();
        }
        private void Show_table()
        {
            sqlConnection.Open();

            string query = "SELECT  Teachers.id,Teachers.lastname, Positions.name FROM Teachers " +
                "INNER JOIN Positions ON Teachers.position_id = Positions.id";
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
                DG_Teachers.Rows.Add(s);
        }
        private void InsertINTO_cb_Position()
        {
            sqlConnection.Open();
            Console.WriteLine("Connection open");
            //Выборка данных их БД
            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT Name FROM Positions",
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
                    cb_Position.Items.Add(Lastname);
                }
            }
            sqlConnection.Close();
        }

        private void DG_Teachers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow row = DG_Teachers.Rows[selectedrow];
            label1.Text = row.Cells[0].Value.ToString();
            tbLastname.Text = row.Cells[1].Value.ToString();
        }

        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if ( tbLastname.Text == "")
            {
                MessageBox.Show("Please enter values!");
            }
            else
            {
                cmd = new SqlCommand($"SELECT *FROM Autors WHERE Lastname='{label1.Text}'", sqlConnection);
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
                        CommandText = $"INSERT INTO Teachers (lastname,position_id) " +
                  $"VALUES('{tbLastname.Text}','{cb_Position.SelectedIndex + 1}')",
                        Connection = sqlConnection
                    };
                    command.ExecuteNonQuery();
                }
            }
            sqlConnection.Close();
            label1.Text = "";
            tbLastname.Clear();
            DG_Teachers.Rows.Clear();
            Show_table();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DG_Teachers.Rows[selectedrow];
            row.Cells[0].Value = label1.Text;
            row.Cells[1].Value = tbLastname.Text;

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"UPDATE Teachers SET lastname = '{tbLastname.Text}', position_id='{cb_Position.SelectedIndex + 1}'  WHERE id='{label1.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
            label1.Text = "";
            tbLastname.Clear();
            DG_Teachers.Rows.Clear();
            Show_table();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int rowindex = DG_Teachers.CurrentCell.RowIndex;
            DG_Teachers.Rows.RemoveAt(rowindex);

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"DELETE FROM Teachers WHERE id='{label1.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
            label1.Text = "";
            tbLastname.Clear();
        }

    }
}
