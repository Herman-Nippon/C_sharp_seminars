// Задача 13: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

int GetThirdDigit(int num)
{
    while (num / 1000 > 0)
    {
        num /= 10;
    }
    return num % 10;
}

Console.Write("Enter a number: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (number < 100)
    Console.WriteLine("There's not enough digits in the number.");
else
    Console.WriteLine($"The third digit of the number is: {GetThirdDigit(number)}");
