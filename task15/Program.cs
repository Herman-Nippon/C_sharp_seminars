// Задача 15: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.
// 6 -> да
// 7 -> да
// 1 -> нет

Console.Write("Enter a digit, corresponding to a day of the week: ");
int number = Convert.ToInt32(Console.ReadLine());

if (number >= 1 && number <= 7)
{
    Console.WriteLine((number >= 6) ? "Yes, it is weekend." : "No, it is not a weekend.");
}
else
{
    Console.WriteLine("The number can't correspond to a day of the week.");
}
