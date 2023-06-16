// Задача 65: Задайте значения M и N. Напишите программу, которая
// выведет все натуральные числа в промежутке от M до N.
// M = 1; N = 5 -> "1, 2, 3, 4, 5"
// M = 4; N = 8 -> "4, 5, 6, 7, 8"

void ConsecutiveNumbersInRange(int num1, int num2)
{
    
    if (num1 < num2) 
    {
        Console.Write($"{num1}, ");
        ConsecutiveNumbersInRange(num1 + 1, num2);
    }
    else if (num2 < num1)
    {
        Console.Write($"{num2}, ");
        ConsecutiveNumbersInRange(num1, num2 + 1);
    }
    else
    {
        Console.WriteLine($"{num1}");
    }
}

Console.WriteLine("Введите два натуральных числа: ");
int number1 = Convert.ToInt32(Console.ReadLine());
int number2 = Convert.ToInt32(Console.ReadLine());

ConsecutiveNumbersInRange(number1, number2);
