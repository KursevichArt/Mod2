using System;
using System.Collections.Generic;
using static System.Console;

namespace Mod2_3_
{
    class Author
    {
        public string Name { get; set; } // Имя автора
        public int BirthYear { get; set; } // Год рождения

        // Конструктор для инициализации автора
        public Author(string name, int birthYear)
        {
            Name = name;
            BirthYear = birthYear;
        }

        // Вывод информации об авторе
        public void DisplayInfo()
        {
            WriteLine($"Автор: {Name}; Год Рождения: {BirthYear}");
        }

        public override string ToString()
        {
            return $"{Name}; Год Рождения: {BirthYear}";
        }
    }

    class Book
    {
        public string Title { get; set; } // Название книги
        public int PublicationYear { get; set; } // Год выпуска
        public Author Author { get; set; } // Автор

        // Конструктор для инициализации книги
        public Book(string title, int publicationYear, Author author)
        {
            Title = title;
            PublicationYear = publicationYear;
            Author = author;
        }

        // Вывод информации о книге
        public void DisplayInfo()
        {
            WriteLine($"Название: {Title}; Год выпуска: {PublicationYear}; Автор: {Author}");
        }
    }

    class Library
    {
        private List<Book> books = new List<Book>(); // Список книг в библиотеке

        // Метод для добавления книги
        public void AddBook(Book book)
        {
            books.Add(book);
            WriteLine($"Книга '{book.Title}' добавлена в библиотеку.");
        }

        // Метод для удаления книги
        public void RemoveBook(Book book)
        {
            if (books.Remove(book))
               WriteLine($"Книга '{book.Title}' удалена из библиотеки.");
            else
               WriteLine($"Книга '{book.Title}' не найдена в библиотеке.");
        }

        // Метод для поиска книг по автору
        public void FindBooksByAuthor(string authorName)
        {
            WriteLine($"Книги автора '{authorName}':");
            foreach (var book in books)
            {
                if (book.Author.Name.Equals(authorName, StringComparison.OrdinalIgnoreCase))
                   WriteLine($"- {book.Title} ({book.PublicationYear})");
            }
        }

        // Метод для поиска книг по году издания
        public void FindBooksByYear(int year)
        {
            WriteLine($"Книги, изданные в {year}:");
            foreach (var book in books)
            {
                if (book.PublicationYear == year)
                   WriteLine($"- {book.Title} (Автор: {book.Author.Name})");
            }
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

            Library library = new Library();
            library.AddBook(book1);
            library.AddBook(book2);

            WriteLine();
            library.FindBooksByAuthor("Лев Толстой");
            WriteLine();
            library.FindBooksByYear(1833);
            WriteLine();

            library.RemoveBook(book1);
            library.RemoveBook(book1); // Попытка удалить книгу, которая уже была удалена

            ReadKey();
        }
    }
}
