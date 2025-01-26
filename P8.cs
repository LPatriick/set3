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

        int firstElement = v[0];
        for (int i = 0; i < n - 1; i++)
        {
            v[i] = v[i + 1];
        }
        v[n - 1] = firstElement;
        foreach (int val in v)
        {
            Console.Write(val + " ");
        }
    }
}
