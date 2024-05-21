using System;

class Program
{
    static void Main()
    {
        // Read the input string
        Console.Write("Enter a string: ");
        string input = Console.ReadLine();

        // Read the value of k
        Console.Write("Enter the value of k: ");
        int k = int.Parse(Console.ReadLine());

        // Encrypt the string
        string encryptedString = EncryptString(input, k);

        // Display the encrypted string
        Console.WriteLine("Encrypted string: " + encryptedString);
    }

    static string EncryptString(string input, int k)
    {
        char[] buffer = input.ToCharArray();

        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];

            if (char.IsLetter(letter))
            {
                char offset = char.IsUpper(letter) ? 'A' : 'a';
                letter = (char)((letter + k - offset) % 26 + offset);
            }

            buffer[i] = letter;
        }

        return new string(buffer);
    }
}
