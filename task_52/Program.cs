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

        int numRows = array.GetLength(0);
        int numColumns = array.GetLength(1);

        double[] columnAverages = new double[numColumns];

        for (int j = 0; j < numColumns; j++)
        {
            int sum = 0;

            for (int i = 0; i < numRows; i++)
            {
                sum += array[i, j];
            }

            columnAverages[j] = (double)sum / numRows;
        }

        Console.Write("Average of each coloumn is : ");

        for (int j = 0; j < numColumns; j++)
        {
            Console.Write(columnAverages[j].ToString("F1"));

            if (j < numColumns - 1)
            {
                Console.Write("; ");
            }
        }

        Console.WriteLine();
    }
}
