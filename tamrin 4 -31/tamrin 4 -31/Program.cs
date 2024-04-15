using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Please select your desired color:");
            Console.WriteLine("r or R: Red");
            Console.WriteLine("g or G: Green");
            Console.WriteLine("b or B: Blue");
            Console.WriteLine("e or E: Exit");

            char input = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            switch (input)
            {
                case 'r':
                    Console.WriteLine("You have selected Red.");
                    break;
                case 'g':
                    Console.WriteLine("You have selected Green.");
                    break;
                case 'b':
                    Console.WriteLine("You have selected Blue.");
                    break;
                case 'e':
                    Console.WriteLine("Hope to see you again!");
                    return;
                default:
                    Console.WriteLine("Invalid input! Please try again.");
                    break;
            }
        }
    }
}
