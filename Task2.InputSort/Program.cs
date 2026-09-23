using System;

namespace Task2.InputSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;

            while (true)
            {
                Console.Write("Введите количество элементов: ");

                try
                {
                    n = int.Parse(Console.ReadLine());

                    if (n > 0)
                    {
                        break;
                    }

                    Console.WriteLine("Количество элементов должно быть больше нуля.");
                }
                catch (FormatException)
                {
                    Console.WriteLine("Ошибка: Введите целое число!");
                }
                catch (OverflowException)
                {
                    Console.WriteLine("Ошибка: Число слишком большое!");
                }
            }

            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                while (true)
                {
                    Console.Write($"Элемент [{i}]: ");

                    try
                    {
                        numbers[i] = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Ошибка: Введите целое число!");
                    }
                    catch (OverflowException)
                    {
                        Console.WriteLine("Ошибка: Число слишком большое!");
                    }
                }
            }

            Console.WriteLine();
            Console.WriteLine($"Исходный массив:  {string.Join(", ", numbers)}");

            int[] reversed = (int[])numbers.Clone();
            Array.Reverse(reversed);

            Console.WriteLine($"Обратный порядок: {string.Join(", ", reversed)}");

            Array.Sort(numbers);

            Console.WriteLine($"Отсортированный:  {string.Join(", ", numbers)}");

            int min = numbers[0];
            int max = numbers[0];

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < min)
                {
                    min = numbers[i];
                }

                if (numbers[i] > max)
                {
                    max = numbers[i];
                }
            }

            Console.WriteLine($"Максимум: {max}");
            Console.WriteLine($"Минимум: {min}");
        }
    }
}