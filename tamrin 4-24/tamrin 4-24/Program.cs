using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please enter a number:");
        string input = Console.ReadLine();

        if (IsPalindrome(input))
        {
            Console.WriteLine("The number is palindrome.");
        }
        else
        {
            Console.WriteLine("The number is not palindrome.");
        }
    }

    static bool IsPalindrome(string number)
    {
        int length = number.Length;
        for (int i = 0; i < length / 2; i++)
        {
            if (number[i] != number[length - i - 1])
            {
                return false;
            }
        }
        return true;
    }
}
