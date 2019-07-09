using Exam_Score_Entity_.DB;
using Exam_Score_Entity_.Models;
using System;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Exam_Score_Entity_
{
    public partial class Form1 : Form
    {
        static Form1()
        {
            //иницилизатор для БД
            Database.SetInitializer(new DefaultInitializer());
        }
        public Form1()
        {
            InitializeComponent();
            pictureBox.Image = Image.FromFile("basket1.png");
            CB_Categories();
            CB_Name();
            CB_Price();
            ListBooks();
            //Editing form = new Editing();
            //form.ShowDialog();
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
        private void CB_Name()
        {
            using (DefaultContext ctx = new DefaultContext())
            {
                foreach (var book in ctx.Books)
                {
                    cb_name.Items.Add(book);
                }
            }
        }
        private void CB_Price()
        {
            using (DefaultContext ctx = new DefaultContext())
            {
                foreach (var book in ctx.Books)
                {
                    cb_price.Items.Add(book.Price);
                }
            }
        }
        private void ListBooks()
        {
            using (DefaultContext ctx = new DefaultContext())
            {
                var books = ctx.Books.AsNoTracking();
                foreach (var book in books)
                {
                   // listBox1.Items.Add(book.Name);
                }
            }
        }
        private void Cb_category_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_category.SelectedIndex >= 0)
            {
                var category = cb_category.SelectedItem as Category;
                using (DefaultContext ctx = new DefaultContext())
                {
                    var books = ctx.Books.ToList()
                        .Where(book => book.Categories.Any(cat => cat.Id == category.Id));

                    dataGridView.Rows.Clear();
                    foreach (var book in books)
                    {
                        dataGridView.Rows.Add(book.Name, book.Autor, book.Price, category);
                    }
                }
            }
        }
        private void Cb_name_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_name.SelectedIndex >= 0)
            {
                var book = cb_name.SelectedItem as Book;
                using (DefaultContext ctx = new DefaultContext())
                {
                    var categories = ctx.Categories.ToList()
                        .Where(cat => cat.Books.Any(b => b.Name == book.Name));

                    dataGridView.Rows.Clear();
                    foreach (var cat in categories)
                    {
                        dataGridView.Rows.Add(book.Name, book.Autor, book.Price, cat.Name);
                    }
                }
            }
        }
        private void Cb_price_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_price.SelectedIndex >= 0)
            {
                decimal price = Convert.ToDecimal(cb_price.SelectedItem);
                using (DefaultContext ctx = new DefaultContext())
                {
                    //var book = ctx.Books.ToList().Where(b => b.Price== price)/* as Book*/;

                    //var categories = ctx.Categories.ToList()
                    //    .Where(cat => cat.Books.Any(b => b.Price == price));

                    //dataGridView.Rows.Clear();
                    //foreach (var cat in categories)
                    //{
                    //    dataGridView.Rows.Add(book.Name, book.Autor, book.Price, cat.Name);
                    //}
                    ;
                    ;
                }
            }
        }//---
        private void Btn_addTObasket_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView.SelectedCells[0].RowIndex;
                DataGridViewCell name = dataGridView.Rows[selectedrowindex].Cells[0];

                //AddToBasket
                using (DefaultContext db = new DefaultContext())
                {
                    //var books = db.Books.ToList().Where(b => b.Name==name.Value.ToString()) as Book;
                    var books = db.Books.ToList();
                    Book book_ = null;
                    foreach (var book in books)
                    {
                        if (book.Name == name.Value.ToString()) book_ = book;
                    }
                    Basket basket = new Basket { Books = book_ };
                    // добавление
                    db.Baskets.Add(basket);
                    db.SaveChanges();   // сохранение изменений
                    MessageBox.Show("Successfully added");
                }
            }
        }
        private void PictureBox_Click(object sender, EventArgs e)
        {
            BasketForm form = new BasketForm();
            form.ShowDialog();
        }
        private void Btn_admin_Click(object sender, EventArgs e)
        {
            Admin form = new Admin();
            form.ShowDialog();
        }
    }
}
