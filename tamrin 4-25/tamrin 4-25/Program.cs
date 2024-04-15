using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please enter the value of m: ");
        int m = int.Parse(Console.ReadLine());

        Console.Write("Please enter the value of n: ");
        int n = int.Parse(Console.ReadLine());

        double result = Power(m, n);
        Console.WriteLine($"{m}^{n} = {result}");
    }

    static double Power(int m, int n)
    {
        return Math.Pow(m, n);
    }
}
