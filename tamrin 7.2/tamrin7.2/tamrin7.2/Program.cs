using System;

public class ParkingFeeCalculator
{
    private const decimal baseFee = 2.0m;
    private const decimal hourlyFee = 0.5m;
    private const decimal maxDailyFee = 10.0m;

    public decimal CalculateParkingFee(int hours, int minutes)
    {
        if (hours < 0 || minutes < 0)
        {
            throw new ArgumentOutOfRangeException("Hours and minutes cannot be negative.");
        }

        decimal totalHours = (decimal)hours + ((decimal)minutes / 60);

        if (totalHours <= 3)
        {
            return baseFee;
        }
        else
        {
            decimal excessHours = totalHours - 3;
            decimal excessHourlyFee = Math.Ceiling(excessHours) * hourlyFee;
            return Math.Min(baseFee + excessHourlyFee, maxDailyFee);
        }
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        ParkingFeeCalculator calculator = new ParkingFeeCalculator();

        Console.WriteLine("Enter parking hours:");
        int hours = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter parking minutes:");
        int minutes = int.Parse(Console.ReadLine());

        decimal parkingFee = calculator.CalculateParkingFee(hours, minutes);
        Console.WriteLine($"Parking fee: ${parkingFee}");
    }
}
