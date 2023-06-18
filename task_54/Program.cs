using System;

class Program
{
    static void Main()
    {
     
        int[,] matrix = {
            { 1, 4, 7, 2 },
            { 5, 9, 2, 3 },
            { 8, 4, 2, 4 }
        };

       
        SortRowsDescending(matrix);

        
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }
    }

    static void SortRowsDescending(int[,] matrix)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            
            int[] temp = new int[matrix.GetLength(1)];

            
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                temp[j] = matrix[i, j];
            }

            
            Array.Sort(temp);
            Array.Reverse(temp);

            
            for (int j = 0; j < matrix.GetLength(1); j++)
            {
                matrix[i, j] = temp[j];
            }
        }
    }
}
