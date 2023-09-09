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