using System;

class Program
{
    static void Main(string[] args)
    {
        // Введите или задайте исходный массив строк
        string[] inputArray = { "abc", "defg", "hi", "jklmn" };

        // Вызываем метод для фильтрации строк
        string[] filteredArray = FilterStrings(inputArray);

        // Выводим результат на экран
        Console.WriteLine("Отфильтрованный массив строк:");
        foreach (string str in filteredArray)
        {
            Console.WriteLine(str);
        }
    }

    static string[] FilterStrings(string[] inputArray)
    {
        int count = 0;
        // Определяем количество строк, которые удовлетворяют условию (длина <= 3 символа)
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                count++;
            }
        }

        // Создаем новый массив для отфильтрованных строк
        string[] resultArray = new string[count];
        int resultIndex = 0;

        // Заполняем новый массив отфильтрованными строками
        for (int i = 0; i < inputArray.Length; i++)
        {
            if (inputArray[i].Length <= 3)
            {
                resultArray[resultIndex] = inputArray[i];
                resultIndex++;
            }
        }

        return resultArray;
    }
}
