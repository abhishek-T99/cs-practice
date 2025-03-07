using System;

class Program
{
    static int LinearSearch(int[] arr, int target)
    {
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] == target)
                return i; // Found at index i
        }

        return -1; // Not found
    }

    static void Main()
    {
        int[] array = { 4, 2, 9, 1, 7, 6 };
        int target = 7;
        int result = LinearSearch(array, target);

        Console.WriteLine(result != -1 ? $"Element found at index {result}" : "Element not found");
    }
}
