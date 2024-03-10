using System;

class Program
{
    static void Main()
    {
        // Inputs
        Console.Write("Enter your monthly salary: ");
        double salary = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter deduction type (1, 2, or 3): ");
        int deductionType = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter tax percentage: ");
        double taxPercentage = Convert.ToDouble(Console.ReadLine());

        // Calculations
        double insurance = (deductionType == 1) ? 0.07 * salary : (deductionType == 2) ? 0.085 * salary : 0.1 * salary;
        double tax = taxPercentage / 100 * salary;
        double netSalary = salary - insurance - tax;

        // Displaying results
        Console.WriteLine($"Salary: {salary}");
        Console.WriteLine($"Insurance: {insurance}");
        Console.WriteLine($"Tax: {tax}");
        Console.WriteLine($"Net Salary: {netSalary}");
    }
}
