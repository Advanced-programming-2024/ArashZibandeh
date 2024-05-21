using System;

class Program
{
    static void Main()
    {
        int[] array = ReadArray(10);
        Console.Write("Enter a number between 0 and 8: ");
        int number = int.Parse(Console.ReadLine());

        if (number < 0 || number > 8)
        {
            Console.WriteLine("Invalid number. Please enter a number between 0 and 8.");
            return;
        }

        RotateArray(array, number);
        PrintArray(array);
    }

    static int[] ReadArray(int length)
    {
        int[] array = new int[length];
        Console.WriteLine($"Enter {length} elements for the array:");
        for (int i = 0; i < length; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static void RotateArray(int[] array, int rotateBy)
    {
        int length = array.Length;
        int[] tempArray = new int[length];

        for (int i = 0; i < length; i++)
        {
            int newIndex = (i + length - rotateBy) % length;
            tempArray[newIndex] = array[i];
        }

        for (int i = 0; i < length; i++)
        {
            array[i] = tempArray[i];
        }
    }

    static void PrintArray(int[] array)
    {
        Console.WriteLine("Rotated array:");
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
