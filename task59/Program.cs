// Задача 59: Задайте двумерный массив из целых чисел.
// Напишите программу, которая удалит строку и столбец, на
// пересечении которых расположен наименьший элемент
// массива.

int[,] CreateFillMatrix(int m, int n, int min, int max)
{
    int[,] arr = new int[m, n];
    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            arr[i, j] = rnd.Next(min, max + 1);
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

int[] FindMin(int[,] matr)
{
    int[] minIndexes = new int[2];
    int minElem = matr[0, 0];
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (minElem > matr[i, j])
            {
                minElem = matr[i, j];
                minIndexes[0] = i;
                minIndexes[1] = j;
            }
        }
    }
    return minIndexes;
}

int[,] RemoveRowCol(int[] indexes, int[,] matr)
{
    int rows = matr.GetLength(0) - 1;
    int columns = matr.GetLength(1) - 1;
    int[,] newMatr = new int[rows, columns];

    for (int i = 0, m = 0; i < rows; i++, m++)
    {
        if (m == indexes[0]) m++;

        for (int j = 0, n = 0; j < columns; j++, n++)
        {
            if (n == indexes[1]) n++;

            newMatr[i, j] = matr[m, n];
        }
    }
    return newMatr;
}

int[,] matrix = CreateFillMatrix(4, 4, 1, 10);
PrintMatrix(matrix);
Console.WriteLine();

int[] minIndexes = FindMin(matrix);
int[,] newMatr = RemoveRowCol(minIndexes, matrix);
PrintMatrix(newMatr);
