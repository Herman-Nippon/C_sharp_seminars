// Задача 20: Напишите программу, которая
// принимает на вход координаты двух точек и
// находит расстояние между ними в 2D
// пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21

int GetInput(int number)
{
    string str = (number == 1 ? "X" : "Y");
    Console.Write($"Enter the {str} value: ");
    return Convert.ToInt32(Console.ReadLine());
}

int Sqare(int num)
{
    return num * num;
}

double GetDifference(int xA, int yA, int xB, int yB)
{
    return Math.Sqrt(Sqare(xA - xB) + Sqare(yA - yB));
}

Console.WriteLine("Enter the coordinates of the first point");
int xA = GetInput(1);
int yA = GetInput(2);
Console.WriteLine("Enter the coordinates of the second point: ");
int xB = GetInput(1);
int yB = GetInput(2);

double result = Math.Round(GetDifference(xA, yA, xB, yB), 2, MidpointRounding.ToZero);
Console.WriteLine($"The distance between two points is: {result}");
