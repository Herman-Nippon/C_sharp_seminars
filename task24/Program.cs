// Задача 24: Напишите программу, которая
// принимает на вход число (А) и выдаёт сумму чисел
// от 1 до А.
// 7 -> 28
// 4 -> 10
// 8 -> 36

int GetSum(int num)
{
    int sum = 0;
    for (int i = 1; i <= num; ++i)
    {
        sum += i;
    }
    return sum;
}

Console.Write("Enter a natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number > 0)
{
    Console.WriteLine($"The sum of numbers from 1 to {number} -> {GetSum(number)}");
}
else
{
    Console.WriteLine("Incorrect input");
}
