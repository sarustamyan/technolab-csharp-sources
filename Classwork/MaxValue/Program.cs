int a = 10;
int b = 15;
int c = 8;
int d = 13;

int max = a;

if (max < b)
{
    max = b;
}
if (max < c)
{
    max = c;
}
if (max < d)
{
    max = d;
}

Console.WriteLine(max);