using Exam_Score_Entity_.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_Score_Entity_.DB
{
    public class DefaultContext:DbContext
    {
        public DefaultContext() : base("defaultConnection") { }
        public DbSet<Book> Books { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Basket> Baskets { get; set; }
    }
}
