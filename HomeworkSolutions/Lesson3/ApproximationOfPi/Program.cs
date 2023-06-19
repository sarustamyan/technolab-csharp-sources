double sum = 0;
int factor = 1;
int denom = 1;

for (int i = 0; i < 5000000; i++)
{
    sum += (double)factor * 1 / denom;
    factor *= -1;
    denom += 2;
}

double pi = sum * 4;
Console.WriteLine(pi);