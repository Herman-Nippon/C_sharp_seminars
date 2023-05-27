// Напишите программу, которая принимает на вход координаты двух точек 
// и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

int GetInput(int number)
{
    string str = "";
    switch (number)
    {
        case 1: str = "X"; break;
        case 2: str = "Y"; break;
        case 3: str = "Z"; break;
    }
    Console.Write($"Enter the {str} value: ");
    return Convert.ToInt32(Console.ReadLine());
}

int Square(int num)
{
    return num * num;
}

double DistanceBetween(int xA, int yA, int zA, int xB, int yB, int zB)
{
    return Math.Sqrt(Square(xA - xB) + Square(yA - yB) + Square(zA - zB));
}

Console.WriteLine("Enter the coordinates of the first point");
int xA = GetInput(1);
int yA = GetInput(2);
int zA = GetInput(3);
Console.WriteLine("Enter the coordinates of the second point");
int xB = GetInput(1);
int yB = GetInput(2);
int zB = GetInput(3);

double result = Math.Round(DistanceBetween(xA, yA, zA, xB, yB, zB), 2);
Console.WriteLine($"The distance between two points is: {result}");
