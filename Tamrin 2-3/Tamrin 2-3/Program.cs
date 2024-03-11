using System;

class Program
{
    static void Main()
    {
        // 3 integers
        Console.Write("Enter the first number: ");
        int a = int.Parse(Console.ReadLine());

        Console.Write("Enter the second number: ");
        int b = int.Parse(Console.ReadLine());

        Console.Write("Enter the third number: ");
        int c = int.Parse(Console.ReadLine());

        // Check if 'a' is even
        if (a % 2 == 0)
        {
            // If 'a' is even, display the sum of cubes
            int sumOfCubes = (int)Math.Pow(a, 3) + (int)Math.Pow(b, 3) + (int)Math.Pow(c, 3);
            Console.WriteLine($"Sum of cubes: {sumOfCubes}");
        }
        else
        {
            // If 'a' is odd, display the sum of squares
            int sumOfSquares = a * a + b * b + c * c;
            Console.WriteLine($"Sum of squares: {sumOfSquares}");
        }
    }
}
