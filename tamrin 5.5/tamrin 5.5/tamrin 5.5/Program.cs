using System;

class Program
{
    static void Main()
    {
        // Test the GetSign method with different values
        Console.WriteLine(GetSign(10));   // Output: +
        Console.WriteLine(GetSign(-5));   // Output: -
        Console.WriteLine(GetSign(0));    // Output: 0
    }

    // Method to return the sign of a number
    static char GetSign(int number)
    {
        if (number > 0)
        {
            return '+';
        }
        else if (number < 0)
        {
            return '-';
        }
        else
        {
            return '0';
        }
    }
}
