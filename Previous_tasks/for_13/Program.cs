using System;

public class Program
{
    public static int Counting(string message)
    {
        Console.WriteLine(message);
        string value = Console.ReadLine();
        int result = Convert.ToInt32(value);
        return result;
    }

    public static void Main()
    {
        int x = Counting("Print any three-digit number");

        if (x > 999 || x < 100)
        {
            Console.WriteLine("This is not a three-digit number");
            return;
        }

        int thirdDigit = x % 10;
        Console.WriteLine($"The third digit is {thirdDigit}");
    }
}
