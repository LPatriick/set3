using System;

class Program
{
    static int CountOverlaps(string s1, string s2)
    {
        int n = s1.Length;
        int matchCount = 0;
        for (int shift = 0; shift < n; shift++)
        {
            for (int i = 0; i < n; i++)
            {
                int rotatedIndex = (i + shift) % n;
                if (s1[i] == s2[rotatedIndex])
                {
                    matchCount++;
                }
            }
        }

        return matchCount;
    }

    static void Main()
    {
        string s1 = Console.ReadLine();
        string s2 = Console.ReadLine();
        if (s1.Length != s2.Length)
        {
            Console.WriteLine("Sirurile trebuie sa aiba aceeasi lungime.");
            return;
        }
        int result = CountOverlaps(s1, s2);
        Console.WriteLine(result);
    }
}
