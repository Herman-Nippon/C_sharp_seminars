// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 5 ->
// 1 | 1
// 2 | 8
// 3 | 27
// 4 | 64
// 5 | 125

void PrintTable(int num)
{
    for (int i = 1; i <= num; ++i)
    {
        Console.WriteLine($"{i} |   {i * i * i}");
    }
}

Console.Write("Enter a natural number: ");
int N = Convert.ToInt32(Console.ReadLine());

if (N <= 0)
{
    Console.WriteLine("The number must be natural");
    return;
}

PrintTable(N);
