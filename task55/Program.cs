// Задача 55: Задайте двумерный массив. Напишите программу,
// которая заменяет строки на столбцы. В случае, если это
// невозможно, программа должна вывести сообщение для
// пользователя.

int[,] CreateFillMatrix(int m, int n)
{
    int[,] arr = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rnd.Next(1, 10);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i, j],4}");
        }

        Console.WriteLine();
    }
}

bool IsValidMatrix(int[,] arr)
{
    return arr.GetLength(0) == arr.GetLength(1);
}

// void SwapRowsColumns(int[,] arr)
// {
//     for (int i = 0; i < arr.GetLength(0) - 1; i++)
//     {
//         for (int j = i + 1; j < arr.GetLength(1); j++)
//         {
//             int temp = arr[i, j];
//             arr[i, j] = arr[j, i];
//             arr[j, i] = temp;
//         }
//     }
// }

void SwapRowsColumns1(int[,] arr)
{
    for (int i = arr.GetLength(0) - 1; i > 0; i--)
    {
        for (int j = 0; j < i; j++)
        {
            int temp = arr[i, j];
            arr[i, j] = arr[j, i];
            arr[j, i] = temp;
        }
    }
}

int[,] array = CreateFillMatrix(4, 4);
PrintMatrix(array);
Console.WriteLine();

if (!IsValidMatrix(array))
{
    Console.WriteLine("Invalid matrix");
    return;
}

SwapRowsColumns1(array);
PrintMatrix(array);
