// У меня не поддерживается русский язык при выводе в консоль, новый ноут, лицензия только на английский язык
Console.WriteLine("Print a first integer");
int Number1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Print a second integer");
int Number2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Print a third integer");
int Number3 = Convert.ToInt32(Console.ReadLine());
if (Number1 > Number2 && Number1 > Number3)
    Console.WriteLine("First number is greater than second and third");
else if (Number2 > Number1 && Number2 > Number3)
    Console.WriteLine("Second number is greater than the first and third");
else Console.WriteLine("Third number is greater than first and second ones");