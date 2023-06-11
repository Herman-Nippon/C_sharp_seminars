// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// -1, -7, 567, 89, 223-> 3

int GetNumber()
{
    Console.Write("How many numbers do you want to enter: ");
    int number = Convert.ToInt32(Console.ReadLine());
    return number;
}

int[] NumbersInput(int num)
{
    int[] arr = new int[num];
    int i = 0;
    while (i < num)
    {
        Console.Write($"Enter {i+1} number: ");
        string value = Console.ReadLine()!;

        if (int.TryParse(value, out int intValue)) arr[i++] = intValue;
        else Console.WriteLine("You haven't entered a whole number! Try again.");
    }
    return arr;
}

int CountGreaterThanZero(int[] arr)
{
    int count = 0;
    foreach (int num in arr)
    {
        if (num > 0) count++;
    }
    return count;
}

int number = GetNumber();

if (number < 1)
{
    Console.WriteLine("Incorrect input");
    return;
}

int[] array = NumbersInput(number);
Console.WriteLine($"You've entered {CountGreaterThanZero(array)} number(s) greater than 0");
