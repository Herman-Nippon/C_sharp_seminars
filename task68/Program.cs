// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int GetNumberFromUser(string prompt)
{
    int intValue;
    bool isValidNumber;

    do
    {
        Console.Write(prompt);
        isValidNumber = int.TryParse(Console.ReadLine(), out intValue) && intValue >= 0;

        if (!isValidNumber) Console.WriteLine("Invalid input. Please, enter a non-negative number.");
    } while (!isValidNumber);

    return intValue;
}

int Ackermann(int n, int m)
{
    if (n == 0)
        return m + 1;
    if (m == 0)
        return Ackermann(n - 1, 1);
    return Ackermann(n - 1, Ackermann(n, m - 1));
}

int numberM = GetNumberFromUser("Enter a non-negative number: ");
int numberN = GetNumberFromUser("Enter a non-negative number: ");

Console.WriteLine(Ackermann(numberN, numberM));
