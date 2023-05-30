// Задача 27: Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе.
// 452 -> 11
// 82 -> 10
// 9012 -> 12

int SumOfDigits(int num)
{
    int result = 0;
    while (num != 0)
    {
        result += num % 10;
        num /= 10;
    }
    return Math.Abs(result); // since (num % 10) expression returns a negative number if num is negative
}

Console.Write("Enter a whole number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"The sum of digits in {number} is {SumOfDigits(number)}");
