using System;
using System.Collections.Generic;

class Program
{
    static List<int> AddLargeNum(List<int> num1, List<int> num2)
    {
        int n1 = num1.Count, n2 = num2.Count;
        int maxLength = Math.Max(n1, n2);
        List<int> result = new List<int>(new int[maxLength + 1]);
        int carry = 0;
        int i = n1 - 1, j = n2 - 1, k = maxLength;
        
        while (i >= 0 || j >= 0 || carry != 0)
        {
            int sum = carry;
            if (i >= 0) sum += num1[i--];
            if (j >= 0) sum += num2[j--];  
            result[k--] = sum % 10;
            carry = sum / 10;
        }
        while (result.Count > 1 && result[0] == 0)
        {
            result.RemoveAt(0);
        }
        return result;
    }
    static List<int> SubtractLargeNum(List<int> num1, List<int> num2)
    {
        int n1 = num1.Count, n2 = num2.Count;
        List<int> result = new List<int>(new int[n1]);
        int borrow = 0;
        int i = n1 - 1, j = n2 - 1, k = n1 - 1;
        while (i >= 0)
        {
            int diff = num1[i] - borrow;
            if (j >= 0) diff -= num2[j--];
            
            if (diff < 0)
            {
                diff += 10;
                borrow = 1;
            }
            else
            {
                borrow = 0;
            }
            
            result[k--] = diff;
            i--;
        }
        while (result.Count > 1 && result[0] == 0)
        {
            result.RemoveAt(0);
        }
        return result;
    }
    static List<int> MultiplyLargeNum(List<int> num1, List<int> num2)
    {
        int n1 = num1.Count, n2 = num2.Count;
        List<int> result = new List<int>(new int[n1 + n2]); 
        for (int i = n1 - 1; i >= 0; i--)
        {
            for (int j = n2 - 1; j >= 0; j--)
            {
                int prod = num1[i] * num2[j] + result[i + j + 1];
                result[i + j + 1] = prod % 10;
                result[i + j] += prod / 10;
            }
        }
        while (result.Count > 1 && result[0] == 0)
        {
            result.RemoveAt(0);
        }
        
        return result;
    }
    static void PrintLargeNum(List<int> num)
    {
        foreach (var digit in num)
        {
            Console.Write(digit);
        }
        Console.WriteLine();
    }

    static void Main()
    {
        List<int> num1 = new List<int> { 1, 2, 3, 4 };
        List<int> num2 = new List<int> { 9, 8, 7 };
        List<int> sum = AddLargeNum(num1, num2);
        PrintLargeNum(sum);
        List<int> diff = SubtractLargeNum(num1, num2);
        PrintLargeNum(diff);
        List<int> product = MultiplyLargeNum(num1, num2);
        PrintLargeNum(product);
    }
}
