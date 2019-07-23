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
            CB_BooksForBook();
            CB_CategoriesForBook();
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
        private void CB_BooksForBook()
        {
            using (DefaultContext ctx = new DefaultContext())
            {
                foreach (var book in ctx.Books)
                {
                    comboBox_book.Items.Add(book);
                }
            }
        }
        private void CB_CategoriesForBook()
        {
            using (DefaultContext ctx = new DefaultContext())
            {
                foreach (var category in ctx.Categories)
                {
                    comboBoxCategory.Items.Add(category);
                }
            }
        }
        private void Btn_add_Click(object sender, EventArgs e)
        {
            if (cb_book.SelectedIndex >= 0)
            {
                var book = cb_book.SelectedItem as Book;

                using (DefaultContext db = new DefaultContext())
                {
                        var categories = db.Categories.Include(b => b.Books).ToList();
                        Category category_ = null;
                        foreach (var cat in categories)
                        {
                            if (cat.Name == tb_name.Text.ToString()) category_ = cat;
                        }
                        if (category_ != null)
                        {
                            MessageBox.Show("Сategory already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            Book book_ = null;
                            var books = db.Books.ToList();
                            foreach (var b in books)
                            {
                                if (b.Name == book.Name) book_ = b;
                            }
                            Category category = new Category { Name = tb_name.Text, Books = new List<Book> { book_ } };
                            // добавление
                            db.Categories.Add(category);
                            db.SaveChanges();   // сохранение изменений
                            MessageBox.Show("Successfully");
                        }
                }
            }
            else
            {
                MessageBox.Show("The book hasn't been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            cb_category.Items.Clear();
            CB_Categories();
        }
        private void Btn_update_Click(object sender, EventArgs e)
        {
            if (cb_category.SelectedIndex >= 0)
            {
                using (DefaultContext db = new DefaultContext())
                {
                    var select_category = cb_category.SelectedItem as Category;
                    var categories = db.Categories.Include(b => b.Books).ToList();
                    foreach (var item in categories)
                    {
                        if (item.Name == select_category.Name)
                        {
                            item.Name = tb_name.Text;//возможность добавлять несколько книг в 1 кат не раб
                        }
                    }
                    db.SaveChanges();
                    MessageBox.Show("Successfully");
                }
            }
            else
            {
                MessageBox.Show("The category hasn't been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (cb_category.SelectedIndex >= 0)
            {
                using (DefaultContext db = new DefaultContext())
                {
                    Category cat = null;
                    var categories = db.Categories.Include(b => b.Books).ToList();
                    var select_category = cb_category.SelectedItem as Category;
                    foreach (var item in categories)
                    {
                        if (item.Name == select_category.Name) cat = item;
                    }
                    db.Categories.Remove(cat);
                    db.SaveChanges();
                    MessageBox.Show("Successfully");
                }
            }
            else MessageBox.Show("The category hasn't been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Btn_addbook_Click(object sender, EventArgs e)
        {
            if (comboBoxCategory.SelectedIndex >= 0)
            {
                var selectedcategory = comboBoxCategory.SelectedItem as Category;
                using (DefaultContext db = new DefaultContext())
                {
                    var books = db.Books.ToList();
                    Book book = null;
                    foreach (var b in books)
                    {
                        if (b.Name == tb_name.Text.ToString()) book = b;
                    }
                    if (book != null)
                    {
                        MessageBox.Show("Book already exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        Category category = null;
                        var categories = db.Categories.ToList();
                        foreach (var item in categories)
                        {
                            if (item.Name == selectedcategory.Name) category = item;
                        }
                        Book b = new Book
                        {
                            Name = tb_name_book.Text,
                            Autor = tb_autor.Text,
                            Price = Convert.ToDecimal(tb_price.Text),
                            Categories = new List<Category> { category }
                        };
                        db.Books.Add(b);
                        db.SaveChanges();
                        MessageBox.Show("Successfully");
                    }
                }
            }
            else MessageBox.Show("The category hasn't been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Btn_udate_book_Click(object sender, EventArgs e)
        {
            using (DefaultContext db = new DefaultContext())
            {
                if (comboBox_book.SelectedIndex >= 0)
                {
                    var select_book = comboBox_book.SelectedItem as Book;
                    var select_category = comboBoxCategory.SelectedItem as Category;
                    var books = db.Books.ToList();
                    Book book = null;
                    foreach (var item in books)
                    {
                        if (item.Name == select_book.Name)
                        {
                            book = item;
                        }
                    }
                    book.Name = tb_name_book.Text;
                    book.Autor = tb_autor.Text;
                    book.Price = Convert.ToDecimal(tb_price.Text);
                    //book.Categories = new List<Category> { select_category };//no
                    db.SaveChanges();
                    MessageBox.Show("Successfully");
                }
            }
        }
        private void Btn_additionally_Click(object sender, EventArgs e)
        {
            if (comboBox_book.SelectedIndex >= 0)
            {
                var book = comboBox_book.SelectedItem as Book;
                tb_name_book.Text = book.Name;
                tb_autor.Text = book.Autor;
                tb_price.Text =book.Price.ToString();
                MessageBox.Show("Successfully");
            }
            else MessageBox.Show("The book hasn't been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        private void Btn_delete_book_Click(object sender, EventArgs e)
        {
            if (comboBox_book.SelectedIndex >= 0)
            {
                using (DefaultContext db = new DefaultContext())
                {
                    Book book = null;
                    var books = db.Books.ToList();
                    var select_book = comboBox_book.SelectedItem as Book;
                    foreach (var item in books)
                    {
                        if (item.Name == select_book.Name)
                        {
                            book = item;
                        }
                    }
                    db.Books.Remove(book);
                    // db.Books.Remove(db.Books.Where(b=>b.Name== select_book.Name)as Book);
                    db.SaveChanges();
                    MessageBox.Show("Successfully");
                }
            }
            else MessageBox.Show("The book hasn't been selected", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
