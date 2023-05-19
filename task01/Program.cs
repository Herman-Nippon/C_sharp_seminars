Console.Write("Enter a number: ");
int num = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter a number: ");
int num1 = Convert.ToInt32(Console.ReadLine());

if (num == num1 * num1)
{
    Console.WriteLine($"Да, {num} является квадратом числа {num1}");
}
else Console.WriteLine($"Нет, {num} не является квадратом числа {num1}");
