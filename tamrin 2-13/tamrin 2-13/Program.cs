using System;

namespace WaterBillCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Enter the water consumption: ");
                float waterConsumption;

                if (!float.TryParse(Console.ReadLine(), out waterConsumption))
                {
                    Console.WriteLine("Invalid input. Please enter a valid number.");
                    continue;
                }

                if (waterConsumption < 0)
                {
                    break;
                }

                Console.WriteLine("Enter the consumption type (H/I/F): ");
                string consumptionType = Console.ReadLine().ToLower();
                float waterBill = CalculateWaterBill(waterConsumption, consumptionType);

                Console.WriteLine($"The bill amount is {waterBill} Rial.");
            }
        }

        static float CalculateWaterBill(float consumption, string type)
        {
            switch (type)
            {
                case "h":
                    return consumption * 5;

                case "i":
                    return (consumption < 4000) ? consumption * 0.75f : consumption * 0.75025f;

                case "f":
                    return (consumption < 2000000) ? consumption * 4 : consumption * 4.00004f;

                default:
                    Console.WriteLine("Invalid consumption type. Please enter H, I, or F.");
                    return 0;
            }
        }
    }
}
