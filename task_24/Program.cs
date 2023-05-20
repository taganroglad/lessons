using System.Diagnostics.CodeAnalysis;

int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}
int summa = 0;
int number = ReadInt("print the digit:   ");


while (number != 0)
{
    number /= 10;
    summa += 1;
}

System.Console.WriteLine(summa);