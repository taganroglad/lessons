// у меня лицензия windows не российская, видимо поэтому после запуска программы выводяться "???"
// Приходиться писать на английском 
using System;

class Program
{
    static void Main(string[] args)
    {
        double[] arr = { 3, 7, 22, 2, 78 };
        double difference = FindMaxMinDifference(arr);

        Console.WriteLine("Difference between max and min elements are: " + difference);
    }

    static double FindMaxMinDifference(double[] arr)
    {
        double max = arr[0];
        double min = arr[0];

    
        foreach (double number in arr)
        {
            if (number > max)
            {
                max = number;
            }

            if (number < min)
            {
                min = number;
            }
        }

        double difference = max - min;
        return difference;
    }
}
