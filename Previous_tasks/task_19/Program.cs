
System.Console.WriteLine("Print any five-digit number");
String? str = Console.ReadLine();
if (str.Length != 5)
{
    System.Console.WriteLine("Incorrect data");
}
else if (str![0] == str![4] && str![1] == str![3])
{
    System.Console.WriteLine("yes, this is palindrom");
}
else
{
    System.Console.WriteLine("no, this is not palindrom");
}