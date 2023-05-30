// Задача 25: Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.
// 3, 5 -> 243 (3⁵)
// 2, 4 -> 16

int Power(int baseNumber, int exp)
{
    int result = 1;
    for (int i = 1; i <= exp; i++)
    {
        result *= baseNumber;
    }
    return result;
}

Console.Write("Enter a whole number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a natural number: ");
int exponent = Convert.ToInt32(Console.ReadLine());

if (exponent <= 0)
{
    Console.WriteLine("Incorrect input (exponent must be natural)");
    return;
}

Console.WriteLine($"{number} to the power of {exponent} is {Power(number, exponent)}");
