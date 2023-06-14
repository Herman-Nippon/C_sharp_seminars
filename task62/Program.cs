// Задача 62. Напишите программу, которая заполнит спирально массив 4 на 4.
// Например, на выходе получается вот такой массив:
// 01 02 03 04
// 12 13 14 05
// 11 16 15 06
// 10 09 08 07

void FillMatrixSpirally(int[,] matr, int rows, int cols)
{
    int rowStart = 0, rowEnd = rows - 1, colStart = 0, colEnd = cols - 1, num = 1;

    if (rows == 1) // special case with one row
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            matr[rowStart, i] = num++;
        }
        return;
    }

    if (cols == 1) // special case with one column
    {
        for (int i = rowStart; i <= rowEnd; i++)
        {
            matr[i, colStart] = num++;
        }
        return;
    }

    while (num <= rows * cols) // general case
    {
        for (int i = colStart; i <= colEnd; i++)
        {
            matr[rowStart, i] = num++;
        }
        rowStart++;
        for (int i = rowStart; i <= rowEnd; i++)
        {
            matr[i, colEnd] = num++;
        }
        colEnd--;
        for (int i = colEnd; i >= colStart; i--)
        {
            matr[rowEnd, i] = num++;
        }
        rowEnd--;
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

int[] ConsoleGetInput(string[] prompts)
{
    int[] values = new int[prompts.Length];
    for (int i = 0; i < prompts.Length; i++)
    {
        Console.Write(prompts[i] + ": ");
        string input = Console.ReadLine()!;
        if (int.TryParse(input, out int intValue))
            values[i] = intValue;
        else
            return null!;
    }
    return values;
}

string[] strPrompts = new string[]{"Rows", "Columns"};
int[] input = ConsoleGetInput(strPrompts);

int numberRows = input[0], numberColumns = input[1];

int[,] matrix = new int[numberRows, numberColumns];

FillMatrixSpirally(matrix, numberRows, numberColumns);
PrintMatrix(matrix);




