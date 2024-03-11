using System;
using System.Collections.Generic;
using System.Linq;

namespace Program
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> households = new List<int>();
            List<int> monthlyCosts = new List<int>();
            List<int> annualCosts = new List<int>();

            Console.WriteLine("Enter the number of households: ");
            int numberOfHouseholds = int.Parse(Console.ReadLine());

            for (int i = 0; i < numberOfHouseholds; i++)
            {
                Console.WriteLine("Enter the household number: ");
                int householdNumber = int.Parse(Console.ReadLine());

                if (householdNumber == -99)
                {
                    Console.WriteLine("Exiting the program.");
                    return;
                }

                households.Add(householdNumber);

                Console.WriteLine("Enter the monthly cost of the household: ");
                int monthlyCostOfHousehold = int.Parse(Console.ReadLine());
                monthlyCosts.Add(monthlyCostOfHousehold);

                int annualCostOfHousehold = monthlyCostOfHousehold * 12;
                annualCosts.Add(annualCostOfHousehold);
            }

            if (households.Count > 0)
            {
                int minimumCost = annualCosts.Min();
                int maximumCost = annualCosts.Max();

                int minimumCostIndex = annualCosts.IndexOf(minimumCost);
                int maximumCostIndex = annualCosts.IndexOf(maximumCost);

                Console.WriteLine("Household with minimum cost:");
                Console.WriteLine("Number: {0}", households[minimumCostIndex]);
                Console.WriteLine("Monthly cost: {0}", monthlyCosts[minimumCostIndex]);
                Console.WriteLine("Annual cost: {0}", minimumCost);

                Console.WriteLine("Household with maximum cost:");
                Console.WriteLine("Number: {0}", households[maximumCostIndex]);
                Console.WriteLine("Monthly cost: {0}", monthlyCosts[maximumCostIndex]);
                Console.WriteLine("Annual cost: {0}", maximumCost);
            }
            else
            {
                Console.WriteLine("No households entered. Exiting the program.");
            }
        }
    }
}
