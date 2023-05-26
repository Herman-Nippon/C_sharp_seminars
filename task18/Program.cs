// Задача 18: Напишите программу, которая по
// заданному номеру четверти, показывает диапазон
// возможных координат точек в этой четверти (x и y).

string GetInterval(int quarter)
{
    switch (quarter)
    {
        case 1: return "x > 0 and y > 0";
        case 2: return "x < 0 and y > 0";
        case 3: return "x < 0 and y < 0";
        case 4: return "x > 0 and y < 0";
        default: return "0";
    }
}

Console.Write("Enter a number, corresponding to the quarter: ");
int number = Convert.ToInt32(Console.ReadLine());

string res = GetInterval(number);
Console.WriteLine(res == "0" ? "Invalid input" : $"The value of axis are: {res}");
