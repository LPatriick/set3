using System;

class Program
{
    static void CalcSetOp(int[] v1, int[] v2)
    {
        int n = v1.Length;
        int[] intersection = new int[n];
        int[] union = new int[n];
        int[] differenceV1V2 = new int[n];
        int[] differenceV2V1 = new int[n];
        for (int i = 0; i < n; i++)
        {
            intersection[i] = v1[i] & v2[i];
            union[i] = v1[i] | v2[i];
            differenceV1V2[i] = v1[i] & (1 - v2[i]);
            differenceV2V1[i] = v2[i] & (1 - v1[i]);
        }
        Console.WriteLine("Intersecția: " + string.Join(", ", intersection));
        Console.WriteLine("Reuniunea: " + string.Join(", ", union));
        Console.WriteLine("Diferența v1 - v2: " + string.Join(", ", differenceV1V2));
        Console.WriteLine("Diferența v2 - v1: " + string.Join(", ", differenceV2V1));
    }

    static void Main()
    {
        int[] v1 = { 1, 0, 1, 1, 0 };
        int[] v2 = { 0, 1, 1, 1, 1 };
        CalcSetOp(v1, v2);
    }
}
