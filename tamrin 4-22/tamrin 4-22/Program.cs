using System;

class Program
{
    static double CalculateTerm(int n, double x)
    {
        double result = 0;
        for (int i = 1; i <= n; i++)
        {
            result += 1 / (x + i * Math.Pow(x, i));
        }
        return result;
    }

    static void Main(string[] args)
    {
        double x = 0.5; // Set the value of x here
        int n = 10; // Number of terms desired
        double sum = CalculateTerm(n, x);
        Console.WriteLine($"Sum of the first ten terms in the series: {sum}");
    }
}
