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
    public partial class Editions : Form
    {
        int selectedrow;
        const string str = @"Data Source=DESKTOP-86QGR3F;Initial Catalog=LibraryFinal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlConnection = new SqlConnection(str);
        DataSet dataSet = new DataSet();
        SqlCommand cmd;
        public Editions()
        {
            InitializeComponent();
            Show_table();
        }
        private void Show_table()
        {
            sqlConnection.Open();

            string query = "SELECT * FROM Editions ORDER BY Id";

            SqlCommand command = new SqlCommand(query, sqlConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[2]);

                data[data.Count - 1][0] = reader[0].ToString();
                data[data.Count - 1][1] = reader[1].ToString();
            }
            reader.Close();

            sqlConnection.Close();

            foreach (string[] s in data)
                DG_Editions.Rows.Add(s);
        }

        private void DG_Editions_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow row = DG_Editions.Rows[selectedrow];
            label1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
        }

        private void Btn_Insert_Click_1(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if ( textBox2.Text == "")
            {
                MessageBox.Show("Please enter Name and id!");
            }
            else
            {
                cmd = new SqlCommand($"SELECT *FROM Editions WHERE Name='{textBox2.Text}'", sqlConnection);
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(cmd);
                dataAdapter1.Fill(dataSet);

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
                        CommandText = $"INSERT INTO Editions (Name) " +
                         $"VALUES('{textBox2.Text}')",
                        Connection = sqlConnection
                    };
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    DG_Editions.Rows.Add(textBox2.Text);
                    label1.Text = "";
                    textBox2.Clear();
                    DG_Editions.Rows.Clear();
                    Show_table();
                }
                sqlConnection.Close();
            }
        }

        private void Btn_Update_Click_1(object sender, EventArgs e)
        {
            DataGridViewRow row = DG_Editions.Rows[selectedrow];
            row.Cells[0].Value = label1.Text;
            row.Cells[1].Value = textBox2.Text;

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"UPDATE Editions SET Name = '{textBox2.Text}' WHERE id='{label1.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
            label1.Text = "";
            textBox2.Clear();
        }

        private void Btn_Delete_Click_1(object sender, EventArgs e)
        {
            int rowindex = DG_Editions.CurrentCell.RowIndex;
            DG_Editions.Rows.RemoveAt(rowindex);

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"DELETE FROM Editions WHERE id='{label1.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
            label1.Text = "";
            textBox2.Clear();
        }
    }
}

