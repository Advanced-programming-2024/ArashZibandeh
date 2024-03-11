using System;

namespace FourDigitNumbersWithOddDigitSum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Function to check if the sum of digits is odd
            bool IsOddDigitSum(int number)
            {
                int sum = 0;

                // Extract and sum the digits
                while (number > 0)
                {
                    sum += number % 10;  // Extract the least significant digit
                    number /= 10;        // Remove the least significant digit
                }

                // Check if the sum is odd
                return sum % 2 == 1;
            }

            // Find and print four-digit numbers with odd digit sum
            for (int i = 1000; i <= 9999; i++)
            {
                if (IsOddDigitSum(i))
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
