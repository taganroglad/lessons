Console.WriteLine("Print the digit");
int number = int.Parse(Console.ReadLine());

Console.WriteLine("Print the first digit");
int firstNumber = int.Parse(Console.ReadLine());

Console.WriteLine("Print the second digit");
int secondNumber = int.Parse(Console.ReadLine());

bool result = isMultiplyTwoNumbers(number, firstNumber, secondNumber);
Console.WriteLine(result? "Digit is multiply" : "Digit isn't multiply");

bool isMultiplyTwoNumbers(int number, int firstNumber, int secondNumber)
{
    return number % firstNumber == 0 && number % secondNumber == 0;
}

