using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Three-digit numbers with a digit product greater than half themselves:");

        for (int i = 100; i <= 999; i++)
        {
            int digitProduct = GetDigitProduct(i);

            if (digitProduct > i / 2)
            {
                Console.WriteLine(i);
            }
        }

        Console.ReadLine();
    }

    static int GetDigitProduct(int number)
    {
        int product = 1;

        while (number > 0)
        {
            int digit = number % 10;
            product *= digit;
            number /= 10;
        }

        return product;
    }
}
