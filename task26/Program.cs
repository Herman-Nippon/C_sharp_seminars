int DigitsInNumber(int num)
{
    int digits = 0;

    if (num == 0) return 1;
    else if (num > 0)
    {
        while (num > 0)
        {
            digits++;
            num /= 10;
        }
        
    }
    else if (num < 0)
    {
        while (num < 0)
        {
            digits++;
            num /= 10;
        }
    }
    return digits;
}

Console.Write("Enter a number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"{number} contains {DigitsInNumber(number)} digits");
