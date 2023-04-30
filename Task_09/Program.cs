/*int numberRandom = new Random().Next(10, 100);
Console.WriteLine($"random digit of cut of 10 - 99 ----- {numberRandom}");
int firstDigit = numberRandom / 10;
int secondDigit = numberRandom % 10;
//if (firstDigit > secondDigit)
//{
//  Console.WriteLine($"The biggest number is firstdigit     {firstDigit}");
//}
//else
//{
//  Console.WriteLine($"The biggest number is secondDigit     {secondDigit}");
//}
int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
{
    Console.WriteLine($"The biggest number is secondDigit     {maxDigit}");
}
*/

int maxDigit = maxDigit(numRandom);
Console.WriteLine(maxDigit);

int maxDigit (int numRandom)
{
    int firstDigit = numRandom / 10;
    int secondDigit = numRandom % 10;
    int maxDigit = firstDigit > secondDigit ? firstDigit : secondDigit;
    return maxDigit;

}

