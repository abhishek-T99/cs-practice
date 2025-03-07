using System;

class Program
{
    static int BinarySearch(int[] arr, int target)
    {
        int left = 0, right = arr.Length - 1;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (arr[mid] == target)
                return mid; // Found target at index mid
            else if (arr[mid] < target)
                left = mid + 1; // Search right half
            else
                right = mid - 1; // Search left half
        }

        return -1; // Element not found
    }

    static void Main()
    {
        int[] sortedArray = { 1, 3, 5, 7, 9, 11, 13 };
        int target = 7;
        int result = BinarySearch(sortedArray, target);

        Console.WriteLine(result != -1 ? $"Element found at index {result}" : "Element not found");
    }
}
