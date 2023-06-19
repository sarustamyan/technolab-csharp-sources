int[] items = new int[] { 1, 3, 5, -1, -6 };
for (int i = items.Length - 1; i >= 0; i--)
{
    if (items[i] > 0)
    {
        Console.WriteLine(items[i]);
        return;
    }
}
