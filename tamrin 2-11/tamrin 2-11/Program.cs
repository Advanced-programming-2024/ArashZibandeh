using System;

class Program
{
    static void Main()
    {
        int count = 0; // Total number of people
        int countMenBetween18And20 = 0; // Number of men aged between 18 and 20
        string input;

        Console.WriteLine("A program to calculate the count and percentage of men aged between 18 and 20.");
        Console.WriteLine("To end the program, -1.");

        while (true)
        {
            Console.Write("Gender (M/F): ");
            input = Console.ReadLine();

            if (input.ToLower() == "m")
            {
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                if (age == -1)
                    break;

                count++;

                if (age >= 18 && age <= 20)
                {
                    countMenBetween18And20++;
                }
            }
            else if (input.ToLower() == "f")
            {
                Console.Write("Age: ");
                int age = int.Parse(Console.ReadLine());

                if (age == -1)
                    break;

                count++;
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter M or F.");
            }
        }

        if (count > 0)
        {
            double percentageMenBetween18And20 = (double)countMenBetween18And20 / count * 100;
            Console.WriteLine($"Number of men aged between 18 and 20: {countMenBetween18And20}");
            Console.WriteLine($"Percentage of men aged between 18 and 20: {percentageMenBetween18And20:F2}%");
        }
        else
        {
            Console.WriteLine("No data entered.");
        }
    }
}
