// Задача 40: Напишите программу, которая принимает на вход три
// числа и проверяет, может ли существовать треугольник с сторонами
// такой длины.
// Теорема о неравенстве треугольника: каждая сторона треугольника
// меньше суммы двух других сторон.

int GetNumber()
{
    Console.Write("Введите длину стороны треугольника: ");
    int number = Convert.ToInt32(Console.ReadLine());
    if (number > 0) return number;
    else return 0;
}

bool SuchTriangleExists(int a, int b, int c)
{
    if ((a < b + c) && (b < a + c) && (c < a + b)) return true;
    else return false;
}

int side1 = GetNumber();
int side2 = GetNumber();
int side3 = GetNumber();

if (side1 == 0 || side2 == 0 || side3 == 0)
{
    Console.WriteLine("Некорректный ввод");
    return;
}

Console.WriteLine(SuchTriangleExists(side1, side2, side3) ? "Такой треугольник существует" : "Такого треугольника не существует");
