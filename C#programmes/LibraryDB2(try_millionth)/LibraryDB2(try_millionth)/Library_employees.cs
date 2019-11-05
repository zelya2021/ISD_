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
    public partial class Library_employees : Form
    {
        int selectedrow;
        const string str = @"Data Source=DESKTOP-86QGR3F;Initial Catalog=LibraryFinal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlConnection = new SqlConnection(str);
        DataSet dataSet = new DataSet();
        SqlCommand cmd;
        public Library_employees()
        {
            InitializeComponent();
            Show_table();
        }
        private void Show_table()
        {
            sqlConnection.Open();

            string query = "SELECT * FROM library_employees ORDER BY Id";
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
                DG_LibraryEmployeers.Rows.Add(s);
        }

        private void DG_LibraryEmployeers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            selectedrow = e.RowIndex;
            DataGridViewRow row = DG_LibraryEmployeers.Rows[selectedrow];
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
                    SqlCommand command = new SqlCommand
                    {
                        CommandText = $"INSERT INTO library_employees (lastname) " +
                       $"VALUES('{tbLastname.Text}')",
                        Connection = sqlConnection
                    };
                    command.ExecuteNonQuery();
                }
                sqlConnection.Close();
                DG_LibraryEmployeers.Rows.Clear();
                Show_table();
            tbLastname.Clear();
            label1.Text = "";
            DG_LibraryEmployeers.Rows.Clear();
            Show_table();
        }

        private void Btn_Update_Click(object sender, EventArgs e)
        {
            DataGridViewRow row = DG_LibraryEmployeers.Rows[selectedrow];
            row.Cells[0].Value = label1.Text;
            row.Cells[1].Value = tbLastname.Text;

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"UPDATE library_employees SET lastname='{tbLastname.Text}'  WHERE id='{label1.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
            tbLastname.Clear();
            label1.Text = "";
            DG_LibraryEmployeers.Rows.Clear();
            Show_table();
        }

        private void Btn_Delete_Click(object sender, EventArgs e)
        {
            int rowindex = DG_LibraryEmployeers.CurrentCell.RowIndex;
            DG_LibraryEmployeers.Rows.RemoveAt(rowindex);

            sqlConnection.Open();
            SqlCommand command = new SqlCommand
            {
                CommandText = $"DELETE FROM library_employees WHERE id='{label1.Text}'",
                Connection = sqlConnection
            };
            command.ExecuteNonQuery();
            sqlConnection.Close();
            tbLastname.Clear();
            label1.Text = "";
        }
    }
}
