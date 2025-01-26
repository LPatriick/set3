using System;

class Program
{
    static void InsertionSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 1; i < n; i++)
        {
            int key = arr[i];
            int j = i - 1;
            while (j >= 0 && arr[j] > key)
            {
                arr[j + 1] = arr[j];
                j = j - 1;
            }
            arr[j + 1] = key;
        }
    }

    static void AfiseazaArray(int[] arr)
    {
        foreach (int element in arr)
        {
            Console.Write(element + " ");
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int[] arr = { 64, 25, 12, 22, 11 };
        AfiseazaArray(arr);
        InsertionSort(arr);
        AfiseazaArray(arr);
    }
}
