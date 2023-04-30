Console.WriteLine("Type any three -digit integer");
int Number = Convert.ToInt32(Console.ReadLine());
if (Number >= 100 & Number <= 999)
{
    int last_number = Number % 10;
    Console.WriteLine($"Last number is {last_number}");
}
else
{
    Console.WriteLine("The number is not three -digit");
}