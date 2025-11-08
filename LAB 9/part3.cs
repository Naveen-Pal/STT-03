using System;
namespace BubbleSortDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 45, 12, 78, 23, 56, 10 };
            Console.WriteLine("Original Array:");
            PrintArray(arr);
            BubbleSort(arr);
            Console.WriteLine("\nSorted Array (Ascending Order):");
            PrintArray(arr);
        }

        static void BubbleSort(int[] arr)
        {
            int n = arr.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (arr[j] > arr[j + 1])
                    {
                        int temp = arr[j];
                        arr[j] = arr[j + 1];
                        arr[j + 1] = temp;
                    }
                }
            }
        }

        static void PrintArray(int[] arr)
        {
            foreach (int num in arr)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();
        }
    }
}
