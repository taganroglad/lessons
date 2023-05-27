int Promt(string message)
{
    System.Console.WriteLine(message);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
    
}

int number = Promt("put three digit number");
if (number < 100 ||  number > 999)
{
    Console.WriteLine("this is not three digit number");
    return;
}
int secondrank = number / 10 % 10;
Console.WriteLine($"second digit is {secondrank}");