using System;

class Program
{
    static void Main(string[] args)
    {

        string[] inputArray = { "abc", "defg", "hi", "jklmn" };

        
        string[] filteredArray = FilterStrings(inputArray);
        
        Console.WriteLine("Отфильтрованный массив строк:");
        foreach (string str in filteredArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterStrings(string[] inputArray)
    {
        int count = 0;
               for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }