using Exam_Score_Entity_.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace Exam_Score_Entity_.DB
{
    public class DefaultInitializer : DropCreateDatabaseIfModelChanges<DefaultContext>
    {
        protected override void Seed(DefaultContext ctx)
        {
            Book p1 = null, p2 = null, p3 = null, p4 = null, p5 = null, p6 = null, p7 = null, p8 = null, p9 = null, p10 = null;

            Category c1 = new Category { Name = "Физика",              Books = new List<Book> { p1,p2  } };
            Category c2 = new Category { Name = "Фэнтези",             Books = new List<Book> { p3, p4 } };
            Category c3 = new Category { Name = "Зарубежная классика", Books = new List<Book> { p5, p6 } };
            Category c4 = new Category { Name = "Русская классика",    Books = new List<Book> { p7, p8 } };
            Category c5 = new Category { Name = "Приключения",         Books = new List<Book> { p9, p10} };

            p1 = new Book
            {
                Categories = new List<Category> { c1 },
                Name = "Черные дыры и молодые вселенные",
                Price = 300.4m,
                Autor= "Стивен Хокинг"
            };
            p2 = new Book
            {
                Categories = new List<Category> { c1 },
                Name = "Кратчайшая история времени",
                Price = 280.0m,
                Autor = "Стивен Хокинг"
            };
            p3 = new Book
            {
                Categories = new List<Category> { c2 },
                Name = "Девочка с медвежьим сердцем",
                Price = 200.7m,
                Autor = "Фрэнсис Хардинг"
            };
            p4 = new Book
            {
                Categories = new List<Category> { c2 },
                Name = "Таймлесс",
                Price = 230.1m,
                Autor = "Керстин Гир"
            };
            p5 = new Book
            {
                Categories = new List<Category> { c3 },
                Name = "Граф Монте-Кристо",
                Price = 220.3m,
                Autor= "Александр Дюма"
            };
            p6 = new Book
            {
                Categories = new List<Category> { c3 },
                Name = "Гордость и предубеждение",
                Price = 310.85m,
                Autor = "Джейн Остин"
            };
            p7 = new Book
            {
                Categories = new List<Category> { c4 },
                Name = "Мастер и Маргарита",
                Price = 210.4m,
                Autor = "Михаил Булгаков"
            };
            p8 = new Book
            {
                Categories = new List<Category> { c4 },
                Name = "Преступление и наказание",
                Price = 190.75m,
                Autor = "Фёдор Достоевский"
            };
            p9 = new Book
            {
                Categories = new List<Category> { c5 },
                Name = "Сердца трех",
                Price = 225.25m,
                Autor = "Джек Лондон"
            };
            p10 = new Book
            {
                Categories = new List<Category> { c5 },
                Name = "Затерянный мир",
                Price = 190.75m,
                Autor = "Артур Конан Дойл"
            };

            ctx.Books.AddRange(new Book[] { p1, p2, p3, p4, p5, p6, p7, p8, p9, p10 });

            ctx.SaveChanges();
        }
    }
}

        
    

