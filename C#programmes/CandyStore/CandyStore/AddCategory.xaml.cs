using CandyStore.Models;
using CandyStore.UserControls;
using Microsoft.Win32;
using System;
using System.Collections.Generic;
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
using System.Windows.Shapes;

namespace CandyStore
{
    /// <summary>
    /// Логика взаимодействия для AddCategory.xaml
    /// </summary>
    public partial class AddCategory : Window
    {
        public Category category = new Category("", "");
        UserControlCategories user;
        public AddCategory()
        {
            InitializeComponent();
        }
        public AddCategory(UserControlCategories mainWindow)
        {
            InitializeComponent();
            user = mainWindow;
        }
        private void Tb_image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "Images:|*.png;*.jpg;*.jpeg"
            };

            if (dlg.ShowDialog() == true)
            {
                category.Image = dlg.FileName;
            }
        }
        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            category.Name = tb_name.Text;
            user.Add(category);
        }
    }
}
