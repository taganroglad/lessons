using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the definition M: ");
        int M = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the definition N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        int sum = CalculateSum(M, N);
        Console.WriteLine("Sum of numbers from {0} to {1}: {2}", M, N, sum);
    }

    static int CalculateSum(int start, int end)
    {
        if (start > end)
            return 0;

        return start + CalculateSum(start + 1, end);
    }
}
