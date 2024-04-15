using System;

class Program
{
    // Function to check if a number is prime
    static bool IsPrime(int number)
    {
        if (number <= 1)
            return false;

        // Check if the number is divisible by any number other than 1 and itself
        for (int i = 2; i <= Math.Sqrt(number); i++)
        {
            if (number % i == 0)
                return false;
        }

        return true;
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Please enter two numbers:");

        // Read two numbers from the user
        int num1 = Convert.ToInt32(Console.ReadLine());
        int num2 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine($"The prime numbers between {num1} and {num2} are:");

        // Print prime numbers between the two input numbers
        for (int i = num1; i <= num2; i++)
        {
            if (IsPrime(i))
                Console.WriteLine(i);
        }

        Console.ReadLine();
    }
}
