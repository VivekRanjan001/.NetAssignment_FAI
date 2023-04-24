using System;

namespace Vivek_Assignment_FAI
{
    class Assignment_03
    {
        static void Main()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("Math Calculator");
                Console.WriteLine("Enter two values:");
                Console.Write("Value 1: ");
                double value1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Value 2: ");
                double value2 = Convert.ToDouble(Console.ReadLine());

                Console.WriteLine("Enter an operator (+, -, *, /): ");
                string operation = Console.ReadLine();

                double result = 0;

                switch (operation)
                {
                    case "+":
                        result = value1 + value2;
                        break;
                    case "-":
                        result = value1 - value2;
                        break;
                    case "*":
                        result = value1 * value2;
                        break;
                    case "/":
                        result = value1 / value2;
                        break;
                    default:
                        Console.WriteLine("Invalid operator!");
                        continue;
                }

                Console.WriteLine($"Result: {result}");

                Console.Write("Enter 'exit' to close the calculator, or press any key to continue: ");
                string exitCommand = Console.ReadLine();
                if (exitCommand.ToLower() == "exit")
                {
                    keepRunning = false;
                }

                Console.Clear();
            }
        }
    }
}
