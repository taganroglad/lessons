using System;

class Program
{
    static void Main(string[] args)
    {
        int n = 4; 
        int[,] matrix = new int[n, n]; 

        int value = 1; 
        int minRow = 0;
        int maxRow = n - 1;
        int minCol = 0;
        int maxCol = n - 1;

        while (value <= n * n)
        {
            
            for (int col = minCol; col <= maxCol; col++)
            {
                matrix[minRow, col] = value;
                value++;
            }
            minRow++;

            
            for (int row = minRow; row <= maxRow; row++)
            {
                matrix[row, maxCol] = value;
                value++;
            }
            maxCol--;

            
            for (int col = maxCol; col >= minCol; col--)
            {
                matrix[maxRow, col] = value;
                value++;
            }
            maxRow--;

            
            for (int row = maxRow; row >= minRow; row--)
            {
                matrix[row, minCol] = value;
                value++;
            }
            minCol++;
        }

        
        for (int row = 0; row < n; row++)
        {
            for (int col = 0; col < n; col++)
            {
                Console.Write(matrix[row, col].ToString().PadLeft(2, '0') + " ");
            }
            Console.WriteLine();
        }
    }
}
