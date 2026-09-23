using System;

namespace Task3
{
    class Program
    {
        public static int[] GetUnique(int[] source)
        {
            int[] result = new int[source.Length];
            int count = 0;

            foreach (int number in source)
            {
                bool exists = false;

                for (int i = 0; i < count; i++)
                {
                    if (result[i] == number)
                    {
                        exists = true;
                        break;
                    }
                }

                if (!exists)
                {
                    result[count] = number;
                    count++;
                }
            }

            int[] unique = new int[count];

            for (int i = 0; i < count; i++)
            {
                unique[i] = result[i];
            }

            return unique;
        }

        static void Main()
        {
            int[] numbers = new int[10];
            Random random = new Random();

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = random.Next(1, 6);
            }

            int[] unique = GetUnique(numbers);

            Console.WriteLine($"Исходный:  {string.Join(", ", numbers)}");
            Console.WriteLine($"Уникальные: {string.Join(", ", unique)}");
        }
    }
}