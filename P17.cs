using System;

class Program
{
    static string ConvertToBase(int n, int b)
    {
        if (n == 0)
        {
            return "0";
        }
        string result = "";
        char[] digits = "0123456789ABCDEF".ToCharArray();
        while (n > 0)
        {
            int remainder = n % b;
            result = digits[remainder] + result;
            n = n / b;
        }

        return result;
    }

    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int b = int.Parse(Console.ReadLine());
        if (b <= 1 || b >= 17)
        {
            Console.WriteLine("Baza între 2 și 16.");
            return;
        }
        string convNumber = ConvertToBase(n, b);
        Console.WriteLine(convNumber);
    }
}
