using System;

class Program
{
    // Method to calculate the new salary after an increase by a certain percentage
    static double CalculateNewSalary(double currentSalary, double percentageIncrease)
    {
        double multiplier = 1 + (percentageIncrease / 100);
        return currentSalary * multiplier;
    }

    static void Main()
    {
        Console.Write("Enter the number of employees: ");
        int n = int.Parse(Console.ReadLine());

        double[] currentSalaries = new double[n];
        double[] newSalaries = new double[n];

        for (int i = 0; i < n; i++)
        {
            Console.Write($"Enter the current salary for employee {i + 1}: ");
            currentSalaries[i] = double.Parse(Console.ReadLine());

            Console.Write($"Enter the percentage increase for employee {i + 1}: ");
            double percentageIncrease = double.Parse(Console.ReadLine());

            newSalaries[i] = CalculateNewSalary(currentSalaries[i], percentageIncrease);
        }

        Console.WriteLine("\nUpdated Salaries:");
        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Employee {i + 1}: Old Salary = {currentSalaries[i]}, New Salary = {newSalaries[i]}");
        }
    }
}
