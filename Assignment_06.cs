using System;

namespace Vivek_Assignment_FAI
{
    class Assignment_06
    {
        static bool IsValidDate(int year, int month, int day)
        {
            // Check if the year is valid (between 1 and 9999)
            if (year < 1 || year > 9999)
            {
                return false;
            }

            // Check if the month is valid (between 1 and 12)
            if (month < 1 || month > 12)
            {
                return false;
            }

            // Check if the day is valid for the given month and year
            int maxDays = DateTime.DaysInMonth(year, month);
            if (day < 1 || day > maxDays)
            {
                return false;
            }

            return true;
        }

        static void Main(string[] args)
        {
            // Test the function with different values
            Console.WriteLine("2018, 13, 1 is a valid date: {0}", IsValidDate(2018, 13, 1));
            Console.WriteLine("2018, 2, 29 is a valid date: {0}", IsValidDate(2018, 2, 29));
            Console.WriteLine("2016, 2, 29 is a valid date: {0}", IsValidDate(2016, 2, 29));
            Console.WriteLine("2000, 2, 29 is a valid date: {0}", IsValidDate(2000, 2, 29));
            Console.WriteLine("2100, 2, 29 is an invalid date: {0}", IsValidDate(2100, 2, 29));
        }
    }
}
