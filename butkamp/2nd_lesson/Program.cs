//Console.Clear();
//Console.WriteLine("print the number");
//int n = int.Parse(Console.ReadLine());
//Console.WriteLine($"result of sum from 1 to {n}: {(1 +n) / 2 * n}");

void InputArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
        array[i] = (i + 1) * 3;
}



int BinarySearch(int[] array, int element)
{
    int left = 0, right = array.Length - 1;
    while (left <= right)
    {
        int middle = (left + right) / 2;
        if (element == array[middle])
            return middle;

        else if (element < array[middle])
            right = middle - 1;
        else
            left = middle + 1;
    }
    return -1;
}

Console.Clear();
Console.Write("Напишите кол-во элементов массива: ");
int n = int.Parse(Console.ReadLine()!);
int[] array = new int[n];
InputArray(array);
Console.WriteLine($"[{string.Join(", ", array)}]"); // .Split()
Console.Write("Введите число, которое Вы хотите найти внутри массива: ");
int element = int.Parse(Console.ReadLine()!);
Console.WriteLine($"Результат: {BinarySearch(array, element)}");