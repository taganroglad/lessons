using System;

class Program
{
    static void Main(string[] args)
    {
        int[,] array = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

        Console.Write("Enter the number of row: ");
        int row = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter the number of coloumn: ");
        int column = Convert.ToInt32(Console.ReadLine());

        int numRows = array.GetLength(0);
        int numColumns = array.GetLength(1);

        if (row >= 0 && row < numRows && column >= 0 && column < numColumns)
        {
            int element = array[row, column];
            Console.WriteLine("Element value: " + element);
        }
        else
        {
            Console.WriteLine("There is no such element.");
        }
    }
}
