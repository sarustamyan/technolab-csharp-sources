int n = 7;
for (int i = 0; i < n / 2 + 1; i++)
{
    Console.Write(new string(' ', n / 2 - i));
    Console.WriteLine(new string('*', i * 2 + 1));
}

for (int i = 0; i < 3; i++)
{
    Console.Write(new string(' ', n / 2));
    Console.WriteLine("*");
}
