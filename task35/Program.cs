// Задача 35: Задайте одномерный массив из 123 случайных чисел.
// Найдите количество элементов массива, значения которых лежат в
// отрезке [10,99].

int[] CreateFillArray(int size, int min, int max)
{
    int[] arr = new int[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(min, max + 1);
    }
    return arr;
}

void PrintArray(int[] arr)
{
    int length = arr.Length;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        if (length - i > 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

int CountTwoDigitNumbers(int[] arr)
{
    int count = 0;
    foreach (int num in arr)
    {
        if ((num >= 10 && num <= 99) || (num >= -99 && num <= -10)) count++;
    }
    return count;
}

int[] array = CreateFillArray(12, -1000, 1000);
PrintArray(array);
int result = CountTwoDigitNumbers(array);
Console.WriteLine((result == 1) ? $"There is {result} two-digit number in the array" : $"There are {result} two-digit numbers in the array");
