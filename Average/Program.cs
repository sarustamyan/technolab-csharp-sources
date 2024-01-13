int[] items = new int[] { int.MaxValue, int.MaxValue };
double average = Sum(items) / (double)items.Length;

int Sum(int[] items)
{
    int sum = 0;
    foreach (int item in items)
    {
        checked
        {
            sum += item;
        }
    }
    return sum;
}

Console.WriteLine(average);

DateTime.DaysInMonth(2024, 2);