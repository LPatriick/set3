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
        int min = v[0], max = v[0];
        int countMin = 1, countMax = 1;
        for (int i = 1; i < n; i++)
        {
            if (v[i] < min)
            {
                min = v[i];
                countMin = 1;
            }
            else if (v[i] == min)
            {
                countMin++;
            }
            if (v[i] > max)
            {
                max = v[i];
                countMax = 1;
            }
            else if (v[i] == max)
            {
                countMax++;
            }
        }
        Console.WriteLine(min +" "+ countMin);
        Console.WriteLine(max +" "+ countMax);
    }
}
