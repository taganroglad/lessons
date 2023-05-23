Console.WriteLine($"Print the first number");
int number1 =Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Print the second number");
int number2 = Convert.ToInt32(Console.ReadLine());

int remainderofdevideing(int num1, int num2);
{
return num1 % num2;
}


void WriteResult(int reminder)
{
    if (reminder == 0 )
    {
        Console.WriteLine($"multiples");
    }
    else
    {
        Console.WriteLine($"not multiples, reminder{reminder}");
    }
}

int result = remainderofdevideing(number1 , number2);  
WriteResult(result);



