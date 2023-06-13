// Задача 56: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку 
// с наименьшей суммой элементов.

// Например, задан массив:
// 1 4 7 2
// 5 9 2 3
// 8 4 2 4
// 5 2 6 7
// Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка


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

int SmallestSumRow(int[,] matr)
{
    int smallestSum = 0;
    int rowSmallestSum = 0;
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            if (i == 0) smallestSum += matr[i, j];
            else sum += matr[i, j];
        }

        if (i != 0 && sum < smallestSum)
        {
            smallestSum = sum;
            rowSmallestSum = i;
        }
    }
    return rowSmallestSum;
}


int[,] matr = CreateFillMatrix(3, 3);
PrintMatrix(matr);
Console.WriteLine();

Console.WriteLine($"The sum of elements is the smallest in {SmallestSumRow(matr) + 1} row");
