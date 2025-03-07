using System;

class Program
{
    static int Partition(int[] arr, int low, int high)
    {
        int pivot = arr[high]; // Choose the last element as pivot
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (arr[j] < pivot)
            {
                i++;
                (arr[i], arr[j]) = (arr[j], arr[i]); // Swap
            }
        }

        (arr[i + 1], arr[high]) = (arr[high], arr[i + 1]); // Swap pivot to correct position
        return i + 1;
    }

    static void QuickSort(int[] arr, int low, int high)
    {
        if (low < high)
        {
            int partitionIndex = Partition(arr, low, high);

            QuickSort(arr, low, partitionIndex - 1);
            QuickSort(arr, partitionIndex + 1, high);
        }
    }

    static void Main()
    {
        int[] array = { 10, 7, 8, 9, 1, 5 };
        QuickSort(array, 0, array.Length - 1);

        Console.WriteLine("Sorted Array: " + string.Join(", ", array));
    }
}
