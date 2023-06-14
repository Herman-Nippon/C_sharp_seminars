// Задайте две матрицы. Напишите программу, которая будет находить произведение двух матриц.
// Например, даны 2 матрицы:
// 2 4 | 3 4
// 3 2 | 3 3
// Результирующая матрица будет:
// 18 20
// 15 18

int GetIntegerFromUser(string prompt)
{
    int intValue;
    bool isValidNumber;

    do
    {
        Console.Write(prompt);
        isValidNumber = int.TryParse(Console.ReadLine(), out intValue);

        if (!isValidNumber) Console.WriteLine("Invalid input. Please, enter an integer.");
    } while (!isValidNumber);

    return intValue;
}

bool ValidDimensions(int rows, int columns)
{
    return (rows > 0) && (columns > 0);
}

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

bool AreMultipliableMatrices(int[,] matr1, int[,] matr2)
{
    return matr1.GetLength(1) == matr2.GetLength(0);
}

int[,] MultiplyMatrices(int[,] matr1, int[,] matr2)
{
    if (!AreMultipliableMatrices(matr1, matr2)) return null!;

    int commonDimension = matr1.GetLength(1); // n in "A is an m × n matrix and B is an n × p matrix"
    int rowsProduct = matr1.GetLength(0);
    int columnsProduct = matr2.GetLength(1);
    int[,] multiplicationProduct = new int[rowsProduct, columnsProduct];

    for (int i = 0; i < rowsProduct; i++)
    {
        for (int j = 0; j < columnsProduct; j++)
        {
            // matrices multiplication is here
            for (int k = 0; k < commonDimension; k++)
            {
                multiplicationProduct[i, j] += matr1[i, k] * matr2[k, j];
            }
        }
    }

    return multiplicationProduct;
}

void PrintMatrix(string prompt, int[,] matr)
{
    Console.WriteLine(prompt);
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],4}");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Enter dimensions of the first matrix");
int row1 = GetIntegerFromUser("Row: ");
int column1 = GetIntegerFromUser("Column: ");

Console.WriteLine("\nEnter dimensions of the second matrix");
int row2 = GetIntegerFromUser("Row: ");
int column2 = GetIntegerFromUser("Column: ");

if (!ValidDimensions(row1, column1) || !ValidDimensions(row2, column2))
{
    Console.WriteLine("Invalid input. Dimensions must be greater than 0.");
    return;
}

int[,] matrix1 = CreateFillMatrix(row1, column1);
PrintMatrix("\nThe first matrix is:", matrix1);
int[,] matrix2 = CreateFillMatrix(row2, column2);
PrintMatrix("\nThe second matrix is:", matrix2);

int[,] resultMatrix = MultiplyMatrices(matrix1, matrix2);
if (resultMatrix == null)
{
    Console.WriteLine("\nIncompatible matrices.");
    return;
}

PrintMatrix("\nThe multiplication product is:", resultMatrix);
