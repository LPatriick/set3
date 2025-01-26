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
        k = k % n;
        int[] rotated = new int[n];
        for (int i = 0; i < n; i++)
        {
            rotated[i] = v[(i + k) % n];
        }
        Console.WriteLine("Vectorul rotit cu {0} poziții spre stânga este:", k);
        foreach (int val in rotated)
        {
            Console.Write(val + " ");
        }
    }
}
