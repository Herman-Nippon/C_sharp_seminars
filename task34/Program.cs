// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

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

int GetAmountEvenNums(int[] arr)
{
    int count = 0;
    foreach (int num in arr)
    {
        if (num % 2 == 0) count++;
    }
    return count;
}

int[] array = CreateFillArray(10, 100, 999);
PrintArray(array);
int res = GetAmountEvenNums(array);
Console.WriteLine((res == 1) ? $"There is {res} even number in the array" : $"There are {res} even numbers in the array");
