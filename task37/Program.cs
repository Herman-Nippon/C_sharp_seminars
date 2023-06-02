// Задача 37: Найдите произведение пар чисел в одномерном массиве.
// Парой считаем первый и последний элемент, второй и предпоследний
// и т.д. Результат запишите в новом массиве.
// [1 2 3 4 5] -> 5 8 3
// [6 7 3 6] -> 36 21

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

int[] MultiplyElementsPairs(int[] arr)
{
    int len = arr.Length;
    int newLen = len / 2;
    if (len % 2 == 1) newLen++;
    
    int[] result = new int[newLen];
    
    for (int i = 0; i < len / 2; i++)
    {
        result[i] = arr[i] * arr[len - 1 - i];
    }

    if (len % 2 == 1)
        result[newLen - 1] = arr[len / 2];
    return result;
}

int[] array = CreateFillArray(3, 0, 10);
PrintArray(array);
int[] array1 = MultiplyElementsPairs(array);
PrintArray(array1);
