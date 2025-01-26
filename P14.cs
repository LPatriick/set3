using System;

class Program
{
    static void MutZero(int[] arr)
    {
        int poz = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] != 0)
            {
                arr[poz] = arr[i];
                if (poz != i)
                {
                    arr[i] = 0;
                }
                poz++;
            }
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
        int[] arr = { 0, 1, 9, 0, 4, 0, 7 };
        AfiseazaArray(arr);
        MutZero(arr);
        AfiseazaArray(arr);
    }
}
