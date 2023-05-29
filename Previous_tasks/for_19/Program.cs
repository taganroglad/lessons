System.Console.WriteLine("print any five-digit number");
string? x = Console.ReadLine();
if (x.Length != 5)
{
    System.Console.WriteLine("this is not five-digit number");
}
else if (x[0] == x[4] && x[1] == x[3])
{
    Console.WriteLine("yes, this is palindorum");
}
else
{
    Console.WriteLine("this is not palindorum");
}