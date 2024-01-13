List<int> items = new List<int> { 1, 2, 3, 5, 7, 8, 9 };

List<int> evenItems = new List<int>();
for (int i = 0; i < items.Count(); i++)
{
    int item = items[i];
    if (item % 2 != 1)
    {
        evenItems.Add(item);
    }
    
}

PrintList(evenItems);

void PrintList(List<int> items)
{
    foreach (int item in items)
    {
        Console.WriteLine(item);
    }
}