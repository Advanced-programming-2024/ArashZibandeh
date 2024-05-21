using System;

class RecursiveMethod
{
    static int F(int x, int y)
    {
        if (x < 0 || y < 0)
            return x - y;
        else
            return F(x - 1, y) + F(x, y - 1);
    }

    static void Main()
    {
        Console.Write("Enter the value of x: ");
        int x = int.Parse(Console.ReadLine());

        Console.Write("Enter the value of y: ");
        int y = int.Parse(Console.ReadLine());

        int result = F(x, y);
        Console.WriteLine($"Result: {result}");
    }
}
