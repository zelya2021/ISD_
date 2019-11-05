using CandyStore.Forms;
using CandyStore.Models;
using CandyStore.UserControls;
using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;
namespace CandyStore
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    /// 
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
       
        private void ListViewMenu_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int index = ListViewMenu.SelectedIndex;
            MuveCursor(index);
            switch (index)
            {
                case 0:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new UserControlCategories());
                    break;
                case 1:
                    MainGrid.Children.Clear();
                    MainGrid.Children.Add(new UserControlDesserts());
                    break;
            }
        }
        private void MuveCursor(int index)
        {
            TrainsitionigContentSlide.OnApplyTemplate();
            CridCursor.Margin = new Thickness(0,(160+(60* index)),0,0);
        }
        private void ButtonFechar_Click(object sender, RoutedEventArgs e)
        {
            Application.Current.Shutdown();
        }
    }
}
