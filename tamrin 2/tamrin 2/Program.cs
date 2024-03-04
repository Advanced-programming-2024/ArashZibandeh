using System;

class MyProgram
{
    static void Main()
    {
        Console.Write("Please enter the value of x: ");
        double x = Convert.ToDouble(Console.ReadLine());

        // Calculate the expression using the left shift operator instead of multiplication
        double y = ((31 << 1) - 17) * x;

        Console.WriteLine($"The value of the expression is: {y}");
    }
}
