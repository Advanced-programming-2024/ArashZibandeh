using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter a string:");
        string input = Console.ReadLine();

        // Function call to count word lengths
        Dictionary<int, int> wordLengthCounts = CountWordLengths(input);

        // Display the results
        Console.WriteLine("Word Lengths and their counts:");
        foreach (var entry in wordLengthCounts)
        {
            Console.WriteLine($"{entry.Key} letters: {entry.Value} words");
        }
    }

    static Dictionary<int, int> CountWordLengths(string input)
    {
        // Split the input string into words based on whitespace
        string[] words = input.Split(new char[] { ' ', '\t', '\n', '\r' }, StringSplitOptions.RemoveEmptyEntries);

        // Dictionary to store the length of words and their counts
        Dictionary<int, int> wordLengthCounts = new Dictionary<int, int>();

        // Iterate over each word
        foreach (string word in words)
        {
            int length = word.Length;

            // If the length is already in the dictionary, increment its count
            if (wordLengthCounts.ContainsKey(length))
            {
                wordLengthCounts[length]++;
            }
            else
            {
                // If the length is not in the dictionary, add it with a count of 1
                wordLengthCounts[length] = 1;
            }
        }

        return wordLengthCounts;
    }
}
