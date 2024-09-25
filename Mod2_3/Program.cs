using System;
using static System.Console;

namespace Mod2_3
{
    class Author
    {
        public string Name { get; set; } // Имя автора
        public int Age { get; set; } // Дата рождения

        // Конструктор для инициализации автора
        public Author(string name, int age)
        {
            Name = name;
            Age = age;
        }

        // Вывод информации об авторе
        public void DisplayInfo()
        {
            WriteLine($"Автор: {Name}; Год Рождения: {Age}");
        }

        public override string ToString()
        {
            return $"{Name};\nГод Рождения: {Age}";
        }
    }

    

    class Book
    {
        public string _Name { get; set; } // Название книги
        public int _Age { get; set; } // Год выпуска
        public Author _Author { get; set; } // Автор

        // Конструктор для инициализации книги
        public Book(string name, int age, Author author)
        {
            _Name = name;
            _Age = age;
            _Author = author;
        }

        // Вывод информации о книге
        public void DisplayInfo()
        {
            WriteLine($"Название: {_Name};\nГод выпуска: {_Age}\nАвтор: {_Author}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Author author1 = new Author("Лев Толстой", 1828);
            Author author2 = new Author("Александр Сергеевич Пушкин", 1799);

            Book book1 = new Book("Война и мир", 1852, author1);
            Book book2 = new Book("Евгений Онегин", 1833, author2);

            book1.DisplayInfo();
            WriteLine();
            book2.DisplayInfo();
            ReadKey();
        }
    }
}