using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("print numbers, separated by commas: ");
        string input = Console.ReadLine();

        // Разделение введенной строки на числа
        string[] numbers = input.Split(',');

        int count = 0;

        // Проверка каждого числа и подсчет положительных чисел
        foreach (string number in numbers)
        {
            int parsedNumber;
            if (int.TryParse(number.Trim(), out parsedNumber) && parsedNumber > 0)
            {
                count++;
            }
        }

        Console.WriteLine("Numbers of positives are: " + count);
    }
}
