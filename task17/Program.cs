// 17. Напишите программу, которая принимает на вход
// координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт
// номер четверти плоскости, в которой находится эта
// точка.

int GetQuarter(int x, int y)
{
    if (x == 0 || y == 0) return 0;
    else if (x > 0)
        if (y > 0) return 1;
        else       return 4;
    else
        if (y > 0) return 2;
        else       return 3;
}

Console.Write("Enter the x coordinate: ");
int x = Convert.ToInt32(Console.ReadLine());
Console.Write("Enter the y coordinate: ");
int y = Convert.ToInt32(Console.ReadLine());

int res = GetQuarter(x, y);
Console.WriteLine(res == 0 ? "Coordinates can't be 0" : $"Those coordinates correspond to the {res} quarter");
