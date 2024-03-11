using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int number = int.Parse(Console.ReadLine());

        int result = CalculateNonZeroDigitsProduct(number);

        Console.WriteLine("The product of non-zero digits of the entered number: " + result);
    }

    static int CalculateNonZeroDigitsProduct(int num)
    {
        int product = 1;

        while (num != 0)
        {
            int digit = num % 10;

            if (digit != 0)
            {
                product *= digit;
            }

            num /= 10;
        }

        return product;
    }
}
