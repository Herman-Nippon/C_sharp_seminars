// Задача 47. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.

double[,] CreateFillMatrix(int m, int n, int lowerBound, int upperBound, int digitsToRound = 2)
{
    double[,] arr = new double[m,n];
    var rnd = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            double value = rnd.NextDouble() * (upperBound - lowerBound) + upperBound;
            arr[i, j] = Math.Round(value, digitsToRound);
        }
    }
    return arr;
}

void PrintMatrix(double[,] arr)
{
    for (int i = 0; i < arr.GetLength(0); i++)
    {

        for (int j = 0; j < arr.GetLength(1); j++)
        {
            Console.Write($"{arr[i,j], 8}");
        }

        Console.WriteLine();
    }
}

int[] PromptSizeArray()
{
    int[] dimensions = new int[2];

    Console.Write("Enter the amount of rows: ");
    dimensions[0] = Convert.ToInt32(Console.ReadLine());
    Console.Write("Enter the amount of columns: ");
    dimensions[1] = Convert.ToInt32(Console.ReadLine());

    if (dimensions[0] < 1 || dimensions[1] < 1) return null!;
    return dimensions;
}

int[] sizeArray = PromptSizeArray();
if (sizeArray == null)
{
    Console.WriteLine("Incorrect input");
    return;
}

double[,] array = CreateFillMatrix(sizeArray[0], sizeArray[1], 0, 10);
PrintMatrix(array);
