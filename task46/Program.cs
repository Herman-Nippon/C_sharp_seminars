// Задача 46: Задайте двумерный массив размером m×n,
// заполненный случайными целыми числами.


int[,] CreateFillMatrix(int m, int n)
{
    int[,] arr = new int[m,n];
    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = rnd.Next(10, 101);
        }
    }
    return arr;
}

void PrintMatrix(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        Console.Write("[");

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (j == 0) Console.Write($"{arr[i,j], 1}");
            else Console.Write($"{arr[i,j], 4}");
        }

        Console.Write("]");
        Console.WriteLine();
    }
}

int[,] array = CreateFillMatrix(3, 4);
PrintMatrix(array);
