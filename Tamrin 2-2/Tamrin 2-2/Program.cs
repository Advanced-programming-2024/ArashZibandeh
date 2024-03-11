using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the base (x): ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter the exponent (y): ");
        int y = int.Parse(Console.ReadLine());

        double result = CalculatePower(x, y);

        Console.WriteLine($"{x}^{y} = {result}");
    }

    static double CalculatePower(int x, int y)
    {
        return Math.Pow(x, y);
    }
}
