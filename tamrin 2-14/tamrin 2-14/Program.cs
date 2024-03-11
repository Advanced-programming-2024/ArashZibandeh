using System;

namespace GradeAnalyzer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            float excellentCount = 0;
            float goodCount = 0;
            float normalCount = 0;
            float poorCount = 0;

            int studentCount = 0;

            Console.WriteLine("Welcome to the Grade Analyzer!");

            while (true)
            {
                Console.Write("Enter the student's grade (or a negative number to exit): ");

                if (!float.TryParse(Console.ReadLine(), out float studentGrade))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                if (studentGrade < 0)
                {
                    break;
                }

                studentCount++;

                ClassifyGrade(studentGrade, ref excellentCount, ref goodCount, ref normalCount, ref poorCount);
            }

            DisplayResults(excellentCount, goodCount, normalCount, poorCount, studentCount);
        }

        static void ClassifyGrade(float grade, ref float excellent, ref float good, ref float normal, ref float poor)
        {
            if (grade >= 18 && grade <= 20)
            {
                excellent++;
            }
            else if (grade >= 15 && grade < 18)
            {
                good++;
            }
            else if (grade >= 12 && grade < 15)
            {
                normal++;
            }
            else if (grade >= 0 && grade < 12)
            {
                poor++;
            }
        }

        static void DisplayResults(float excellent, float good, float normal, float poor, int totalStudents)
        {
            Console.WriteLine("\nAnalysis Results:");

            Console.WriteLine($"Percentage of Excellent Students: {CalculatePercentage(excellent, totalStudents)}%");
            Console.WriteLine($"Percentage of Good Students: {CalculatePercentage(good, totalStudents)}%");
            Console.WriteLine($"Percentage of Normal Students: {CalculatePercentage(normal, totalStudents)}%");
            Console.WriteLine($"Percentage of Poor Students: {CalculatePercentage(poor, totalStudents)}%");
        }

        static float CalculatePercentage(float count, int total)
        {
            return (count / total) * 100;
        }
    }
}
