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
        int suma = 0;
        foreach (int element in v)
        {
            suma += element;
        }
        Console.WriteLine(suma);
    }
}
