using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter the number of employees: ");
        int n = int.Parse(Console.ReadLine());

        int min1 = int.MaxValue;
        int min2 = int.MaxValue;
        int min3 = int.MaxValue;

        for (int i = 1; i <= n; i++)
        {
            Console.Write($"Enter overtime hours for employee {i}: ");
            int extraHours = int.Parse(Console.ReadLine());

            if (extraHours < min1)
            {
                min3 = min2;
                min2 = min1;
                min1 = extraHours;
            }
            else if (extraHours < min2)
            {
                min3 = min2;
                min2 = extraHours;
            }
            else if (extraHours < min3)
            {
                min3 = extraHours;
            }
        }

        Console.WriteLine($"Three employees with the least overtime hours: {min1}, {min2}, {min3}");
    }
}
