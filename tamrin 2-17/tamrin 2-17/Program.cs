using System;

namespace FourDigitNumberCounter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Variable to store the count of zeros
            int count = 0;

            // Check all four-digit numbers
            for (int i = 1000; i <= 9999; i++)
            {
                // Store the current number in a separate variable
                int currentNumber = i;

                // Check each digit
                for (int j = 0; j < 4; j++)
                {
                    // If the last digit is equal to 0, increase the count of zeros
                    if (currentNumber % 10 == 0)
                    {
                        count++;
                    }

                    // Divide the number by 10 to check the next digit
                    currentNumber /= 10;
                }
            }

            // Display the count of zeros
            Console.WriteLine("The number of zeros in all four-digit numbers: {0}", count);
        }
    }
}
