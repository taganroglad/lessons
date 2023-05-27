// у меня лицензия windows не российская, видимо поэтому после запуска программы выводяться "???"
// Приходиться писать на английском 
using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = GenerateRandomArray(10);
        Console.WriteLine("array:");
        PrintArray(arr);

        int sumOddElements = SumOddPositionElements(arr);
        Console.WriteLine("sum of elements at odd positions: " + sumOddElements);
    }

    static int[] GenerateRandomArray(int length)
    {
        int[] arr = new int[length];
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            arr[i] = random.Next(1, 100);
        }

        return arr;
    }

    static int SumOddPositionElements(int[] arr)
    {
        int sumOdd = 0;

        for (int i = 1; i < arr.Length; i += 2)
        {
            sumOdd += arr[i];
        }

        return sumOdd;
    }

    static void PrintArray(int[] arr)
    {
        foreach (int number in arr)
        {
            Console.Write(number + " ");
        }
        Console.WriteLine();
    }
}
