using System;

class Program
{
    static void Merge(int[] arr, int left, int mid, int right)
    {
        int leftSize = mid - left + 1;
        int rightSize = right - mid;

        int[] leftArray = new int[leftSize];
        int[] rightArray = new int[rightSize];

        // Copy data to temp arrays
        Array.Copy(arr, left, leftArray, 0, leftSize);
        Array.Copy(arr, mid + 1, rightArray, 0, rightSize);

        int i = 0, j = 0, k = left;

        // Merge the temp arrays back into arr
        while (i < leftSize && j < rightSize)
        {
            if (leftArray[i] <= rightArray[j])
                arr[k++] = leftArray[i++];
            else
                arr[k++] = rightArray[j++];
        }

        // Copy remaining elements of leftArray[], if any
        while (i < leftSize)
            arr[k++] = leftArray[i++];

        // Copy remaining elements of rightArray[], if any
        while (j < rightSize)
            arr[k++] = rightArray[j++];
    }

    static void MergeSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int mid = left + (right - left) / 2;

            MergeSort(arr, left, mid);
            MergeSort(arr, mid + 1, right);

            Merge(arr, left, mid, right);
        }
    }

    static void Main()
    {
        int[] array = { 12, 11, 13, 5, 6, 7 };
        MergeSort(array, 0, array.Length - 1);

        Console.WriteLine("Sorted Array: " + string.Join(", ", array));
    }
}
