using System;

class Program
{
    static void CiurulLuiEratostene(int n)
    {
        bool[] prime = new bool[n + 1];
        for (int i = 2; i <= n; i++)
        {
            prime[i] = true;
        }
        for (int p = 2; p * p <= n; p++)
        {
            if (prime[p])
            {
                for (int i = p * p; i <= n; i += p)
                {
                    prime[i] = false;
                }
            }
        }
        for (int i = 2; i <= n; i++)
        {
            if (prime[i])
            {
                Console.Write(i + " ");
            }
        }
        Console.WriteLine();
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        Console.WriteLine($"Numerele prime mai mici sau egale cu {n} sunt:");
        CiurulLuiEratostene(n);
    }
}
