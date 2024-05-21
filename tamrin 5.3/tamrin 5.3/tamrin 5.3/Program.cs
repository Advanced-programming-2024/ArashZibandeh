using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter two numbers:");
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Odd numbers between " + num1 + " and " + num2 + " are:");
        PrintOddNumbers(num1, num2);
    }

    static void PrintOddNumbers(int start, int end)
    {
        if (start > end)
        {
            int temp = start;
            start = end;
            end = temp;
        }

        if (start % 2 == 0)
        {
            start++;
        }

        if (start <= end)
        {
            Console.WriteLine(start);
            PrintOddNumbers(start + 2, end);
        }
    }
}
