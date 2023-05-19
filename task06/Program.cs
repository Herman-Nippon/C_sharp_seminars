// Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Is the number {num} even?");

if (Convert.ToBoolean(num % 2)) //if the remainder is 1 (or -1) -> the expr becomes true
{
    Console.WriteLine($"No, the number {num} is odd.");
}
else
{
    Console.WriteLine($"Yes, the number {num} is even.");
}

