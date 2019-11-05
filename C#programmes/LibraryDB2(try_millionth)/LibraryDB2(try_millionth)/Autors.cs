using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DB_Library_2_tryOne_
{
    public partial class Autors : Form
    {
        int selectedrow;
        const string str = @"Data Source=DESKTOP-86QGR3F;Initial Catalog=LibraryFinal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlConnection = new SqlConnection(str);
        DataSet dataSet = new DataSet();
        // SqlCeCommand cmd;
        SqlCommand cmd;
        public Autors()
        {
            InitializeComponent();
            Show_table();
        }
        private void Show_table()
        {
            sqlConnection.Open();

            string query = "SELECT * FROM Autors ORDER BY Id";

            SqlCommand command = new SqlCommand(query, sqlConnection);

            SqlDataReader reader = command.ExecuteReader();

            List<string[]> data = new List<string[]>();

            while (reader.Read())
            {
                data.Add(new string[2]);

                data[data.Count - 1][1] = reader[1].ToString();
                data[data.Count - 1][0] = reader[0].ToString();
            }
            reader.Close();

            sqlConnection.Close();

            foreach (string[] s in data)
                DG_Autors.Rows.Add(s);
        }

        private void Btn_Insert_Click_1(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if (tb_lastname.Text == "")
            {
                MessageBox.Show("Please enter Name!");
            }
            else
            {
                cmd = new SqlCommand($"SELECT *FROM Autors WHERE Lastname='{tb_lastname.Text}'", sqlConnection);
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
                        CommandText = $"INSERT INTO Autors (Lastname) " +
                         $"VALUES('{tb_lastname.Text}')",
                        Connection = sqlConnection
                    };
                    command.ExecuteNonQuery();
                    sqlConnection.Close();
                    DG_Autors.Rows.Add( tb_lastname.Text);
                    tb_lastname.Clear();
                    DG_Autors.Rows.Clear();
                    Show_table();
            }
                sqlConnection.Close();
            }
        }

        private void Btn_Update_Click_1(object sender, EventArgs e)
        {

            DataGridViewRow row = DG_Autors.Rows[selectedrow];
            row.Cells[1].Value = tb_lastname.Text;

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"UPDATE Autors SET Lastname= '{tb_lastname.Text}' WHERE id='{label1.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
            tb_lastname.Clear();
            label1.Text="";
            DG_Autors.Rows.Clear();
            Show_table();
        }

        private void Btn_Delete_Click_1(object sender, EventArgs e)
        {
            int rowindex = DG_Autors.CurrentCell.RowIndex;
            DG_Autors.Rows.RemoveAt(rowindex);

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"DELETE FROM Autors WHERE id='{label1.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
            tb_lastname.Clear();
            label1.Text = "";
        }

        private void DG_Autors_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow row = DG_Autors.Rows[selectedrow];
            tb_lastname.Text = row.Cells[1].Value.ToString();
            label1.Text = row.Cells[0].Value.ToString();
        }
    }
}
