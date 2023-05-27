int Promt(string message)
{
    System.Console.WriteLine(message);
    string value = System.Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int chislo = Promt("print three-digit number");
if (chislo > 999 || chislo <100)
{
    Console.WriteLine("this is not three digit");
}
int seconrank = chislo / 10 % 10;
Console.WriteLine($"second rank is {seconrank}");
