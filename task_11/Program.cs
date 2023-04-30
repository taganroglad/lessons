int anyNumber = new Random().Next(100, 1000);
Console.WriteLine(anyNumber);
int firstDigit = anyNumber / 100;
int thirdDigit = anyNumber % 10;
Console.WriteLine(anyNumber);
Console.WriteLine((firstDigit * 10) + thirdDigit);