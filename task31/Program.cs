// Задача 31: Задайте массив из 12 элементов, заполненный
// случайными числами из промежутка [-9, 9]. Найдите сумму
// отрицательных и положительных элементов массива.

int PositiveSum(int[] arr)
{
    int posSum = 0;
    foreach (int num in arr)
    {
        if (num > 0) posSum += num;
    }
    return posSum;
}

int NegativeSum(int[] arr)
{
    int negSum = 0;
    foreach (int num in arr)
    {
        if (num < 0) negSum += num;
    }
    return negSum;
}

void FillArray(int[] arr)
{
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        arr[i] = rand.Next(-9, 10);
    }
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

int[] array = new int[12];
FillArray(array);
PrintArray(array);

Console.WriteLine($"The sum of negative elements is {NegativeSum(array)}");
Console.WriteLine($"The sum of positive elements is {PositiveSum(array)}");
