// Задайте двумерный массив. Напишите программу, которая упорядочит по убыванию элементы каждой строки двумерного массива.
// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// В итоге получается вот такой массив:
// 7 4 2 1
// 9 5 3 2
// 8 4 4 2

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

void SortRowsDescending(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {

        // this is bubble sort for each sub-array in the matrix
        int length = matr.GetLength(1);
        for (int j = 0; j < length - 1; j++)
        {
            for (int k = 0; k < length - j - 1; k++)
            {
                if (matr[i, k] < matr[i, k + 1])
                {
                    int temp = matr[i, k];
                    matr[i, k] = matr[i, k + 1];
                    matr[i, k + 1] = temp;
                }
            }
        }
    }
}


int[,] matrix = CreateFillMatrix(4, 4);
PrintMatrix(matrix);
Console.WriteLine();

SortRowsDescending(matrix);
PrintMatrix(matrix);
