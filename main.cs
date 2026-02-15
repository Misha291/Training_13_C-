using System;

namespace tran13
{
    class Program
    {
        static void Main()
        {
            int[] numbers = { 3, 7, 2, 9, 4 };

            Console.Write($"Массив: ");

            int sum = 0;

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write($"{numbers[i]} ");

                sum += numbers[i];
            }
            Console.WriteLine();
            Console.Write($"Сумма: {sum}");
            Console.ReadKey();
        }
    }
}
