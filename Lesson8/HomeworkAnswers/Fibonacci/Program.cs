int Fibonacci1(int n)
{
    var results = new int[n];    
    results[0] = 1;
    results[1] = 1;

    for (int i = 2; i < n; i++)
    {
        results[i] = (results[i-1] + results[i-2]);
    }
    return results[n - 1];
}

Console.WriteLine(Fibonacci1(5));