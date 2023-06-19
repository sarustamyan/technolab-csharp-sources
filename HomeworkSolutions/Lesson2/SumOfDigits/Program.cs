for (int i = 10; i <= 99; i++)
{
    int firstDigit = i / 10;
    int lastDigit = i % 10;
    if (firstDigit + lastDigit > 14)
    {
        Console.WriteLine(i);
    }
}