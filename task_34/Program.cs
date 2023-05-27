//Задача 34: Задайте массив заполненный случайными положительными
//трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

//[345, 897, 568, 234] -> 2

using System;

class Program
{
    static void Main(string[] args)
    {
        int[] numbers = GenerateRandomArray(4);
        int count = CountEvenNumbers(numbers);

        Console.WriteLine("Generated numbers are:");
        PrintArray(numbers);

        Console.WriteLine("number of evens: " + count);
    }

    static int[] GenerateRandomArray(int length)
    {
        int[] arr = new int[length];
        Random random = new Random();

        for (int i = 0; i < length; i++)
        {
            arr[i] = random.Next(100, 1000);
        }

        return arr;
    }

    static int CountEvenNumbers(int[] arr)
    {
        int count = 0;

        foreach (int number in arr)
        {
            if (number % 2 == 0)
            {
                count++;
            }
        }

        return count;
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
