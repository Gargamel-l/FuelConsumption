using System;

namespace FuelConsumptionCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.InputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Калькулятор расстояния на основе мощности двигателя и количества топлива");

            try
            {
                Console.Write("Введите мощность двигателя в лошадиных силах (л.с.): ");
                int enginePower = int.Parse(Console.ReadLine());

                Console.Write("Введите количество топлива в литрах: ");
                double fuelAmount = double.Parse(Console.ReadLine());

                // Базовый расход для 100 л.с.
                double baseConsumptionPerHundred = 10.0;

                // Расчет дополнительного расхода
                double extraConsumption = (enginePower - 100) / 10 * 0.5;

                // Общий расход на 100 км
                double totalConsumptionPerHundred = baseConsumptionPerHundred + extraConsumption;

                // Расчет расстояния
                double distance = (fuelAmount / totalConsumptionPerHundred) * 100;

                Console.WriteLine($"Автомобиль сможет пройти приблизительно {distance:F2} км.");
            }
            catch (FormatException)
            {
                Console.WriteLine("Ошибка: введены некорректные данные. Пожалуйста, используйте числовые значения.");
            }
        }
    }
}
