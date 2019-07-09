using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Score_Entity_.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Autor { get; set; }
        public decimal Price { get; set; }
        public virtual ICollection<Category> Categories { get; set; }//ленивая загрузка
        public virtual ICollection<Basket> Baskets { get; set; }
        public override string ToString()
        {
            return Name;
        }
    }
}
