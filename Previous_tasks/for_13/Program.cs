int counting(string message)
{
    Console.Write(message);
    string value = Console.Readline();
    int result = Convert.ToInt32(value);
    return result;
}
int x = counting("pring any three-digit number");
if (x > 999 || x < 100)
{
    Console.WriteLine("This is not three digit number");
    return;
}
int thirdrank = x / 100 % 100;
System.Console.WriteLine($"The third digit is {thirdrank}");
