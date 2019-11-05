using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyStore.Models
{
    public class Dessert : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string _Name = "";
        private string _Description = "";
        private decimal _Price = 0;
        private string _Image = "";
        private string _Category = "";
        public int Id{ get; set; }
        public string Name
        {
            get => _Name;
            set
            {
                if (!_Name.Equals(value))
                {
                    _Name = value;
                    OnPropertyChanged(nameof(Name));
                }
            }
        }
        public string Description
        {
            get => _Description;
            set
            {
                if (!_Description.Equals(value))
                {
                    _Description = value;
                    OnPropertyChanged(nameof(Description));
                }
            }
        }
        public decimal Price
        {
            get => _Price;
            set
            {
                if (!_Price.Equals(value))
                {
                    _Price = value;
                    OnPropertyChanged(nameof(Price));
                }
            }
        }
        public string Image
        {
            get => _Image;
            set
            {
                _Image = value;
                OnPropertyChanged(nameof(Image));
            }
        }
        public string Category
        {
            get => _Category;
            set
            {
                if (!_Category.Equals(value))
                {
                    _Category = value;
                    OnPropertyChanged(nameof(Category));
                }
            }
        }
        public Dessert() { }
        public Dessert(string name, string description, string category, decimal price, string image)
        {
            Name = name;
            Description = description;
            Price = price;
            Category = category;
            Image = image;
        }
        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
