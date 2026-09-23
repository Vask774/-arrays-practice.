using System;
using System.Linq;

namespace Final.Task
{
    class Program
    {
        static void Main()
        {
            // Вариант 1. Температура за неделю

            double[] temperatures =
            {
                22.5, 23.1, 19.8, 21.3, 24.0, 25.2, 20.7
            };

            double average = temperatures.Average();
            double max = temperatures.Max();
            double min = temperatures.Min();
            int daysAbove20 = temperatures.Count(temperature => temperature > 20);

            Console.WriteLine($"Средняя температура: {average:F1} °C");
            Console.WriteLine($"Максимальная температура: {max:F1} °C");
            Console.WriteLine($"Минимальная температура: {min:F1} °C");
            Console.WriteLine($"Дней выше 20 °C: {daysAbove20}");
        }
    }
}