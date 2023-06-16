// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
// Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

int GetNaturalNumberFromUser(string prompt)
{
    int intValue;
    bool isValidNumber;

    do
    {
        Console.Write(prompt);
        isValidNumber = int.TryParse(Console.ReadLine(), out intValue) && intValue >= 1;

        if (!isValidNumber) Console.WriteLine("Invalid input. Please, enter a natural number.");
    } while (!isValidNumber);

    return intValue;
}

void PrintSequence(int num)
{
    if (num > 1)
    {
        Console.Write($"{num}, ");
        PrintSequence(num - 1);
    }
    else 
    {
        Console.WriteLine($"{num}");
    }
}



int number = GetNaturalNumberFromUser("Enter a natural number: ");
PrintSequence(number);
