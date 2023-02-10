////int Const5()
////{
////    return 5;
////}


////int Sum(int a, int b)
////{
////    return a + b;
////}
////Console.WriteLine(Sum(Const5(), 4));

//int DaysInAMonth(int month, int year)
//{
//    if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
//    {
//        return 31;
//    }
//    else if (month == 4 || month == 6 || month == 9 || month == 11)
//    {
//        return 30;
//    }
//    else if (month == 2)
//    {
//        if (IsLeapYear(year))
//        {
//            return 29;
//        }
//        else
//        {
//            return 28;
//        }
//    }
//    else
//    {
//        return -1;
//    }
//}

//bool IsLeapYear(int year)
//{
//    return DateTime.IsLeapYear(year);
//}


//int m = 1;
//int y = 2023;
//Console.WriteLine(DaysInAMonth(m, 2023));

//Console.WriteLine(new DateTime(1983, 6, 1).DayOfWeek);


int[] items = new[] { 3, 4, 5 };

double Average(int[] items)
{   
    return (double)Sum(items) / items.Length;
}

int Sum(int[] items)
{
    int sum = 0;
    for (int i = 0; i < items.Length; i++)
    {
        sum += items[i];
    }
    return sum;
}

Console.WriteLine(Average(items));
Console.WriteLine(Average(items));