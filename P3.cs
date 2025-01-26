using System;

class Program
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        int[] v = new int[n];
        for (int i = 0; i < n; i++)
        {
            Console.Write($i + 1);
            v[i] = int.Parse(Console.ReadLine());
        }
        int min = v[0], max = v[0];
        int pozMin = 0, pozMax = 0;
        for (int i = 1; i < n; i += 2)
        {
            int localMin, localMax;
            if (i + 1 < n)
            {
                if (v[i] < v[i + 1])
                {
                    localMin = v[i];
                    localMax = v[i + 1];
                }
                else
                {
                    localMin = v[i + 1];
                    localMax = v[i];
                }
            }
            else
            {
                localMin = localMax = v[i];
            }
            if (localMin < min)
            {
                min = localMin;
                pozMin = v[i] == localMin ? i : i + 1;
            }
            if (localMax > max)
            {
                max = localMax;
                pozMax = v[i] == localMax ? i : i + 1;
            }
        }
        Console.WriteLine(min +" "+ pozMin);
        Console.WriteLine(max +" "+ pozMax);
    }
}
