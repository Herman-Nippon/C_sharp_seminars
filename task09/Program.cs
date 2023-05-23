// 9. Напишите программу, которая выводит
// случайное число из отрезка [10, 99] и показывает
// наибольшую цифру числа.
// 78 -> 8
// 12-> 2
// 85 -> 8

// void PrintArray(int[] array)
// {
//     foreach (int i in array)
//     {
//         Console.Write(i + " ");
//     }
//     Console.WriteLine();
// }

int number = new Random().Next(10, 100);
int[] digits = new int[2] { number % 10, (number / 10)};

Console.WriteLine($"The biggest digit in the number {number} is {Math.Max(digits[0], digits[1])}");
