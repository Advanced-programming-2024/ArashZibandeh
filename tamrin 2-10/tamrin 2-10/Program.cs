using System;

class Program
{
    static void Main()
    {
        // Input: Initial investment amount
        Console.Write("Please enter the initial investment amount: ");
        double initialInvestment = Convert.ToDouble(Console.ReadLine());

        // Calculate annual profit and display results for each of the 8 years
        for (int year = 1; year <= 8; year++)
        {
            double annualProfit = 0.05 * initialInvestment; // 5% of the investment as annual profit
            initialInvestment += annualProfit; // Add profit to the investment

            Console.WriteLine($"Year {year}: Investment: {initialInvestment:C}, Annual Profit: {annualProfit:C}");
        }

        // Display the total investment at the end of 8 years
        Console.WriteLine($"Final investment after 8 years: {initialInvestment:C}");
    }
}
