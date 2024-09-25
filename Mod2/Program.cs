using System;
using static System.Console;
using System.Globalization;

namespace Mod2
{
    class Employee
    {
        // Поля класса
        private string name;
        private int age;
        private string position;
        private decimal salary;

        // Конструктор по умолчанию
        public Employee()
        {
            name = "Неизвестно";
            age = 0;
            position = "Неизвестно";
            salary = 0.0m;
        }

        // Конструктор с параметрами
        public Employee(string name, int age, string position, decimal salary)
        {
            this.name = name;
            this.age = age;
            this.position = position;
            this.salary = salary;
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

        public decimal Salary
        {
            get { return salary; }
            set { salary = value; }
        }

        // Метод для расчета годового дохода
        public decimal CalculateAnnualIncome()
        {
            return salary * 12;
        }

        // Метод для вывода информации о сотруднике
        public void DisplayInfo()
        {
            // Устанавливаем кодировку консоли в UTF-8
            OutputEncoding = System.Text.Encoding.UTF8;

            // Используем культуру "ru-RU" для корректного отображения валюты в рублях
            CultureInfo culture = new CultureInfo("by-BY");

            WriteLine($"Имя: {name}");
            WriteLine($"Возраст: {age}");
            WriteLine($"Должность: {position}");
            // Указываем культуру для форматирования зарплаты
            WriteLine($"Месячная зарплата: {salary.ToString("C", culture)}");
            WriteLine($"Годовой доход: {CalculateAnnualIncome().ToString("C", culture)}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Создание объекта с помощью конструктора по умолчанию
            Employee employee1 = new Employee();
            employee1.DisplayInfo();
            WriteLine();

            // Создание объекта с помощью конструктора с параметрами
            Employee employee2 = new Employee("Иван Иванов", 30, "Программист", 50000m);
            employee2.DisplayInfo();
            WriteLine();

            // Изменение значений полей объекта
            employee1.Name = "Петр Петров";
            employee1.Age = 28;
            employee1.Position = "Менеджер";
            employee1.Salary = 40000m;
            employee1.DisplayInfo();
        }
    }
}
