// Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.
// 5 -> 2, 4
// 8 -> 2, 4, 6, 8

Console.Write("Enter a natural number: ");
int num = Convert.ToInt32(Console.ReadLine());

if (num > 0)
{
    int i = 2;
    while (i <= num)
    {
        Console.Write($"{i} ");
        i += 2;
    }
}
else 
{
    Console.WriteLine("The number must be natural.");
}

Console.WriteLine(); //для того, чтобы курсор перешел на след строку
