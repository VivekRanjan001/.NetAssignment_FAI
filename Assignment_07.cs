using System;

namespace Vivek_Assignment_FAI
{
    class Assignment_07
    {
        static bool IsPrimeNumber(int num)
        {
            if (num <= 1)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    return false;
                }
            }

            return true;
        }

        static void Main(string[] args)
        {
            // Call the isPrimeNumber function with different values
            int[] numbers = { 2, 3, 5, 7, 11, 15, 20, 29, 30, 37 };

            foreach (int num in numbers)
            {
                if (IsPrimeNumber(num))
                {
                    Console.WriteLine($"{num} is a prime number.");
                }
                else
                {
                    Console.WriteLine($"{num} is not a prime number.");
                }
            }

            Console.ReadKey();
        }
    }
}
