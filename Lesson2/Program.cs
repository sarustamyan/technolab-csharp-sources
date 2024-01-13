


int limit = 100;
int sum = 0;
for (int k = 2; k <= limit; k++)
{
    bool isPrime = true;
    for (int i = 2; i <= k / 2; i++)
    {
        if (k % i == 0)
        {
            isPrime = false;
            break;
        }
    }

    if (isPrime)
    {
        sum += k;
    }
}
Console.WriteLine(sum); 