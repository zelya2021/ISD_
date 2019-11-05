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
    public partial class Students : Form
    {
        int selectedrow;
        const string str = @"Data Source=DESKTOP-86QGR3F;Initial Catalog=LibraryFinal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlConnection = new SqlConnection(str);
        DataSet dataSet = new DataSet();
        SqlCommand cmd;
        public Students()
        {
            InitializeComponent();
            Show_table();
            InsertINTO_cb_Group();
        }
        private void Show_table()
        {
            sqlConnection.Open();
            //"SELECT  Books.id,Books.name, Editions.Name FROM Books INNER JOIN Editions ON Books.edition_id = Editions.id";
            string query = "SELECT  Students.id, Students.Lastname, theGroups.Name FROM Students " +
                "INNER JOIN theGroups ON Students.group_id = theGroups.id";
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
                DG_Students.Rows.Add(s);
        }
        private void InsertINTO_cb_Group()
        {
            sqlConnection.Open();
            //Выборка данных их БД
            SqlCommand command = new SqlCommand
            {
                CommandText = "SELECT Name FROM theGroups",
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
                    cb_Group.Items.Add(Lastname);
                }
            }
            sqlConnection.Close();
        }

        private void DG_Students_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow row = DG_Students.Rows[selectedrow];
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
                //lastname
                cmd = new SqlCommand($"SELECT *FROM Books WHERE Name='{label1.Text}'", sqlConnection);
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
                        CommandText = $"INSERT INTO Students (Lastname,group_id) " +
                  $"VALUES('{tbLastname.Text}','{cb_Group.SelectedIndex + 1}')",
                        Connection = sqlConnection
                    };
                    command.ExecuteNonQuery();
                }
               
            }
            sqlConnection.Close();
            tbLastname.Clear();
            label1.Text = "";
            DG_Students.Rows.Clear();
            Show_table();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DG_Students.Rows[selectedrow];
            row.Cells[0].Value = label1.Text;
            row.Cells[1].Value = tbLastname.Text;

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"UPDATE Students SET Lastname = '{tbLastname.Text}', group_id='{cb_Group.SelectedIndex + 1}'  WHERE id='{label1.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
            tbLastname.Clear();
            label1.Text = "";
            DG_Students.Rows.Clear();
            Show_table();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int rowindex = DG_Students.CurrentCell.RowIndex;
            DG_Students.Rows.RemoveAt(rowindex);

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"DELETE FROM Students WHERE id='{label1.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
            tbLastname.Clear();
            label1.Text = "";
        }
    }
}
