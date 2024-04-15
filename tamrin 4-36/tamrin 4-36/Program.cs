using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 8; // Number of rows in the pattern

        // Nested loop to print the pattern
        for (int i = 1; i <= n; i++)
        {
            for (int j = 1; j <= n - 1; j++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine(i); // Print i followed by a newline
        }
    }
}
