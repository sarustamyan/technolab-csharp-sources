int[] numbers = new int[] { 10, 20, 12, 20, 20 };

if (numbers.Length == 0)
{
    Console.WriteLine("Empty array");
    return;
}

// Max value
int max = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (max < numbers[i])
    {
        max = numbers[i];
    }
}
Console.WriteLine(max);

// Max index
int maxIndex = 0;
for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[maxIndex] <= numbers[i])
    {
        maxIndex = i;
    }
}
Console.WriteLine(maxIndex);
