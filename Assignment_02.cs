using System;

namespace Vivek_Assignment_FAI
{
    class Assignment_02
    {
        static void Main(string[] args)
        {
            // Test data
            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            DisplayOddEvenNumbers(numbers);
        }

        static void DisplayOddEvenNumbers(int[] numbers)
        {
            Console.WriteLine("Odd Numbers:");
            foreach (var num in numbers)
            {
                if (num % 2 != 0)
                {
                    Console.WriteLine(num);
                }
            }

            Console.WriteLine("\nEven Numbers:");
            foreach (var num in numbers)
            {
                if (num % 2 == 0)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
