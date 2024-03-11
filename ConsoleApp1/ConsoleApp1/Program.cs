using System;

class Program
{
    static void Main()
    {
        int n;
        do
        {
            Console.Write("Please enter an odd number: ");
            n = int.Parse(Console.ReadLine());

            if (n % 2 == 0)
            {
                Console.WriteLine("Error: Please enter an odd number. Try again.");
            }
            else
            {
                int result = HesabSeriesSum(n);
                Console.WriteLine($"The sum of the series is: {result}");
            }
        } while (n % 2 == 0);
    }

    static int HesabSeriesSum(int n)
    {
        int sum = 0;
        int sign = 1;

        for (int i = 1; i <= n; i += 2)
        {
            sum += sign * i;
            sign = -sign; // Change sign in each step
        }

        return sum;
    }
}
