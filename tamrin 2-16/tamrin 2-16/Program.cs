using System;

namespace PerfectNumberFinder
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Function to check if a number is a perfect number
            bool IsPerfectNumber(int number)
            {
                int sum = 0;
                for (int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        sum += i;
                    }
                }
                return sum == number;
            }

            // Function to calculate the product of digits
            int GetProductOfDigits(int number)
            {
                int product = 1;
                while (number > 0)
                {
                    product *= number % 10;
                    number /= 10;
                }
                return product;
            }

            Console.WriteLine("Four-digit numbers with a perfect product of digits:");

            // Print all four-digit numbers with a perfect number as the product of their digits
            for (int i = 1000; i <= 9999; i++)
            {
                int product = GetProductOfDigits(i);
                if (IsPerfectNumber(product))
                {
                    Console.WriteLine($"Number: {i}, Product of Digits: {product}");
                }
            }
        }
    }
}
