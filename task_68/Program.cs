using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the definition m: ");
        int m = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the definition n: ");
        int n = Convert.ToInt32(Console.ReadLine());

        int result = AckermannFunction(m, n);
        Console.WriteLine("A({0},{1}) = {2}", m, n, result);
    }

    static int AckermannFunction(int m, int n)
    {
        if (m == 0)
            return n + 1;

        if (m > 0 && n == 0)
            return AckermannFunction(m - 1, 1);

        if (m > 0 && n > 0)
            return AckermannFunction(m - 1, AckermannFunction(m, n - 1));

        return -1; // В случае некорректных входных данных
    }
}
