using System;

class Program
{
    static void Main()
    {
        int[,,] array = GenerateArray();

        Console.WriteLine("tridimensional array with index:");

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    Console.WriteLine($"{array[i, j, k]}({i},{j},{k})");
                }
            }
        }
    }

    static int[,,] GenerateArray()
    {
        int[,,] array = new int[2, 2, 2];
        int number = 25;

        for (int i = 0; i < array.GetLength(0); i++)
        {
            for (int j = 0; j < array.GetLength(1); j++)
            {
                for (int k = 0; k < array.GetLength(2); k++)
                {
                    array[i, j, k] = number;
                    number++;
                }
            }
        }

        return array;
    }
}
