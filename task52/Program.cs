// Задача 52. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.

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

void PrintAverages(double[] arr, int digits = 2)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.WriteLine($"Column {i} average is {Math.Round(arr[i], digits)}");
    }
}

double[] GetColumnsAverage(int[,] arr)
{   
    int rows = arr.GetLength(0), columns = arr.GetLength(1);
    double[] averagesCol = new double[columns];
    for (int j = 0; j < columns; j++)
    {
        double sumCol = 0;
        for (int i = 0; i < rows; i++)
        {
            sumCol += arr[i, j];
        }
        averagesCol[j] = sumCol / rows;
    }
    return averagesCol;
}

int[,] array = CreateFillMatrix(4, 3);
PrintMatrix(array);

Console.WriteLine();
PrintAverages(GetColumnsAverage(array));
