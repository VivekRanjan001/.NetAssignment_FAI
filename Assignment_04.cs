using System;

namespace Vivek_Assignment_FAI
{
    class Assignment_04
    {
        static void Main(string[] args)
        {
            // Get array size from user
            Console.WriteLine("Enter the size of the array:");
            int size = Convert.ToInt32(Console.ReadLine());

            // Dynamically create array based on user input
            int[] array = new int[size];

            // Get array values from user
            Console.WriteLine("Enter the values for the array:");
            for (int i = 0; i < size; i++)
            {
                Console.Write($"Value {i + 1}: ");
                array[i] = Convert.ToInt32(Console.ReadLine());
            }

            // Display array contents
            Console.WriteLine("Array contents:");
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine($"Value {i + 1}: {array[i]}");
            }

            // Wait for user input before closing
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
