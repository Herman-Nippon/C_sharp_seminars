// Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
// 2, 3, 7 -> 7
// 44 5 78 -> 78
// 22 3 9 -> 22

Console.Write("Enter a number: ");
int number1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter another number: ");
int number2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Enter another number: ");
int number3 = Convert.ToInt32(Console.ReadLine());

int max = number1;

if (max < number2)
{
    max = number2; // рабочий, но не слишком приятный код
}
if (max < number3)
{
    max = number3;
}

// int max = Math.Max(number1, Math.Max(number2, number3)); //я бы использовал такой вариант

Console.WriteLine($"The biggest number is {max}");
