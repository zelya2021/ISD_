using CandyStore.Forms;
using CandyStore.Models;
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
    /// Логика взаимодействия для AddDessert.xaml
    /// </summary>
    public partial class AddDessert : Window
    {
        public Dessert dessert { get; set; } = new Dessert("", "", "", 0, null);
        UserControlDesserts user;
        public AddDessert()
        {
            InitializeComponent();
        }
        public AddDessert(UserControlDesserts mainWindow)
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
                dessert.Image = dlg.FileName;
            }
        }
        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            dessert.Name = tb_name.Text;
            dessert.Category = tb_category.Text;
            dessert.Description = tb_description.Text;
            dessert.Price = Convert.ToDecimal(tb_price.Text);
            user.Add(dessert);
        }
    }
}
