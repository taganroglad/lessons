int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int number = ReadInt("insert the number:   ");

int factorial = 1;
for (int i = 1;  i <= number; i++)
{
    factorial = factorial * i;
}
System.Console.WriteLine(factorial);
