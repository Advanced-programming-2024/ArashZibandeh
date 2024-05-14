using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Define a list to store employee information
        List<Employee> employees = new List<Employee>();

        // Entering employee information into the list
        employees.Add(new Employee("001", 1399, 1, 5, 3000));
        employees.Add(new Employee("002", 1400, 0, 6, 3500));
        employees.Add(new Employee("003", 1398, 1, 4, 3200));
        employees.Add(new Employee("004", 1401, 0, 7, 3800));
        employees.Add(new Employee("005", 1397, 1, 3, 2800));

        // Variables to store the count of male and female employees and the sum of salaries
        int maleCount = 0;
        int femaleCount = 0;
        int maleSalarySum = 0;
        int femaleSalarySum = 0;

        // Calculating the count of male and female employees and the sum of their salaries
        foreach (Employee emp in employees)
        {
            if (emp.Gender == 1) // Male
            {
                maleCount++;
                maleSalarySum += emp.Salary;
            }
            else // Female
            {
                femaleCount++;
                femaleSalarySum += emp.Salary;
            }
        }

        // Printing the results
        Console.WriteLine("a: Number of male employees: " + maleCount);
        Console.WriteLine("b: Number of female employees: " + femaleCount);
        Console.WriteLine("c: Average salary for males: " + (maleCount > 0 ? maleSalarySum / maleCount : 0));
        Console.WriteLine("   Average salary for females: " + (femaleCount > 0 ? femaleSalarySum / femaleCount : 0));
    }
}

// Class to display information for each employee
class Employee
{
    public string EmployeeId { get; }
    public int HiringYear { get; }
    public int Gender { get; } // 0 for female, 1 for male
    public int EmploymentGrade { get; } // 1 to 9
    public int Salary { get; }

    public Employee(string employeeId, int hiringYear, int gender, int employmentGrade, int salary)
    {
        EmployeeId = employeeId;
        HiringYear = hiringYear;
        Gender = gender;
        EmploymentGrade = employmentGrade;
        Salary = salary;
    }
}
