using System;
using static System.Console;

namespace Mod2_2_
{
    class Person
    {
        // Поля класса
        private string name;
        private int age;
        private string position;

        // Конструктор по умолчанию
        public Person()
        {
            name = "Неизвестно";
            age = 0;
            position = "Неизвестно";
        }

        // Конструктор с параметрами
        public Person(string name, int age, string position)
        {
            this.name = name;
            this.age = age;
            this.position = position;
        }

        // Свойства для доступа и установки полей
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public string Position
        {
            get { return position; }
            set { position = value; }
        }

        // Метод для вывода информации о сотруднике
        public void DisplayInfo()
        {
            WriteLine($"Имя: {name}");
            WriteLine($"Возраст: {age}");
            WriteLine($"Местоположение: {position}");
            WriteLine();
        }

        public void InputData()
        {
            ForegroundColor = ConsoleColor.Green;
            // Ввод имени
            Write("Введите имя: ");
            name = ReadLine();

            // Ввод возраста
            Write("Введите возраст: ");
            age = Convert.ToInt32(ReadLine());

            // Ввод адреса
            Write("Введите адрес: ");
            position = ReadLine();
            ResetColor();
            WriteLine("");
        }

        // Деструктор
        ~Person()
        {
            WriteLine($"Объект {name} был удалён.");
            WriteLine();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта с помощью конструктора по умолчанию
            Person employee1 = new Person();

            // Создание объекта с помощью конструктора с параметрами
            Person employee2 = new Person("Иван Иванов", 30, "Минск");
            employee2.DisplayInfo();
            WriteLine();

            // Изменение значений полей объекта
            employee1.InputData();
            employee1.DisplayInfo();

            // Вызов garbage collector для демонстрации деструктора
            employee1 = null;
            employee2 = null;
            GC.Collect();
            GC.WaitForPendingFinalizers();
        }
    }
}