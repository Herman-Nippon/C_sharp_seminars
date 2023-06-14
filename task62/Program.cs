// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

bool CheckUnfinished(int num, int rows, int cols)
{
    return num <= rows * cols;
}

void FillMatrixSpirally(int[,] matr, int rows, int cols)
{
    int rowStart = 0, rowEnd = rows - 1, colStart = 0, colEnd = cols - 1, num = 1;

    while (CheckUnfinished(num, rows, cols))
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            matr[rowStart, i] = num++;
        }
        rowStart++;
        if (!CheckUnfinished(num, rows, cols)) break;
        
        for (int i = rowStart; i <= rowEnd; i++)
        {
            matr[i, colEnd] = num++;
        }
        colEnd--;
        if (!CheckUnfinished(num, rows, cols)) break;

        for (int i = colEnd; i >= colStart; i--)
        {
            matr[rowEnd, i] = num++;
        }
        rowEnd--;
        if (!CheckUnfinished(num, rows, cols)) break;

        for (int i = rowEnd; i >= rowStart; i--)
        {
            matr[i, colStart] = num++;
        }
        colStart++;
    }
}

void PrintMatrix(int[,] matr)
{
    for (int i = 0; i < matr.GetLength(0); i++)
    {
        for (int j = 0; j < matr.GetLength(1); j++)
        {
            Console.Write($"{matr[i, j],5}");
        }
        Console.WriteLine();
    }
}

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

int numberRows = GetIntegerFromUser("Rows: ");
int numberColumns = GetIntegerFromUser("Columns: ");

if (numberRows < 1 || numberColumns < 1)
{
    Console.WriteLine("Incorrect input, rows and columns numbers must be greater than 0");
    return;
}

int[,] matrix = new int[numberRows, numberColumns];

FillMatrixSpirally(matrix, numberRows, numberColumns);
Console.WriteLine();
PrintMatrix(matrix);




