using System;

namespace Task1.Statistics
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] numbers = new int[10];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 101);
            }

            Console.WriteLine($"Массив: {string.Join(", ", numbers)}");

            int sum = 0;
            double product = 1;
            int evenCount = 0;

            foreach (int number in numbers)
            {
                sum += number;
                product *= number;

                if (number % 2 == 0)
                {
                    evenCount++;
                }
            }

            double average = (double)sum / numbers.Length;

            int greaterCount = 0;

            foreach (int number in numbers)
            {
                if (number > average)
                {
                    greaterCount++;
                }
            }

            Console.WriteLine($"Сумма: {sum}");
            Console.WriteLine($"Произведение: {product:E2}");
            Console.WriteLine($"Чётных чисел: {evenCount}");
            Console.WriteLine($"Больше среднего ({average:F1}): {greaterCount}");
        }
    }
}