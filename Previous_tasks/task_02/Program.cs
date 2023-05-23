// У меня не поддерживается русский язык при выводе в консоль, новый ноут, лицензия только на английский язык
Console.WriteLine("Print a first integer");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Print a second integer");
int Number2 = Convert.ToInt32(Console.ReadLine());
if (Number1 > Number2)
    Console.WriteLine("First number is greater than second");
else if (Number1 == Number2)
    Console.WriteLine("Numbers are equal");
else Console.WriteLine("Second number is greater than first");