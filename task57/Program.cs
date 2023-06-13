// Задача 57: Составить частотный словарь элементов
// двумерного массива. Частотный словарь содержит
// информацию о том, сколько раз встречается элемент
// входных данных.

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

SortedDictionary<int, int> CountElements(int[,] arr)
{
    SortedDictionary<int, int> elements = new SortedDictionary<int, int>();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            if (elements.ContainsKey(arr[i, j]))
            {
                elements[arr[i, j]]++;
            }
            else
            {
                elements[arr[i, j]] = 1;
            }
        }
    }
    return elements;
}

void PrintDict(SortedDictionary<int, int> dict)
{
    foreach (var item in dict)
    {
        Console.WriteLine($"\"{item.Key}\": {item.Value}");
    }
}

int[,] matrix = CreateFillMatrix(5, 5);
PrintMatrix(matrix);
Console.WriteLine();

PrintDict(CountElements(matrix));
