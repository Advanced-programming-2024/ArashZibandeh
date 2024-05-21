using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Split the input string into words
        string[] words = input.Split(' ');

        // Filter out the two-letter words
        var filteredWords = words.Where(word => word.Length != 2);

        // Join the filtered words back into a string
        string result = string.Join(" ", filteredWords);

        // Display the result
        Console.WriteLine("Modified string:");
        Console.WriteLine(result);
    }
}
