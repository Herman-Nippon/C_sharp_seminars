// Задача 22: Напишите программу, которая
// принимает на вход число (N) и выдаёт таблицу
// квадратов чисел от 1 до N.
// 5 -> 1, 4, 9, 16, 25.
// 2 -> 1,4


void PrintResult(int N)
{
    for (int i = 1; i <= N; ++i)
    {
        Console.WriteLine($"{i}:    {i * i}");
    }
}

Console.Write("Enter the natural number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
    PrintResult(num);
else
    Console.WriteLine("Incorrect input");
