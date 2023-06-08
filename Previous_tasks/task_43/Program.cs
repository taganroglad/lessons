using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Print arg. b1: ");
        double b1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Print arg. k1: ");
        double k1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Print arg. b2: ");
        double b2 = Convert.ToDouble(Console.ReadLine());

        Console.Write("Print arg. k2: ");
        double k2 = Convert.ToDouble(Console.ReadLine());

        double x = (b2 - b1) / (k1 - k2);
        double y = k1 * x + b1;

        Console.WriteLine("The intersectiom point of two lines: ({0}; {1})", x, y);
    }
}
