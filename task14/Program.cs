// 14. Напишите программу, которая принимает на
// вход число и проверяет, кратно ли оно
// одновременно 7 и 23.
// 14 -> нет
// 46 -> нет
// 161 -> да

bool DivisibleByTwoNumbers(int divisor1, int divisor2, int number)
{
    return (number % divisor1 == 0) && (number % divisor2 == 0);
}

Console.Write("Enter the number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(DivisibleByTwoNumbers(7, 23, num) ? $"{num} -> yes" : $"{num} -> no");
