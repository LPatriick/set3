using System;

class Program
{
    static int CountOcc(int[] s, int[] p)
    {
        int count = 0;
        int n = s.Length;
        int m = p.Length;
        for (int i = 0; i <= n - m; i++)
        {
            bool found = true;
            for (int j = 0; j < m; j++)
            {
                if (s[i + j] != p[j])
                {
                    found = false;
                    break;
                }
            }

            if (found)
            {
                count++;
            }
        }

        return count;
    }

    static void Main()
    {
        int[] s = { 1, 2, 1, 2, 1, 3, 1, 2, 1 };
        int[] p = { 1, 2, 1 };
        int result = CountOcc(s, p);
        Console.WriteLine($"p apare în s de {result} ori.");
    }
}
