using System;

class Program
{
    static void Main(string[] args)
    {
        int rows = 4;
        int cols = 7;

        // Loop through rows
        for (int i = 0; i < rows; i++)
        {
            // Loop through columns
            for (int j = 0; j < cols; j++)
            {
                Console.Write("$ ");
            }
            Console.WriteLine(); // Move to the next line after each row
        }
    }
}
