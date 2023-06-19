double Average(int[] items)
{
    int sum = 0;
    foreach (int item in items)
    {
        sum += item;
    }
    return (double)sum / items.Length;
}

int[] param = new int[] { 1, 2, 3, 4, 10 };
Console.WriteLine(Average(param));