int Den(string text)
{
    Console.WriteLine(text);
    string value = Console.ReadLine();
    int result = Convert.ToInt32(value);
    return result;
}

int vhod = Den("Print the number of the day");
    if (vhod > 5) 
    {
    Console.WriteLine("This day is weekend");
    }
    else Console.WriteLine("This is weekday");