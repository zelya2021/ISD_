using Exam_Score_Entity_.DB;
using Exam_Score_Entity_.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Exam_Score_Entity_
{
    public partial class Editing : Form
    {
        public Editing()
        {
            InitializeComponent();
            CB_Categories();
            CB_Books();
        }
        private void CB_Categories()
        {
            using (DefaultContext ctx = new DefaultContext())
            {
                foreach (var category in ctx.Categories)
                {
                    cb_category.Items.Add(category);
                }
            }
        }
        private void CB_Books()
        {
            using (DefaultContext ctx = new DefaultContext())
            {
                foreach (var book in ctx.Books)
                {
                    cb_book.Items.Add(book);
                }
            }
        }
        private void Btn_add_Click(object sender, EventArgs e)
        {
            if (cb_book.SelectedIndex >= 0)
            {
                // var category_ = cb_category.SelectedItem as Category;
                var book = cb_book.SelectedItem as Book;

                using (DefaultContext db = new DefaultContext())
                {
                    Category category = new Category { Name = tb_name.Text, Books = new List<Book> { book } };

                    // добавление
                    db.Categories.Add(category);
                    db.SaveChanges();   // сохранение изменений
                }
            }
            cb_category.Items.Clear();
            CB_Categories();
        }

        private void Btn_update_Click(object sender, EventArgs e)
        {

        }
    }
}
