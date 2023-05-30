// Задача 28: Напишите программу, которая
// принимает на вход число N и выдаёт
// произведение чисел от 1 до N.
// 4 -> 24
// 5 -> 120

int Factorial(int num)
{
    int factorial = 1;
    for (int i = 1; i <= num; i++)
    {
        factorial *= i;
    }
    return factorial;
}

Console.Write("Enter a natural number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number <= 0)
{
    Console.WriteLine("Incorrect input");
    return;
}

Console.WriteLine($"Factorial of {number} is {Factorial(number)}");
