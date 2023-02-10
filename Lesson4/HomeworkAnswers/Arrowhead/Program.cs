var n = 7;
for (var i = 1; i <= n + 1; i = i + 2)
{
    Console.Write("".PadLeft((n - i) / 2, ' '));
    Console.WriteLine("".PadLeft(i, '*'));
}
for (var i = 0; i < 3; i++)
{
    Console.Write("".PadLeft((n) / 2, ' '));
    Console.WriteLine("*");
}