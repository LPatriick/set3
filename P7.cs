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
        for (int i = 0; i < n / 2; i++)
        {
            int temp = v[i];
            v[i] = v[n - 1 - i];
            v[n - 1 - i] = temp;
        }
        foreach (int val in v)
        {
            Console.Write(val + " ");
        }
    }
}
