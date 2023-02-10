int[] items = new int[] { };

var maxIndex = 0;

for (var i = 0; i < items.Length; i++)
{
    if (items[maxIndex] <= items[i])
    { 
        maxIndex = i;
    }
}
Console.WriteLine(maxIndex);