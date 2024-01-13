List<int> items = new List<int>() { 1, 4, 2, 10, 6 };

int Max(List<int> items)
{
    if (items.Count() == 1)
    { 
        return items[0];
    }

    return Math.Max(items[0], Max(items.Skip(1).ToList()));
}

Console.WriteLine(Max(items));