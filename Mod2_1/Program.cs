using System;
using static System.Console;

namespace Mod2_1
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
        public Person(string name, int age, string position, decimal salary)
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
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта с помощью конструктора по умолчанию
            Person employee1 = new Person();
            employee1.DisplayInfo();
            WriteLine();

            // Создание объекта с помощью конструктора с параметрами
            Person employee2 = new Person("Иван Иванов", 30, "Минск", 50000m);
            employee2.DisplayInfo();
            WriteLine();

            // Изменение значений полей объекта
            employee1.Name = "Петр Петров";
            employee1.Age = 28;
            employee1.Position = "Орша";
            employee1.InputData();
            employee1.DisplayInfo(); 
        }
    }
}
