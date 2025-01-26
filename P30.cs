using System;

class Program
{
    static void SortBicriterial(int[] E, int[] W)
    {
        Array.Sort(E, W, new Comparison<int>((e1, e2) =>
        {
            int index1 = Array.IndexOf(E, e1);
            int index2 = Array.IndexOf(E, e2);

            if (e1 < e2)
                return -1;
            else if (e1 > e2)
                return 1;
            else
                return W[index2].CompareTo(W[index1]);
        }
    }

    static void PrintArrays(int[] E, int[] W)
    {
        Console.WriteLine("E: " + string.Join(", ", E));
        Console.WriteLine("W: " + string.Join(", ", W));
    }

    static void Main()
    {
        int[] E = { 3, 1, 2, 3, 2 };
        int[] W = { 10, 20, 30, 40, 50 };
        PrintArrays(E, W);
        SortBicriterial(E, W);
        PrintArrays(E, W);
    }
}
