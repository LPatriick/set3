using System;

class Program
{
    static void Main()
    {
        int[] vector = { 5, 3, 8, 1, 2 };
        int index = 2;
        Array.Sort(vector);
        Console.WriteLine($"pozitia {index} dupa sortare {vector[index]}");
    }
}
