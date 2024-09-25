using System;
using static System.Console;

namespace Mod2_5
{
    class TemperatureSensor
    {
        private double _temperature;

        // Событие, которое будет вызываться при изменении температуры
        public event EventHandler<double> TemperatureChanged;

        public double Temperature
        {
            get { return _temperature; }
            set
            {
                // Если температура изменилась, вызываем событие
                if (_temperature != value)
                {
                    _temperature = value;
                    OnTemperatureChanged(_temperature);
                }
            }
        }

        // Метод для вызова события
        protected virtual void OnTemperatureChanged(double newTemperature)
        {
            TemperatureChanged?.Invoke(this, newTemperature);
        }
    }

    class Thermostat
    {
        private double _targetTemperature;

        public Thermostat(double targetTemperature)
        {
            _targetTemperature = targetTemperature;
        }

        // Подписка на событие TemperatureChanged
        public void Subscribe(TemperatureSensor sensor)
        {
            sensor.TemperatureChanged += HandleTemperatureChanged;
        }

        // Реакция на изменение температуры
        public double TargetTemperature => _targetTemperature; // Свойство для получения целевой температуры

        private void HandleTemperatureChanged(object sender, double newTemperature)
        {
            WriteLine($"Температура изменилась на: {newTemperature}°C");
            if (newTemperature < _targetTemperature)
               WriteLine("Включение отопления");
            else
               WriteLine("Выключение отопления");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TemperatureSensor sensor = new TemperatureSensor();
            Thermostat thermostat = new Thermostat(20.0); // целевая температура 20°C

            // Вывод целевой температуры
            WriteLine($"Температура: {thermostat.TargetTemperature}°C");

            // Подписываем термостат на событие изменения температуры
            thermostat.Subscribe(sensor);

            // Изменяем температуру и вызываем событие
            sensor.Temperature = 18.0; // Температура ниже целевой, включаем отопление
            sensor.Temperature = 22.0; // Температура выше целевой, выключаем отопление
        }
    }
}