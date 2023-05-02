using System;
namespace Vivek_Assignment_FAI
{
    class Assignment_11
    {
        public static double CalculateInterest(double principal, double rate, double term)
        {
            // Calculate interest amount
            double interest = principal * rate * term / 100;

            // Return interest amount
            return interest;
        }
    }
}
