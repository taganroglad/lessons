
Console.Write("Print a digit N: ");
int n = Convert.ToInt32(Console.ReadLine());

    for (int i = 1; i <= n; i++)
    {
        int cube = i * i * i;
        Console.Write($"{cube} ");
    }

Console.WriteLine();
    