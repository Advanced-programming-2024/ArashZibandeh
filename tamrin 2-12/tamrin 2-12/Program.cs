using System;

class Program
{
    static void Main()
    {
        // Input variables
        Console.Write("Number of subscribers: ");
        int numberOfSubscribers = int.Parse(Console.ReadLine());

        // Initialize total amounts
        double totalGrossAmount = 0;
        double totalTaxAmount = 0;
        double totalNetAmount = 0;

        // Process each subscriber
        for (int i = 1; i <= numberOfSubscribers; i++)
        {
            Console.WriteLine($"--- Subscriber {i} ---");

            Console.Write("Start hour of conversation (0 to 23 or -99 to finish): ");
            int startHour = int.Parse(Console.ReadLine());

            if (startHour == -99)
                break;

            Console.Write("Number of conversation pulses: ");
            int pulseCount = int.Parse(Console.ReadLine());

            Console.Write("Day of the week (1 to 7): ");
            int dayOfWeek = int.Parse(Console.ReadLine());

            // Calculate gross amount
            double pulseRate = 47; // Riyals
            double grossAmount = pulseCount * pulseRate;

            // Apply rate based on time and day
            double rate = 1.0;
            if (startHour >= 23 || (startHour >= 0 && startHour < 8))
                rate = 0.5;
            else if (dayOfWeek == 7)
                rate = 0.75;

            grossAmount *= rate;

            // Apply tax
            double taxRate = 0.04;
            double taxAmount = grossAmount * taxRate;

            // Calculate net amount
            double netAmount = grossAmount - taxAmount;

            // Display results
            Console.WriteLine($"Gross amount: {grossAmount} Riyals");
            Console.WriteLine($"Tax: {taxAmount} Riyals");
            Console.WriteLine($"Net amount: {netAmount} Riyals");

            // Update total amounts
            totalGrossAmount += grossAmount;
            totalTaxAmount += taxAmount;
            totalNetAmount += netAmount;

            Console.WriteLine();
        }

        // Display totals
        Console.WriteLine($"--- Total ---");
        Console.WriteLine($"Total gross amount: {totalGrossAmount} Riyals");
        Console.WriteLine($"Total tax: {totalTaxAmount} Riyals");
        Console.WriteLine($"Total net amount: {totalNetAmount} Riyals");
    }
}
