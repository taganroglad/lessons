Console.WriteLine("Type any integer");
int Number = Convert.ToInt32(Console.ReadLine());
int count = -Number;
while (Number >= count)
{
    Console.WriteLine($"{count}");
    count++;
    }
Console.WriteLine();