// Задача 10: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.
// 456 -> 5
// 782 -> 8
// // 918 -> 1

int GetSecondDigit(int num)
{
    return (num / 10) % 10;
}

Console.Write("Enter a three-digit number: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 100 && number <= 999)
{
    Console.WriteLine($"The second digit of the number is {GetSecondDigit(number)}");
}
else
{
    Console.WriteLine("Incorrect number.");
}


