using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CandyStore.Models
{
    public class Category : INotifyPropertyChanged
    {
        public Category() { }
        public Category(string name, string image)
        {
            Name = name;
            Image = image;
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private string _Name = "";
        private string _Image = "";
        public int Id { get; set; }
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
        public string Image
        {
            get => _Image;
            set
            {
                _Image = value;
                OnPropertyChanged(nameof(Image));
            }
        }
        public virtual ICollection<Dessert> Desserts { get; set; }
        public void OnPropertyChanged(string prop)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(prop));
        }
    }
}
