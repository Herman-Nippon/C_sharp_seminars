// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. Напишите программу, 
// которая будет построчно выводить массив, добавляя индексы каждого элемента.
// Например, задан массив размером 2 x 2 x 2.
// Результат:
// 66(0,0,0) 25(0,1,0) 27(0,0,1) 90(0,1,1)
// 34(1,0,0) 41(1,1,0) 26(1,0,1) 55(1,1,1)


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

int rows = GetIntegerFromUser("Rows: ");
int columns = GetIntegerFromUser("Columns: ");
int depth = GetIntegerFromUser("Depth: ");
int lowerBound = GetIntegerFromUser("Min number: ");
int upperBound = GetIntegerFromUser("Max number: ");

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
