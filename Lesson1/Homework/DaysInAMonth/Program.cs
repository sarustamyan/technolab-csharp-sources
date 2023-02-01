int month = 1;
int year = 2023;

if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
{
    Console.WriteLine(31);
}
else if (month == 4 || month == 6 || month == 9 || month == 11)
{
    Console.WriteLine(30);
}
else if (month == 2)
{
    Console.WriteLine(28);
}
else
{
    Console.WriteLine("Invalid month.");
}
