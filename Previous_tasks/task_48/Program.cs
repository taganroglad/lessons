int ReadInt(string text)
{
    System.Console.Write(text);
    return Convert.ToInt32(Console.ReadLine());
}
int m = ReadInt("print the number of columns  ");
int n = ReadInt("print the number of rows  ");

int [,] Macciv = new int[m, n];
for (int i = 0; i < Macciv.GetLength(0); i++)
{
    for (int j = 0; j < Macciv.GetLength(1); j++)
    {
        Macciv[i, j] = i + j;
    }
}