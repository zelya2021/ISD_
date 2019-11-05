using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace LibraryDB2_try_millionth_
{
    public partial class Form1 : Form
    {
        const string str = @"Data Source=DESKTOP-86QGR3F;Initial Catalog=LibraryFinal;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
        SqlConnection sqlConnection = new SqlConnection(str);
        public Form1()
        {
            InitializeComponent();
        }

        private void Btn_Autors_Click(object sender, EventArgs e)
        {
            DB_Library_2_tryOne_.Autors autors = new DB_Library_2_tryOne_.Autors();
            autors.ShowDialog();
            autors.Close();
        }

        private void Btn_Editions_Click(object sender, EventArgs e)
        {
            Editions editions = new Editions();
            editions.ShowDialog();
            editions.Close();
        }

        private void Btn_Books_Click(object sender, EventArgs e)
        {
            Books books = new Books();
            books.ShowDialog();
            books.Close();
        }

        private void Btn_Books_Autors_Click(object sender, EventArgs e)
        {
            Books_Autors books_Autors = new Books_Autors();
            books_Autors.ShowDialog();
            books_Autors.Close();
        }

        private void Btn_Library_employees_Click(object sender, EventArgs e)
        {
            Library_employees library_Employees = new Library_employees();
            library_Employees.ShowDialog();
            library_Employees.Close();
        }

        private void Btn_Positions_Click(object sender, EventArgs e)
        {
            Positions positions = new Positions();
            positions.ShowDialog();
            positions.Close();
        }

        private void Btn_theGroups_Click(object sender, EventArgs e)
        {
            theGroups groups = new theGroups();
            groups.ShowDialog();
            groups.Close();
        }

        private void Btn_Students_Click(object sender, EventArgs e)
        {
            Students students = new Students();
            students.ShowDialog();
            students.Close();
        }

        private void Btn_Teachers_Click(object sender, EventArgs e)
        {
            Teachers teachers = new Teachers();
            teachers.ShowDialog();
            teachers.Close();
        }

        private void Btn_Students_cards_Click(object sender, EventArgs e)
        {
            Students_cards students_Cards = new Students_cards();
            students_Cards.ShowDialog();
            students_Cards.Close();
        }

        private void Btn_Teachers_cards_Click(object sender, EventArgs e)
        {
            Teachers_cards teachers_Cards = new Teachers_cards();
            teachers_Cards.ShowDialog();
            teachers_Cards.Close();
        }
    }
}
