using CandyStore.Models;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CandyStore.UserControls
{
    public partial class UserControlCategories : UserControl
    {
        public ObservableCollection<Category> Categories { get; set; } = new ObservableCollection<Category>();
        public Category category { get; set; } = new Category("", "");
        public UserControlCategories()
        {
            InitializeComponent();
            DataContext = this;

            string[] imagesForcategory = new string[]
              {
                    "http://pngimg.com/uploads/cake/cake_PNG13143.png",
                    "https://img.lovepik.com/element/40032/0596.png_860.png"
              };
            Categories.Add(new Category
            {
                Name = "Шоколадные десерты",
                Image = imagesForcategory[1]
            });
            Categories.Add(new Category
            {
                Name = "Торты",
                Image = imagesForcategory[0]
            });
        }
        private void Btn_delete_Click(object sender, RoutedEventArgs e)
        {
            Categories.Remove(lbCategory.SelectedItem as Category);
        }

        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            AddCategory user = new AddCategory(this);
            user.ShowDialog();
            user.Close();
        }
        public void Add(Category category)
        {
            Categories.Add(category);
        }

        private void Image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (lbCategory.SelectedIndex != -1)
            {
                Category category = lbCategory.SelectedItem as Category;
                LoadImage(category);
            }
        }
        private void LoadImage(Category c)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "Images:|*.png;*.jpg;*.jpeg"
            };

            if (dlg.ShowDialog() == true)
            {
                c.Image = dlg.FileName;
            }
        }
    }
}
