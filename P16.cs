using System;

class Program
{
    static int GCD(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
    static int GCDVector(int[] arr)
    {
        int result = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            result = GCD(result, arr[i]);
            if (result == 1) break;
        }
        return result;
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
        int[] arr = { 12, 24, 36, 48, 60 };
        AfiseazaArray(arr);
        int result = GCDVector(arr);
        Console.WriteLine(result);
    }
}
