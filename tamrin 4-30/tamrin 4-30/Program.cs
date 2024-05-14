using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Numbers between 1000 and 1100 divisible by 9 and their digit sum divisible by 9:");

        for (int i = 1000; i <= 1100; i++)
        {
            if (i % 9 == 0 && DigitSum(i) % 9 == 0)
            {
                Console.WriteLine(i);
            }
        }
    }

    // Function to calculate the sum of digits of a number
    static int DigitSum(int number)
    {
        int sum = 0;
        while (number != 0)
        {
            sum += number % 10;
            number /= 10;
        }
        return sum;
    }
}
