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
        int pozitie = -1;
        for (int i = 0; i < n; i++)
        {
            if (v[i] == k)
            {
                pozitie = i;
                break;
            }
        }
        if (pozitie != -1)
        {
            Console.WriteLine($"Valoarea {k} apare prima data pe poziția {pozitie}.");
        }
        else
        {
            Console.WriteLine($"Valoarea {k} nu apare în vector.");
        }
    }
}
