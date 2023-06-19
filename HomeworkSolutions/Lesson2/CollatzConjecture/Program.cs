int number = 12;

while (number != 1)
{
    if (number % 2 == 0)
    {
        number /= 2;
    }
    else
    {
        number = 3 * number + 1;
    }
    Console.WriteLine(number);
}