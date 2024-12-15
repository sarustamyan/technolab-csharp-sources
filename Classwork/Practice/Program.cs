//int DaysInMonth(int month, int year)
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
//        if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
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
//        throw new ArgumentException("month");
//    }
//}

//Console.WriteLine("Please input the month (1-12)");
//int month = int.Parse(Console.ReadLine());
//Console.WriteLine("Please input the year in the following format: yyyy");
//string inputYear = Console.ReadLine();
//int year = int.Parse(inputYear);

//var temp = DaysInMonth(month, year);
//Console.WriteLine(temp);

int[] items = new int[] { 1, 2, 3, 4 };
Console.WriteLine(Average(items));

double Average(int[] items)
{
    return (double)Sum(items) / items.Length;
}

int Sum(int[] items)
{
    var sum = 0;
    foreach (var item in items)
    {
        sum += item;
    }
    return sum;
}