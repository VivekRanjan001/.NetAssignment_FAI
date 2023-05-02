using System;

namespace Vivek_Assignment_FAI
{
    class Assignment_10
    {
        static string[] ones = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
        static string[] tens = { "", "ten", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        static string[] teens = { "", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };

        static string InWords(int num)
        {
            if (num == 0)
            {
                return "zero";
            }

            string words = "";

            // Convert crore place
            if (num >= 10000000)
            {
                words += InWords(num / 10000000) + " crore ";
                num %= 10000000;
            }

            // Convert lakh place
            if (num >= 100000)
            {
                words += InWords(num / 100000) + " lakh ";
                num %= 100000;
            }

            // Convert thousand place
            if (num >= 1000)
            {
                words += InWords(num / 1000) + " thousand ";
                num %= 1000;
            }

            // Convert hundred place
            if (num >= 100)
            {
                words += InWords(num / 100) + " hundred ";
                num %= 100;
            }

            // Convert tens place
            if (num >= 11 && num <= 19)
            {
                words += teens[num - 10];
                num = 0;
            }
            else if (num >= 20)
            {
                words += tens[num / 10];
                num %= 10;
            }

            // Convert ones place
            if (num >= 1 && num <= 9)
            {
                words += ones[num];
            }

            return words.TrimEnd();
        }

        static void Main(string[] args)
        {
            // Test the function with different input numbers
            int num1 = 12345;
            string inWords1 = InWords(num1);
            Console.WriteLine("{0} => {1}", num1, inWords1);

            int num2 = 10203040;
            string inWords2 = InWords(num2);
            Console.WriteLine("{0} => {1}", num2, inWords2);

            int num3 = 101;
            string inWords3 = InWords(num3);
            Console.WriteLine("{0} => {1}", num3, inWords3);
        }
    }
}
