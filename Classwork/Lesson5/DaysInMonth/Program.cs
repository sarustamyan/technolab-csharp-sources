Console.WriteLine(DaysInMonth(2, 2000));

Console.WriteLine(DateTime.DaysInMonth(month: 2, year: 2000));

int DaysInMonth(int month, int year)
{
    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
    {
        return 31;
    }
    else if (month == 4 || month == 6 || month == 9 || month == 11)
    {
        return 30;
    }
    else if (month == 2)
    {
        if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0))
        {
            return 29;
        }
        else
        {
            return 28;
        }
    }
    else
    {
        return -1;
    }
}