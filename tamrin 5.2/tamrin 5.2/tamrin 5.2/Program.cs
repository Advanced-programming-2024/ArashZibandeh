using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());
        PrintMultiplesOfThree(n);
    }

    static void PrintMultiplesOfThree(int n)
    {
        if (n <= 0)
        {
            return;
        }

        PrintMultiplesOfThree(n - 1);

        if (n % 3 == 0)
        {
            Console.WriteLine(n);
        }
    }
}
