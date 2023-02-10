var pi = 1d;
for (var i = 1; i <= 500000; i++)
{
    if (i % 10000 == 0)
    {
        Console.WriteLine($"{i}: {pi * 4}");
    }
    var factor = (i % 2 == 0) ? 1 : -1;
    pi = pi + factor * (1d / (i * 2 + 1));
}