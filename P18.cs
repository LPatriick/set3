using System;

class Program
{
    static double EvalPolinom(double[] coeficienti, double x)
    {
        double rez = 0;
        for (int i = coeficienti.Length - 1; i >= 0; i--)
        {
            rez = rez * x + coeficienti[i];
        }
        
        return rez;
    }

    static void Main()
    {
        double[] coeficienti = { 2, 3, 4 };
        double x = double.Parse(Console.ReadLine());
        double rez = EvalPolinom(coeficienti, x);
        Console.WriteLine(rez);
    }
}
