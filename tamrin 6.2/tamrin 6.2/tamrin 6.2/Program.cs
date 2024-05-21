using System;

class CaesarCipher
{
    static void Main()
    {
        Console.Write("Enter the encrypted text: ");
        string encryptedText = Console.ReadLine().ToUpper();

        Console.Write("Enter the key (k): ");
        int key = int.Parse(Console.ReadLine());

        string decryptedText = Decrypt(encryptedText, key);
        Console.WriteLine("Decrypted text: " + decryptedText);
    }

    static string Decrypt(string cipherText, int key)
    {
        char[] buffer = cipherText.ToCharArray();

        for (int i = 0; i < buffer.Length; i++)
        {
            char letter = buffer[i];

            if (char.IsLetter(letter))
            {
                letter = (char)(letter - key);

                if (letter < 'A')
                {
                    letter = (char)(letter + 26);
                }
                buffer[i] = letter;
            }
        }
        return new string(buffer);
    }
}
