using System;

class Program
{
    static void Main()
    {
        int number;

        do
        {
            Console.WriteLine("Enter a number (enter -1 to exit): ");
            string input = Console.ReadLine();

            if (!int.TryParse(input, out number))
            {
                Console.WriteLine("Invalid input. Please enter a number.");
                continue;
            }

            if (number == -1)
            {
                Console.WriteLine("Program terminated.");
                break;
            }

            if (ContainsZero(number))
            {
                Console.WriteLine("The entered number contains the digit 0.");
            }
            else
            {
                Console.WriteLine("The entered number does not contain the digit 0.");
            }

        } while (true);
    }

    static bool ContainsZero(int n)
    {
        while (n != 0)
        {
            if (n % 10 == 0)
            {
                return true;
            }
            n /= 10;
        }
        return false;
    }
}
