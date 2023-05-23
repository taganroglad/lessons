    using System;

namespace DistanceCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("print cords for  A (x,y,z):");
            string[] a = Console.ReadLine().Split(',');

            Console.WriteLine("print cords for B (x,y,z):");
            string[] b = Console.ReadLine().Split(',');

            double x1 = Convert.ToDouble(a[0].Trim());
            double y1 = Convert.ToDouble(a[1].Trim());
            double z1 = Convert.ToDouble(a[2].Trim());

            double x2 = Convert.ToDouble(b[0].Trim());
            double y2 = Convert.ToDouble(b[1].Trim());
            double z2 = Convert.ToDouble(b[2].Trim());

            double distance = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2));

            Console.WriteLine($"Distance between A and B: {distance:F2}");
        }
    }
}
