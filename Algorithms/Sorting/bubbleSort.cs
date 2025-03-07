using System;

class Program
{
    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        bool swapped;

        for (int i = 0; i < n - 1; i++)
        {
            swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // Swap arr[j] and arr[j+1]
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;

                    swapped = true;
                }
            }

            if (!swapped) // If no swaps, array is already sorted
                break;
        }
    }

    static void Main()
    {
        int[] array = { 5, 3, 8, 1, 2 };
        BubbleSort(array);

        Console.WriteLine("Sorted Array: " + string.Join(", ", array));
    }
}
