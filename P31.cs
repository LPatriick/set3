using System;

class Program
{
    static string FindMaj(int[] arr)
    {
        int candidate = -1;
        int count = 0;
        foreach (int num in arr)
        {
            if (count == 0)
            {
                candidate = num;
                count = 1;
            }
            else if (num == candidate)
            {
                count++;
            }
            else
            {
                count--;
            }
        }
        int validationCount = 0;
        foreach (int num in arr)
        {
            if (num == candidate)
            {
                validationCount++;
            }
        }
        if (validationCount > arr.Length / 2)
        {
            return candidate.ToString();
        }
        else
        {
            return "nu exista";
        }
    }
  
    static void PrintArray(int[] arr)
    {
        Console.WriteLine("Vector: " + string.Join(", ", arr));
    }

    static void Main()
    {
        int[] arr = { 3, 3, 4, 2, 4, 4, 2, 4, 4 };
        PrintArray(arr);
        string result = FindMaj(arr);
        Console.WriteLine(result);
    }
}
