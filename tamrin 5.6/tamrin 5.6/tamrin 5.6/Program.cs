using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the first number: ");
        int num1 = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int num2 = int.Parse(Console.ReadLine());

        Console.WriteLine("Prime numbers between {0} and {1} are:", num1, num2);

        for (int i = num1; i <= num2; i++)
        {
            if (IsPrime(i))
            {
                Console.Write(i + " ");
            }
        }
    }

    static bool IsPrime(int number)
    {
        if (number <= 1)
        {
            return false;
        }

        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i
