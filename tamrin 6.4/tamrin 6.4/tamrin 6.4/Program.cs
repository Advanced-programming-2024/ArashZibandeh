using System;
using System.Linq;

class Program
{
    static void Main()
    {
        Random random = new Random();

        // Generate first array with 10 random numbers between 1 and 40
        int[] array1 = new int[10];
        for (int i = 0; i < array1.Length; i++)
        {
            array1[i] = random.Next(1, 41); // Generates a random number between 1 and 40
        }

        // Generate second array with 10 random numbers between 1 and 50
        int[] array2 = new int[10];
        for (int i = 0; i < array2.Length; i++)
        {
            array2[i] = random.Next(1, 51); // Generates a random number between 1 and 50
        }

        // Find elements that are in array1 but not in array2
        var difference = array1.Except(array2);

        // Print the elements of the first array
        Console.WriteLine("Array 1: " + string.Join(", ", array1));

        // Print the elements of the second array
        Console.WriteLine("Array 2: " + string.Join(", ", array2));

        // Print the difference
        Console.WriteLine("Elements in Array 1 but not in Array 2: " + string.Join(", ", difference));
    }
}
