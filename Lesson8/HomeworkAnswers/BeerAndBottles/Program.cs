int beers(int n)
{
    if (n < 3)
    {
        return 0;
    }
    else
    {
        var numberOfBottles = n / 3;
        var remainingAmount = n / 3 + n % 3;
        return numberOfBottles + beers(remainingAmount);
    }
   
}
Console.WriteLine(beers(15));