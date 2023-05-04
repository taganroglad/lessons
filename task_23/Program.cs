using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Print a digit N: ");
        int n = int.Parse(Console.ReadLine());

        for (int i = 1; i <= n; i++)
        {
            int cube = i * i * i;
            Console.Write($"{cube} ");
        }

        Console.WriteLine();
    }
}