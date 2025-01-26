using System;
using System.Collections.Generic;

class Program
{
    static void CalcSetOp(int[] v1, int[] v2)
    {
        HashSet<int> set1 = new HashSet<int>(v1);
        HashSet<int> set2 = new HashSet<int>(v2);
        HashSet<int> intersection = new HashSet<int>(set1);
        intersection.IntersectWith(set2);
        Console.WriteLine("Intersecția: " + string.Join(", ", intersection));
        HashSet<int> union = new HashSet<int>(set1);
        union.UnionWith(set2);
        Console.WriteLine("Reuniunea: " + string.Join(", ", union));
        HashSet<int> differenceV1V2 = new HashSet<int>(set1);
        differenceV1V2.ExceptWith(set2);
        Console.WriteLine("Diferența v1 - v2: " + string.Join(", ", differenceV1V2));
        HashSet<int> differenceV2V1 = new HashSet<int>(set2);
        differenceV2V1.ExceptWith(set1);
        Console.WriteLine("Diferența v2 - v1: " + string.Join(", ", differenceV2V1));
    }

    static void Main()
    {
        int[] v1 = { 1, 2, 3, 4, 5, 5 };
        int[] v2 = { 4, 5, 6, 7, 7 };
        CalcSetOp(v1, v2);
    }
}
