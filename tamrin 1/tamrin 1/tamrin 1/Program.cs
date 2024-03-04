using System;

class Program
{
    static void Main()
    {
        Console.Write("Please enter a number: ");
        int userInput = int.Parse(Console.ReadLine());

        Console.WriteLine($"Multiples of 3 less than {userInput}:");
        for (int i = 3; i < userInput; i += 3)
        {
            Console.WriteLine(i);
        }
    }
}
