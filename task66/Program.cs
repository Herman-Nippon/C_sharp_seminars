// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
// Выполнить с помощью рекурсии.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

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

int GetSumRec(int m, int n)
{
    if (m == n)
        return m;
    if (n < m)
        return n + GetSumRec(m, n + 1);
    else
        return m + GetSumRec(m + 1, n);
}   



int numberM = GetNaturalNumberFromUser("Enter a natural number: ");
int numberN = GetNaturalNumberFromUser("Enter a natural number: ");
Console.WriteLine(GetSumRec(numberM, numberN));
