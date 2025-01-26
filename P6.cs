using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write(i + 1);
            v[i] = int.Parse(Console.ReadLine());
        }
        int k = int.Parse(Console.ReadLine());
        if (k < 0 || k >= n)
        {
            Console.WriteLine("k invalid");
            return;
        }
        int[] vNou = new int[n - 1];
        for (int i = 0; i < k; i++)
        {
            vNou[i] = v[i];
        }
        for (int i = k + 1; i < n; i++)
        {
            vNou[i - 1] = v[i];
        }
        foreach (int val in vNou)
        {
            Console.Write(val + " ");
        }
    }
}
