// Задача 44: Не используя рекурсию, выведите первые N чисел
// Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Если N = 5 -> 0 1 1 2 3
// Если N = 3 -> 0 1 1
// Если N = 7 -> 0 1 1 2 3 5 8

int GetNumber()
{
    Console.Write("Enter a natural number: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number >= 1) return number;
    else return -1;
}

void PrintFibSequence(int num)
{
    Console.Write($"If N = {num} ->");
    int elem1 = 0;
    int elem2 = 1;
    int temp;

    if (num == 1)
    {
        Console.Write($" {elem1}");
        return;
    }
    else if (num == 2)
    {
        Console.Write($" {elem1} {elem2}");
        return;
    }
    else
    {
        Console.Write($" {elem1} {elem2}");
        for (int i = 2; i < num; i++)
        {
            temp = elem2 + elem1;
            elem1 = elem2;
            elem2 = temp;
            Console.Write($" {elem2}");
        }
    }
}

int number = GetNumber();

if (number == -1)
{
    Console.WriteLine("Incorrect input");
    return;
}

PrintFibSequence(number);
Console.WriteLine();

