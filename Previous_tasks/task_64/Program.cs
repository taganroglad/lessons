using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter the definition N: ");
        int N = Convert.ToInt32(Console.ReadLine());

        PrintNaturalNumbers(N);
    }

    static void PrintNaturalNumbers(int number)
    {
        if (number > 0)
        {
            Console.Write(number + " ");
            PrintNaturalNumbers(number - 1);
        }
    }
}
