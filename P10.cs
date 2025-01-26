using System;

class Program
{
    static int CautareBinara(int[] v, int k)
    {
        int stanga = 0;
        int dreapta = v.Length - 1;
        while (stanga <= dreapta)
        {
            int mijloc = stanga + (dreapta - stanga) / 2;
            if (v[mijloc] == k)
            {
                return mijloc;
            }
            else if (v[mijloc] < k)
            {
                stanga = mijloc + 1;
            else
            {
                dreapta = mijloc - 1;
            }
        }
        return -1;
    }

    static void Main()
    {
        int[] v = { 1, 3, 5, 7, 9, 11, 13, 15 };
        int k = 7;

        int pozitie = CautareBinara(v, k);
        if (pozitie != -1)
        {
            Console.WriteLine($"{k} pe pozitia {pozitie}.");
        }
        else
        {
            Console.WriteLine($"{k} nu este in vector.");
        }
    }
}
