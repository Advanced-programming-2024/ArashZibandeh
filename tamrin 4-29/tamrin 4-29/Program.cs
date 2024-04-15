// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
using System;

class Program
{
    static void Main(string[] args)
    {
        // Variables to store game results
        int player1Score = 0;
        int player2Score = 0;

        // Loop for 5 rounds of the game
        for (int round = 1; round <= 5; round++)
        {
            // Display round number
            Console.WriteLine("Round " + round);

            // Players input their choices
            int player1Choice, player2Choice;

            Console.WriteLine("Player 1, enter your choice (1 for scissors, 2 for rock, 3 for paper):");
            player1Choice = int.Parse(Console.ReadLine());

            Console.WriteLine("Player 2, enter your choice (1 for scissors, 2 for rock, 3 for paper):");
            player2Choice = int.Parse(Console.ReadLine());

            // Check the winner and add score to the respective variable
            if (player1Choice == player2Choice)
            {
                Console.WriteLine("It's a tie!");
            }
            else if ((player1Choice == 1 && player2Choice == 3) ||
                     (player1Choice == 2 && player2Choice == 1) ||
                     (player1Choice == 3 && player2Choice == 2))
            {
                Console.WriteLine("Player 1 wins!");
                player1Score++;
            }
            else
            {
                Console.WriteLine("Player 2 wins!");
                player2Score++;
            }
        }

        // Display the overall result
        Console.WriteLine("Final Score:");
        Console.WriteLine("Player 1: " + player1Score + " points");
        Console.WriteLine("Player 2: " + player2Score + " points");

        // Determine the final winner
        if (player1Score > player2Score)
        {
            Console.WriteLine("Player 1 wins the game!");
        }
        else if (player2Score > player1Score)
        {
            Console.WriteLine("Player 2 wins the game!");
        }
        else
        {
            Console.WriteLine("It's a tie!");
        }
    }
}
