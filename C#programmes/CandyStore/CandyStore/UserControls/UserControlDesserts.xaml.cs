using CandyStore.Models;
using CandyStore.UserControls;
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

namespace CandyStore.Forms
{
    /// <summary>
    /// Логика взаимодействия для UserControlCategory.xaml
    /// </summary>
    public partial class UserControlDesserts : UserControl
    {
        public ObservableCollection<Dessert> Desserts { get; set; } = new ObservableCollection<Dessert>();
        public Dessert dessert { get; set; } = new Dessert("","", "",0, null);
        public UserControlDesserts()
        {
            InitializeComponent();
            DataContext = this;
          

            string[] images = new string[]
                {
                    "https://ua.all.biz/img/ua/catalog/8987096.png",
                    "http://www.petrodiet.ru/image/data/7.png",
                    "https://www.koolinar.ru/all_image/enciclopedias/1/1448/enc-e932e0a9-f34c-4387-bee4-575d50ec3eb3_large.png",
                    "https://ua.all.biz/img/ua/catalog/13103797.png"
                };
           // Category c1 = null, c2 = null;
            Dessert d1=new Dessert
            {
                Name = "Шоколадный фондан",
                Image = images[0],
                Description = "Французский запеченный шоколадный десерт,с жидким шоколадом внутри и на 75% состоящий из шоколада.\nСладкоежкам понравится не применено.",
                Price = 120,
                Category = "Шоколадные десерты"
            };
            Dessert d2 = new Dessert
            {
                Name = "Брауни",
                Image = images[1],
                Description = "Нежнейшее шоколадное лакомство с влажной начинкой.",
                Price = 100,
                Category = "Шоколадные десерты"
            };
            Dessert d3 = new Dessert
            {
                Name = "Прага",
                Image = images[2],
                Description = "Классический рецепт нежного, сочного, шоколадного бисквита, который много десятилетий пользуется огромным успехом.",
                Price = 450,
                Category = "Торты"
            };
            Dessert d4 = new Dessert
            {
                Name = "Наполеон",
                Image = images[3],
                Description = "Это, наверное, самый популярный торт в мире, который нравится многим. Традиционно он готовится из слоеного теста, коржи перемазываются сливочным, масляным или заварным кремом.",
                Price = 400,
                Category = "Торты"
            };
            Desserts.Add(d1);
            Desserts.Add(d2);
            Desserts.Add(d3);
            Desserts.Add(d4);
        }

        private void Btn_Flipper_Click(object sender, RoutedEventArgs e)
        {
            if (tb_name.Text == "")
                MessageBox.Show("Выберите десерт!", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
        }
        private void Tb_image_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (lbDesserts.SelectedIndex != -1)
            {
                Dessert dessert = lbDesserts.SelectedItem as Dessert;
                LoadImage(dessert);
            }
        }
        private void LoadImage(Dessert d)
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                Filter = "Images:|*.png;*.jpg;*.jpeg"
            };

            if (dlg.ShowDialog() == true)
            {
                d.Image = dlg.FileName;
            }
        }
        private void Btn_delete_Click(object sender, RoutedEventArgs e)
        {
            Desserts.Remove(lbDesserts.SelectedItem as Dessert);
        }
        private void Btn_add_Click(object sender, RoutedEventArgs e)
        {
            AddDessert user = new AddDessert(this);
            user.ShowDialog();
            user.Close();
        }
        public void Add(Dessert dessert)
        {
            Desserts.Add(dessert);
        }
    }
}
