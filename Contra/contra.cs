using System;

class Program
{
    static void Main(string[] args)
    {

        string[] inputArray = { "abc", "defg", "hi", "jklmn" };

        
        string[] filteredArray = FilterStrings(inputArray);
        
        Console.WriteLine("Filtered string array:");
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

        string[] resultArray = new string[count];
        int resultIndex = 0;
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[resultIndex] = inputArray[i];
                resultIndex++;
            }
        }

        return resultArray;
    }
}




