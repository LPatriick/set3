using System;
using System.Collections.Generic;

class Program
{
    static void MergeSortArray(int[] v1, int[] v2)
    {
        int i = 0, j = 0;
        List<int> result = new List<int>();
        while (i < v1.Length && j < v2.Length)
        {
            if (v1[i] < v2[j])
            {
                result.Add(v1[i]);
                i++;
            }
            else
            {
                result.Add(v2[j]);
                j++;
            }
        }
        while (i < v1.Length)
        {
            result.Add(v1[i]);
            i++;
        }
        while (j < v2.Length)
        {
            result.Add(v2[j]);
            j++;
        }
        Console.WriteLine("Vectorul interclasat: " + string.Join(", ", result));
    }

    static void Main()
    {
        int[] v1 = { 1, 3, 5, 7 };
        int[] v2 = { 2, 4, 6, 8 };
        MergeSortArray(v1, v2);
    }
}
