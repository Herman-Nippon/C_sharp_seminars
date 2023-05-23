// 16. Напишите программу, которая принимает на
// вход два числа и проверяет, является ли одно
// число квадратом другого.
// 5, 25 -> да
// -4, 16 -> да
// 25, 5 -> да
// 8,9 -> нет

bool IsSquared(int num1, int num2)
{
    return (num1 * num1 == num2) || (num2 * num2 == num1);
}

Console.Write("Enter the first number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter the second number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(IsSquared(number1, number2) ? "Yes" : "No");
