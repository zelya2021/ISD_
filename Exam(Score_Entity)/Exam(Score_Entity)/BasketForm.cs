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
    public partial class BasketForm : Form
    {
        public BasketForm()
        {
            InitializeComponent();
            Show();
        }
        public void Show()
        {
            using (DefaultContext db = new DefaultContext())
            {
                dataGridView.Rows.Clear();
                var baskets = db.Baskets.Include(b => b.Books).ToList();
                foreach (var basket in baskets)
                {
                    dataGridView.Rows.Add(basket.Books.Name, basket.Books.Autor, basket.Books.Price);
                }
            }

        }
        private void Btn_delete_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedCells.Count > 0)
            {
                int selectedrowindex = dataGridView.SelectedCells[0].RowIndex;
                DataGridViewCell name = dataGridView.Rows[selectedrowindex].Cells[0];

                using (DefaultContext db = new DefaultContext())
                {
                    var baskets = db.Baskets.Include(b => b.Books).ToList();
                    //Basket basket = db.Baskets.FirstOrDefault();//no caching
                    //var basket = baskets.Where(bask => bask.Books.Name == name.Value.ToString());
                    Basket basket_ = null;
                    foreach (var basket in baskets)
                    {
                        if (basket.Books.Name == name.Value.ToString()) basket_ = basket;
                    }
                    if (baskets.Count != 0)
                    {
                        db.Baskets.Remove(basket_);
                        db.SaveChanges();
                    }
                    else MessageBox.Show("Basket is empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    Show();
                }
            }
        }
    }
}
