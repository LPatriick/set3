using System;

class Program
{
    static void ElimDupe(int[] arr)
    {
        int n = arr.Length;
        if (n <= 1) return;
        Array.Sort(arr);
        int poz = 1;
        for (int i = 1; i < n; i++)
        {
            if (arr[i] != arr[i - 1])
            {
                arr[poz] = arr[i];
                poz++;
            }
        }
        Array.Resize(ref arr, poz);
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
        int[] arr = { 4, 5, 6, 2, 6, 4, 3, 3, 5 };
        AfiseazaArray(arr);
        ElimDupe(arr);
        AfiseazaArray(arr);
    }
}
