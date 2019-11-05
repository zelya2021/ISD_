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
    public partial class theGroups : Form
    {
        int selectedrow;
        const string str = @"Data Source=DESKTOP-86QGR3F;Initial Catalog=LibraryFinal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlConnection = new SqlConnection(str);
        DataSet dataSet = new DataSet();
        SqlCommand cmd;
        public theGroups()
        {
            InitializeComponent();
            Show_table();
        }
        private void Show_table()
        {
            sqlConnection.Open();

            string query = "SELECT * FROM theGroups ORDER BY Id";
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
                DG_Groups.Rows.Add(s);
        }

        private void DG_Groups_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow row = DG_Groups.Rows[selectedrow];
            label1.Text = row.Cells[0].Value.ToString();
            tbName.Text = row.Cells[1].Value.ToString();
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
                    CommandText = $"INSERT INTO theGroups (Name) " +
                       $"VALUES('{tbName.Text}')",
                    Connection = sqlConnection
                };
                command.ExecuteNonQuery();
                sqlConnection.Close();
                DG_Groups.Rows.Clear();
                label1.Text = "";
                tbName.Clear();
                Show_table();
                DG_Groups.Rows.Clear();
                Show_table();
            }
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DG_Groups.Rows[selectedrow];
            row.Cells[0].Value = label1.Text;
            row.Cells[1].Value = tbName.Text;

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"UPDATE theGroups SET Name = '{tbName.Text}' WHERE id='{label1.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
            label1.Text = "";
            tbName.Clear();
            DG_Groups.Rows.Clear();
            Show_table();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int rowindex = DG_Groups.CurrentCell.RowIndex;
            DG_Groups.Rows.RemoveAt(rowindex);

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"DELETE FROM theGroups WHERE id='{label1.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
            label1.Text = "";
            tbName.Clear();
        }
    }
}
