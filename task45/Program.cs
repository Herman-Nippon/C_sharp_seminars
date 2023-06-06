// Задача 45: Напишите программу, которая будет создавать
// копию заданного массива с помощью поэлементного
// копирования.

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

int[] CopyArray(int[] arr)
{
    int len = arr.Length;
    int[] newArr = new int[len];
    for (int i = 0; i < len; i++)
    {
        newArr[i] = arr[i];
    }
    return newArr;
}

int[] array = CreateFillArray(5, 1, 10);
PrintArray(array);
int[] newArray = CopyArray(array);
PrintArray(newArray);
