int a = 10;
int b = 12;
int c = 8;
int d = 18;

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