using System;

class Program
{
    static void Main(string[] args)
    {
        int m = 3; 
        int n = 4; 

        double[,] array = new double[m, n];
        Random random = new Random();

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                array[i, j] = random.NextDouble() * 20 - 10; 
            }
        }

        for (int i = 0; i < m; i++)
        {
            for (int j = 0; j < n; j++)
            {
                Console.Write(array[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
