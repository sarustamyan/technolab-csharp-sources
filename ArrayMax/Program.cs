int[] items = new int[] { 8, 4, 2, 8, 6 };

if (items.Length == 0)
{
    Console.WriteLine("Empty Array!");
    return;
}

int max = items[0];
int maxIndex = 0;
for (int i = 0; i < items.Length; i++)
{
    if (max < items[i])
    { 
        max = items[i];
        maxIndex = i;
    }
}
Console.WriteLine(maxIndex);