using System;

class Program
{
    static void Main()
    {
        const int arraySize = 15;

        // Read the first array
        Console.WriteLine("Enter 15 elements for the first array:");
        int[] array1 = ReadArray(arraySize);

        // Read the second array
        Console.WriteLine("Enter 15 elements for the second array:");
        int[] array2 = ReadArray(arraySize);

        // Multiply the arrays
        int[] productArray = MultiplyArrays(array1, array2);

        // Print the arrays
        Console.WriteLine("First Array:");
        PrintArray(array1);

        Console.WriteLine("Second Array:");
        PrintArray(array2);

        Console.WriteLine("Product Array:");
        PrintArray(productArray);
    }

    static int[] ReadArray(int size)
    {
        int[] array = new int[size];
        for (int i = 0; i < size; i++)
        {
            Console.Write($"Element {i + 1}: ");
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }

    static int[] MultiplyArrays(int[] array1, int[] array2)
    {
        int size = array1.Length;
        int[] productArray = new int[size];
        for (int i = 0; i < size; i++)
        {
            productArray[i] = array1[i] * array2[i];
        }
        return productArray;
    }

    static void PrintArray(int[] array)
    {
        foreach (int element in array)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }
}
