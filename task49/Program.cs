// Задача 49: Задайте двумерный массив. Найдите элементы, у
// которых оба индекса чётные, и замените эти элементы на их
// квадраты.

int[,] CreateFillMatrix(int m, int n)
{
    int[,] arr = new int[m,n];
    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i,j] = rnd.Next(1, 10);
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
            Console.Write($"{arr[i,j], 4}");
        }

        Console.WriteLine();
    }
}

void ReplaceEvenElements(int[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i += 2)
    {
        for (int j = 0; j < arr.GetLength(1); j += 2)
        {
            arr[i,j] = arr[i,j] * arr[i,j];
        }
    }
}

int[,] array = CreateFillMatrix(5, 5);
PrintMatrix(array);
ReplaceEvenElements(array);
Console.WriteLine();
PrintMatrix(array);
