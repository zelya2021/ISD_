using System;
using System.Collections.Generic;
using System.Data.Linq.Mapping;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4_ADOnet
{
    [Table(Name="Car")]
    public class Car
    {
        [Column(IsDbGenerated =true, IsPrimaryKey =true)]
        public int Id { get; set; }
        [Column]
        public string Mark { get; set; }
        [Column]
        public int Price { get; set; }
    }
}
