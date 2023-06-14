// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)


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

void Print3dArray(int[,,] arr, int third_dim)
{
    for (int i = 0, count_elem = 1; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++, count_elem++)
            {
                Console.Write($"{arr[i, j, k]}({i},{j},{k}) ");
                if (count_elem % third_dim == 0) Console.WriteLine();
            }
        }
    }
    Console.WriteLine();
}

void Fill3dArrayRandom(int[,,] arr, int startNumber, int endNumber)
{
    // creates an array of unique numbers in the desired range
    int[] uniqueNumbers = Enumerable.Range(startNumber, endNumber - startNumber + 1).ToArray();

    Random rnd = new Random(); // creates new object of Random class
    int endIndex = uniqueNumbers.Length - 1;

    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                int randomValueIndex = rnd.Next(endIndex + 1); // generate random index
                arr[i, j, k] = uniqueNumbers[randomValueIndex]; // pick a unique number with the random index

                // remove the picked number from the array of unique numbers
                uniqueNumbers[randomValueIndex] = uniqueNumbers[endIndex]; 

                endIndex--; // restrict access to the duplicate
            }
        }
    }
}

bool IsUniqueArray(int[,,] arr)
{
    HashSet<int> set = new HashSet<int>();
    for (int i = 0; i < arr.GetLength(0); i++)
    {
        for (int j = 0; j < arr.GetLength(1); j++)
        {
            for (int k = 0; k < arr.GetLength(2); k++)
            {
                if (set.Contains(arr[i, j, k])) return false;
                else set.Add(arr[i, j, k]);
            }
        }
    }
    return true;
}

string[] strPrompts = new string[]{"Rows", "Columns", "Depth", "Min value", "Max value"};
int[] input = ConsoleGetInput(strPrompts);

if (input == null)
{
    Console.WriteLine("Incorrect input, you must provide integer numbers");
    return;
}

int rows = input[0], columns = input[1], depth = input[2], lowerBound = input[3], upperBound = input[4];

if (rows < 1 || columns < 1 || depth < 1)
{
    Console.WriteLine("Incorrect input, you must assign a valid number to dimensions");
    return;
}
else if (rows * columns * depth > upperBound - lowerBound + 1)
{
    Console.WriteLine("There are not enough numbers for that 3d array");
    return;
}

Console.WriteLine();
int[,,] array3d = new int[rows, columns, depth];
Fill3dArrayRandom(array3d, lowerBound, upperBound);
Print3dArray(array3d, depth);
Console.WriteLine(IsUniqueArray(array3d) ? "There are no repeating numbers in the array" : "There are repeating numbers in the array");
