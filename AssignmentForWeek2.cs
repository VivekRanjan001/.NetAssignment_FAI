using System;
using System.Collections.Generic;

namespace Vivek_Assignment_FAI.Week2
{
    class AssignmentForWeek2
    {
        static Dictionary<string, string> cardDetails = new Dictionary<string, string>();

        static void Main()
        {
            bool keepRunning = true;

            while (keepRunning)
            {
                Console.WriteLine("ATM Card Validation");
                Console.WriteLine("1. Enter Card Details");
                Console.WriteLine("2. Update PIN");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1/2/3): ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        EnterCardDetails();
                        break;
                    case "2":
                        UpdatePIN();
                        break;
                    case "3":
                        keepRunning = false;
                        break;
                    default:
                        Console.WriteLine("Invalid choice!");
                        break;
                }
            }
        }

        static void EnterCardDetails()
        {
            Console.WriteLine("Enter 16-digit Card Number: ");
            string cardNumber = Console.ReadLine();
            if (cardDetails.ContainsKey(cardNumber))
            {
                Console.WriteLine("Card already stored. Please validate your PIN.");
                ValidatePIN(cardNumber);
            }
            else
            {
                Console.WriteLine("Card is used for the first time. Default PIN is 1234.");
                cardDetails.Add(cardNumber, "1234");
            }
        }

        static void ValidatePIN(string cardNumber)
        {
            Console.WriteLine("Enter your PIN: ");
            string pin = Console.ReadLine();
            if (cardDetails[cardNumber] == pin)
            {
                Console.WriteLine("PIN validated successfully.");
            }
            else
            {
                Console.WriteLine("Invalid PIN. Please try again.");
            }
        }

        static void UpdatePIN()
        {
            Console.WriteLine("Enter 16-digit Card Number: ");
            string cardNumber = Console.ReadLine();
            if (cardDetails.ContainsKey(cardNumber))
            {
                Console.WriteLine("Enter new PIN: ");
                string newPIN = Console.ReadLine();
                cardDetails[cardNumber] = newPIN;
                Console.WriteLine("PIN updated successfully.");
            }
            else
            {
                Console.WriteLine("Card not found. Please enter valid card details.");
            }
        }
    }
}
