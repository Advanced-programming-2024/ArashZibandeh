using System;

namespace NumberRangeFinder
{
    internal class Program
    {
        // Function to calculate the sum of digits
        static int SumOfDigits(int number)
        {
            int sum = 0;
            while (number > 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        static void Main(string[] args)
        {
            int firstNumber, secondNumber, targetSum;

            // Input validation for the first number
            do
            {
                Console.Write("Enter the first number: ");
            } while (!int.TryParse(Console.ReadLine(), out firstNumber));

            // Input validation for the second number
            do
            {
                Console.Write("Enter the second number: ");
            } while (!int.TryParse(Console.ReadLine(), out secondNumber));

            // Input validation for the target sum
            do
            {
                Console.Write("Enter the target sum: ");
            } while (!int.TryParse(Console.ReadLine(), out targetSum));

            // Check numbers between the first and second numbers
            Console.WriteLine($"Numbers between {firstNumber} and {secondNumber} with a digit sum of {targetSum}:");

            for (int i = firstNumber + 1; i < secondNumber; i++)
            {
                // Check the sum of digits
                if (SumOfDigits(i) == targetSum)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
