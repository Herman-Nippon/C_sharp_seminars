// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да

int ReverseNumber(int num)
{
    int reversedNum = 0;
    while(num > 0)
    {
        reversedNum *= 10;
        reversedNum += num % 10;
        num /= 10;
    }
    return reversedNum;
}

bool IsFiveDigitNumber(int num)
{
    return (num >= 10000 && num <= 99999);
}

Console.Write("Enter a five-digit number: ");
int number = Math.Abs(Convert.ToInt32(Console.ReadLine()));

if (IsFiveDigitNumber(number))
{   
    string str = "is not";
    if (number == ReverseNumber(number)) str = "is";
    Console.WriteLine($"The number {str} a palindrome");
}
else
{
    Console.WriteLine("The input must be a five-digit number");
}
