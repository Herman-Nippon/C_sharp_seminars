// 11. Напишите программу, которая выводит случайное
// трёхзначное число и удаляет вторую цифру этого
// числа.
// 456 -> 46
// 782 -> 72
// 918 -> 98

int DeleteSecondDigit(int num)
{
    int firstDigit = num / 100;
    int secondDigit = num % 10;
    return firstDigit * 10 + secondDigit;
}

int number = new Random().Next(100, 1000);

Console.WriteLine($"Three-digit number - {number}");
int deleteSecondDigit = DeleteSecondDigit(number);
Console.WriteLine($"The number without the second digit - {deleteSecondDigit}");
