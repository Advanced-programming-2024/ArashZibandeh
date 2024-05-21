using System;

class Program
{
    static void Main()
    {
        // Reading a series of numbers from the user and storing them in an array
        Console.WriteLine("Enter the number of elements:");
        int n = int.Parse(Console.ReadLine());
        int[] numbers = new int[n];

        Console.WriteLine($"Enter {n} numbers:");
        for (int i = 0; i < n; i++)
        {
            numbers[i] = int.Parse(Console.ReadLine());
        }

        // Calculating the sum of the first half of the numbers in the array
        int sumFirstHalf = 0;
        int half = n / 2;
        for (int i = 0; i < half; i++)
        {
            sumFirstHalf += numbers[i];
        }

        // Calculating the sum of the second half of the numbers in the array
        int sumSecondHalf = 0;
        for (int i = half; i < n; i++)
        {
            sumSecondHalf += numbers[i];
        }

        // Checking if the sum of the second half is greater than the sum of the first half
        if (sumSecondHalf > sumFirstHalf)
        {
            Console.WriteLine("The sum of the second half is greater than the sum of the first half.");
        }
        else
        {
            Console.WriteLine("The sum of the first half is greater or equal to the sum of the second half.");
        }

        // Printing the sums for reference
        Console.WriteLine($"Sum of the first half: {sumFirstHalf}");
        Console.WriteLine($"Sum of the second half: {sumSecondHalf}");
    }
}
