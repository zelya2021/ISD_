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
    public partial class Positions : Form
    {
        int selectedrow;
        const string str = @"Data Source=DESKTOP-86QGR3F;Initial Catalog=LibraryFinal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlConnection = new SqlConnection(str);
        DataSet dataSet = new DataSet();
        // SqlCeCommand cmd;
        SqlCommand cmd;
        public Positions()
        {
            InitializeComponent();
            Show_table();
        }
        private void Show_table()
        {
            sqlConnection.Open();

            string query = "SELECT * FROM Positions ORDER BY Id";
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
                DG_Positions.Rows.Add(s);
        }
        private void Btn_Insert_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if ( tbName.Text == "")
            {
                MessageBox.Show("Please enter values!");
            }
            else
            {
                SqlCommand command = new SqlCommand
                {
                    CommandText = $"INSERT INTO Positions (name) " +
                     $"VALUES('{tbName.Text}')",
                    Connection = sqlConnection
                };
                command.ExecuteNonQuery();
                sqlConnection.Close();
                DG_Positions.Rows.Add(tbName.Text);
                tbName.Clear();
                label1.Text = "";
            }
            sqlConnection.Close();
            DG_Positions.Rows.Clear();
            Show_table();
        }

        private void DG_Positions_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow row = DG_Positions.Rows[selectedrow];
            label1.Text = row.Cells[0].Value.ToString();
            tbName.Text = row.Cells[1].Value.ToString();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DG_Positions.Rows[selectedrow];
            row.Cells[0].Value = label1.Text;
            row.Cells[1].Value = tbName.Text;

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"UPDATE Positions SET Name = '{tbName.Text}' WHERE id='{label1.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
            label1.Text = "";
            tbName.Clear();
            DG_Positions.Rows.Clear();
            Show_table();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int rowindex = DG_Positions.CurrentCell.RowIndex;
            DG_Positions.Rows.RemoveAt(rowindex);

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"DELETE FROM Positions WHERE id='{label1.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
            label1.Text = "";
            tbName.Clear();
        }
    }
}
