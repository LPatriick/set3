using System;

class Program
{
    static int CompareLex(int[] v1, int[] v2)
    {
        int n1 = v1.Length;
        int n2 = v2.Length;
        int minLength = Math.Min(n1, n2);
        for (int i = 0; i < minLength; i++)
        {
            if (v1[i] < v2[i]) return -1;
            if (v1[i] > v2[i]) return 1;
        }
        if (n1 < n2) return -1;
        if (n1 > n2) return 1;
        return 0;
    }

    static void Main()
    {
        int[] v1 = { 1, 3, 5 };
        int[] v2 = { 1, 3, 4 };
        int result = CompareLex(v1, v2);
        if (result < 0)
        {
            Console.WriteLine("Primul vector apare primul.");
        }
        else if (result > 0)
        {
            Console.WriteLine("Al doilea vector apare primul.");
        }
        else
        {
            Console.WriteLine("egali");
        }
    }
}
