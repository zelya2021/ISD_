using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exam_Score_Entity_
{
    public partial class Admin : Form
    {
        private string login = /*"Jimmy"*/"1";
        private string password = /*"albatross"*/"2";
        public Admin()
        {
            InitializeComponent();
        }
        private void Btn_Ok_Click(object sender, EventArgs e)
        {
            if (tb_login.Text == login && tb_password.Text == password)
            {
                Editing form = new Editing();
                form.Show();
            }
            else MessageBox.Show("Invalid login or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
