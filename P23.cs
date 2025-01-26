using System;
using System.Collections.Generic;

class Program
{
    static void CalcSetOp(int[] v1, int[] v2)
    {
        int i = 0, j = 0;
        List<int> intersection = new List<int>();
        List<int> union = new List<int>();
        List<int> differenceV1V2 = new List<int>();
        List<int> differenceV2V1 = new List<int>();
        while (i < v1.Length || j < v2.Length)
        {
            if (i < v1.Length && j < v2.Length)
            {
                if (v1[i] < v2[j])
                {
                    union.Add(v1[i]);
                    differenceV1V2.Add(v1[i]);
                    i++;
                }
                else if (v1[i] > v2[j])
                {
                    union.Add(v2[j]);
                    differenceV2V1.Add(v2[j]);
                    j++;
                }
                else
                {
                    union.Add(v1[i]);
                    intersection.Add(v1[i]);
                    i++;
                    j++;
                }
            }
            else if (i < v1.Length)
            {
                union.Add(v1[i]);
                differenceV1V2.Add(v1[i]);
                i++;
            }
            else if (j < v2.Length)
            {
                union.Add(v2[j]);
                differenceV2V1.Add(v2[j]);
                j++;
            }
        }
        Console.WriteLine("Intersecția: " + string.Join(", ", intersection));
        Console.WriteLine("Reuniunea: " + string.Join(", ", union));
        Console.WriteLine("Diferența v1 - v2: " + string.Join(", ", differenceV1V2));
        Console.WriteLine("Diferența v2 - v1: " + string.Join(", ", differenceV2V1));
    }

    static void Main()
    {
        int[] v1 = { 1, 2, 3, 4, 5 };
        int[] v2 = { 3, 4, 5, 6, 7 };
        CalcSetOp(v1, v2);
    }
}
