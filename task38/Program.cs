// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.
// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] CreateFillArray(int size, int lowerBound, int upperBound, int digits = 2)
{
    double[] arr = new double[size];
    Random rand = new Random();
    for (int i = 0; i < arr.Length; i++)
    {
        double num = rand.NextDouble() * (upperBound - lowerBound) + lowerBound;
        arr[i] = Math.Round(num, digits);
    }
    return arr;
}

void PrintArray(double[] arr)
{
    int length = arr.Length;
    Console.Write("[");
    for (int i = 0; i < length; i++)
    {
        if (length - i > 1)
            Console.Write($"{arr[i]}, ");
        else
            Console.Write($"{arr[i]}");
    }
    Console.WriteLine("]");
}

double[] GetMinMax(double[] arr, int min, int max)
{
    double[] MinMax = new double[2];
    MinMax[0] = Convert.ToDouble(max); // initialise min number with the biggest number possible in the array
    MinMax[1] = Convert.ToDouble(min); // initialise max number with the smallest number possible in the array

    foreach (double num in arr)
    {
        if (MinMax[0] > num) MinMax[0] = num;
        if (MinMax[1] < num) MinMax[1] = num;
    }
    return MinMax;
}

int minNumber = 0, maxNumber = 20;
double[] array = CreateFillArray(5, minNumber, maxNumber);
PrintArray(array);

double[] MinMaxArray = GetMinMax(array, minNumber, maxNumber);

// converting result to number with two digits after decimal point
string resultStr = String.Format("{0:0.00}", MinMaxArray[1] - MinMaxArray[0]);

Console.WriteLine($"{MinMaxArray[1]} - {MinMaxArray[0]} = {resultStr}");
